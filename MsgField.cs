using System.Text;
using System.Text.RegularExpressions;

public struct MsgField
{
    public string Name;
    public string Type;
    public int Count;
    public int Offset;
    public int Unk;

    private static string[] _builtInTypes = [
        "bool",
        "byte",
        "sbyte",
        "char",
        "decimal",
        "double",
        "float",
        "int",
        "uint",
        "nint",
        "nuint",
        "long",
        "ulong",
        "short",
        "ushort",
    ];

    // https://learn.microsoft.com/en-us/windows/win32/winprog/windows-data-types
    private static Dictionary<string, string> _typeMap = new()
    {
        { "unsigned char", "byte" },
        { "char", "byte"},
        { "unsigned short", "ushort" },
        { "unsigned int", "uint" },
        { "unsigned long", "uint" },
        { "time_t", "uint"},
        { "uint32", "uint" },
        { "EQSerialNumber", "int" }, // guess
        { "T3D_ACTORINSTANCEPTR", "IntPtr" },
        { "BOOL", "int" }, // TODO: think through changing this to a C# bool
        { "BYTE", "byte" },
        { "DWORD", "uint" },
    };
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"/* {Offset.ToString().PadLeft(4, '0')} */ ");
        sb.Append($"{Type} {Name}");
        if (IncludeCount)
            sb.Append($"[{Count}]");
        sb.Append(';');
        // sb.Append($" // {Unk}"); // Append unknown value?
        return sb.ToString();
    }

    public string ToCSharpString()
    {
        var mappedType = TypeMap(Type, Count);
        var sb = new StringBuilder();
        sb.AppendLine("    /// <remarks>");
        sb.Append($"    /// Source field: `{Type} {Name}");
        if (IncludeCount)
            sb.Append($"[{Count}]");
        sb.Append(";`\n");
        sb.AppendLine("    /// </remarks>");
        if (mappedType == "byte")
        {
            var unmanagedType = Type == "char" ? "I8" : "U8";
            var size = Count > 1 ? $", SizeConst = {Count}" : string.Empty;
            sb.AppendLine($"    [MarshalAs(UnmanagedType.{unmanagedType}{size})]");
        }
        else if (mappedType == "string")
        {
            sb.AppendLine($"    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = {Count})]");
        }
        else if (IncludeCount)
        {
            sb.AppendLine($"    [MarshalAs(UnmanagedType.ByValArray, SizeConst = {Count})]");
        }
        sb.Append($"    [FieldOffset({Offset})] public {mappedType} {FieldName()};");
        return sb.ToString();
    }

    private string FieldName()
    {
        if (Name == "Parent_Class")
        {
            // Create a field name based on parent type
            var str = Type.Replace("EQ_", string.Empty);
            return Regex.Replace(str, @"\d", string.Empty);
        }

        return Name.CleanupString();
    }

    private static string TypeMap(string type, int count)
    {
        if (type == "char" && count > 1)
        {
            return "string";
        }

        if (type.EndsWith(" *") || type.EndsWith(" **"))
        {
            return "IntPtr";
        }

        if (_typeMap.TryGetValue(type, out var value))
        {
            return value;
        }

        if (Array.Exists(_builtInTypes, e => e == type))
        {
            return type;
        }

        return type.CleanupString();
    }

    private readonly bool IncludeCount => Count > 1 && Name != "Parent_Class";
}

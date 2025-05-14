using System.Text;
using System.Text.RegularExpressions;

public struct MsgField
{
    public string Name;
    public string Type;
    public int Count;
    public int Offset;
    public MsgFieldType FieldType;
    public int NextFieldOffset;
    private MsgStruct _msgStruct;

    public MsgField(MsgStruct msgStruct)
    {
        _msgStruct = msgStruct;
    }

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
        string indent = "        ";
        var mappedType = TypeMap(Type, Count);
        var padding = Padding(mappedType);

        var sb = new StringBuilder();
        sb.AppendLine($"{indent}/// <remarks>");
        sb.Append($"{indent}/// Source field: <c>{Type} {Name}");
        if (IncludeCount)
            sb.Append($"[{Count}]");
        sb.Append(";</c>\n");
        sb.AppendLine($"{indent}/// Offset {Offset}");
        sb.AppendLine($"{indent}/// </remarks>");

        var unmanagedType = string.Empty;

        // bytes need an explicit unmanaged type
        if (mappedType == "byte" || mappedType == "sbyte")
        {
            unmanagedType = Type == "char" ? "I1" : "U1";
        }

        if (mappedType == "string")
        {
            sb.AppendLine($"{indent}[MarshalAs(UnmanagedType.ByValTStr, SizeConst = {Count})]");
        }
        else if (IncludeCount)
        {
            sb.Append($"{indent}[MarshalAs(UnmanagedType.ByValArray");
            if (!string.IsNullOrEmpty(unmanagedType))
            {
                sb.Append($", ArraySubType = UnmanagedType.{unmanagedType}");
            }
            sb.AppendLine($", SizeConst = {Count})]");
        }
        else if (!string.IsNullOrEmpty(unmanagedType))
        {
            sb.AppendLine($"{indent}[MarshalAs(UnmanagedType.{unmanagedType})]");
        }

        if (IncludeCount && mappedType != "string")
        {
            mappedType += "[]";
        }

        sb.Append($"{indent}public {mappedType} {FieldName()};");

        switch(padding)
        {
            case 1:
                sb.AppendLine($"\n{indent}[MarshalAs(UnmanagedType.U1)]");
                sb.Append($"{indent}private byte {PaddingFieldName()};");
                break;
            case > 1 and < 4:
                sb.AppendLine($"\n{indent}[MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = {padding})]");
                sb.Append($"{indent}private byte[] {PaddingFieldName()};");
                break;
            case > 3:
                // Generated data edgecase, potential missing or variable length field
                sb.Append($"\n\n{indent}// FIXME: {padding} bytes missing.");
                break;
        }

        return sb.ToString();
    }

    private string FieldName()
    {
        if (FieldType == MsgFieldType.Parent)
        {
            // Create a field name based on parent type
            var str = Type.Replace("EQ_", string.Empty);
            return Regex.Replace(str, @"\d", string.Empty);
        }

        return I18n.T($"{_msgStruct.Name.StructString()}.{Name.CleanupString()}");
    }

    private string PaddingFieldName()
    {
        string name = FieldName();
        return $"_{char.ToLower(name[0])}{name[1..]}Padding";
    }

    // returns how much padding is needed after the field
    private int Padding(string mappedType)
    {
        var mappedSize = TypeMapper.Instance.GetTypeSize(mappedType);
        if (mappedSize == 0)
        {
            return 0;
        }

        var byteSize = NextFieldOffset - Offset;
        var mappedByteSize = mappedSize * Count;
        if (byteSize > mappedByteSize)
        {
            var padding = byteSize - mappedByteSize;
            Console.WriteLine($"    Pad {mappedType} {FieldName()} {padding} bytes ({mappedByteSize} to {byteSize})");

            return padding;
        }

        return 0;
    }

    private static string TypeMap(string type, int count)
    {
        if (type == "char" && count > 1)
        {
            return "string";
        }

        if (type.EndsWith(" *") || type.EndsWith(" **"))
        {
            return "int";
        }

        if (TypeMapper.TypeMap.TryGetValue(type, out var value))
        {
            return value;
        }

        if (TypeMapper.BuiltInTypes.ContainsKey(type))
        {
            return type;
        }

        return type.StructString();
    }

    private readonly bool IncludeCount => Count > 1 && FieldType != MsgFieldType.Parent;
}

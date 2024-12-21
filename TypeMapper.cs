public sealed class TypeMapper
{
    private static readonly Lazy<TypeMapper> lazy =
        new Lazy<TypeMapper>(() => new TypeMapper());

    public static TypeMapper Instance { get { return lazy.Value; } }

    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/sizeof
    public static readonly Dictionary<string, int> BuiltInTypes = new()
    {
        { "bool", 1 },
        { "byte", 1 },
        { "sbyte", 1 },
        { "char", 2 },
        { "decimal", 16 },
        { "double", 8 },
        { "float", 4 },
        { "int", 4 },
        { "uint", 4 },
        { "long", 8 },
        { "ulong", 8 },
        { "short", 2 },
        { "ushort", 2 },
        { "string", 1 }, // Custom addition
    };

    // https://learn.microsoft.com/en-us/windows/win32/winprog/windows-data-types
    public static readonly Dictionary<string, string> TypeMap = new()
    {
        { "unsigned char", "byte" },
        { "char", "sbyte"},
        { "unsigned short", "ushort" },
        { "unsigned int", "uint" },
        { "long", "int" },
        { "unsigned long", "uint" },
        { "time_t", "uint"},
        { "uint32", "uint" },
        { "EQSerialNumber", "int" }, // guess
        { "T3D_ACTORINSTANCEPTR", "int" },
        { "BOOL", "int" }, // TODO: think through changing this to a C# bool
        { "BYTE", "byte" },
        { "DWORD", "uint" },
    };

    public Dictionary<string, int> CustomTypes = [];

    private TypeMapper()
    {
    }

    public void AddCustomType(string name, int size)
    {
        CustomTypes.Add(name, size);
    }

    public int GetTypeSize(string name)
    {
        if (BuiltInTypes.TryGetValue(name, out var builtInSize))
        {
            return builtInSize;
        }

        if (CustomTypes.TryGetValue(name, out var customSize))
        {
            return customSize;
        }

        return 0;
    }
}

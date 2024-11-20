using System.Text;

public struct MsgStruct
{
    public string Name;
    public int Size;
    public MsgField[] Fields;
    public bool HasEnum;

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"// {Fields.Length} field");
        if (Fields.Length > 1)
            sb.Append('s');
        sb.Append($" {Size} byte");
        if (Size > 1)
          sb.Append('s');
        sb.AppendLine($"\nstruct {Name} {{");
        foreach (var field in Fields)
        {
            sb.AppendLine($"    {field.ToString()}");
        }
        sb.AppendLine($"    /* {Size.ToString().PadLeft(4, '0')} */");
        sb.AppendLine("};");
        return sb.ToString();
    }

    public string ToCSharpString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("using System.Runtime.InteropServices;");
        if (HasEnum)
        {
            sb.AppendLine("using EqPackets.Data.Enums;");
        }
        sb.AppendLine("\nnamespace EqPackets.Data.Structs;\n");
        sb.AppendLine("/// <remarks>");
        sb.AppendLine($"/// Source name: `{Name}`");
        sb.AppendLine("/// </remarks>");
        sb.AppendLine($"[StructLayout(LayoutKind.Explicit, Size = {Size}, CharSet = CharSet.Ansi)]");
        sb.AppendLine($"public struct {Name.CleanupString()}");
        sb.AppendLine("{");
        for (int i = 0; i < Fields.Length; i++)
        {
            sb.AppendLine(Fields[i].ToCSharpString());
            if (i + 1 < Fields.Length)
            {
                sb.AppendLine();
            }
        }
        sb.Append("}");
        return sb.ToString();
    }
}

using System.Text;

public struct MsgStruct
{
    public string Name;
    public int Size;
    public MsgField[] Fields;
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"// {Name}");
        sb.AppendLine($"// {Size} bytes");
        sb.AppendLine($"// {Fields.Length} fields");
        sb.AppendLine($"struct {Name} {{");
        foreach (var field in Fields)
        {
            sb.AppendLine($"    {field.ToString()}");
        }
        sb.AppendLine($"    /* {Size.ToString().PadLeft(4, '0')} */");
        sb.AppendLine("};");
        return sb.ToString();
    }
}

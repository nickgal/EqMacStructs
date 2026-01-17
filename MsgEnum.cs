using System.Text;

public struct MsgEnum
{
    public string Name;
    public string Type;
    public Dictionary<string, string> Members;

    public string ToImhexString()
    {
        var sb = new StringBuilder();
        var mappedType = Type switch
        {
            "int" => "s32",
            _ => Type
        };
        string enumType = string.IsNullOrEmpty(Type) ? string.Empty : $" : {mappedType}";
        sb.AppendLine($"/// Source name: `{Name}`");
        sb.AppendLine($"enum {Name.StructString()}{enumType} {{");
        foreach (var (memberName, memberValue) in Members)
        {
            sb.AppendLine($"    {memberName} = {memberValue},");
        }
        sb.AppendLine("};");
        return sb.ToString();
    }

    public string ToCSharpString()
    {
        string indent = "    ";
        var sb = new StringBuilder();
        string enumType = string.IsNullOrEmpty(Type) ? string.Empty : $" : {Type}";
        sb.AppendLine("namespace EqPackets.Data.Enums\n{");
        sb.AppendLine($"{indent}/// <remarks>");
        sb.AppendLine($"{indent}/// Source name: `{Name}`");
        sb.AppendLine($"{indent}/// </remarks>");
        sb.AppendLine($"{indent}public enum {Name.StructString()}{enumType}");
        sb.AppendLine($"{indent}{{");
        if (Members.Count > 0)
        {
            foreach (var (memberName, memberValue) in Members)
            {
                sb.AppendLine($"{indent}{indent}{memberName} = {memberValue},");
            }
        }
        else
        {
            sb.AppendLine($"{indent}{indent}// TODO:");
        }
        sb.AppendLine($"{indent}}}");
        sb.Append('}');
        return sb.ToString();
    }
}

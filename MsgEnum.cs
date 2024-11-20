using System.Text;

public struct MsgEnum
{
    public string Name;
    public string Type;
    public Dictionary<string, string> Members;

    public string ToCSharpString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("namespace EqPackets.Messages.Enums;\n");
        sb.AppendLine("/// <remarks>");
        sb.AppendLine($"/// Source name: `{Name}`");
        sb.AppendLine("/// </remarks>");
        sb.AppendLine($"public enum {Name.CleanupString()} : {Type}");
        sb.AppendLine("{");
        if (Members.Count > 0)
        {
            foreach (var (memberName, memberValue) in Members)
            {
                sb.AppendLine($"    {memberName} = {memberValue},");
            }
        }
        else
        {
            sb.AppendLine("    // TODO:");
        }
        sb.AppendLine("}");
        return sb.ToString();
    }
}

using System.Text;

public struct MsgField
{
    public string Name;
    public string Type;
    public int Count;
    public int Offset;
    public int Unk;
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"/* {Offset.ToString().PadLeft(4, '0')} */ ");
        sb.Append($"{Type} {Name}");
        if (Count > 1)
            sb.Append($"[{Count}]");
        sb.Append(';');
        // sb.Append($" // {Unk}"); // Append unknown value?
        return sb.ToString();
    }
}

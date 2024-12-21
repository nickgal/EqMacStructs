// seems to correlate to the field type
// 0 - void
// 1 - a 1 byte type like char
// 2 - a 2 byte type like short
// 3 - a 4 byte type like int or EQZoneIndex
// 4 - a class eg. EQ_Affect
// 6 - Parent_Class
public enum MsgFieldType
{
    Void = 0,
    OneByte = 1,
    TwoByte = 2,
    FourByte = 3,
    Class = 4,
    Parent = 6
}

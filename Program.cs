// See https://aka.ms/new-console-template for more information
using Kaitai;

var msgs = new List<MsgStruct>();
var kaitaiMsgs = EqmacMsgs.FromFile(@"D:\EqMac\EverQuest.app\Contents\MacOS\EverQuest");

foreach (var msg in kaitaiMsgs.Msgs)
{
    var msgStruct = new MsgStruct
    {
        Name = msg.Name.Str,
        Size = (int)msg.Msg.MsgSize,
        Fields = new MsgField[msg.Fields.Count]
    };
    for (int i = 0; i < msg.Fields.Count; i++)
    {
        var field = msg.Fields[i];
        msgStruct.Fields[i] = new MsgField
        {
            Name = field.Name.Str,
            Type = field.Type.Str,
            Count = (int)field.FieldLength,
            Offset = (int)field.FieldPos,
            Unk = (int)field.Unk3
        };
    }
    Console.WriteLine(msgStruct.ToString());
    msgs.Add(msgStruct);
}

using (StreamWriter outputFile = new("eqmac_net_structs.h"))
{
    foreach (var msg in msgs)
    {
        outputFile.WriteLine(msg.ToString());
    }
}

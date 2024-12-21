// See https://aka.ms/new-console-template for more information
using Kaitai;

MsgEnum[] enumTypes = [
    new MsgEnum { Name = "ChangeWorld_State", Type = "int", Members = []},
    new MsgEnum {
        Name = "PetCommandType",
        Type = "int",
        Members = new()
        {
            { "BackOff", "1" },
            { "GetLost", "2" },
            { "HealthReport", "4" },
            { "GuardHere", "5" },
            { "GuardMe", "6" },
            { "Attack", "7" },
            { "FollowMe", "8" },
            { "SitDown", "9" },
            { "StandUp", "10" },
            { "Taunt", "11" },
            { "Hold", "12" },
            { "NoTaunt", "14" },
            { "Lead", "16" },
            { "Slumber", "17" },
        }
    },
    new MsgEnum {
        Name = "EQZoneIndex",
        Type = "int",
        Members = new()
        {
            { "Qeynos", "1" },
            { "Qeynos2", "2" },
            { "Qrg", "3" },
            { "Qeytoqrg", "4" },
            { "Highpass", "5" },
            { "Highkeep", "6" },
            { "Freportn", "8" },
            { "Freportw", "9" },
            { "Freporte", "10" },
            { "Runnyeye", "11" },
            { "Qey2hh1", "12" },
            { "Northkarana", "13" },
            { "Southkarana", "14" },
            { "Eastkarana", "15" },
            { "Beholder", "16" },
            { "Blackburrow", "17" },
            { "Paw", "18" },
            { "Rivervale", "19" },
            { "Kithicor", "20" },
            { "Commons", "21" },
            { "Ecommons", "22" },
            { "Erudnint", "23" },
            { "Erudnext", "24" },
            { "Nektulos", "25" },
            { "Cshome", "26" },
            { "Lavastorm", "27" },
            { "Nektropos", "28" },
            { "Halas", "29" },
            { "Everfrost", "30" },
            { "Soldunga", "31" },
            { "Soldungb", "32" },
            { "Misty", "33" },
            { "Nro", "34" },
            { "Sro", "35" },
            { "Befallen", "36" },
            { "Oasis", "37" },
            { "Tox", "38" },
            { "Hole", "39" },
            { "Neriaka", "40" },
            { "Neriakb", "41" },
            { "Neriakc", "42" },
            { "Neriakd", "43" },
            { "Najena", "44" },
            { "Qcat", "45" },
            { "Innothule", "46" },
            { "Feerrott", "47" },
            { "Cazicthule", "48" },
            { "Oggok", "49" },
            { "Rathemtn", "50" },
            { "Lakerathe", "51" },
            { "Grobb", "52" },
            { "Aviak", "53" },
            { "Gfaydark", "54" },
            { "Akanon", "55" },
            { "Steamfont", "56" },
            { "Lfaydark", "57" },
            { "Crushbone", "58" },
            { "Mistmoore", "59" },
            { "Kaladima", "60" },
            { "Felwithea", "61" },
            { "Felwitheb", "62" },
            { "Unrest", "63" },
            { "Kedge", "64" },
            { "Guktop", "65" },
            { "Gukbottom", "66" },
            { "Kaladimb", "67" },
            { "Butcher", "68" },
            { "Oot", "69" },
            { "Cauldron", "70" },
            { "Airplane", "71" },
            { "Fearplane", "72" },
            { "Permafrost", "73" },
            { "Kerraridge", "74" },
            { "Paineel", "75" },
            { "Hateplane", "76" },
            { "Arena", "77" },
            { "Fieldofbone", "78" },
            { "Warslikswood", "79" },
            { "Soltemple", "80" },
            { "Droga", "81" },
            { "Cabwest", "82" },
            { "Swampofnohope", "83" },
            { "Firiona", "84" },
            { "Lakeofillomen", "85" },
            { "Dreadlands", "86" },
            { "Burningwood", "87" },
            { "Kaesora", "88" },
            { "Sebilis", "89" },
            { "Citymist", "90" },
            { "Skyfire", "91" },
            { "Frontiermtns", "92" },
            { "Overthere", "93" },
            { "Emeraldjungle", "94" },
            { "Trakanon", "95" },
            { "Timorous", "96" },
            { "Kurn", "97" },
            { "Erudsxing", "98" },
            { "Stonebrunt", "100" },
            { "Warrens", "101" },
            { "Karnor", "102" },
            { "Chardok", "103" },
            { "Dalnir", "104" },
            { "Charasis", "105" },
            { "Cabeast", "106" },
            { "Nurga", "107" },
            { "Veeshan", "108" },
            { "Veksar", "109" },
            { "Iceclad", "110" },
            { "Frozenshadow", "111" },
            { "Velketor", "112" },
            { "Kael", "113" },
            { "Skyshrine", "114" },
            { "Thurgadina", "115" },
            { "Eastwastes", "116" },
            { "Cobaltscar", "117" },
            { "Greatdivide", "118" },
            { "Wakening", "119" },
            { "Westwastes", "120" },
            { "Crystal", "121" },
            { "Necropolis", "123" },
            { "Templeveeshan", "124" },
            { "Sirens", "125" },
            { "Mischiefplane", "126" },
            { "Growthplane", "127" },
            { "Sleeper", "128" },
            { "Thurgadinb", "129" },
            { "Erudsxing2", "130" },
            { "Shadowhaven", "150" },
            { "Bazaar", "151" },
            { "Nexus", "152" },
            { "Echo", "153" },
            { "Acrylia", "154" },
            { "Sharvahl", "155" },
            { "Paludal", "156" },
            { "Fungusgrove", "157" },
            { "Vexthal", "158" },
            { "Sseru", "159" },
            { "Katta", "160" },
            { "Netherbian", "161" },
            { "Ssratemple", "162" },
            { "Griegsend", "163" },
            { "Thedeep", "164" },
            { "Shadeweaver", "165" },
            { "Hollowshade", "166" },
            { "Grimling", "167" },
            { "Mseru", "168" },
            { "Letalis", "169" },
            { "Twilight", "170" },
            { "Thegrey", "171" },
            { "Tenebrous", "172" },
            { "Maiden", "173" },
            { "Dawnshroud", "174" },
            { "Scarlet", "175" },
            { "Umbral", "176" },
            { "Akheva", "179" },
            { "Arena2", "180" },
            { "Jaggedpine", "181" },
            { "Tutorial", "183" },
            { "Load", "184" },
            { "Load2", "185" },
            { "Codecay", "200" },
            { "Pojustice", "201" },
            { "Poknowledge", "202" },
            { "Potranquility", "203" },
            { "Ponightmare", "204" },
            { "Podisease", "205" },
            { "Poinnovation", "206" },
            { "Potorment", "207" },
            { "Povalor", "208" },
            { "Bothunder", "209" },
            { "Postorms", "210" },
            { "Hohonora", "211" },
            { "Solrotower", "212" },
            { "Powar", "213" },
            { "Potactics", "214" },
            { "Poair", "215" },
            { "Powater", "216" },
            { "Pofire", "217" },
            { "Poeartha", "218" },
            { "Potimea", "219" },
            { "Hohonorb", "220" },
            { "Nightmareb", "221" },
            { "Poearthb", "222" },
            { "Potimeb", "223" },
        }
    },
    new MsgEnum {
        Name = "ZONE_REQ_REASON",
        Type = "int",
        Members = new() {
            { "Teleport", "0" }, // "teleport" - DoTeleport zoneline
            { "Unknown", "1" }, // takp uses this for #zone
            { "VehicleTransfer", "2" }, // "vehicle xfr"
            { "SummonPlayer", "3" }, // "summon player"
            { "ZoneCommand", "4" }, // "zone command" - msg_translocate without a caster name
            { "GotoPlayer", "5" }, // "goto player"
            { "Gate", "6" }, // "gate"
            { "PortalSpell", "7" }, // "portal spell"
            { "ZoneCommandWithCaster", "8" }, // "zone command" - msg_translocate with a caster name
            { "ResurrectPlayer", "9" }, // "resurrect player"
            { "RepopToHomeAtDeath", "10"}, // "repop to home at death"
        },
    },
    new MsgEnum {
        Name = "ZONE_REQ_STATUS",
        Type = "int",
        Members = [] // TODO:
    }
];

var enumTypeNames = enumTypes.Select(t => t.Name);

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

        msgStruct.Fields[i] = new MsgField(msgStruct)
        {
            Name = field.Name.Str,
            Type = field.Type.Str,
            Count = (int)field.FieldLength,
            Offset = (int)field.FieldPos,
            FieldType = (MsgFieldType)field.Unk3,
            NextFieldOffset = i + 1 == msg.Fields.Count ? msgStruct.Size : (int)msg.Fields[i + 1].FieldPos,
        };

        if (!msgStruct.HasEnum  && enumTypeNames.Contains(msgStruct.Fields[i].Type))
        {
            msgStruct.HasEnum = true;
        }
    }

    // HACK: EQ_PC should offset EQ_PCData4 by the size of EQ_Character
    if (msgStruct.Name == "EQ_PC")
    {
        msgStruct.Fields[1].Offset = 3780; // EQ_Character size
    }

    // HACK: doHouseLock parses into invalid data with two "status" fields
    if (msgStruct.Name == "doHouseLock")
    {
        msgStruct.Fields[2].Name = "status_unk";
        msgStruct.Fields[2].Offset = 12;
    }

    msgs.Add(msgStruct);
}

foreach (var msg in msgs)
{
    TypeMapper.Instance.AddCustomType(msg.Name.StructString(), msg.Size);
}

using (StreamWriter outputFile = new("eqmac_net_structs.h"))
{
    foreach (var msg in msgs)
    {
        outputFile.WriteLine(msg.ToString());
    }
}

Directory.CreateDirectory("csharp/Structs");
foreach (var msg in msgs)
{
    using (StreamWriter outputFile = new($"csharp/Structs/{msg.Name.StructString()}.cs"))
    {
        outputFile.WriteLine(msg.ToCSharpString());
    }
}

Directory.CreateDirectory("csharp/Enums");
foreach (var msgEnum in enumTypes)
{
    using (StreamWriter outputFile = new($"csharp/Enums/{msgEnum.Name.StructString()}.cs"))
    {
        outputFile.WriteLine(msgEnum.ToCSharpString());
    }
}

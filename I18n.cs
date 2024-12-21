public static class I18n
{
    private static readonly Dictionary<string, string> _lookups = new()
    {
        { "AbilityPts", "AbilityPoints" },
        { "Accel", "Acceleration" },
        { "Alt", "Percentage"},
        { "AltexpUpMsg", "AltExperienceUpdateMsg" },
        { "Amt", "Amount" },
        { "Anim", "Animation" },
        { "AnimSpeed", "AnimationSpeed" },
        { "AnimVariation", "AnimationVariation" },
        { "AtkMissMe", "AttackMissMe" },
        { "AutoInven", "AutoInventory" },
        { "AvatarLvl", "AvatarLevel" },
        { "AvLevel", "AvatarLevel" },
        { "Bardsongs", "BardSongs" },
        { "BCopper", "BankCopper" },
        { "BegH", "BeginningHeading" },
        { "BegP", "BeginningPitch" },
        { "BegState", "BeginningState" },
        { "BegX", "BeginningX" },
        { "BegY", "BeginningY" },
        { "BegZ", "BeginningZ" },
        { "BGold", "BankGold" },
        { "Bodytype", "BodyType" },
        { "BPersist", "Persist" },
        { "BPlatinum", "BankPlatinum" },
        { "BSilver", "BankSilver" },
        { "BTemporaryPet", "TemporaryPet" },
        { "Buffend", "BufferEnd" },
        { "Buffstart", "BufferStart" },
        { "Bugrpt", "BugReport" },
        { "Castspellmsg", "CastSpellMsg" },
        { "Cclass", "CClass" },
        { "Charname", "CharacterName" },
        { "CharName", "CharacterName" },
        { "ChngAbility", "ChangeAbility" },
        { "ChngForm", "ChangeForm" },
        { "ChngName", "ChangeName" },
        { "ChngSkill", "ChangeSkill" },
        { "Cksum", "Checksum" },
        { "Clevel", "CLevel" },
        { "ClrFaction", "ClearFaction" },
        { "Cmd", "Command" },
        { "CompData", "CompressedData" },
        { "ConAffects", "ContainerAffects" },
        { "ConType", "ContainerType" },
        { "Copp", "Copper" },
        { "Corpsename", "CorpseName" },
        { "Crace", "CRace" },
        { "Criticalmelee", "CriticalMelee" },
        { "Criticalspells", "CriticalSpells" },
        { "Csex", "CSex" },
        { "CurDay", "CurrentDay" },
        { "CurHour", "CurrentHour" },
        { "CurHp", "CurrentHp" },
        { "CurMana", "CurrentMana" },
        { "CurMinute", "CurrentMinute" },
        { "CurMonth", "CurrentMonth" },
        { "CurState", "CurrentState" },
        { "CurX", "CurrentX" },
        { "CurY", "CurrentY" },
        { "CurYear", "CurrentYear" },
        { "CurZ", "CurrentZ" },
        { "CurZoneId", "CurrentZoneId" },
        { "Datarate", "DataRate" },
        { "Delfile", "DeleteFile" },
        { "Desc", "Description" },
        { "DestPc", "DestinationPc" },
        { "DestX", "DestinationX" },
        { "DestY", "DestinationY" },
        { "DestZ", "DestinationZ" },
        { "Dmgshields", "DamageShields" },
        { "DoAltExp", "DoAlternateExperience" },
        { "DopostMsg", "DoPostMsg" },
        { "ElementDam", "ElementDamage" },
        { "EndRt", "EndRoute" },
        { "EndWardate", "EndWarDate" },
        { "EqException", "EQException" },
        { "EQMissileHitinfo", "EQMissileHitInfo" },
        { "EqPc", "EQPc" },
        { "EQPcdata3", "EQPcData3" },
        { "EQPcdata4", "EQPcData4" },
        { "EqTime", "EQTime" },
        { "Exp", "Experience" },
        { "Explost", "ExperienceLost" },
        { "ExpModifier", "ZoneExperienceModifier" },
        { "ExpReward", "ExperienceReward" },
        { "Extdat1", "ExtraData1" },
        { "Extdat2", "ExtraData2" },
        { "Extdatint", "ExtraDataInt" },
        { "ExtraEqdat", "ExtraEquipmentData" },
        { "Extstr", "ExtraString" },
        { "FactionMod", "FactionModifier" },
        { "Factionnum", "FactionNumber" },
        { "FactionNum", "FactionNumber" },
        { "FactValue", "FactionValue" },
        { "FogOn", "ZoneType" },
        { "Foodwater", "FoodWater" },
        { "FTimeLeft", "TimeLeft" },
        { "Gbuffend", "GuaranteedBufferEnd" },
        { "Gbuffstart", "GuaranteedBufferStart" },
        { "GData", "GuildData" },
        { "GMasterId", "GrandMasterId" },
        { "GmstationNum", "GmStationNumber" },
        { "GraveyardTme", "GraveyardTime" },
        { "Groupdat", "GroupData" },
        { "Groupnames", "GroupNames" },
        { "GuarBuffer", "GuaranteedBuffer" },
        { "GuildCRCmsg", "GuildCrcMsg" },
        { "GuildDat", "GuildData" },
        { "GuildmotdSet", "GuildMotdSet" },
        { "guildPeace", "GuildPeace" },
        { "H", "Heading" },
        { "HardLvlLimit", "HardLevelLimit" },
        { "HCopper", "HeldCopper" },
        { "Hdg", "Heading" },
        { "HGold", "HeldGold" },
        { "Highestlevel", "HighestLevel" },
        { "Hilvl", "HighLevel" },
        { "HitptMsg", "HitPointMsg" },
        { "HomeH", "HomeHeading" },
        { "HpChgMsg", "HpChangeMsg" },
        { "HPlatinum", "HeldPlatinum" },
        { "HSilver", "HeldSilver" },
        { "IdNum", "IdNumber" },
        { "IID", "Id" },
        { "ImageNbr", "ImageNumber" },
        { "IMaxPrice", "MaxPrice" },
        { "IMinPrice", "MinPrice" },
        { "InvenLocation", "InventoryLocation" },
        { "InvRefnum", "InventoryRefNumber" },
        { "IsInvis", "IsInvisible" },
        { "ISpellNumber", "SpellNumber" },
        { "Itemrefnum", "ItemRefNumber" },
        { "ItemRefnums", "ItemRefNumbers" },
        { "IValue", "Value" },
        { "Keynum", "KeyNumber" },
        { "Lang", "Language" },
        { "LangType", "LanguageType" },
        { "LastBuffOut", "LastBufferOut" },
        { "LastGuarBuffOut", "LastGuaranteedBufferOut" },
        { "Lockmsg", "LockMsg" },
        { "Logshoweq", "LogShowEQ" },
        { "Lolvl", "LowLevel" },
        { "Lreason", "LoginReason" },
        { "Maxx", "MaxX" },
        { "Maxy", "MaxY" },
        { "Maxz", "MaxZ" },
        { "MBitFlags", "BitFlags" },
        { "Minx", "MinX" },
        { "Miny", "MinY" },
        { "Minz", "MinZ" },
        { "MiscInfo", "MiscellaneousInfo" },
        { "Modfaction", "ModFaction" },
        { "ModfactionVal", "ModFactionValue" },
        { "ModRt", "ModRoute" },
        { "Msg", "Message" },
        { "MsgGiveitem", "MsgGiveItem" },
        { "MsgType", "MessageType" },
        { "MyChar", "MyCharacter" },
        { "Myphysics", "MyPhysics" },
        { "NecroID", "NecroId" },
        { "Netphysics", "NetPhysics" },
        { "Netphysicsinfo", "NetPhysicsInfo" },
        { "NewCharName", "NewCharacterName" },
        { "NewHostAddr", "NewHostAddress" },
        { "Newname", "NewName" },
        { "NewNum", "NewNumber" },
        { "Newtext", "NewText" },
        { "NFocusEffectNum", "FocusEffectNumber" },
        { "Nograv", "NoGravity" },
        { "Notetype", "NoteType" },
        { "Npcid", "NpcId" },
        { "Npcspells", "NpcSpells" },
        { "Num", "Number" },
        { "NumActive", "NumberActive" },
        { "NumCheckouts", "NumberCheckouts" },
        { "NumCoords", "NumberCoords" },
        { "Numinzone", "NumberInZone" },
        { "numrecs", "NumberRecords" },
        { "OldNum", "OldNumber" },
        { "OrigAvaLevel", "OriginalAvatarLevel" },
        { "OrigCharName", "OriginalCharacterName" },
        { "OrigWorldName", "OriginalWorldName" },
        { "OrigZoneId", "OriginalZoneId" },
        { "OwnerID", "OwnerId" },
        { "P", "Pitch" },
        { "Pcabilities", "PCAbilities" },
        { "Pcdata", "PcData" },
        { "Pclass", "Class" },
        { "PCopper", "PlayerCopper" },
        { "PCSaveMsg", "PcSaveMsg" },
        { "Pcspells", "PcSpells" },
        { "Percentback", "PercentBack" },
        { "PetID", "PetId" },
        { "PetitionQstatus", "PetitionQueueStatus" },
        { "PetitionQtype", "PetitionQueueType" },
        { "PGold", "PlayerGold" },
        { "Physicsinfo", "PhysicsInfo" },
        { "PkActive", "PlayerKillActive" },
        { "Pkill", "PlayerKill" },
        { "Plat", "Platinum" },
        { "Playerdata", "PlayerData" },
        { "PlayerID", "PlayerId" },
        { "Playername", "PlayerName" },
        { "Post60Exp", "Post60Experience" },
        { "PPlatinum", "PlayerPlatinum" },
        { "Prev", "Previous" },
        { "PrimActor", "PrimaryActor" },
        { "PSilver", "PlayerSilver" },
        { "Pword", "Password" },
        { "Qty", "Quantity" },
        { "Rainchance", "RainChance" },
        { "Rainduration", "RainDuration" },
        { "RanReturnMsg", "RandomReturnMsg" },
        { "RateH", "RateHeading" },
        { "RateP", "RatePitch" },
        { "Recnum", "RecordNumber" },
        { "RecordNbr", "RecordNumber" },
        { "Refnum", "RefNumber"},
        { "ReqLootermsg", "ReqLooterMsg" },
        { "ReqName", "RequestName" },
        { "Reqplayed", "ReqPlayed" },
        { "Routenum", "RouteNumber" },
        { "RpActive", "RolePlayActive" },
        { "SecdActor", "SecondaryActor" },
        { "SerialNbr", "SerialNumber" },
        { "Sernbr", "SerialNumber" },
        { "SetDatRateMsg", "SetDataRateMsg" },
        { "Silv", "Silver" },
        { "Skillnum", "SkillNumber" },
        { "SkillTmrMsg", "SkillTimerMsg" },
        { "Skillvalue", "SkillValue" },
        { "SMark", "SoulMark" },
        { "Snooptext", "SnoopText" },
        { "Snowchance", "SnowChance" },
        { "Snowduration", "SnowDuration" },
        { "Soundnum", "SoundNumber" },
        { "Speakingskill", "SpeakingSkill" },
        { "SpecBodytypeBane", "SpecBodyTypeBane" },
        { "Specialcodes", "SpecialCodes" },
        { "Specialdates", "SpecialDates" },
        { "SpellLvl", "SpellLevel" },
        { "SpellNbr", "SpellNumber" },
        { "Spellnum", "SpellNumber" },
        { "StartRt", "StartRoute" },
        { "StationNum", "StationNumber" },
        { "StatusUnk", "StatusUnknown" },
        { "Stopcastingmsg", "StopCastingMsg" },
        { "StrToken", "StringToken" },
        { "SzArg", "Arg" },
        { "SzFilter", "Filter" },
        { "Szoneid", "SourceZoneId" },
        { "SzParam", "Param" },
        { "Targetid", "TargetId" },
        { "Tempspellbook", "TempSpellbook" },
        { "Tgt", "Target" },
        { "TgtIDmsg", "TargetIdMsg"},
        { "Timezone", "TimeZone" },
        { "TitleNbr", "TitleNumber" },
        { "TmLastModulated", "TimeLastModulated" },
        { "TmLastShield", "TimeLastShield" },
        { "Tohit", "ToHit" },
        { "Tradeitem", "TradeItem" },
        { "Trademoney", "TradeMoney" },
        { "TransSpell", "TranslocateSpell" },
        { "Tzoneid", "TargetZoneId" },
        { "UniqueGuildID", "UniqueGuildId" },
        { "VaultCon", "VaultContainer" },
        { "VaultConAffects", "VaultContainerAffects" },
        { "Vehiclename", "VehicleName" },
        { "Vx", "VelocityX" },
        { "Vy", "VelocityY" },
        { "Vz", "VelocityZ" },
        { "Warguild", "WarGuild" },
        { "Wclass", "WeaponClass" },
        { "WeatherChgMsg", "WeatherChangeMsg" },
        { "WldgroupMsg", "WorldGroupMsg" },
        { "Wordnum", "WorldNumber" },
        { "Wordval", "WordValue" },
        { "Zonecontrol", "ZoneControl" },
        { "ZoneHeader.Name", "ZoneLongName" },
        { "ZoneHeader.Zone", "ZoneShortName" },
        { "Zoneid", "ZoneId" },
        { "ZserverStatmsg", "ZoneServerStatMsg" },
    };

    public static string T(string str)
    {
        if (_lookups.TryGetValue(str, out var lookup))
        {
            return lookup;
        }

        var lastStr = str.Split('.')[^1];

        if (_lookups.TryGetValue(lastStr, out lookup))
        {
            return lookup;
        }

        return lastStr;
    }
}
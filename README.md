# EqMacStructs

Extract and format network message structs from the eqmac binary.

```c
// __avLevel
// 1 bytes
// 1 fields
struct __avLevel {
    /* 0000 */ unsigned char level;
    /* 0001 */
};

// AbilityMsg
// 227 bytes
// 1 fields
struct AbilityMsg {
    /* 0000 */ unsigned char ability[227];
    /* 0227 */
};

// alternateMsg
// 256 bytes
// 1 fields
struct alternateMsg {
    /* 0000 */ char desc[256];
    /* 0256 */
};

// AltexpUpMsg
// 8 bytes
// 3 fields
struct AltexpUpMsg {
    /* 0000 */ unsigned long experience;
    /* 0004 */ short ability_pts;
    /* 0006 */ unsigned char alt;
    /* 0008 */
};

// altGive
// 8 bytes
// 2 fields
struct altGive {
    /* 0000 */ unsigned short target;
    /* 0004 */ int value;
    /* 0008 */
};

// AltTimerMsg
// 12 bytes
// 3 fields
struct AltTimerMsg {
    /* 0000 */ int time_last_used;
    /* 0004 */ short ability;
    /* 0008 */ unsigned long current_time;
    /* 0012 */
};

// anim_msg
// 12 bytes
// 3 fields
struct anim_msg {
    /* 0000 */ unsigned short player_id;
    /* 0004 */ int anim;
    /* 0008 */ float anim_speed;
    /* 0012 */
};

// applyPoison
// 8 bytes
// 2 fields
struct applyPoison {
    /* 0000 */ int inven_location;
    /* 0004 */ int success;
    /* 0008 */
};

// approve
// 172 bytes
// 5 fields
struct approve {
    /* 0032 */ char name[64];
    /* 0096 */ int race;
    /* 0100 */ int cclass;
    /* 0104 */ char sysop[64];
    /* 0168 */ unsigned char status;
    /* 0172 */
};

// __bandage
// 4 bytes
// 2 fields
struct __bandage {
    /* 0000 */ unsigned short id;
    /* 0002 */ short amt;
    /* 0004 */
};

// _bugrpt
// 1131 bytes
// 7 fields
struct _bugrpt {
    /* 0000 */ char name[64];
    /* 0064 */ char account[32];
    /* 0096 */ char time[5];
    /* 0101 */ char date[4];
    /* 0105 */ char dupe;
    /* 0106 */ char crash;
    /* 0107 */ char text[1024];
    /* 1131 */
};

// BazaarMsgItem
// 76 bytes
// 6 fields
struct BazaarMsgItem {
    /* 0000 */ short msg_type;
    /* 0002 */ short qty;
    /* 0004 */ short item_id;
    /* 0006 */ unsigned short seller_id;
    /* 0008 */ unsigned int price;
    /* 0012 */ char item_name[64];
    /* 0076 */
};

// becomeNPCMsg
// 8 bytes
// 2 fields
struct becomeNPCMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int level;
    /* 0008 */
};

// beginTrade
// 4 bytes
// 2 fields
struct beginTrade {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// buffUp
// 4 bytes
// 2 fields
struct buffUp {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned char level;
    /* 0004 */
};

// bzrBuyMsg
// 80 bytes
// 7 fields
struct bzrBuyMsg {
    /* 0000 */ short msg_type;
    /* 0002 */ unsigned short bzr_merc_id;
    /* 0004 */ int item_id;
    /* 0008 */ unsigned long ask_price;
    /* 0012 */ short quantity;
    /* 0014 */ short slot;
    /* 0016 */ char item_name[64];
    /* 0080 */
};

// bzrGenericMsg
// 20 bytes
// 2 fields
struct bzrGenericMsg {
    /* 0000 */ short msg_type;
    /* 0004 */ int value[4];
    /* 0020 */
};

// bzrItemArrayMsg
// 644 bytes
// 3 fields
struct bzrItemArrayMsg {
    /* 0000 */ short msg_type;
    /* 0004 */ int bzrItem[80];
    /* 0324 */ unsigned long bzrPrice[80];
    /* 0644 */
};

// bzrSearchMsg
// 88 bytes
// 10 fields
struct bzrSearchMsg {
    /* 0000 */ short msg_type;
    /* 0002 */ unsigned short player_id;
    /* 0004 */ short cclass;
    /* 0006 */ short crace;
    /* 0008 */ short stat;
    /* 0010 */ short slot;
    /* 0012 */ short type;
    /* 0014 */ char item_name[64];
    /* 0080 */ int iMinPrice;
    /* 0084 */ int iMaxPrice;
    /* 0088 */
};

// bzrItemUpdateMsg
// 12 bytes
// 3 fields
struct bzrItemUpdateMsg {
    /* 0000 */ short msg_type;
    /* 0004 */ int item_id;
    /* 0008 */ unsigned long ask_price;
    /* 0012 */
};

// cancelDuel
// 6 bytes
// 3 fields
struct cancelDuel {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ unsigned char reason;
    /* 0006 */
};

// canTrade
// 4 bytes
// 2 fields
struct canTrade {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// castspellmsg
// 12 bytes
// 5 fields
struct castspellmsg {
    /* 0000 */ short which_slot;
    /* 0002 */ short spell_nbr;
    /* 0004 */ short item_slot;
    /* 0006 */ unsigned short target_id;
    /* 0008 */ int crc32;
    /* 0012 */
};

// chngAbility
// 12 bytes
// 3 fields
struct chngAbility {
    /* 0000 */ unsigned short target;
    /* 0004 */ int ability;
    /* 0008 */ int value;
    /* 0012 */
};

// changeGuildLeader
// 64 bytes
// 1 fields
struct changeGuildLeader {
    /* 0000 */ char newLeader[64];
    /* 0064 */
};

// changeItem
// 68 bytes
// 2 fields
struct changeItem {
    /* 0000 */ char name[64];
    /* 0064 */ int refnum;
    /* 0068 */
};

// changeMoney
// 72 bytes
// 3 fields
struct changeMoney {
    /* 0000 */ char name[64];
    /* 0064 */ int type;
    /* 0068 */ int qty;
    /* 0072 */
};

// changeWorldMsg
// 752 bytes
// 12 fields
struct changeWorldMsg {
    /* 0000 */ ChangeWorld_State state;
    /* 0004 */ ChangeWorld_State status;
    /* 0008 */ char origCharName[64];
    /* 0072 */ char origWorldName[256];
    /* 0328 */ short origZoneId;
    /* 0330 */ short origAvaLevel;
    /* 0332 */ char newCharName[64];
    /* 0396 */ char newHostAddr[256];
    /* 0652 */ short newPort;
    /* 0654 */ short newZoneId;
    /* 0656 */ char stationId[32];
    /* 0688 */ char credentials[64];
    /* 0752 */
};

// chestLock
// 20 bytes
// 6 fields
struct chestLock {
    /* 0000 */ unsigned short id;
    /* 0004 */ unsigned long sernbr;
    /* 0008 */ short status;
    /* 0010 */ short type;
    /* 0012 */ int capacity;
    /* 0016 */ int image_nbr;
    /* 0020 */
};

// chngName
// 196 bytes
// 5 fields
struct chngName {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ char newname[64];
    /* 0192 */ unsigned short badName;
    /* 0194 */ unsigned short changed;
    /* 0196 */
};

// chngForm
// 20 bytes
// 11 fields
struct chngForm {
    /* 0000 */ unsigned short targetid;
    /* 0002 */ short race;
    /* 0004 */ unsigned char sex;
    /* 0005 */ char texture_type;
    /* 0006 */ char head;
    /* 0008 */ short face;
    /* 0010 */ unsigned char Hair;
    /* 0011 */ unsigned char HairColor;
    /* 0012 */ unsigned char Beard;
    /* 0013 */ unsigned char BeardColor;
    /* 0016 */ int height;
    /* 0020 */
};

// chngSkill
// 12 bytes
// 3 fields
struct chngSkill {
    /* 0000 */ unsigned short target;
    /* 0004 */ int skill;
    /* 0008 */ int value;
    /* 0012 */
};

// clearSlot
// 6 bytes
// 3 fields
struct clearSlot {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */ char slot;
    /* 0006 */
};

// clientUseCharge
// 8 bytes
// 4 fields
struct clientUseCharge {
    /* 0000 */ unsigned long inv_refnum;
    /* 0004 */ char hunger;
    /* 0005 */ char thirst;
    /* 0006 */ char expend;
    /* 0008 */
};

// clientAddPlayer
// 68 bytes
// 2 fields
struct clientAddPlayer {
    /* 0000 */ int crc32;
    /* 0004 */ char name[64];
    /* 0068 */
};

// client_spawn_npc
// 116 bytes
// 7 fields
struct client_spawn_npc {
    /* 0000 */ char name[64];
    /* 0064 */ char filename[32];
    /* 0096 */ float x;
    /* 0100 */ float y;
    /* 0104 */ float z;
    /* 0108 */ unsigned char qty;
    /* 0112 */ unsigned int duration;
    /* 0116 */
};

// clrFaction
// 68 bytes
// 2 fields
struct clrFaction {
    /* 0000 */ char name[64];
    /* 0064 */ int factionnum;
    /* 0068 */
};

// consentVerify
// 129 bytes
// 3 fields
struct consentVerify {
    /* 0000 */ char looter[64];
    /* 0064 */ char corpsename[64];
    /* 0128 */ char consent;
    /* 0129 */
};

// controlNpc
// 4 bytes
// 2 fields
struct controlNpc {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned char control;
    /* 0004 */
};

// corpseLogMsg
// 68 bytes
// 2 fields
struct corpseLogMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int logActive;
    /* 0068 */
};

// createGold
// 4 bytes
// 1 fields
struct createGold {
    /* 0000 */ int amt;
    /* 0004 */
};

// createGuild
// 208 bytes
// 7 fields
struct createGuild {
    /* 0000 */ int guild_faction;
    /* 0004 */ char guild_name[64];
    /* 0068 */ char guild_leader[64];
    /* 0132 */ int status;
    /* 0136 */ char gm_name[64];
    /* 0200 */ int worldServerOK;
    /* 0204 */ unsigned int guild_id;
    /* 0208 */
};

// createItem_MacMsg
// 34 bytes
// 3 fields
struct createItem_MacMsg {
    /* 0000 */ char name[30];
    /* 0030 */ short recordNbr;
    /* 0032 */ short slot;
    /* 0034 */
};

// deleteMsg
// 8 bytes
// 3 fields
struct deleteMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned short id;
    /* 0004 */ int category;
    /* 0008 */
};

// disarmMsg
// 8 bytes
// 4 fields
struct disarmMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned short target;
    /* 0004 */ short skill;
    /* 0006 */ char status;
    /* 0008 */
};

// disband
// 128 bytes
// 2 fields
struct disband {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */
};

// doCombine
// 32 bytes
// 7 fields
struct doCombine {
    /* 0000 */ unsigned char type;
    /* 0002 */ short skill;
    /* 0004 */ short location;
    /* 0006 */ short item[10];
    /* 0026 */ short product;
    /* 0028 */ short difficulty;
    /* 0030 */ short itemrefnum;
    /* 0032 */
};

// doHouseLock
// 12 bytes
// 3 fields
struct doHouseLock {
    /* 0000 */ int status;
    /* 0004 */ unsigned short id;
    /* 0000 */ long status;
    /* 0012 */
};

// doHouseMoney
// 16 bytes
// 1 fields
struct doHouseMoney {
    /* 0000 */ long money[4];
    /* 0016 */
};

// doNpcCmd
// 4 bytes
// 2 fields
struct doNpcCmd {
    /* 0000 */ unsigned short id;
    /* 0002 */ short index;
    /* 0004 */
};

// doPlayer
// 129 bytes
// 3 fields
struct doPlayer {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ char found;
    /* 0129 */
};

// doPlayer2
// 162 bytes
// 5 fields
struct doPlayer2 {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ char stationNum[32];
    /* 0160 */ char found;
    /* 0161 */ char dir;
    /* 0162 */
};

// dopostMsg
// 1174 bytes
// 6 fields
struct dopostMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ char time[16];
    /* 0018 */ char author[64];
    /* 0082 */ short language;
    /* 0084 */ char subject[64];
    /* 0148 */ short type;
    /* 1174 */
};

// duel
// 4 bytes
// 2 fields
struct duel {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// emoteMsg
// 1026 bytes
// 2 fields
struct emoteMsg {
    /* 0000 */ short lang_type;
    /* 0002 */ char desc[1024];
    /* 1026 */
};

// endRt
// 24 bytes
// 6 fields
struct endRt {
    /* 0000 */ long minx;
    /* 0004 */ long miny;
    /* 0008 */ long minz;
    /* 0012 */ long maxx;
    /* 0016 */ long maxy;
    /* 0020 */ long maxz;
    /* 0024 */
};

// EQ_Affect
// 10 bytes
// 7 fields
struct EQ_Affect {
    /* 0000 */ unsigned char type;
    /* 0001 */ unsigned char level;
    /* 0002 */ unsigned char charges;
    /* 0003 */ unsigned char activated;
    /* 0004 */ short number;
    /* 0006 */ short duration;
    /* 0008 */ short data;
    /* 0010 */
};

// EQ_Character
// 3780 bytes
// 6 fields
struct EQ_Character {
    /* 0000 */ EQ_CharacterData3 Parent_Class[3444];
    /* 3444 */ EQPlayer * me;
    /* 3448 */ EQ_Item * possessions[30];
    /* 3568 */ unsigned char spellcast_level;
    /* 3570 */ EQ_Affect m_NpcEffects[15];
    /* 3720 */ unsigned short m_EffectIds[30];
    /* 3780 */
};

// EQ_CharacterData3
// 3444 bytes
// 68 fields
struct EQ_CharacterData3 {
    /* 0000 */ EQCVersionInfo version;
    /* 0002 */ char name[64];
    /* 0066 */ char lastName[32];
    /* 0098 */ char Title[32];
    /* 0132 */ unsigned int uniqueGuildID;
    /* 0136 */ unsigned char sex;
    /* 0138 */ unsigned short race;
    /* 0140 */ unsigned char cclass;
    /* 0142 */ unsigned short bodytype;
    /* 0144 */ unsigned char level;
    /* 0148 */ unsigned long experience;
    /* 0152 */ short practices;
    /* 0154 */ short cur_mana;
    /* 0156 */ short cur_hp;
    /* 0158 */ char status;
    /* 0160 */ short STR;
    /* 0162 */ short STA;
    /* 0164 */ short CHA;
    /* 0166 */ short DEX;
    /* 0168 */ short INT;
    /* 0170 */ short AGI;
    /* 0172 */ short WIS;
    /* 0174 */ unsigned char face;
    /* 0175 */ unsigned char armor_type[9];
    /* 0184 */ unsigned long tint[9];
    /* 0220 */ short _possessions[30];
    /* 0280 */ unsigned char languages[32];
    /* 0312 */ EQ_Affect item_affects[30];
    /* 0612 */ EQ_Affect m_Effects[15];
    /* 0762 */ short _containers[90];
    /* 0942 */ EQ_Affect con_affects[90];
    /* 1842 */ short _spellbook[512];
    /* 2866 */ short _memorized[16];
    /* 2898 */ char _max_allowed_spell_slots;
    /* 2900 */ float cur_x;
    /* 2904 */ float cur_y;
    /* 2908 */ float cur_z;
    /* 2912 */ float heading;
    /* 2916 */ unsigned char position;
    /* 2920 */ long p_platinum;
    /* 2924 */ long p_gold;
    /* 2928 */ long p_silver;
    /* 2932 */ long p_copper;
    /* 2936 */ long b_platinum;
    /* 2940 */ long b_gold;
    /* 2944 */ long b_silver;
    /* 2948 */ long b_copper;
    /* 2952 */ long h_platinum;
    /* 2956 */ long h_gold;
    /* 2960 */ long h_silver;
    /* 2964 */ long h_copper;
    /* 2968 */ long a_platinum;
    /* 2972 */ long a_gold;
    /* 2976 */ long a_silver;
    /* 2980 */ long a_copper;
    /* 2984 */ short skill[100];
    /* 3184 */ short innate[25];
    /* 3234 */ char air_supply;
    /* 3235 */ char texture_type;
    /* 3236 */ float height;
    /* 3240 */ float width;
    /* 3244 */ float length;
    /* 3248 */ float view_height;
    /* 3252 */ char vehiclename[64];
    /* 3316 */ int primActor;
    /* 3320 */ int secdActor;
    /* 3324 */ int extdatint[29];
    /* 3440 */ EQZoneIndex cur_zone_id;
    /* 3444 */
};

// EQ_Container
// 276 bytes
// 7 fields
struct EQ_Container {
    /* 0000 */ EQ_Item Parent_Class[228];
    /* 0228 */ EQ_Item * items_held[10];
    /* 0268 */ unsigned char con_type;
    /* 0269 */ unsigned char capacity;
    /* 0270 */ unsigned char status;
    /* 0271 */ unsigned char sizeMax;
    /* 0272 */ unsigned char discount;
    /* 0276 */
};

// EQ_Equipment
// 360 bytes
// 54 fields
struct EQ_Equipment {
    /* 0000 */ EQ_Item Parent_Class[228];
    /* 0228 */ char STR;
    /* 0229 */ char STA;
    /* 0230 */ char CHA;
    /* 0231 */ char DEX;
    /* 0232 */ char INT;
    /* 0233 */ char AGI;
    /* 0234 */ char WIS;
    /* 0235 */ char save_magic;
    /* 0236 */ char save_fire;
    /* 0237 */ char save_cold;
    /* 0238 */ char save_disease;
    /* 0239 */ char save_poison;
    /* 0240 */ short hp;
    /* 0242 */ short mana;
    /* 0244 */ short ac;
    /* 0246 */ char maxCharges;
    /* 0247 */ unsigned char burn;
    /* 0248 */ unsigned char light;
    /* 0249 */ unsigned char ticks;
    /* 0250 */ unsigned char base_damage;
    /* 0251 */ unsigned char activated;
    /* 0252 */ unsigned char range;
    /* 0253 */ unsigned char cclass;
    /* 0254 */ unsigned char enchantable;
    /* 0255 */ unsigned char spell_level;
    /* 0256 */ unsigned char armor_type;
    /* 0260 */ unsigned long tint;
    /* 0264 */ short faction;
    /* 0266 */ short spell_nbr;
    /* 0268 */ long pclass;
    /* 0272 */ long race;
    /* 0276 */ EQ_Affect affect;
    /* 0288 */ float merchant_gouge;
    /* 0292 */ int extra_eqdat[4];
    /* 0308 */ long recast_timer;
    /* 0312 */ unsigned char spec_skill;
    /* 0314 */ short spec_skill_percent;
    /* 0316 */ short spec_race_bane;
    /* 0318 */ short spec_bodytype_bane;
    /* 0320 */ unsigned char spec_bane_damage;
    /* 0322 */ short title_flag;
    /* 0324 */ unsigned char level_restrict_stat;
    /* 0325 */ unsigned char skill_restrict_stat;
    /* 0326 */ short chance_proc;
    /* 0328 */ unsigned char element_flag;
    /* 0329 */ unsigned char element_dam;
    /* 0330 */ short modfaction[4];
    /* 0338 */ short modfaction_val[4];
    /* 0348 */ long deity;
    /* 0352 */ short hard_lvl_limit;
    /* 0354 */ short instrument_type;
    /* 0356 */ short instrument_mod;
    /* 0358 */ short m_nFocusEffectNum;
    /* 0360 */
};

// eq_exception
// 92 bytes
// 5 fields
struct eq_exception {
    /* 0000 */ unsigned int oldNum;
    /* 0004 */ unsigned int newNum;
    /* 0008 */ unsigned int msg;
    /* 0012 */ long decr_msg[10];
    /* 0052 */ long decr_time[10];
    /* 0092 */
};

// EQ_Item
// 228 bytes
// 23 fields
struct EQ_Item {
    /* 0000 */ char name[64];
    /* 0064 */ char loreName[80];
    /* 0144 */ char actor_tag[30];
    /* 0174 */ unsigned char weight;
    /* 0175 */ unsigned char rentable;
    /* 0176 */ unsigned char droppable;
    /* 0177 */ unsigned char size;
    /* 0178 */ unsigned char type;
    /* 0180 */ short record_nbr;
    /* 0182 */ short image_nbr;
    /* 0184 */ short location;
    /* 0188 */ long position;
    /* 0192 */ long value;
    /* 0196 */ float cur_x;
    /* 0200 */ float cur_y;
    /* 0204 */ float cur_z;
    /* 0208 */ float heading;
    /* 0212 */ unsigned long inv_refnum;
    /* 0216 */ short log;
    /* 0218 */ short loot_log;
    /* 0220 */ short avatar_lvl;
    /* 0222 */ short bottom_feed;
    /* 0224 */ unsigned char poof_item;
    /* 0228 */
};

// EQ_Note
// 264 bytes
// 5 fields
struct EQ_Note {
    /* 0000 */ EQ_Item Parent_Class[228];
    /* 0228 */ unsigned char notetype;
    /* 0229 */ unsigned char status;
    /* 0230 */ char language;
    /* 0231 */ char text[30];
    /* 0264 */
};

// EQ_PC
// 8452 bytes
// 17 fields
struct EQ_PC {
    /* 0000 */ EQ_Character Parent_Class[3780];
    /* 0000 */ EQ_PCData4 Parent_Class[4592];
    /* 8372 */ EQ_Item * vault[8];
    /* 8404 */ connection_t * my_socket;
    /* 8408 */ char * GuarBuffer;
    /* 8412 */ char * Buffer;
    /* 8416 */ EQ_PC * prev;
    /* 8420 */ EQ_PC * next;
    /* 8424 */ uint32 TransfersReceived;
    /* 8428 */ unsigned long lastBuffOut;
    /* 8432 */ unsigned long lastGuarBuffOut;
    /* 8436 */ unsigned short buffstart;
    /* 8438 */ unsigned short buffend;
    /* 8440 */ unsigned short gbuffstart;
    /* 8442 */ unsigned short gbuffend;
    /* 8444 */ int m_lastLanguageSpoken;
    /* 8448 */ int m_raidId;
    /* 8452 */
};

// EQ_PCData3
// 4464 bytes
// 59 fields
struct EQ_PCData3 {
    /* 0000 */ EQZoneIndex home_zone[5];
    /* 0020 */ float home_x[5];
    /* 0040 */ float home_y[5];
    /* 0060 */ float home_z[5];
    /* 0080 */ float home_h[5];
    /* 0100 */ EQ_Affect vault_affects[8];
    /* 0180 */ EQ_Affect vault_con_affects[80];
    /* 0980 */ unsigned long login_time;
    /* 0984 */ short _vault[8];
    /* 1000 */ short _vault_con[80];
    /* 1160 */ short deity;
    /* 1162 */ short guild;
    /* 1164 */ time_t created;
    /* 1168 */ time_t last_played;
    /* 1172 */ unsigned long minutes_played;
    /* 1176 */ char thirst;
    /* 1177 */ char hunger;
    /* 1178 */ char fatigue;
    /* 1179 */ unsigned char pkill;
    /* 1180 */ unsigned char highest_level;
    /* 1181 */ unsigned char anonymous;
    /* 1182 */ unsigned char gm;
    /* 1183 */ unsigned char guild_status;
    /* 1184 */ short sobriety;
    /* 1188 */ unsigned int spell_used[10];
    /* 1228 */ char groupnames[384];
    /* 1612 */ int groupdat[6];
    /* 1636 */ unsigned int Post60Exp;
    /* 1640 */ unsigned char NobilityRank;
    /* 1641 */ unsigned char do_alt_exp;
    /* 1642 */ unsigned char HairColor;
    /* 1643 */ unsigned char BeardColor;
    /* 1644 */ unsigned char LeftEye;
    /* 1645 */ unsigned char RightEye;
    /* 1646 */ unsigned char Hair;
    /* 1647 */ unsigned char Beard;
    /* 1648 */ unsigned char OldFace;
    /* 1652 */ int NewArmorType[22];
    /* 1740 */ unsigned long NewArmorTint[22];
    /* 1828 */ unsigned short pcabilities[60];
    /* 1948 */ unsigned int ATR_DIVINE_RES_timer;
    /* 1952 */ unsigned int ATR_FREE_HOT_timer;
    /* 1956 */ unsigned int ATR_TARGET_DA_timer;
    /* 1960 */ unsigned int ATR_PURIFY_timer;
    /* 1964 */ unsigned int ATR_DIRE_CHARM_timer;
    /* 1968 */ unsigned int ATR_STRONG_ROOT_timer;
    /* 1972 */ unsigned int ATR_MASOCHISM_timer;
    /* 1976 */ unsigned int ATR_MANA_BURN_timer;
    /* 1980 */ unsigned int ATR_GATHER_MANA_timer;
    /* 1984 */ unsigned int ATR_PET_LOH_timer;
    /* 1988 */ unsigned int ATR_DEADMEZ_timer;
    /* 1992 */ unsigned int ATR_MASS_FEAR_timer;
    /* 1996 */ short new_air_supply;
    /* 1998 */ short AbilityPts;
    /* 2000 */ unsigned int ATR_MASS_BUFF_timer;
    /* 2004 */ DWORD SerialNumber;
    /* 2008 */ unsigned char mBitFlags[800];
    /* 2808 */ unsigned int POP_CLASS_SPELL_TIMER;
    /* 2812 */ int PCExtraInt[413];
    /* 4464 */
};

// EQ_PCData4
// 4592 bytes
// 61 fields
struct EQ_PCData4 {
    /* 0000 */ EQZoneIndex home_zone[5];
    /* 0020 */ float home_x[5];
    /* 0040 */ float home_y[5];
    /* 0060 */ float home_z[5];
    /* 0080 */ float home_h[5];
    /* 0100 */ EQ_Affect vault_affects[8];
    /* 0180 */ EQ_Affect vault_con_affects[80];
    /* 0980 */ unsigned long login_time;
    /* 0984 */ short _vault[8];
    /* 1000 */ short _vault_con[80];
    /* 1160 */ short deity;
    /* 1162 */ short guild;
    /* 1164 */ time_t created;
    /* 1168 */ time_t last_played;
    /* 1172 */ unsigned long minutes_played;
    /* 1176 */ char thirst;
    /* 1177 */ char hunger;
    /* 1178 */ char fatigue;
    /* 1179 */ unsigned char pkill;
    /* 1180 */ unsigned char highest_level;
    /* 1181 */ unsigned char anonymous;
    /* 1182 */ unsigned char gm;
    /* 1183 */ unsigned char guild_status;
    /* 1184 */ short sobriety;
    /* 1188 */ unsigned int spell_used[10];
    /* 1228 */ char groupnames[384];
    /* 1612 */ int groupdat[6];
    /* 1636 */ unsigned int Post60Exp;
    /* 1640 */ unsigned char NobilityRank;
    /* 1641 */ unsigned char do_alt_exp;
    /* 1642 */ unsigned char HairColor;
    /* 1643 */ unsigned char BeardColor;
    /* 1644 */ unsigned char LeftEye;
    /* 1645 */ unsigned char RightEye;
    /* 1646 */ unsigned char Hair;
    /* 1647 */ unsigned char Beard;
    /* 1648 */ unsigned char OldFace;
    /* 1652 */ int NewArmorType[22];
    /* 1740 */ unsigned long NewArmorTint[22];
    /* 1828 */ unsigned short pcabilities[120];
    /* 2068 */ unsigned int ATR_DIVINE_RES_timer;
    /* 2072 */ unsigned int ATR_FREE_HOT_timer;
    /* 2076 */ unsigned int ATR_TARGET_DA_timer;
    /* 2080 */ unsigned int ATR_PURIFY_timer;
    /* 2084 */ unsigned int ATR_DIRE_CHARM_timer;
    /* 2088 */ unsigned int ATR_STRONG_ROOT_timer;
    /* 2092 */ unsigned int ATR_MASOCHISM_timer;
    /* 2096 */ unsigned int ATR_MANA_BURN_timer;
    /* 2100 */ unsigned int ATR_GATHER_MANA_timer;
    /* 2104 */ unsigned int ATR_PET_LOH_timer;
    /* 2108 */ unsigned int ATR_DEADMEZ_timer;
    /* 2112 */ unsigned int ATR_MASS_FEAR_timer;
    /* 2116 */ short new_air_supply;
    /* 2118 */ short AbilityPts;
    /* 2120 */ unsigned int ATR_MASS_BUFF_timer;
    /* 2124 */ DWORD SerialNumber;
    /* 2128 */ unsigned char mBitFlags[800];
    /* 2928 */ unsigned int POP_CLASS_SPELL_TIMER;
    /* 2932 */ unsigned int m_tmLastShield;
    /* 2936 */ unsigned int m_tmLastModulated;
    /* 2940 */ int PCExtraInt[413];
    /* 4592 */
};

// eq_time
// 6 bytes
// 5 fields
struct eq_time {
    /* 0000 */ unsigned char cur_hour;
    /* 0001 */ unsigned char cur_minute;
    /* 0002 */ unsigned char cur_day;
    /* 0003 */ unsigned char cur_month;
    /* 0004 */ short cur_year;
    /* 0006 */
};

// EQClientSwitch
// 44 bytes
// 13 fields
struct EQClientSwitch {
    /* 0000 */ char actor_tag[16];
    /* 0016 */ float beg_x;
    /* 0020 */ float beg_y;
    /* 0024 */ float beg_z;
    /* 0028 */ float beg_h;
    /* 0032 */ short beg_p;
    /* 0034 */ short scale;
    /* 0036 */ unsigned short player_id;
    /* 0038 */ unsigned char id;
    /* 0039 */ unsigned char type;
    /* 0040 */ unsigned char state;
    /* 0041 */ unsigned char beg_state;
    /* 0042 */ short spell;
    /* 0044 */
};

// EQCVersionInfo
// 2 bytes
// 1 fields
struct EQCVersionInfo {
    /* 0000 */ VersionWord v;
    /* 0002 */
};

// EQItemList
// 224 bytes
// 19 fields
struct EQItemList {
    /* 0000 */ EQItemList * prev;
    /* 0004 */ EQItemList * next;
    /* 0008 */ short record_nbr;
    /* 0012 */ long serial_nbr;
    /* 0016 */ EQZoneIndex zone_id;
    /* 0020 */ void * my_actor;
    /* 0024 */ EQ_Affect affect;
    /* 0034 */ EQ_Affect con_affects[10];
    /* 0136 */ long expires;
    /* 0140 */ float heading;
    /* 0144 */ float z;
    /* 0148 */ float y;
    /* 0152 */ float x;
    /* 0156 */ char actor_tag[30];
    /* 0186 */ short items_held[10];
    /* 0208 */ int zonefile_index;
    /* 0212 */ int weight;
    /* 0216 */ short key;
    /* 0220 */ unsigned long locked;
    /* 0224 */
};

// EQMissile
// 112 bytes
// 16 fields
struct EQMissile {
    /* 0000 */ unsigned char type;
    /* 0004 */ EQMissile * prev;
    /* 0008 */ EQMissile * next;
    /* 0012 */ physicsinfo myphysics;
    /* 0060 */ EQPMInfo * LocalInfo;
    /* 0064 */ unsigned short launcher_id;
    /* 0066 */ unsigned short target_id;
    /* 0068 */ short record_nbr;
    /* 0070 */ short attack_rating;
    /* 0072 */ int base_damage;
    /* 0076 */ unsigned char light;
    /* 0077 */ unsigned char weight;
    /* 0078 */ unsigned char range;
    /* 0079 */ unsigned char wclass;
    /* 0080 */ unsigned char skill_used;
    /* 0081 */ char actor_tag[30];
    /* 0112 */
};

// EQMissileHitinfo
// 36 bytes
// 13 fields
struct EQMissileHitinfo {
    /* 0000 */ unsigned short defender_id;
    /* 0002 */ unsigned short attacker_id;
    /* 0004 */ short attack_rating;
    /* 0008 */ int base_damage;
    /* 0012 */ float force;
    /* 0016 */ float hit_heading;
    /* 0020 */ float hit_pitch;
    /* 0024 */ unsigned char skill_used;
    /* 0026 */ unsigned short min_damage;
    /* 0028 */ unsigned short tohit;
    /* 0030 */ short spell_nbr;
    /* 0032 */ unsigned char spell_lvl;
    /* 0033 */ unsigned char misc_info;
    /* 0036 */
};

// EQMoneyList
// 112 bytes
// 17 fields
struct EQMoneyList {
    /* 0000 */ EQMoneyList * prev;
    /* 0004 */ EQMoneyList * next;
    /* 0008 */ int platinum;
    /* 0012 */ int gold;
    /* 0016 */ int silver;
    /* 0020 */ int copper;
    /* 0024 */ int serial_nbr;
    /* 0028 */ char zone_name[20];
    /* 0048 */ long expires;
    /* 0052 */ T3D_ACTORINSTANCEPTR my_actor;
    /* 0056 */ float x;
    /* 0060 */ float y;
    /* 0064 */ float z;
    /* 0068 */ float heading;
    /* 0072 */ float pitch;
    /* 0076 */ float roll;
    /* 0080 */ char actor_tag[30];
    /* 0112 */
};

// EQNetPlayer
// 224 bytes
// 44 fields
struct EQNetPlayer {
    /* 0000 */ unsigned int random_dontuse;
    /* 0004 */ netphysicsinfo netphysics;
    /* 0018 */ unsigned short leader_id;
    /* 0020 */ unsigned char anim_variation;
    /* 0021 */ unsigned char HairColor;
    /* 0022 */ unsigned char BeardColor;
    /* 0023 */ unsigned char LeftEye;
    /* 0024 */ unsigned char RightEye;
    /* 0025 */ unsigned char Hair;
    /* 0026 */ unsigned char Beard;
    /* 0027 */ unsigned char title_nbr;
    /* 0028 */ float height;
    /* 0032 */ float walk_speed;
    /* 0036 */ float run_speed;
    /* 0040 */ unsigned long tint[9];
    /* 0076 */ unsigned short id;
    /* 0078 */ short bodytype;
    /* 0080 */ char hp_percentage;
    /* 0082 */ short guild;
    /* 0084 */ unsigned short crace;
    /* 0086 */ unsigned char NPC;
    /* 0087 */ unsigned char cclass;
    /* 0088 */ unsigned char csex;
    /* 0089 */ unsigned char clevel;
    /* 0090 */ unsigned char is_invis;
    /* 0091 */ unsigned char is_sneaking;
    /* 0092 */ unsigned char pkill;
    /* 0093 */ unsigned char position;
    /* 0094 */ unsigned char light;
    /* 0095 */ char anonymous;
    /* 0096 */ char afk;
    /* 0097 */ char pc_summoned;
    /* 0098 */ char zonecontrol;
    /* 0099 */ char gm;
    /* 0100 */ char nograv;
    /* 0101 */ char texture_type;
    /* 0102 */ char head_type;
    /* 0103 */ unsigned char face;
    /* 0104 */ unsigned short armor_type[9];
    /* 0122 */ short guild_status;
    /* 0124 */ short deity;
    /* 0126 */ char temporaryPet;
    /* 0127 */ char name[64];
    /* 0191 */ char lastName[32];
    /* 0224 */
};

// EQObject
// 88 bytes
// 12 fields
struct EQObject {
    /* 0000 */ unsigned char type;
    /* 0004 */ EQObject * prev;
    /* 0008 */ EQObject * next;
    /* 0012 */ char name[20];
    /* 0032 */ char actor_tag[26];
    /* 0060 */ float scale;
    /* 0064 */ float x;
    /* 0068 */ float y;
    /* 0072 */ float z;
    /* 0076 */ float h;
    /* 0080 */ float p;
    /* 0084 */ T3D_ACTORINSTANCEPTR my_actor;
    /* 0088 */
};

// EQPlayer
// 352 bytes
// 60 fields
struct EQPlayer {
    /* 0000 */ unsigned char type;
    /* 0001 */ char name[64];
    /* 0068 */ EQZoneIndex zone_id;
    /* 0072 */ physicsinfo myphysics;
    /* 0120 */ EQPlayer * prev;
    /* 0124 */ EQPlayer * next;
    /* 0128 */ void * corpse;
    /* 0132 */ EQPMInfo * LocalInfo;
    /* 0136 */ void * My_Char;
    /* 0140 */ float view_height;
    /* 0144 */ float sprite_oheight;
    /* 0148 */ unsigned short id;
    /* 0150 */ unsigned short leader_id;
    /* 0152 */ int max_hp;
    /* 0156 */ int cur_hp;
    /* 0160 */ short guild;
    /* 0164 */ connection_t ** my_socket;
    /* 0168 */ unsigned char NPC;
    /* 0169 */ unsigned char cclass;
    /* 0170 */ unsigned short crace;
    /* 0172 */ unsigned char csex;
    /* 0173 */ unsigned char clevel;
    /* 0174 */ unsigned char is_invis;
    /* 0175 */ unsigned char is_sneaking;
    /* 0176 */ unsigned char pkill;
    /* 0177 */ unsigned char position;
    /* 0178 */ unsigned char light;
    /* 0179 */ unsigned char face;
    /* 0180 */ unsigned short armor_type[9];
    /* 0200 */ unsigned long tint[9];
    /* 0236 */ char texture_type;
    /* 0240 */ float height;
    /* 0244 */ float width;
    /* 0248 */ float length;
    /* 0252 */ char head_type;
    /* 0256 */ float walk_speed;
    /* 0260 */ float run_speed;
    /* 0264 */ char zonecontrol;
    /* 0265 */ char gm;
    /* 0266 */ short nograv;
    /* 0268 */ int bodytype;
    /* 0272 */ EQPlayer * view_player;
    /* 0276 */ int anonymous;
    /* 0280 */ short avatar;
    /* 0284 */ int afk;
    /* 0288 */ int pc_summoned;
    /* 0292 */ int title_nbr;
    /* 0296 */ int extra;
    /* 0300 */ char lastName[32];
    /* 0332 */ short guild_status;
    /* 0334 */ short deity;
    /* 0336 */ unsigned char anim_variation;
    /* 0337 */ unsigned char HairColor;
    /* 0338 */ unsigned char BeardColor;
    /* 0339 */ unsigned char LeftEye;
    /* 0340 */ unsigned char RightEye;
    /* 0341 */ unsigned char Hair;
    /* 0342 */ unsigned char Beard;
    /* 0344 */ EQSerialNumber SerialNumber;
    /* 0348 */ char m_bTemporaryPet;
    /* 0352 */
};

// EQPlayerDeath
// 20 bytes
// 8 fields
struct EQPlayerDeath {
    /* 0000 */ unsigned short victim_id;
    /* 0002 */ unsigned short killer_id;
    /* 0004 */ unsigned short corpse_number;
    /* 0006 */ unsigned char victim_level;
    /* 0008 */ short spell_nbr;
    /* 0010 */ unsigned char skill_used;
    /* 0012 */ int damage_done;
    /* 0016 */ unsigned char is_PC;
    /* 0020 */
};

// EQSuccessfulHit
// 24 bytes
// 8 fields
struct EQSuccessfulHit {
    /* 0000 */ unsigned short defender_id;
    /* 0002 */ unsigned short attacker_id;
    /* 0004 */ unsigned char skill_used;
    /* 0006 */ short spell_nbr;
    /* 0008 */ int damage_done;
    /* 0012 */ float force;
    /* 0016 */ float hit_heading;
    /* 0020 */ float hit_pitch;
    /* 0024 */
};

// EQSwitchState
// 2 bytes
// 2 fields
struct EQSwitchState {
    /* 0000 */ unsigned char id;
    /* 0001 */ unsigned char state;
    /* 0002 */
};

// EQToggleSwitch
// 8 bytes
// 4 fields
struct EQToggleSwitch {
    /* 0000 */ unsigned char id;
    /* 0002 */ short picking_skill;
    /* 0004 */ short record_nbr;
    /* 0006 */ unsigned short player_id;
    /* 0008 */
};

// expendItemCharge
// 8 bytes
// 2 fields
struct expendItemCharge {
    /* 0000 */ int item_class;
    /* 0004 */ int record_nbr;
    /* 0008 */
};

// expGain
// 8 bytes
// 2 fields
struct expGain {
    /* 0000 */ unsigned short id;
    /* 0004 */ int exp;
    /* 0008 */
};

// expGive
// 8 bytes
// 2 fields
struct expGive {
    /* 0000 */ unsigned short target;
    /* 0004 */ int value;
    /* 0008 */
};

// expSet
// 8 bytes
// 2 fields
struct expSet {
    /* 0000 */ unsigned short target;
    /* 0004 */ float level;
    /* 0008 */
};

// expUpMsg
// 4 bytes
// 1 fields
struct expUpMsg {
    /* 0000 */ unsigned long experience;
    /* 0004 */
};

// faction_MacMsg
// 382 bytes
// 3 fields
struct faction_MacMsg {
    /* 0000 */ short faction;
    /* 0002 */ char name[60];
    /* 0062 */ char standing[320];
    /* 0382 */
};

// feignMsg
// 6 bytes
// 3 fields
struct feignMsg {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned short fake;
    /* 0004 */ char status;
    /* 0006 */
};

// follow
// 128 bytes
// 2 fields
struct follow {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */
};

// foodItem
// 16 bytes
// 4 fields
struct foodItem {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int qty;
    /* 0012 */ int foodwater;
    /* 0016 */
};

// forceTitle
// 68 bytes
// 2 fields
struct forceTitle {
    /* 0000 */ char target[64];
    /* 0064 */ int cmd;
    /* 0068 */
};

// fwaterMsg
// 6 bytes
// 3 fields
struct fwaterMsg {
    /* 0000 */ short hunger;
    /* 0002 */ short thirst;
    /* 0004 */ short fatigue;
    /* 0006 */
};

// getStats
// 268 bytes
// 4 fields
struct getStats {
    /* 0000 */ char name[64];
    /* 0064 */ short level;
    /* 0066 */ short cclass;
    /* 0068 */ short skill[100];
    /* 0268 */
};

// gmQuest
// 28 bytes
// 7 fields
struct gmQuest {
    /* 0000 */ unsigned short target;
    /* 0004 */ int experience;
    /* 0008 */ int item;
    /* 0012 */ int plat;
    /* 0016 */ int gold;
    /* 0020 */ int silv;
    /* 0024 */ int copp;
    /* 0028 */
};

// guild_dat
// 96 bytes
// 9 fields
struct guild_dat {
    /* 0000 */ int faction_num;
    /* 0004 */ char name[64];
    /* 0068 */ int warguild;
    /* 0072 */ int active;
    /* 0076 */ unsigned long endWardate;
    /* 0080 */ int warRequest;
    /* 0084 */ int extdat1;
    /* 0088 */ int extdat2;
    /* 0092 */ int guildId;
    /* 0096 */
};

// guildAdded
// 100 bytes
// 2 fields
struct guildAdded {
    /* 0000 */ int guild_index;
    /* 0004 */ guild_dat guild_entry;
    /* 0100 */
};

// guildCRCmsg
// 49156 bytes
// 2 fields
struct guildCRCmsg {
    /* 0000 */ int crc32;
    /* 0004 */ guild_dat gData[512];
    /* 49156 */
};

// guildExists
// 8 bytes
// 2 fields
struct guildExists {
    /* 0000 */ int guild;
    /* 0004 */ int exists;
    /* 0008 */
};

// guildInfo
// 68 bytes
// 2 fields
struct guildInfo {
    /* 0000 */ int num;
    /* 0004 */ guild_dat name;
    /* 0068 */
};

// guildInvite
// 136 bytes
// 4 fields
struct guildInvite {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short guild;
    /* 0132 */ int level;
    /* 0136 */
};

// guildList
// 34820 bytes
// 1 fields
struct guildList {
    /* 0000 */ int numrecs;
    /* 34820 */
};

// guildmotdSet
// 580 bytes
// 3 fields
struct guildmotdSet {
    /* 0000 */ char name[64];
    /* 0064 */ int guild;
    /* 0068 */ char message[512];
    /* 0580 */
};

// guildNameEntry
// 36 bytes
// 2 fields
struct guildNameEntry {
    /* 0000 */ char name[32];
    /* 0032 */ int status;
    /* 0036 */
};

// guildPeace
// 140 bytes
// 5 fields
struct guildPeace {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ int warWith;
    /* 0132 */ int days;
    /* 0136 */ int status;
    /* 0140 */
};

// guildRemove
// 136 bytes
// 4 fields
struct guildRemove {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short guild;
    /* 0132 */ int level;
    /* 0136 */
};

// guildRename
// 128 bytes
// 2 fields
struct guildRename {
    /* 0000 */ char newGuildName[64];
    /* 0064 */ char oldGuildName[64];
    /* 0128 */
};

// guildReply
// 136 bytes
// 4 fields
struct guildReply {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ int status;
    /* 0132 */ short guild;
    /* 0136 */
};

// guildStatus
// 136 bytes
// 4 fields
struct guildStatus {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short guild;
    /* 0132 */ int level;
    /* 0136 */
};

// guildWar
// 140 bytes
// 1 fields
struct guildWar {
    /* 0000 */ guildPeace Parent_Class[140];
    /* 0140 */
};

// hitptMsg
// 12 bytes
// 3 fields
struct hitptMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int hp;
    /* 0008 */ int max_hp;
    /* 0012 */
};

// hpChgMsg
// 8 bytes
// 2 fields
struct hpChgMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int cur_hp;
    /* 0008 */
};

// inspect
// 1744 bytes
// 6 fields
struct inspect {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ char name[1408];
    /* 1412 */ short image[22];
    /* 1456 */ char text[256];
    /* 1712 */ char title[32];
    /* 1744 */
};

// InspectItem
// 66 bytes
// 2 fields
struct InspectItem {
    /* 0000 */ short item_id;
    /* 0002 */ char item_name[64];
    /* 0066 */
};

// invite
// 193 bytes
// 4 fields
struct invite {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */ char party[64];
    /* 0192 */ unsigned char pkill;
    /* 0193 */
};

// item_find_message
// 84 bytes
// 2 fields
struct item_find_message {
    /* 0000 */ int itemNumber;
    /* 0004 */ char partialName[80];
    /* 0084 */
};

// joinStatus
// 129 bytes
// 3 fields
struct joinStatus {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */ unsigned char answer;
    /* 0129 */
};

// keynumMsg
// 12 bytes
// 3 fields
struct keynumMsg {
    /* 0000 */ int keynum;
    /* 0004 */ short recnum;
    /* 0008 */ int rent;
    /* 0012 */
};

// KunarkApprovedMsg
// 4 bytes
// 1 fields
struct KunarkApprovedMsg {
    /* 0000 */ int status;
    /* 0004 */
};

// kunarkMsg
// 68 bytes
// 2 fields
struct kunarkMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int status;
    /* 0068 */
};

// launchSpellInfo
// 12 bytes
// 3 fields
struct launchSpellInfo {
    /* 0000 */ int slot;
    /* 0004 */ int spell;
    /* 0008 */ int type;
    /* 0012 */
};

// leave_guildmaster
// 4 bytes
// 2 fields
struct leave_guildmaster {
    /* 0000 */ unsigned short guildmaster;
    /* 0002 */ unsigned short me;
    /* 0004 */
};

// leave_merchant
// 4 bytes
// 2 fields
struct leave_merchant {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */
};

// levelUpMsg
// 12 bytes
// 3 fields
struct levelUpMsg {
    /* 0000 */ int level;
    /* 0004 */ int highestlevel;
    /* 0008 */ int experience;
    /* 0012 */
};

// LFGMsg
// 68 bytes
// 2 fields
struct LFGMsg {
    /* 0000 */ unsigned char name[64];
    /* 0064 */ int status;
    /* 0068 */
};

// LFGMsg2
// 8 bytes
// 2 fields
struct LFGMsg2 {
    /* 0000 */ unsigned short id;
    /* 0004 */ int status;
    /* 0008 */
};

// lockmsg
// 2 bytes
// 1 fields
struct lockmsg {
    /* 0000 */ unsigned short id;
    /* 0002 */
};

// loginKey
// 386 bytes
// 5 fields
struct loginKey {
    /* 0000 */ char name[64];
    /* 0064 */ char pword[32];
    /* 0096 */ char keycode[32];
    /* 0128 */ char hostname[256];
    /* 0384 */ short port;
    /* 0386 */
};

// LoginMsg
// 200 bytes
// 5 fields
struct LoginMsg {
    /* 0000 */ char unistring[186];
    /* 0186 */ short port;
    /* 0188 */ unsigned char zone_server;
    /* 0192 */ int lreason;
    /* 0196 */ short version;
    /* 0200 */
};

// logshoweq
// 4 bytes
// 1 fields
struct logshoweq {
    /* 0000 */ int value;
    /* 0004 */
};

// loot_msg
// 12 bytes
// 4 fields
struct loot_msg {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short me;
    /* 0004 */ short slot;
    /* 0008 */ int autoInven;
    /* 0012 */
};

// makeNewLeaderMsg
// 68 bytes
// 2 fields
struct makeNewLeaderMsg {
    /* 0000 */ int guild_faction;
    /* 0004 */ char new_leader[64];
    /* 0068 */
};

// ManaMsg
// 4 bytes
// 2 fields
struct ManaMsg {
    /* 0000 */ unsigned short player_id;
    /* 0002 */ short my_mana;
    /* 0004 */
};

// materialChange
// 12 bytes
// 4 fields
struct materialChange {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char location;
    /* 0004 */ unsigned short type;
    /* 0008 */ unsigned long tint;
    /* 0012 */
};

// meditateMsg
// 4 bytes
// 1 fields
struct meditateMsg {
    /* 0000 */ int meditating;
    /* 0004 */
};

// memSpellBook
// 524 bytes
// 4 fields
struct memSpellBook {
    /* 0000 */ int slot;
    /* 0004 */ int spell;
    /* 0008 */ int type;
    /* 0012 */ short tempspellbook[256];
    /* 0524 */
};

// modInven
// 1156 bytes
// 4 fields
struct modInven {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short index;
    /* 0130 */ unsigned char type;
    /* 1156 */
};

// modMoney
// 136 bytes
// 4 fields
struct modMoney {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ unsigned char type;
    /* 0132 */ long amount;
    /* 0136 */
};

// modRt
// 40 bytes
// 11 fields
struct modRt {
    /* 0000 */ short route;
    /* 0002 */ char terrain;
    /* 0004 */ BOOL outdoor;
    /* 0008 */ BOOL open;
    /* 0012 */ char height;
    /* 0016 */ long minx;
    /* 0020 */ long miny;
    /* 0024 */ long minz;
    /* 0028 */ long maxx;
    /* 0032 */ long maxy;
    /* 0036 */ long maxz;
    /* 0040 */
};

// ModulationMsg
// 4 bytes
// 1 fields
struct ModulationMsg {
    /* 0000 */ unsigned int fTimeLeft;
    /* 0004 */
};

// money_MacMsg
// 56 bytes
// 5 fields
struct money_MacMsg {
    /* 0000 */ char name[40];
    /* 0040 */ long platinum;
    /* 0044 */ long gold;
    /* 0048 */ long silver;
    /* 0052 */ long copper;
    /* 0056 */
};

// motdSet
// 576 bytes
// 2 fields
struct motdSet {
    /* 0000 */ char name[64];
    /* 0064 */ char message[512];
    /* 0576 */
};

// moveItem
// 12 bytes
// 3 fields
struct moveItem {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int qty;
    /* 0012 */
};

// moveMoney
// 20 bytes
// 5 fields
struct moveMoney {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int typeFrom;
    /* 0012 */ int typeTo;
    /* 0016 */ int amt;
    /* 0020 */
};

// msg_delIlist
// 8 bytes
// 2 fields
struct msg_delIlist {
    /* 0000 */ unsigned long sernbr;
    /* 0004 */ unsigned short id;
    /* 0008 */
};

// msg_ppoint
// 44 bytes
// 4 fields
struct msg_ppoint {
    /* 0000 */ char name[32];
    /* 0032 */ float x;
    /* 0036 */ float y;
    /* 0040 */ float z;
    /* 0044 */
};

// msg_who_req
// 140 bytes
// 8 fields
struct msg_who_req {
    /* 0000 */ char name[64];
    /* 0064 */ short race;
    /* 0066 */ short cclass;
    /* 0068 */ short lolvl;
    /* 0070 */ short hilvl;
    /* 0072 */ short gm;
    /* 0074 */ short guild;
    /* 0076 */ char req_name[64];
    /* 0140 */
};

// msgAddPlayer
// 356 bytes
// 2 fields
struct msgAddPlayer {
    /* 0000 */ int crc32;
    /* 0004 */ EQPlayer playerdata;
    /* 0356 */
};

// msgChangePCAffect
// 20 bytes
// 4 fields
struct msgChangePCAffect {
    /* 0000 */ unsigned short id;
    /* 0002 */ EQ_Affect affect;
    /* 0012 */ int slot;
    /* 0016 */ int change_type;
    /* 0020 */
};

// msgCompData
// 131074 bytes
// 2 fields
struct msgCompData {
    /* 0000 */ short num_items;
    /* 0002 */ char compData[131072];
    /* 131074 */
};

// msgCorpseXYZ
// 16 bytes
// 4 fields
struct msgCorpseXYZ {
    /* 0000 */ unsigned short id;
    /* 0004 */ float x;
    /* 0008 */ float y;
    /* 0012 */ float z;
    /* 0016 */
};

// msgDoAttack
// 12 bytes
// 3 fields
struct msgDoAttack {
    /* 0000 */ unsigned short id;
    /* 0004 */ int slot;
    /* 0008 */ int skill;
    /* 0012 */
};

// msgNpcReaction
// 24 bytes
// 7 fields
struct msgNpcReaction {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned short npcid;
    /* 0004 */ int reaction;
    /* 0008 */ int level;
    /* 0012 */ int cur_hp;
    /* 0016 */ int max_hp;
    /* 0020 */ int server_type;
    /* 0024 */
};

// MsgPetInfo
// 6 bytes
// 3 fields
struct MsgPetInfo {
    /* 0000 */ unsigned short Owner_ID;
    /* 0002 */ unsigned short Pet_ID;
    /* 0004 */ unsigned char flag;
    /* 0006 */
};

// msgGetSafeCoords
// 88 bytes
// 7 fields
struct msgGetSafeCoords {
    /* 0000 */ char name[64];
    /* 0064 */ EQZoneIndex zoneid;
    /* 0068 */ float x;
    /* 0072 */ float y;
    /* 0076 */ float z;
    /* 0080 */ float hdg;
    /* 0084 */ ZONE_REQ_STATUS status;
    /* 0088 */
};

// msgGiveitem
// 2180 bytes
// 3 fields
struct msgGiveitem {
    /* 0000 */ char source[64];
    /* 0064 */ char tgt[64];
    /* 0128 */ int type;
    /* 2180 */
};

// msgLimboMoney
// 16 bytes
// 4 fields
struct msgLimboMoney {
    /* 0000 */ long plat;
    /* 0004 */ long gold;
    /* 0008 */ long silver;
    /* 0012 */ long copper;
    /* 0016 */
};

// msgQueryExp
// 64 bytes
// 1 fields
struct msgQueryExp {
    /* 0000 */ char name[64];
    /* 0064 */
};

// msgSkillImprove
// 8 bytes
// 2 fields
struct msgSkillImprove {
    /* 0000 */ int skillnum;
    /* 0004 */ int skillvalue;
    /* 0008 */
};

// msgTeleportPC
// 24 bytes
// 6 fields
struct msgTeleportPC {
    /* 0000 */ EQZoneIndex zoneid;
    /* 0004 */ float x;
    /* 0008 */ float y;
    /* 0012 */ float z;
    /* 0016 */ float hdg;
    /* 0020 */ ZONE_REQ_REASON reason;
    /* 0024 */
};

// msgTraceLogin
// 96 bytes
// 2 fields
struct msgTraceLogin {
    /* 0000 */ char stationNum[32];
    /* 0032 */ char characterName[64];
    /* 0096 */
};

// newSurname
// 100 bytes
// 3 fields
struct newSurname {
    /* 0000 */ char name[64];
    /* 0064 */ int status;
    /* 0068 */ char lastName[32];
    /* 0100 */
};

// newtext
// 2184 bytes
// 6 fields
struct newtext {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short lang;
    /* 0130 */ short type;
    /* 0132 */ unsigned char locale;
    /* 0134 */ short speakingskill;
    /* 2184 */
};

// netphysicsinfo
// 13 bytes
// 7 fields
struct netphysicsinfo {
    /* 0000 */ char accel;
    /* 0001 */ unsigned char h;
    /* 0002 */ char rate_h;
    /* 0003 */ short x;
    /* 0005 */ short y;
    /* 0007 */ short z;
    /* 0009 */ unsigned long velocities;
    /* 0013 */
};

// NoNameApprovalMsg
// 68 bytes
// 2 fields
struct NoNameApprovalMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int status;
    /* 0068 */
};

// npcCheckItems
// 1204 bytes
// 7 fields
struct npcCheckItems {
    /* 0000 */ unsigned short id;
    /* 0004 */ int plat;
    /* 0008 */ int gold;
    /* 0012 */ int silver;
    /* 0016 */ int copper;
    /* 0020 */ short item_refnums[32];
    /* 0084 */ char item_names[1120];
    /* 1204 */
};

// npcCheckItemsZone
// 260 bytes
// 2 fields
struct npcCheckItemsZone {
    /* 0000 */ int cmd;
    /* 0004 */ char szFilter[256];
    /* 0260 */
};

// NPCMoney
// 20 bytes
// 6 fields
struct NPCMoney {
    /* 0000 */ unsigned short sendId;
    /* 0002 */ unsigned short targetId;
    /* 0004 */ long platinum;
    /* 0008 */ long gold;
    /* 0012 */ long silver;
    /* 0016 */ long copper;
    /* 0020 */
};

// OverrideTimerMessage
// 4 bytes
// 1 fields
struct OverrideTimerMessage {
    /* 0000 */ int override_timer;
    /* 0004 */
};

// old_guild_dat
// 144 bytes
// 11 fields
struct old_guild_dat {
    /* 0000 */ int faction_num;
    /* 0004 */ char name[64];
    /* 0068 */ char leader[32];
    /* 0100 */ int numinzone;
    /* 0104 */ int warguild;
    /* 0108 */ int active;
    /* 0112 */ unsigned long endWardate;
    /* 0116 */ int warRequest;
    /* 0120 */ int extdat1;
    /* 0124 */ int extdat2;
    /* 0128 */ char extstr[16];
    /* 0144 */
};

// pcGuildMsg
// 72 bytes
// 3 fields
struct pcGuildMsg {
    /* 0000 */ int guild;
    /* 0004 */ int status;
    /* 0008 */ char name[64];
    /* 0072 */
};

// PCSaveMsg
// 8460 bytes
// 3 fields
struct PCSaveMsg {
    /* 0000 */ int crc32;
    /* 0004 */ EQ_PC pcdata;
    /* 8456 */ unsigned char SaveIndex;
    /* 8460 */
};

// permaKillMsg
// 8 bytes
// 2 fields
struct permaKillMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int delfile;
    /* 0008 */
};

// pet_command_message
// 8 bytes
// 2 fields
struct pet_command_message {
    /* 0000 */ PetCommandType command;
    /* 0004 */ unsigned short targetId;
    /* 0008 */
};

// petitionQstatus
// 184 bytes
// 9 fields
struct petitionQstatus {
    /* 0000 */ int id_num;
    /* 0004 */ int urgency;
    /* 0008 */ int cur_state;
    /* 0012 */ unsigned long time_in;
    /* 0016 */ char user_handle[32];
    /* 0048 */ char dest_pc[64];
    /* 0112 */ int num_active;
    /* 0116 */ char pet_pc[64];
    /* 0180 */ unsigned long last_checkin_time;
    /* 0184 */
};

// petitionQtype
// 2220 bytes
// 15 fields
struct petitionQtype {
    /* 0000 */ int id_num;
    /* 0004 */ int urgency;
    /* 0008 */ char user_handle[32];
    /* 0040 */ char guide_handle[32];
    /* 0072 */ int zoneid;
    /* 0076 */ char char_name[64];
    /* 0140 */ int level;
    /* 0144 */ int cclass;
    /* 0148 */ int race;
    /* 0152 */ int cur_state;
    /* 0156 */ int num_checkouts;
    /* 0160 */ int unavailable;
    /* 0164 */ unsigned long time_in;
    /* 0168 */ unsigned long last_checkin_time;
    /* 0172 */ char user_text[1024];
    /* 2220 */
};

// physicsinfo
// 48 bytes
// 12 fields
struct physicsinfo {
    /* 0000 */ float x;
    /* 0004 */ float y;
    /* 0008 */ float z;
    /* 0012 */ float h;
    /* 0016 */ float p;
    /* 0020 */ float accel;
    /* 0024 */ float vx;
    /* 0028 */ float vy;
    /* 0032 */ float vz;
    /* 0036 */ float rate_h;
    /* 0040 */ float rate_p;
    /* 0044 */ float view_pitch;
    /* 0048 */
};

// PINFO
// 1620 bytes
// 18 fields
struct PINFO {
    /* 0000 */ char name[640];
    /* 0640 */ unsigned char level[10];
    /* 0650 */ unsigned char cclass[10];
    /* 0660 */ unsigned short race[10];
    /* 0680 */ int cur_zone_id[10];
    /* 0720 */ unsigned char sex[10];
    /* 0730 */ unsigned char face[10];
    /* 0740 */ int type[90];
    /* 1100 */ unsigned long tint[90];
    /* 1460 */ short deity[10];
    /* 1480 */ int primActor[10];
    /* 1520 */ int secdActor[10];
    /* 1560 */ unsigned char HairColor[10];
    /* 1570 */ unsigned char BeardColor[10];
    /* 1580 */ unsigned char LeftEye[10];
    /* 1590 */ unsigned char RightEye[10];
    /* 1600 */ unsigned char Hair[10];
    /* 1610 */ unsigned char Beard[10];
    /* 1620 */
};

// prohibExe
// 4098 bytes
// 1 fields
struct prohibExe {
    /* 0000 */ short num;
    /* 4098 */
};

// publicKeyMsg
// 544 bytes
// 1 fields
struct publicKeyMsg {
    /* 0000 */ vlMsg vl[2];
    /* 0544 */
};

// _readyTrade
// 4 bytes
// 2 fields
struct _readyTrade {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char flag;
    /* 0004 */
};

// randomMsg
// 8 bytes
// 2 fields
struct randomMsg {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */
};

// ranReturnMsg
// 76 bytes
// 4 fields
struct ranReturnMsg {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int result;
    /* 0012 */ char name[64];
    /* 0076 */
};

// refuseTrade
// 6 bytes
// 3 fields
struct refuseTrade {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ unsigned char reason;
    /* 0006 */
};

// reportText
// 5248 bytes
// 3 fields
struct reportText {
    /* 0000 */ char name[64];
    /* 0064 */ char buffer[5120];
    /* 5184 */ char offender[64];
    /* 5248 */
};

// req_bzr_merchant
// 16 bytes
// 4 fields
struct req_bzr_merchant {
    /* 0000 */ unsigned short bzr_merc_id;
    /* 0004 */ int item_id;
    /* 0008 */ float bzr_greed;
    /* 0012 */ unsigned char ok;
    /* 0016 */
};

// req_merchant
// 12 bytes
// 4 fields
struct req_merchant {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */ unsigned char ok;
    /* 0008 */ float greed;
    /* 0012 */
};

// req_guildmaster
// 244 bytes
// 6 fields
struct req_guildmaster {
    /* 0000 */ unsigned short guildmaster;
    /* 0002 */ unsigned short me;
    /* 0004 */ short skill[100];
    /* 0204 */ float greed;
    /* 0208 */ unsigned char ok;
    /* 0209 */ unsigned char lang[32];
    /* 0244 */
};

// reqGuildChestLock
// 6 bytes
// 3 fields
struct reqGuildChestLock {
    /* 0000 */ unsigned short id;
    /* 0002 */ short key;
    /* 0004 */ short data;
    /* 0006 */
};

// reqGuildName
// 4 bytes
// 1 fields
struct reqGuildName {
    /* 0000 */ int guild_faction;
    /* 0004 */
};

// reqInsp
// 4 bytes
// 2 fields
struct reqInsp {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// reqLootermsg
// 192 bytes
// 3 fields
struct reqLootermsg {
    /* 0000 */ unsigned char requestor[64];
    /* 0064 */ unsigned char corpse[64];
    /* 0128 */ unsigned char looter[64];
    /* 0192 */
};

// reqplayed
// 136 bytes
// 4 fields
struct reqplayed {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ unsigned int created;
    /* 0132 */ unsigned long minutes_played;
    /* 0136 */
};

// requestHdr
// 4 bytes
// 2 fields
struct requestHdr {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned char type;
    /* 0004 */
};

// requestMsg
// 6 bytes
// 3 fields
struct requestMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned short id;
    /* 0004 */ unsigned char type;
    /* 0006 */
};

// rescue
// 2 bytes
// 1 fields
struct rescue {
    /* 0000 */ unsigned short target;
    /* 0002 */
};

// resurrectMsg
// 228 bytes
// 12 fields
struct resurrectMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int zoneid;
    /* 0008 */ float x;
    /* 0012 */ float y;
    /* 0016 */ float z;
    /* 0020 */ int percentback;
    /* 0024 */ char name[64];
    /* 0088 */ unsigned long explost;
    /* 0092 */ char caster[64];
    /* 0156 */ short spellnum;
    /* 0158 */ char corpsename[64];
    /* 0224 */ int consent;
    /* 0228 */
};

// retHouseItem
// 28 bytes
// 7 fields
struct retHouseItem {
    /* 0000 */ unsigned short id;
    /* 0004 */ long sernbr;
    /* 0008 */ EQ_Affect affect;
    /* 0018 */ short recnum;
    /* 0020 */ short slot;
    /* 0022 */ short type;
    /* 0024 */ long value;
    /* 0028 */
};

// retHouseMoney
// 16 bytes
// 4 fields
struct retHouseMoney {
    /* 0000 */ unsigned short id;
    /* 0004 */ long sernbr;
    /* 0008 */ int type;
    /* 0012 */ int qty;
    /* 0016 */
};

// reward_MacMsg
// 48 bytes
// 10 fields
struct reward_MacMsg {
    /* 0000 */ unsigned short sendId;
    /* 0002 */ unsigned short targetId;
    /* 0004 */ int exp_reward;
    /* 0008 */ int faction;
    /* 0012 */ int faction_mod;
    /* 0016 */ int copper;
    /* 0020 */ int silver;
    /* 0024 */ int gold;
    /* 0028 */ int platinum;
    /* 0032 */ short items[8];
    /* 0048 */
};

// rpServer
// 244 bytes
// 13 fields
struct rpServer {
    /* 0000 */ int rp_active;
    /* 0004 */ int pk_active;
    /* 0008 */ int AutoIdentify;
    /* 0012 */ int NameGen;
    /* 0016 */ int Gibberish;
    /* 0020 */ int test_server;
    /* 0024 */ int Locale;
    /* 0028 */ int ProfanityFilter;
    /* 0032 */ char ServerName[64];
    /* 0096 */ char loggingServerPassword[16];
    /* 0112 */ char loggingServerAddress[64];
    /* 0176 */ int loggingServerPort;
    /* 0180 */ char localizedEmailAddress[64];
    /* 0244 */
};

// sacrificeMsg
// 12 bytes
// 3 fields
struct sacrificeMsg {
    /* 0000 */ int necroID;
    /* 0004 */ int playerID;
    /* 0008 */ int response;
    /* 0012 */
};

// searchCorpse
// 132 bytes
// 3 fields
struct searchCorpse {
    /* 0000 */ char name[64];
    /* 0064 */ char corpsename[64];
    /* 0128 */ int zoneid;
    /* 0132 */
};

// sell_msg
// 16 bytes
// 5 fields
struct sell_msg {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */ short slot;
    /* 0008 */ int quantity;
    /* 0012 */ long value;
    /* 0016 */
};

// send_eq
// 2052 bytes
// 2 fields
struct send_eq {
    /* 0000 */ unsigned short me;
    /* 0002 */ char type;
    /* 2052 */
};

// send_eq2
// 2060 bytes
// 4 fields
struct send_eq2 {
    /* 0000 */ unsigned long ask_price;
    /* 0004 */ int location;
    /* 0008 */ unsigned short me;
    /* 0010 */ char type;
    /* 2060 */
};

// sendHdr
// 116 bytes
// 5 fields
struct sendHdr {
    /* 0000 */ unsigned short id;
    /* 0002 */ char time[16];
    /* 0018 */ char author[64];
    /* 0082 */ short language;
    /* 0084 */ char subject[32];
    /* 0116 */
};

// SendInspectItem
// 360 bytes
// 1 fields
struct SendInspectItem {
    /* 0000 */ char data[360];
    /* 0360 */
};

// setDatRateMsg
// 4 bytes
// 1 fields
struct setDatRateMsg {
    /* 0000 */ float datarate;
    /* 0004 */
};

// setFaction
// 72 bytes
// 3 fields
struct setFaction {
    /* 0000 */ char name[64];
    /* 0064 */ int factionnum;
    /* 0068 */ int fact_value;
    /* 0072 */
};

// shieldMsg
// 2 bytes
// 1 fields
struct shieldMsg {
    /* 0000 */ unsigned short target;
    /* 0002 */
};

// sisaLogMsg
// 68 bytes
// 2 fields
struct sisaLogMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int logActive;
    /* 0068 */
};

// SkillTmrMsg
// 8 bytes
// 2 fields
struct SkillTmrMsg {
    /* 0000 */ short theSkill;
    /* 0004 */ unsigned long theTimer;
    /* 0008 */
};

// sMark
// 456 bytes
// 7 fields
struct sMark {
    /* 0000 */ char Name[64];
    /* 0064 */ char stationNum[32];
    /* 0096 */ char gmName[64];
    /* 0160 */ char gmstationNum[32];
    /* 0192 */ unsigned long timeStamp;
    /* 0196 */ int category;
    /* 0200 */ char text[256];
    /* 0456 */
};

// snooptext
// 2242 bytes
// 4 fields
struct snooptext {
    /* 0000 */ char snooper[64];
    /* 0064 */ char target[64];
    /* 0128 */ char source[64];
    /* 0192 */ short type;
    /* 2242 */
};

// sp_chksum
// 2056 bytes
// 4 fields
struct sp_chksum {
    /* 0000 */ int cksum;
    /* 0004 */ unsigned long size;
    /* 0008 */ unsigned long wordnum[256];
    /* 1032 */ unsigned long wordval[256];
    /* 2056 */
};

// SpellActivateParticles
// 4 bytes
// 2 fields
struct SpellActivateParticles {
    /* 0000 */ short iID;
    /* 0002 */ short iSpellNumber;
    /* 0004 */
};

// spellText
// 514 bytes
// 1 fields
struct spellText {
    /* 0000 */ unsigned short source;
    /* 0514 */
};

// argumentText
// 44 bytes
// 2 fields
struct argumentText {
    /* 0000 */ unsigned short source;
    /* 0004 */ int token;
    /* 0044 */
};

// SpellWornOffMessage
// 4 bytes
// 2 fields
struct SpellWornOffMessage {
    /* 0000 */ short iID;
    /* 0002 */ short iSpellNumber;
    /* 0004 */
};

// soulMarkAddMsg
// 456 bytes
// 1 fields
struct soulMarkAddMsg {
    /* 0000 */ sMark soulMark;
    /* 0456 */
};

// soulMarkMsg
// 5536 bytes
// 2 fields
struct soulMarkMsg {
    /* 0000 */ char name[64];
    /* 0064 */ sMark soulMarks[12];
    /* 5536 */
};

// soulMarkReqMsg
// 192 bytes
// 4 fields
struct soulMarkReqMsg {
    /* 0000 */ char gmName[64];
    /* 0064 */ char gmstationNum[32];
    /* 0096 */ char name[64];
    /* 0160 */ char stationNum[32];
    /* 0192 */
};

// soundMsg
// 4 bytes
// 2 fields
struct soundMsg {
    /* 0000 */ unsigned short id;
    /* 0002 */ short soundnum;
    /* 0004 */
};

// start_casting
// 8 bytes
// 3 fields
struct start_casting {
    /* 0000 */ unsigned short caster_id;
    /* 0002 */ short spell_nbr;
    /* 0004 */ unsigned int casting_time;
    /* 0008 */
};

// startRt
// 16 bytes
// 4 fields
struct startRt {
    /* 0000 */ char terrain;
    /* 0004 */ BOOL outdoor;
    /* 0008 */ BOOL open;
    /* 0012 */ char height;
    /* 0016 */
};

// statChange
// 8 bytes
// 3 fields
struct statChange {
    /* 0000 */ unsigned short id;
    /* 0002 */ short field;
    /* 0004 */ long value;
    /* 0008 */
};

// statUpdate
// 15 bytes
// 2 fields
struct statUpdate {
    /* 0000 */ unsigned short id;
    /* 0002 */ netphysicsinfo physics;
    /* 0015 */
};

// stealMsg
// 2060 bytes
// 6 fields
struct stealMsg {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ short skill;
    /* 0006 */ char status;
    /* 0008 */ long money;
    /* 0012 */ char data[2048];
    /* 2060 */
};

// stell
// 388 bytes
// 5 fields
struct stell {
    /* 0000 */ char whom[64];
    /* 0064 */ char tline[256];
    /* 0320 */ char speaker[64];
    /* 0384 */ short language;
    /* 0386 */ short speakingskill;
    /* 0388 */
};

// stopcastingmsg
// 4 bytes
// 2 fields
struct stopcastingmsg {
    /* 0000 */ short cur_mana;
    /* 0002 */ short spell_nbr;
    /* 0004 */
};

// submit
// 76 bytes
// 4 fields
struct submit {
    /* 0000 */ char name[64];
    /* 0064 */ int race;
    /* 0068 */ int cclass;
    /* 0072 */ int deity;
    /* 0076 */
};

// swapSpell
// 8 bytes
// 2 fields
struct swapSpell {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */
};

// switchName
// 32 bytes
// 2 fields
struct switchName {
    /* 0000 */ char name[30];
    /* 0030 */ unsigned short id;
    /* 0032 */
};

// switchSpell
// 8 bytes
// 2 fields
struct switchSpell {
    /* 0000 */ int switch_id;
    /* 0004 */ int spellnum;
    /* 0008 */
};

// TargetGroupBuffMsg
// 4 bytes
// 1 fields
struct TargetGroupBuffMsg {
    /* 0000 */ int iValue;
    /* 0004 */
};

// targetMsg
// 2 bytes
// 1 fields
struct targetMsg {
    /* 0000 */ unsigned short target;
    /* 0002 */
};

// tellToggle
// 68 bytes
// 2 fields
struct tellToggle {
    /* 0000 */ char name[64];
    /* 0064 */ int on;
    /* 0068 */
};

// tgtIDmsg
// 2 bytes
// 1 fields
struct tgtIDmsg {
    /* 0000 */ unsigned short id;
    /* 0002 */
};

// tp_coords
// 24 bytes
// 6 fields
struct tp_coords {
    /* 0000 */ short index;
    /* 0004 */ float x;
    /* 0008 */ float y;
    /* 0012 */ float z;
    /* 0016 */ float hdg;
    /* 0020 */ int zoneid;
    /* 0024 */
};

// tp_msg
// 3076 bytes
// 2 fields
struct tp_msg {
    /* 0000 */ short num_coords;
    /* 0004 */ tp_coords tp[128];
    /* 3076 */
};

// toggleState
// 4 bytes
// 1 fields
struct toggleState {
    /* 0000 */ int state;
    /* 0004 */
};

// tokenStringMsg
// 6 bytes
// 3 fields
struct tokenStringMsg {
    /* 0000 */ short string_token;
    /* 0002 */ short string_color;
    /* 0004 */ short fromWorld;
    /* 0006 */
};

// tradeitem
// 2054 bytes
// 3 fields
struct tradeitem {
    /* 0000 */ unsigned short id;
    /* 0002 */ short slot;
    /* 0004 */ unsigned char type;
    /* 2054 */
};

// trademoney
// 8 bytes
// 3 fields
struct trademoney {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char type;
    /* 0004 */ long amt;
    /* 0008 */
};

// trainMsg
// 12 bytes
// 3 fields
struct trainMsg {
    /* 0000 */ unsigned short gMasterId;
    /* 0004 */ int language;
    /* 0008 */ int skill;
    /* 0012 */
};

// translocateMsg
// 92 bytes
// 8 fields
struct translocateMsg {
    /* 0000 */ EQZoneIndex zoneid;
    /* 0004 */ int trans_spell;
    /* 0008 */ int response;
    /* 0012 */ char caster[64];
    /* 0076 */ float dest_x;
    /* 0080 */ float dest_y;
    /* 0084 */ float dest_z;
    /* 0088 */ int is_ok;
    /* 0092 */
};

// trapLocation
// 12 bytes
// 3 fields
struct trapLocation {
    /* 0000 */ float x;
    /* 0004 */ float y;
    /* 0008 */ float z;
    /* 0012 */
};

// tuneMsg
// 132 bytes
// 4 fields
struct tuneMsg {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char bPersist;
    /* 0003 */ char szParam[64];
    /* 0067 */ char szArg[64];
    /* 0132 */
};

// updateFilters
// 68 bytes
// 17 fields
struct updateFilters {
    /* 0000 */ int dmgshields;
    /* 0004 */ int npcspells;
    /* 0008 */ int pcspells;
    /* 0012 */ int bardsongs;
    /* 0016 */ int server_filter;
    /* 0020 */ int guild_chat;
    /* 0024 */ int socials;
    /* 0028 */ int group_chat;
    /* 0032 */ int shouts;
    /* 0036 */ int auctions;
    /* 0040 */ int oocs;
    /* 0044 */ int my_misses;
    /* 0048 */ int other_miss;
    /* 0052 */ int other_hit;
    /* 0056 */ int atk_miss_me;
    /* 0060 */ int criticalspells;
    /* 0064 */ int criticalmelee;
    /* 0068 */
};

// updateFaceMsg
// 7 bytes
// 7 fields
struct updateFaceMsg {
    /* 0000 */ unsigned char HairColor;
    /* 0001 */ unsigned char BeardColor;
    /* 0002 */ unsigned char LeftEye;
    /* 0003 */ unsigned char RightEye;
    /* 0004 */ unsigned char Hair;
    /* 0005 */ unsigned char Beard;
    /* 0006 */ unsigned char face;
    /* 0007 */
};

// vehicle_xfr
// 68 bytes
// 2 fields
struct vehicle_xfr {
    /* 0000 */ char vehicle[64];
    /* 0064 */ EQZoneIndex zoneid;
    /* 0068 */
};

// VersionWord
// 2 bytes
// 2 fields
struct VersionWord {
    /* 0000 */ BYTE minor;
    /* 0001 */ BYTE major;
    /* 0002 */
};

// vlMsg
// 272 bytes
// 5 fields
struct vlMsg {
    /* 0000 */ int negative;
    /* 0004 */ int share;
    /* 0008 */ int array[64];
    /* 0264 */ int z;
    /* 0268 */ int n;
    /* 0272 */
};

// weatherChgMsg
// 16 bytes
// 4 fields
struct weatherChgMsg {
    /* 0000 */ int rain;
    /* 0004 */ int snow;
    /* 0008 */ int severity;
    /* 0012 */ int duration;
    /* 0016 */
};

// weatherMsg
// 8 bytes
// 2 fields
struct weatherMsg {
    /* 0000 */ int type;
    /* 0004 */ int severity;
    /* 0008 */
};

// wherePlayer
// 152 bytes
// 8 fields
struct wherePlayer {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ unsigned char found;
    /* 0132 */ int zoneid;
    /* 0136 */ long x;
    /* 0140 */ long y;
    /* 0144 */ long z;
    /* 0148 */ long data;
    /* 0152 */
};

// who_response
// 2108 bytes
// 9 fields
struct who_response {
    /* 0000 */ DWORD playerSerialNumber;
    /* 0004 */ unsigned short beginTextToken;
    /* 0006 */ char separator[30];
    /* 0036 */ unsigned short endTextToken;
    /* 0040 */ int filteredCount;
    /* 0044 */ int noActiveCharCount;
    /* 0048 */ int count;
    /* 0052 */ int totalPlayers;
    /* 0056 */ short totalLines;
    /* 2108 */
};

// wldgroupMsg
// 136 bytes
// 4 fields
struct wldgroupMsg {
    /* 0000 */ int cmd;
    /* 0004 */ char name[64];
    /* 0068 */ char member[64];
    /* 0132 */ unsigned long strToken;
    /* 0136 */
};

// WorldRemoveGuild
// 148 bytes
// 7 fields
struct WorldRemoveGuild {
    /* 0000 */ char source[64];
    /* 0064 */ char target[64];
    /* 0128 */ int szoneid;
    /* 0132 */ int tzoneid;
    /* 0136 */ int guild;
    /* 0140 */ int level;
    /* 0144 */ int status;
    /* 0148 */
};

// ww_MacMsg
// 20 bytes
// 5 fields
struct ww_MacMsg {
    /* 0000 */ unsigned char iflock;
    /* 0004 */ long platinum;
    /* 0008 */ long gold;
    /* 0012 */ long silver;
    /* 0016 */ long copper;
    /* 0020 */
};

// zone_address_t
// 130 bytes
// 2 fields
struct zone_address_t {
    /* 0000 */ char hostname[128];
    /* 0128 */ short port;
    /* 0130 */
};

// zonecmdx
// 260 bytes
// 2 fields
struct zonecmdx {
    /* 0000 */ char fname[256];
    /* 0256 */ int routenum;
    /* 0260 */
};

// zoneHeader
// 572 bytes
// 45 fields
struct zoneHeader {
    /* 0000 */ char charname[64];
    /* 0064 */ char zone[32];
    /* 0096 */ char name[128];
    /* 0224 */ char desc[150];
    /* 0374 */ unsigned char fogOn;
    /* 0375 */ unsigned char fogBaseRed[4];
    /* 0379 */ unsigned char fogBaseGreen[4];
    /* 0383 */ unsigned char fogBaseBlue[4];
    /* 0388 */ float fogBaseStart[4];
    /* 0404 */ float fogBaseEnd[4];
    /* 0420 */ float gravity;
    /* 0424 */ unsigned char outdoor;
    /* 0425 */ unsigned char rainchance[4];
    /* 0429 */ unsigned char rainduration[4];
    /* 0433 */ unsigned char snowchance[4];
    /* 0437 */ unsigned char snowduration[4];
    /* 0441 */ unsigned char specialdates[16];
    /* 0457 */ unsigned char specialcodes[16];
    /* 0473 */ char timezone;
    /* 0474 */ unsigned char sky;
    /* 0476 */ short water_music;
    /* 0478 */ short normal_music_day;
    /* 0480 */ short normal_music_night;
    /* 0484 */ float exp_modifier;
    /* 0488 */ float safe_x;
    /* 0492 */ float safe_y;
    /* 0496 */ float safe_z;
    /* 0500 */ float max_z;
    /* 0504 */ float min_z;
    /* 0508 */ float min_clip;
    /* 0512 */ float max_clip;
    /* 0516 */ int forage_novice;
    /* 0520 */ int forage_medium;
    /* 0524 */ int forage_advanced;
    /* 0528 */ int fishing_novice;
    /* 0532 */ int fishing_medium;
    /* 0536 */ int fishing_advanced;
    /* 0540 */ int sky_lock;
    /* 0544 */ unsigned short graveyard_tme;
    /* 0548 */ int scriptPeriodicHour;
    /* 0552 */ int scriptPeriodicMinute;
    /* 0556 */ int scriptPeriodicFast;
    /* 0560 */ int scriptPlayerDead;
    /* 0564 */ int scriptNpcDead;
    /* 0568 */ int scriptPlayerEntering;
    /* 0572 */
};

// zoneSky
// 4 bytes
// 1 fields
struct zoneSky {
    /* 0000 */ int skyType;
    /* 0004 */
};

// zserver_statmsg
// 76 bytes
// 4 fields
struct zserver_statmsg {
    /* 0000 */ char playername[64];
    /* 0064 */ int zoneid;
    /* 0068 */ ZONE_REQ_REASON reason;
    /* 0072 */ ZONE_REQ_STATUS status;
    /* 0076 */
};
```

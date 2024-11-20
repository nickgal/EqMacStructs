# EqMacStructs

Extract and format network message structs from the eqmac binary.

```c
// 1 field 1 byte
struct __avLevel {
    /* 0000 */ unsigned char level;
    /* 0001 */
};

// 1 field 227 bytes
struct AbilityMsg {
    /* 0000 */ unsigned char ability[227];
    /* 0227 */
};

// 1 field 256 bytes
struct alternateMsg {
    /* 0000 */ char desc[256];
    /* 0256 */
};

// 3 fields 8 bytes
struct AltexpUpMsg {
    /* 0000 */ unsigned long experience;
    /* 0004 */ short ability_pts;
    /* 0006 */ unsigned char alt;
    /* 0008 */
};

// 2 fields 8 bytes
struct altGive {
    /* 0000 */ unsigned short target;
    /* 0004 */ int value;
    /* 0008 */
};

// 3 fields 12 bytes
struct AltTimerMsg {
    /* 0000 */ int time_last_used;
    /* 0004 */ short ability;
    /* 0008 */ unsigned long current_time;
    /* 0012 */
};

// 3 fields 12 bytes
struct anim_msg {
    /* 0000 */ unsigned short player_id;
    /* 0004 */ int anim;
    /* 0008 */ float anim_speed;
    /* 0012 */
};

// 2 fields 8 bytes
struct applyPoison {
    /* 0000 */ int inven_location;
    /* 0004 */ int success;
    /* 0008 */
};

// 5 fields 172 bytes
struct approve {
    /* 0032 */ char name[64];
    /* 0096 */ int race;
    /* 0100 */ int cclass;
    /* 0104 */ char sysop[64];
    /* 0168 */ unsigned char status;
    /* 0172 */
};

// 2 fields 4 bytes
struct __bandage {
    /* 0000 */ unsigned short id;
    /* 0002 */ short amt;
    /* 0004 */
};

// 7 fields 1131 bytes
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

// 6 fields 76 bytes
struct BazaarMsgItem {
    /* 0000 */ short msg_type;
    /* 0002 */ short qty;
    /* 0004 */ short item_id;
    /* 0006 */ unsigned short seller_id;
    /* 0008 */ unsigned int price;
    /* 0012 */ char item_name[64];
    /* 0076 */
};

// 2 fields 8 bytes
struct becomeNPCMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int level;
    /* 0008 */
};

// 2 fields 4 bytes
struct beginTrade {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// 2 fields 4 bytes
struct buffUp {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned char level;
    /* 0004 */
};

// 7 fields 80 bytes
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

// 2 fields 20 bytes
struct bzrGenericMsg {
    /* 0000 */ short msg_type;
    /* 0004 */ int value[4];
    /* 0020 */
};

// 3 fields 644 bytes
struct bzrItemArrayMsg {
    /* 0000 */ short msg_type;
    /* 0004 */ int bzrItem[80];
    /* 0324 */ unsigned long bzrPrice[80];
    /* 0644 */
};

// 10 fields 88 bytes
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

// 3 fields 12 bytes
struct bzrItemUpdateMsg {
    /* 0000 */ short msg_type;
    /* 0004 */ int item_id;
    /* 0008 */ unsigned long ask_price;
    /* 0012 */
};

// 3 fields 6 bytes
struct cancelDuel {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ unsigned char reason;
    /* 0006 */
};

// 2 fields 4 bytes
struct canTrade {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// 5 fields 12 bytes
struct castspellmsg {
    /* 0000 */ short which_slot;
    /* 0002 */ short spell_nbr;
    /* 0004 */ short item_slot;
    /* 0006 */ unsigned short target_id;
    /* 0008 */ int crc32;
    /* 0012 */
};

// 3 fields 12 bytes
struct chngAbility {
    /* 0000 */ unsigned short target;
    /* 0004 */ int ability;
    /* 0008 */ int value;
    /* 0012 */
};

// 1 field 64 bytes
struct changeGuildLeader {
    /* 0000 */ char newLeader[64];
    /* 0064 */
};

// 2 fields 68 bytes
struct changeItem {
    /* 0000 */ char name[64];
    /* 0064 */ int refnum;
    /* 0068 */
};

// 3 fields 72 bytes
struct changeMoney {
    /* 0000 */ char name[64];
    /* 0064 */ int type;
    /* 0068 */ int qty;
    /* 0072 */
};

// 12 fields 752 bytes
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

// 6 fields 20 bytes
struct chestLock {
    /* 0000 */ unsigned short id;
    /* 0004 */ unsigned long sernbr;
    /* 0008 */ short status;
    /* 0010 */ short type;
    /* 0012 */ int capacity;
    /* 0016 */ int image_nbr;
    /* 0020 */
};

// 5 fields 196 bytes
struct chngName {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ char newname[64];
    /* 0192 */ unsigned short badName;
    /* 0194 */ unsigned short changed;
    /* 0196 */
};

// 11 fields 20 bytes
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

// 3 fields 12 bytes
struct chngSkill {
    /* 0000 */ unsigned short target;
    /* 0004 */ int skill;
    /* 0008 */ int value;
    /* 0012 */
};

// 3 fields 6 bytes
struct clearSlot {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */ char slot;
    /* 0006 */
};

// 4 fields 8 bytes
struct clientUseCharge {
    /* 0000 */ unsigned long inv_refnum;
    /* 0004 */ char hunger;
    /* 0005 */ char thirst;
    /* 0006 */ char expend;
    /* 0008 */
};

// 2 fields 68 bytes
struct clientAddPlayer {
    /* 0000 */ int crc32;
    /* 0004 */ char name[64];
    /* 0068 */
};

// 7 fields 116 bytes
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

// 2 fields 68 bytes
struct clrFaction {
    /* 0000 */ char name[64];
    /* 0064 */ int factionnum;
    /* 0068 */
};

// 3 fields 129 bytes
struct consentVerify {
    /* 0000 */ char looter[64];
    /* 0064 */ char corpsename[64];
    /* 0128 */ char consent;
    /* 0129 */
};

// 2 fields 4 bytes
struct controlNpc {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned char control;
    /* 0004 */
};

// 2 fields 68 bytes
struct corpseLogMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int logActive;
    /* 0068 */
};

// 1 field 4 bytes
struct createGold {
    /* 0000 */ int amt;
    /* 0004 */
};

// 7 fields 208 bytes
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

// 3 fields 34 bytes
struct createItem_MacMsg {
    /* 0000 */ char name[30];
    /* 0030 */ short recordNbr;
    /* 0032 */ short slot;
    /* 0034 */
};

// 3 fields 8 bytes
struct deleteMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned short id;
    /* 0004 */ int category;
    /* 0008 */
};

// 4 fields 8 bytes
struct disarmMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned short target;
    /* 0004 */ short skill;
    /* 0006 */ char status;
    /* 0008 */
};

// 2 fields 128 bytes
struct disband {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */
};

// 7 fields 32 bytes
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

// 3 fields 12 bytes
struct doHouseLock {
    /* 0000 */ int status;
    /* 0004 */ unsigned short id;
    /* 0012 */ long status_unk;
    /* 0012 */
};

// 1 field 16 bytes
struct doHouseMoney {
    /* 0000 */ long money[4];
    /* 0016 */
};

// 2 fields 4 bytes
struct doNpcCmd {
    /* 0000 */ unsigned short id;
    /* 0002 */ short index;
    /* 0004 */
};

// 3 fields 129 bytes
struct doPlayer {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ char found;
    /* 0129 */
};

// 5 fields 162 bytes
struct doPlayer2 {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ char stationNum[32];
    /* 0160 */ char found;
    /* 0161 */ char dir;
    /* 0162 */
};

// 6 fields 1174 bytes
struct dopostMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ char time[16];
    /* 0018 */ char author[64];
    /* 0082 */ short language;
    /* 0084 */ char subject[64];
    /* 0148 */ short type;
    /* 1174 */
};

// 2 fields 4 bytes
struct duel {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// 2 fields 1026 bytes
struct emoteMsg {
    /* 0000 */ short lang_type;
    /* 0002 */ char desc[1024];
    /* 1026 */
};

// 6 fields 24 bytes
struct endRt {
    /* 0000 */ long minx;
    /* 0004 */ long miny;
    /* 0008 */ long minz;
    /* 0012 */ long maxx;
    /* 0016 */ long maxy;
    /* 0020 */ long maxz;
    /* 0024 */
};

// 7 fields 10 bytes
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

// 6 fields 3780 bytes
struct EQ_Character {
    /* 0000 */ EQ_CharacterData3 Parent_Class;
    /* 3444 */ EQPlayer * me;
    /* 3448 */ EQ_Item * possessions[30];
    /* 3568 */ unsigned char spellcast_level;
    /* 3570 */ EQ_Affect m_NpcEffects[15];
    /* 3720 */ unsigned short m_EffectIds[30];
    /* 3780 */
};

// 68 fields 3444 bytes
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

// 7 fields 276 bytes
struct EQ_Container {
    /* 0000 */ EQ_Item Parent_Class;
    /* 0228 */ EQ_Item * items_held[10];
    /* 0268 */ unsigned char con_type;
    /* 0269 */ unsigned char capacity;
    /* 0270 */ unsigned char status;
    /* 0271 */ unsigned char sizeMax;
    /* 0272 */ unsigned char discount;
    /* 0276 */
};

// 54 fields 360 bytes
struct EQ_Equipment {
    /* 0000 */ EQ_Item Parent_Class;
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

// 5 fields 92 bytes
struct eq_exception {
    /* 0000 */ unsigned int oldNum;
    /* 0004 */ unsigned int newNum;
    /* 0008 */ unsigned int msg;
    /* 0012 */ long decr_msg[10];
    /* 0052 */ long decr_time[10];
    /* 0092 */
};

// 23 fields 228 bytes
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

// 5 fields 264 bytes
struct EQ_Note {
    /* 0000 */ EQ_Item Parent_Class;
    /* 0228 */ unsigned char notetype;
    /* 0229 */ unsigned char status;
    /* 0230 */ char language;
    /* 0231 */ char text[30];
    /* 0264 */
};

// 17 fields 8452 bytes
struct EQ_PC {
    /* 0000 */ EQ_Character Parent_Class;
    /* 3780 */ EQ_PCData4 Parent_Class;
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

// 59 fields 4464 bytes
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

// 61 fields 4592 bytes
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

// 5 fields 6 bytes
struct eq_time {
    /* 0000 */ unsigned char cur_hour;
    /* 0001 */ unsigned char cur_minute;
    /* 0002 */ unsigned char cur_day;
    /* 0003 */ unsigned char cur_month;
    /* 0004 */ short cur_year;
    /* 0006 */
};

// 13 fields 44 bytes
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

// 1 field 2 bytes
struct EQCVersionInfo {
    /* 0000 */ VersionWord v;
    /* 0002 */
};

// 19 fields 224 bytes
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

// 16 fields 112 bytes
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

// 13 fields 36 bytes
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

// 17 fields 112 bytes
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

// 44 fields 224 bytes
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

// 12 fields 88 bytes
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

// 60 fields 352 bytes
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

// 8 fields 20 bytes
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

// 8 fields 24 bytes
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

// 2 fields 2 bytes
struct EQSwitchState {
    /* 0000 */ unsigned char id;
    /* 0001 */ unsigned char state;
    /* 0002 */
};

// 4 fields 8 bytes
struct EQToggleSwitch {
    /* 0000 */ unsigned char id;
    /* 0002 */ short picking_skill;
    /* 0004 */ short record_nbr;
    /* 0006 */ unsigned short player_id;
    /* 0008 */
};

// 2 fields 8 bytes
struct expendItemCharge {
    /* 0000 */ int item_class;
    /* 0004 */ int record_nbr;
    /* 0008 */
};

// 2 fields 8 bytes
struct expGain {
    /* 0000 */ unsigned short id;
    /* 0004 */ int exp;
    /* 0008 */
};

// 2 fields 8 bytes
struct expGive {
    /* 0000 */ unsigned short target;
    /* 0004 */ int value;
    /* 0008 */
};

// 2 fields 8 bytes
struct expSet {
    /* 0000 */ unsigned short target;
    /* 0004 */ float level;
    /* 0008 */
};

// 1 field 4 bytes
struct expUpMsg {
    /* 0000 */ unsigned long experience;
    /* 0004 */
};

// 3 fields 382 bytes
struct faction_MacMsg {
    /* 0000 */ short faction;
    /* 0002 */ char name[60];
    /* 0062 */ char standing[320];
    /* 0382 */
};

// 3 fields 6 bytes
struct feignMsg {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned short fake;
    /* 0004 */ char status;
    /* 0006 */
};

// 2 fields 128 bytes
struct follow {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */
};

// 4 fields 16 bytes
struct foodItem {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int qty;
    /* 0012 */ int foodwater;
    /* 0016 */
};

// 2 fields 68 bytes
struct forceTitle {
    /* 0000 */ char target[64];
    /* 0064 */ int cmd;
    /* 0068 */
};

// 3 fields 6 bytes
struct fwaterMsg {
    /* 0000 */ short hunger;
    /* 0002 */ short thirst;
    /* 0004 */ short fatigue;
    /* 0006 */
};

// 4 fields 268 bytes
struct getStats {
    /* 0000 */ char name[64];
    /* 0064 */ short level;
    /* 0066 */ short cclass;
    /* 0068 */ short skill[100];
    /* 0268 */
};

// 7 fields 28 bytes
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

// 9 fields 96 bytes
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

// 2 fields 100 bytes
struct guildAdded {
    /* 0000 */ int guild_index;
    /* 0004 */ guild_dat guild_entry;
    /* 0100 */
};

// 2 fields 49156 bytes
struct guildCRCmsg {
    /* 0000 */ int crc32;
    /* 0004 */ guild_dat gData[512];
    /* 49156 */
};

// 2 fields 8 bytes
struct guildExists {
    /* 0000 */ int guild;
    /* 0004 */ int exists;
    /* 0008 */
};

// 2 fields 68 bytes
struct guildInfo {
    /* 0000 */ int num;
    /* 0004 */ guild_dat name;
    /* 0068 */
};

// 4 fields 136 bytes
struct guildInvite {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short guild;
    /* 0132 */ int level;
    /* 0136 */
};

// 1 field 34820 bytes
struct guildList {
    /* 0000 */ int numrecs;
    /* 34820 */
};

// 3 fields 580 bytes
struct guildmotdSet {
    /* 0000 */ char name[64];
    /* 0064 */ int guild;
    /* 0068 */ char message[512];
    /* 0580 */
};

// 2 fields 36 bytes
struct guildNameEntry {
    /* 0000 */ char name[32];
    /* 0032 */ int status;
    /* 0036 */
};

// 5 fields 140 bytes
struct guildPeace {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ int warWith;
    /* 0132 */ int days;
    /* 0136 */ int status;
    /* 0140 */
};

// 4 fields 136 bytes
struct guildRemove {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short guild;
    /* 0132 */ int level;
    /* 0136 */
};

// 2 fields 128 bytes
struct guildRename {
    /* 0000 */ char newGuildName[64];
    /* 0064 */ char oldGuildName[64];
    /* 0128 */
};

// 4 fields 136 bytes
struct guildReply {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ int status;
    /* 0132 */ short guild;
    /* 0136 */
};

// 4 fields 136 bytes
struct guildStatus {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short guild;
    /* 0132 */ int level;
    /* 0136 */
};

// 1 field 140 bytes
struct guildWar {
    /* 0000 */ guildPeace Parent_Class;
    /* 0140 */
};

// 3 fields 12 bytes
struct hitptMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int hp;
    /* 0008 */ int max_hp;
    /* 0012 */
};

// 2 fields 8 bytes
struct hpChgMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int cur_hp;
    /* 0008 */
};

// 6 fields 1744 bytes
struct inspect {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ char name[1408];
    /* 1412 */ short image[22];
    /* 1456 */ char text[256];
    /* 1712 */ char title[32];
    /* 1744 */
};

// 2 fields 66 bytes
struct InspectItem {
    /* 0000 */ short item_id;
    /* 0002 */ char item_name[64];
    /* 0066 */
};

// 4 fields 193 bytes
struct invite {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */ char party[64];
    /* 0192 */ unsigned char pkill;
    /* 0193 */
};

// 2 fields 84 bytes
struct item_find_message {
    /* 0000 */ int itemNumber;
    /* 0004 */ char partialName[80];
    /* 0084 */
};

// 3 fields 129 bytes
struct joinStatus {
    /* 0000 */ char target[64];
    /* 0064 */ char name[64];
    /* 0128 */ unsigned char answer;
    /* 0129 */
};

// 3 fields 12 bytes
struct keynumMsg {
    /* 0000 */ int keynum;
    /* 0004 */ short recnum;
    /* 0008 */ int rent;
    /* 0012 */
};

// 1 field 4 bytes
struct KunarkApprovedMsg {
    /* 0000 */ int status;
    /* 0004 */
};

// 2 fields 68 bytes
struct kunarkMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int status;
    /* 0068 */
};

// 3 fields 12 bytes
struct launchSpellInfo {
    /* 0000 */ int slot;
    /* 0004 */ int spell;
    /* 0008 */ int type;
    /* 0012 */
};

// 2 fields 4 bytes
struct leave_guildmaster {
    /* 0000 */ unsigned short guildmaster;
    /* 0002 */ unsigned short me;
    /* 0004 */
};

// 2 fields 4 bytes
struct leave_merchant {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */
};

// 3 fields 12 bytes
struct levelUpMsg {
    /* 0000 */ int level;
    /* 0004 */ int highestlevel;
    /* 0008 */ int experience;
    /* 0012 */
};

// 2 fields 68 bytes
struct LFGMsg {
    /* 0000 */ unsigned char name[64];
    /* 0064 */ int status;
    /* 0068 */
};

// 2 fields 8 bytes
struct LFGMsg2 {
    /* 0000 */ unsigned short id;
    /* 0004 */ int status;
    /* 0008 */
};

// 1 field 2 bytes
struct lockmsg {
    /* 0000 */ unsigned short id;
    /* 0002 */
};

// 5 fields 386 bytes
struct loginKey {
    /* 0000 */ char name[64];
    /* 0064 */ char pword[32];
    /* 0096 */ char keycode[32];
    /* 0128 */ char hostname[256];
    /* 0384 */ short port;
    /* 0386 */
};

// 5 fields 200 bytes
struct LoginMsg {
    /* 0000 */ char unistring[186];
    /* 0186 */ short port;
    /* 0188 */ unsigned char zone_server;
    /* 0192 */ int lreason;
    /* 0196 */ short version;
    /* 0200 */
};

// 1 field 4 bytes
struct logshoweq {
    /* 0000 */ int value;
    /* 0004 */
};

// 4 fields 12 bytes
struct loot_msg {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short me;
    /* 0004 */ short slot;
    /* 0008 */ int autoInven;
    /* 0012 */
};

// 2 fields 68 bytes
struct makeNewLeaderMsg {
    /* 0000 */ int guild_faction;
    /* 0004 */ char new_leader[64];
    /* 0068 */
};

// 2 fields 4 bytes
struct ManaMsg {
    /* 0000 */ unsigned short player_id;
    /* 0002 */ short my_mana;
    /* 0004 */
};

// 4 fields 12 bytes
struct materialChange {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char location;
    /* 0004 */ unsigned short type;
    /* 0008 */ unsigned long tint;
    /* 0012 */
};

// 1 field 4 bytes
struct meditateMsg {
    /* 0000 */ int meditating;
    /* 0004 */
};

// 4 fields 524 bytes
struct memSpellBook {
    /* 0000 */ int slot;
    /* 0004 */ int spell;
    /* 0008 */ int type;
    /* 0012 */ short tempspellbook[256];
    /* 0524 */
};

// 4 fields 1156 bytes
struct modInven {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short index;
    /* 0130 */ unsigned char type;
    /* 1156 */
};

// 4 fields 136 bytes
struct modMoney {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ unsigned char type;
    /* 0132 */ long amount;
    /* 0136 */
};

// 11 fields 40 bytes
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

// 1 field 4 bytes
struct ModulationMsg {
    /* 0000 */ unsigned int fTimeLeft;
    /* 0004 */
};

// 5 fields 56 bytes
struct money_MacMsg {
    /* 0000 */ char name[40];
    /* 0040 */ long platinum;
    /* 0044 */ long gold;
    /* 0048 */ long silver;
    /* 0052 */ long copper;
    /* 0056 */
};

// 2 fields 576 bytes
struct motdSet {
    /* 0000 */ char name[64];
    /* 0064 */ char message[512];
    /* 0576 */
};

// 3 fields 12 bytes
struct moveItem {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int qty;
    /* 0012 */
};

// 5 fields 20 bytes
struct moveMoney {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int typeFrom;
    /* 0012 */ int typeTo;
    /* 0016 */ int amt;
    /* 0020 */
};

// 2 fields 8 bytes
struct msg_delIlist {
    /* 0000 */ unsigned long sernbr;
    /* 0004 */ unsigned short id;
    /* 0008 */
};

// 4 fields 44 bytes
struct msg_ppoint {
    /* 0000 */ char name[32];
    /* 0032 */ float x;
    /* 0036 */ float y;
    /* 0040 */ float z;
    /* 0044 */
};

// 8 fields 140 bytes
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

// 2 fields 356 bytes
struct msgAddPlayer {
    /* 0000 */ int crc32;
    /* 0004 */ EQPlayer playerdata;
    /* 0356 */
};

// 4 fields 20 bytes
struct msgChangePCAffect {
    /* 0000 */ unsigned short id;
    /* 0002 */ EQ_Affect affect;
    /* 0012 */ int slot;
    /* 0016 */ int change_type;
    /* 0020 */
};

// 2 fields 131074 bytes
struct msgCompData {
    /* 0000 */ short num_items;
    /* 0002 */ char compData[131072];
    /* 131074 */
};

// 4 fields 16 bytes
struct msgCorpseXYZ {
    /* 0000 */ unsigned short id;
    /* 0004 */ float x;
    /* 0008 */ float y;
    /* 0012 */ float z;
    /* 0016 */
};

// 3 fields 12 bytes
struct msgDoAttack {
    /* 0000 */ unsigned short id;
    /* 0004 */ int slot;
    /* 0008 */ int skill;
    /* 0012 */
};

// 7 fields 24 bytes
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

// 3 fields 6 bytes
struct MsgPetInfo {
    /* 0000 */ unsigned short Owner_ID;
    /* 0002 */ unsigned short Pet_ID;
    /* 0004 */ unsigned char flag;
    /* 0006 */
};

// 7 fields 88 bytes
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

// 3 fields 2180 bytes
struct msgGiveitem {
    /* 0000 */ char source[64];
    /* 0064 */ char tgt[64];
    /* 0128 */ int type;
    /* 2180 */
};

// 4 fields 16 bytes
struct msgLimboMoney {
    /* 0000 */ long plat;
    /* 0004 */ long gold;
    /* 0008 */ long silver;
    /* 0012 */ long copper;
    /* 0016 */
};

// 1 field 64 bytes
struct msgQueryExp {
    /* 0000 */ char name[64];
    /* 0064 */
};

// 2 fields 8 bytes
struct msgSkillImprove {
    /* 0000 */ int skillnum;
    /* 0004 */ int skillvalue;
    /* 0008 */
};

// 6 fields 24 bytes
struct msgTeleportPC {
    /* 0000 */ EQZoneIndex zoneid;
    /* 0004 */ float x;
    /* 0008 */ float y;
    /* 0012 */ float z;
    /* 0016 */ float hdg;
    /* 0020 */ ZONE_REQ_REASON reason;
    /* 0024 */
};

// 2 fields 96 bytes
struct msgTraceLogin {
    /* 0000 */ char stationNum[32];
    /* 0032 */ char characterName[64];
    /* 0096 */
};

// 3 fields 100 bytes
struct newSurname {
    /* 0000 */ char name[64];
    /* 0064 */ int status;
    /* 0068 */ char lastName[32];
    /* 0100 */
};

// 6 fields 2184 bytes
struct newtext {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ short lang;
    /* 0130 */ short type;
    /* 0132 */ unsigned char locale;
    /* 0134 */ short speakingskill;
    /* 2184 */
};

// 7 fields 13 bytes
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

// 2 fields 68 bytes
struct NoNameApprovalMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int status;
    /* 0068 */
};

// 7 fields 1204 bytes
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

// 2 fields 260 bytes
struct npcCheckItemsZone {
    /* 0000 */ int cmd;
    /* 0004 */ char szFilter[256];
    /* 0260 */
};

// 6 fields 20 bytes
struct NPCMoney {
    /* 0000 */ unsigned short sendId;
    /* 0002 */ unsigned short targetId;
    /* 0004 */ long platinum;
    /* 0008 */ long gold;
    /* 0012 */ long silver;
    /* 0016 */ long copper;
    /* 0020 */
};

// 1 field 4 bytes
struct OverrideTimerMessage {
    /* 0000 */ int override_timer;
    /* 0004 */
};

// 11 fields 144 bytes
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

// 3 fields 72 bytes
struct pcGuildMsg {
    /* 0000 */ int guild;
    /* 0004 */ int status;
    /* 0008 */ char name[64];
    /* 0072 */
};

// 3 fields 8460 bytes
struct PCSaveMsg {
    /* 0000 */ int crc32;
    /* 0004 */ EQ_PC pcdata;
    /* 8456 */ unsigned char SaveIndex;
    /* 8460 */
};

// 2 fields 8 bytes
struct permaKillMsg {
    /* 0000 */ unsigned short id;
    /* 0004 */ int delfile;
    /* 0008 */
};

// 2 fields 8 bytes
struct pet_command_message {
    /* 0000 */ PetCommandType command;
    /* 0004 */ unsigned short targetId;
    /* 0008 */
};

// 9 fields 184 bytes
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

// 15 fields 2220 bytes
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

// 12 fields 48 bytes
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

// 18 fields 1620 bytes
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

// 1 field 4098 bytes
struct prohibExe {
    /* 0000 */ short num;
    /* 4098 */
};

// 1 field 544 bytes
struct publicKeyMsg {
    /* 0000 */ vlMsg vl[2];
    /* 0544 */
};

// 2 fields 4 bytes
struct _readyTrade {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char flag;
    /* 0004 */
};

// 2 fields 8 bytes
struct randomMsg {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */
};

// 4 fields 76 bytes
struct ranReturnMsg {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */ int result;
    /* 0012 */ char name[64];
    /* 0076 */
};

// 3 fields 6 bytes
struct refuseTrade {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ unsigned char reason;
    /* 0006 */
};

// 3 fields 5248 bytes
struct reportText {
    /* 0000 */ char name[64];
    /* 0064 */ char buffer[5120];
    /* 5184 */ char offender[64];
    /* 5248 */
};

// 4 fields 16 bytes
struct req_bzr_merchant {
    /* 0000 */ unsigned short bzr_merc_id;
    /* 0004 */ int item_id;
    /* 0008 */ float bzr_greed;
    /* 0012 */ unsigned char ok;
    /* 0016 */
};

// 4 fields 12 bytes
struct req_merchant {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */ unsigned char ok;
    /* 0008 */ float greed;
    /* 0012 */
};

// 6 fields 244 bytes
struct req_guildmaster {
    /* 0000 */ unsigned short guildmaster;
    /* 0002 */ unsigned short me;
    /* 0004 */ short skill[100];
    /* 0204 */ float greed;
    /* 0208 */ unsigned char ok;
    /* 0209 */ unsigned char lang[32];
    /* 0244 */
};

// 3 fields 6 bytes
struct reqGuildChestLock {
    /* 0000 */ unsigned short id;
    /* 0002 */ short key;
    /* 0004 */ short data;
    /* 0006 */
};

// 1 field 4 bytes
struct reqGuildName {
    /* 0000 */ int guild_faction;
    /* 0004 */
};

// 2 fields 4 bytes
struct reqInsp {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */
};

// 3 fields 192 bytes
struct reqLootermsg {
    /* 0000 */ unsigned char requestor[64];
    /* 0064 */ unsigned char corpse[64];
    /* 0128 */ unsigned char looter[64];
    /* 0192 */
};

// 4 fields 136 bytes
struct reqplayed {
    /* 0000 */ char target[64];
    /* 0064 */ char source[64];
    /* 0128 */ unsigned int created;
    /* 0132 */ unsigned long minutes_played;
    /* 0136 */
};

// 2 fields 4 bytes
struct requestHdr {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned char type;
    /* 0004 */
};

// 3 fields 6 bytes
struct requestMsg {
    /* 0000 */ unsigned short source;
    /* 0002 */ unsigned short id;
    /* 0004 */ unsigned char type;
    /* 0006 */
};

// 1 field 2 bytes
struct rescue {
    /* 0000 */ unsigned short target;
    /* 0002 */
};

// 12 fields 228 bytes
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

// 7 fields 28 bytes
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

// 4 fields 16 bytes
struct retHouseMoney {
    /* 0000 */ unsigned short id;
    /* 0004 */ long sernbr;
    /* 0008 */ int type;
    /* 0012 */ int qty;
    /* 0016 */
};

// 10 fields 48 bytes
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

// 13 fields 244 bytes
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

// 3 fields 12 bytes
struct sacrificeMsg {
    /* 0000 */ int necroID;
    /* 0004 */ int playerID;
    /* 0008 */ int response;
    /* 0012 */
};

// 3 fields 132 bytes
struct searchCorpse {
    /* 0000 */ char name[64];
    /* 0064 */ char corpsename[64];
    /* 0128 */ int zoneid;
    /* 0132 */
};

// 5 fields 16 bytes
struct sell_msg {
    /* 0000 */ unsigned short merchant;
    /* 0002 */ unsigned short me;
    /* 0004 */ short slot;
    /* 0008 */ int quantity;
    /* 0012 */ long value;
    /* 0016 */
};

// 2 fields 2052 bytes
struct send_eq {
    /* 0000 */ unsigned short me;
    /* 0002 */ char type;
    /* 2052 */
};

// 4 fields 2060 bytes
struct send_eq2 {
    /* 0000 */ unsigned long ask_price;
    /* 0004 */ int location;
    /* 0008 */ unsigned short me;
    /* 0010 */ char type;
    /* 2060 */
};

// 5 fields 116 bytes
struct sendHdr {
    /* 0000 */ unsigned short id;
    /* 0002 */ char time[16];
    /* 0018 */ char author[64];
    /* 0082 */ short language;
    /* 0084 */ char subject[32];
    /* 0116 */
};

// 1 field 360 bytes
struct SendInspectItem {
    /* 0000 */ char data[360];
    /* 0360 */
};

// 1 field 4 bytes
struct setDatRateMsg {
    /* 0000 */ float datarate;
    /* 0004 */
};

// 3 fields 72 bytes
struct setFaction {
    /* 0000 */ char name[64];
    /* 0064 */ int factionnum;
    /* 0068 */ int fact_value;
    /* 0072 */
};

// 1 field 2 bytes
struct shieldMsg {
    /* 0000 */ unsigned short target;
    /* 0002 */
};

// 2 fields 68 bytes
struct sisaLogMsg {
    /* 0000 */ char name[64];
    /* 0064 */ int logActive;
    /* 0068 */
};

// 2 fields 8 bytes
struct SkillTmrMsg {
    /* 0000 */ short theSkill;
    /* 0004 */ unsigned long theTimer;
    /* 0008 */
};

// 7 fields 456 bytes
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

// 4 fields 2242 bytes
struct snooptext {
    /* 0000 */ char snooper[64];
    /* 0064 */ char target[64];
    /* 0128 */ char source[64];
    /* 0192 */ short type;
    /* 2242 */
};

// 4 fields 2056 bytes
struct sp_chksum {
    /* 0000 */ int cksum;
    /* 0004 */ unsigned long size;
    /* 0008 */ unsigned long wordnum[256];
    /* 1032 */ unsigned long wordval[256];
    /* 2056 */
};

// 2 fields 4 bytes
struct SpellActivateParticles {
    /* 0000 */ short iID;
    /* 0002 */ short iSpellNumber;
    /* 0004 */
};

// 1 field 514 bytes
struct spellText {
    /* 0000 */ unsigned short source;
    /* 0514 */
};

// 2 fields 44 bytes
struct argumentText {
    /* 0000 */ unsigned short source;
    /* 0004 */ int token;
    /* 0044 */
};

// 2 fields 4 bytes
struct SpellWornOffMessage {
    /* 0000 */ short iID;
    /* 0002 */ short iSpellNumber;
    /* 0004 */
};

// 1 field 456 bytes
struct soulMarkAddMsg {
    /* 0000 */ sMark soulMark;
    /* 0456 */
};

// 2 fields 5536 bytes
struct soulMarkMsg {
    /* 0000 */ char name[64];
    /* 0064 */ sMark soulMarks[12];
    /* 5536 */
};

// 4 fields 192 bytes
struct soulMarkReqMsg {
    /* 0000 */ char gmName[64];
    /* 0064 */ char gmstationNum[32];
    /* 0096 */ char name[64];
    /* 0160 */ char stationNum[32];
    /* 0192 */
};

// 2 fields 4 bytes
struct soundMsg {
    /* 0000 */ unsigned short id;
    /* 0002 */ short soundnum;
    /* 0004 */
};

// 3 fields 8 bytes
struct start_casting {
    /* 0000 */ unsigned short caster_id;
    /* 0002 */ short spell_nbr;
    /* 0004 */ unsigned int casting_time;
    /* 0008 */
};

// 4 fields 16 bytes
struct startRt {
    /* 0000 */ char terrain;
    /* 0004 */ BOOL outdoor;
    /* 0008 */ BOOL open;
    /* 0012 */ char height;
    /* 0016 */
};

// 3 fields 8 bytes
struct statChange {
    /* 0000 */ unsigned short id;
    /* 0002 */ short field;
    /* 0004 */ long value;
    /* 0008 */
};

// 2 fields 15 bytes
struct statUpdate {
    /* 0000 */ unsigned short id;
    /* 0002 */ netphysicsinfo physics;
    /* 0015 */
};

// 6 fields 2060 bytes
struct stealMsg {
    /* 0000 */ unsigned short target;
    /* 0002 */ unsigned short source;
    /* 0004 */ short skill;
    /* 0006 */ char status;
    /* 0008 */ long money;
    /* 0012 */ char data[2048];
    /* 2060 */
};

// 5 fields 388 bytes
struct stell {
    /* 0000 */ char whom[64];
    /* 0064 */ char tline[256];
    /* 0320 */ char speaker[64];
    /* 0384 */ short language;
    /* 0386 */ short speakingskill;
    /* 0388 */
};

// 2 fields 4 bytes
struct stopcastingmsg {
    /* 0000 */ short cur_mana;
    /* 0002 */ short spell_nbr;
    /* 0004 */
};

// 4 fields 76 bytes
struct submit {
    /* 0000 */ char name[64];
    /* 0064 */ int race;
    /* 0068 */ int cclass;
    /* 0072 */ int deity;
    /* 0076 */
};

// 2 fields 8 bytes
struct swapSpell {
    /* 0000 */ int from;
    /* 0004 */ int to;
    /* 0008 */
};

// 2 fields 32 bytes
struct switchName {
    /* 0000 */ char name[30];
    /* 0030 */ unsigned short id;
    /* 0032 */
};

// 2 fields 8 bytes
struct switchSpell {
    /* 0000 */ int switch_id;
    /* 0004 */ int spellnum;
    /* 0008 */
};

// 1 field 4 bytes
struct TargetGroupBuffMsg {
    /* 0000 */ int iValue;
    /* 0004 */
};

// 1 field 2 bytes
struct targetMsg {
    /* 0000 */ unsigned short target;
    /* 0002 */
};

// 2 fields 68 bytes
struct tellToggle {
    /* 0000 */ char name[64];
    /* 0064 */ int on;
    /* 0068 */
};

// 1 field 2 bytes
struct tgtIDmsg {
    /* 0000 */ unsigned short id;
    /* 0002 */
};

// 6 fields 24 bytes
struct tp_coords {
    /* 0000 */ short index;
    /* 0004 */ float x;
    /* 0008 */ float y;
    /* 0012 */ float z;
    /* 0016 */ float hdg;
    /* 0020 */ int zoneid;
    /* 0024 */
};

// 2 fields 3076 bytes
struct tp_msg {
    /* 0000 */ short num_coords;
    /* 0004 */ tp_coords tp[128];
    /* 3076 */
};

// 1 field 4 bytes
struct toggleState {
    /* 0000 */ int state;
    /* 0004 */
};

// 3 fields 6 bytes
struct tokenStringMsg {
    /* 0000 */ short string_token;
    /* 0002 */ short string_color;
    /* 0004 */ short fromWorld;
    /* 0006 */
};

// 3 fields 2054 bytes
struct tradeitem {
    /* 0000 */ unsigned short id;
    /* 0002 */ short slot;
    /* 0004 */ unsigned char type;
    /* 2054 */
};

// 3 fields 8 bytes
struct trademoney {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char type;
    /* 0004 */ long amt;
    /* 0008 */
};

// 3 fields 12 bytes
struct trainMsg {
    /* 0000 */ unsigned short gMasterId;
    /* 0004 */ int language;
    /* 0008 */ int skill;
    /* 0012 */
};

// 8 fields 92 bytes
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

// 3 fields 12 bytes
struct trapLocation {
    /* 0000 */ float x;
    /* 0004 */ float y;
    /* 0008 */ float z;
    /* 0012 */
};

// 4 fields 132 bytes
struct tuneMsg {
    /* 0000 */ unsigned short id;
    /* 0002 */ unsigned char bPersist;
    /* 0003 */ char szParam[64];
    /* 0067 */ char szArg[64];
    /* 0132 */
};

// 17 fields 68 bytes
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

// 7 fields 7 bytes
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

// 2 fields 68 bytes
struct vehicle_xfr {
    /* 0000 */ char vehicle[64];
    /* 0064 */ EQZoneIndex zoneid;
    /* 0068 */
};

// 2 fields 2 bytes
struct VersionWord {
    /* 0000 */ BYTE minor;
    /* 0001 */ BYTE major;
    /* 0002 */
};

// 5 fields 272 bytes
struct vlMsg {
    /* 0000 */ int negative;
    /* 0004 */ int share;
    /* 0008 */ int array[64];
    /* 0264 */ int z;
    /* 0268 */ int n;
    /* 0272 */
};

// 4 fields 16 bytes
struct weatherChgMsg {
    /* 0000 */ int rain;
    /* 0004 */ int snow;
    /* 0008 */ int severity;
    /* 0012 */ int duration;
    /* 0016 */
};

// 2 fields 8 bytes
struct weatherMsg {
    /* 0000 */ int type;
    /* 0004 */ int severity;
    /* 0008 */
};

// 8 fields 152 bytes
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

// 9 fields 2108 bytes
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

// 4 fields 136 bytes
struct wldgroupMsg {
    /* 0000 */ int cmd;
    /* 0004 */ char name[64];
    /* 0068 */ char member[64];
    /* 0132 */ unsigned long strToken;
    /* 0136 */
};

// 7 fields 148 bytes
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

// 5 fields 20 bytes
struct ww_MacMsg {
    /* 0000 */ unsigned char iflock;
    /* 0004 */ long platinum;
    /* 0008 */ long gold;
    /* 0012 */ long silver;
    /* 0016 */ long copper;
    /* 0020 */
};

// 2 fields 130 bytes
struct zone_address_t {
    /* 0000 */ char hostname[128];
    /* 0128 */ short port;
    /* 0130 */
};

// 2 fields 260 bytes
struct zonecmdx {
    /* 0000 */ char fname[256];
    /* 0256 */ int routenum;
    /* 0260 */
};

// 45 fields 572 bytes
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

// 1 field 4 bytes
struct zoneSky {
    /* 0000 */ int skyType;
    /* 0004 */
};

// 4 fields 76 bytes
struct zserver_statmsg {
    /* 0000 */ char playername[64];
    /* 0064 */ int zoneid;
    /* 0068 */ ZONE_REQ_REASON reason;
    /* 0072 */ ZONE_REQ_STATUS status;
    /* 0076 */
};
```

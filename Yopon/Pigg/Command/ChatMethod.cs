namespace Yopon.Pigg.Command
{
    public sealed class ChatMethod
    {
        /*
         * 正規表現による置換
         * 置換前: public static const (.*?):int = ([\d-]*?);
         * 置換後: public static readonly short $1 = $2;
         *
         * 最終更新日: 2017/07/09
         */

        public static readonly short ERROR = -255;

        public static readonly short CHECK_AREA = 16;

        public static readonly short CHECK_AREA_RESULT = 17;

        public static readonly short LOGIN_CHAT = 32;

        public static readonly short LOGIN_CHAT_RESULT = 33;

        public static readonly short UPDATE_POINT_RESULT = 47;

        public static readonly short GET_CHAT_SERVER_TIME = 48;

        public static readonly short GET_CHAT_SERVER_TIME_RESULT = 49;

        public static readonly short NOTIFICATION = 144;

        public static readonly short ALERT_RESULT = 149;

        public static readonly short ENTER_ROOM = 256;

        public static readonly short ENTER_AREA_RESULT = 257;

        public static readonly short ENTER_QUEUE_RESULT = 258;

        public static readonly short ENTER_QUEUE_START_RESULT = 259;

        public static readonly short ENTER_ROOM_FULL_RESULT = 260;

        public static readonly short ENTER_ROOM_READY_RESULT = 261;

        public static readonly short ENTER_ROOM_EXECUTE = 262;

        public static readonly short ENTER_USER_ROOM_RESULT = 273;

        public static readonly short ENTER_USER_GARDEN_RESULT = 274;

        public static readonly short MOVE_USER_ROOM = 275;

        public static readonly short ENTER_QUEUE_CANCEL = 276;

        public static readonly short ENTER_QUEUE_CANCEL_RESULT = 277;

        public static readonly short FORCE_MOVE = 263;

        public static readonly short FORCE_MOVE_RESULT = 264;

        public static readonly short MOVE = 512;

        public static readonly short MOVE_RESULT = 513;

        public static readonly short MOVE_END = 514;

        public static readonly short MOVE_END_RESULT = 515;

        public static readonly short TIRED = 516;

        public static readonly short TIRED_RESULT = 517;

        public static readonly short APPEAR_USER = 528;

        public static readonly short LEAVE_USER = 544;

        public static readonly short APPEAR_FRIEND_USER = 545;

        public static readonly short MOVE_FROM_TO = 546;

        public static readonly short MOVE_FROM_TO_RESULT = 547;

        public static readonly short PLACE_FURNITURE = 768;

        public static readonly short PLACE_FURNITURE_RESULT = 769;

        public static readonly short MOVE_FURNITURE = 784;

        public static readonly short MOVE_FURNITURE_RESULT = 785;

        public static readonly short REMOVE_FURNITURE = 800;

        public static readonly short REMOVE_FURNITURE_RESULT = 801;

        public static readonly short CHANGE_ROOM = 816;

        public static readonly short CHANGE_ROOM_RESULT = 817;

        public static readonly short RESET_ROOM = 818;

        public static readonly short CHANGE_WINDOW_AQUARIUM = 825;

        public static readonly short CAHNGE_WINDOW_AQUARIUM_RESULT = 826;

        public static readonly short CHANGE_ROOM_SIZE = 819;

        public static readonly short CHANGE_ROOM_SIZE_RESULT = 820;

        public static readonly short CHANGE_ROOM_SIZE_RESULT_POINT = 821;

        public static readonly short ADD_SUB_ROOM = 822;

        public static readonly short ADD_SUB_ROOM_RESULT = 823;

        public static readonly short ADD_SUB_ROOM_RESULT_POINT = 824;

        public static readonly short CHANGE_GARDEN_SIZE_RESULT = 829;

        public static readonly short PLACE_ACTION_ITEM = 928;

        public static readonly short PLACE_ACTION_ITEM_RESULT = 929;

        public static readonly short REMOVE_ACTION_ITEM = 930;

        public static readonly short REMOVE_ACTION_ITEM_RESULT = 931;

        public static readonly short UPDATE_ACTION_ITEM_RESULT = 932;

        public static readonly short MOVE_ACTION_ITEM = 933;

        public static readonly short MOVE_ACTION_ITEM_RESULT = 934;

        public static readonly short USE_ACTION_ITEM = 935;

        public static readonly short USE_ACTION_ITEM_RESULT = 936;

        public static readonly short OPEN_GIFT_ITEM = 937;

        public static readonly short OPEN_GIFT_ITEM_RESULT = 938;

        public static readonly short OPEN_ALL_ACTION_ITEM = 939;

        public static readonly short OPEN_ALL_ACTION_ITEM_RESULT = 940;

        public static readonly short PLACE_GIFT = 941;

        public static readonly short GIFT_USER_ACTION = 942;

        public static readonly short TALK = 1024;

        public static readonly short TALK_RESULT = 1025;

        public static readonly short ECHO = 1026;

        public static readonly short ECHO_RESULT = 1027;

        public static readonly short ECHO_CLEAR = 1028;

        public static readonly short TALKLOG_RESULT = 1029;

        public static readonly short TYPING = 1030;

        public static readonly short TYPING_RESULT = 1031;

        public static readonly short CANCEL_TYPING = 1032;

        public static readonly short CANCEL_TYPING_RESULT = 1033;

        public static readonly short STAMP = 1088;

        public static readonly short STAMP_RESULT = 1089;

        public static readonly short ACTION = 1040;

        public static readonly short ACTION_RESULT = 1041;

        public static readonly short ROOM_ACTION = 1042;

        public static readonly short ROOM_ACTION_RESULT = 1043;

        public static readonly short SYSTEM_ACTION = 1044;

        public static readonly short SYSTEM_ACTION_RESULT = 1045;

        public static readonly short ADD_CONDITION_RESULT = 1050;

        public static readonly short REMOVE_CONDITION_RESULT = 1051;

        public static readonly short USER_EFFECT_RESULT = 1052;

        public static readonly short START_DRESSUP = 1056;

        public static readonly short START_DRESSUP_RESULT = 1057;

        public static readonly short FINISH_DRESSUP = 1058;

        public static readonly short FINISH_DRESSUP_RESULT = 1058;

        public static readonly short START_DRESSUP_MANNEQUIN = 1059;

        public static readonly short START_DRESSUP_MANNEQUIN_RESULT = 1060;

        public static readonly short FINISH_DRESSUP_MANNEQUIN = 1061;

        public static readonly short FINISH_DRESSUP_MANNEQUIN_RESULT = 1062;

        public static readonly short BAN_USER = 1071;

        public static readonly short BAN_USER_RESULT = 1087;

        public static readonly short ADD_BLOCK_USER = 3585;

        public static readonly short ADD_BLOCK_USER_RESULT = 3586;

        public static readonly short BALLOON_CHANGE = 1072;

        public static readonly short BALLOON_CHANGE_RESULT = 1073;

        public static readonly short USE_FURNITURE = 1536;

        public static readonly short USE_FURNITURE_RESULT = 1537;

        public static readonly short GAME_JOIN = 2048;

        public static readonly short GAME_JOIN_RESULT = 2049;

        public static readonly short GAME_READY = 2050;

        public static readonly short GAME_READY_RESULT = 2051;

        public static readonly short GAME_LEAVE = 2052;

        public static readonly short GAME_LEAVE_RESULT = 2053;

        public static readonly short GAME_DATA = 2054;

        public static readonly short GAME_RESULT_DATA = 2055;

        public static readonly short TABLE_GAME = 2064;

        public static readonly short TABLE_GAME_RESULT = 2065;

        public static readonly short TABLE_GAME_SHOW_RESULT = 2066;

        public static readonly short TABLE_GAME_TALK = 2067;

        public static readonly short TABLE_GAME_TALK_RESULT = 2068;

        public static readonly short TABLE_GAME_ACTION = 2069;

        public static readonly short TABLE_GAME_ACTION_RESULT = 2070;

        public static readonly short TABLE_GAME_ABORT_RESULT = 2071;

        public static readonly short TABLE_GAME_HIDE = 2072;

        public static readonly short CASINO_UPDATE_BALANCE_RESULT = 2096;

        public static readonly short CASINO_GAME_JOIN_REQUEST = 2097;

        public static readonly short CASINO_USE_LUCKY_ITEM_RESULT = 2100;

        public static readonly short CASINO_GAME_LEAVE = 2101;

        public static readonly short CASINO_FEVER_TIME_MODULE_UPDATE_RESULT = 2102;

        public static readonly short CASINO_FEVER_TIME_MODULE_SHOW_REQUEST = 2103;

        public static readonly short CASINO_ROYALE_FEVERTIME_DATA_REQUEST = 2104;

        public static readonly short CASINO_ROYALE_FEVERTIME_DATA_RESULT = 2105;

        public static readonly short CASINO_ROYALE_FEVERTIME_NOTIFY_RESULT = 2112;

        public static readonly short CASINO_ROYALE_JACKPOT_INCENTIVE_RESULT = 2113;

        public static readonly short GIVE_GOOD = 1792;

        public static readonly short UPDATE_GOOD_RESULT = 1794;

        public static readonly short GOOD_PIGG_RESULT = 1795;

        public static readonly short PET_PLACE_RESULT = 2305;

        public static readonly short PET_LEAVE_RESULT = 2306;

        public static readonly short PET_ACTION_RESULT = 2307;

        public static readonly short PET_MOVE = 2308;

        public static readonly short PET_MOVE_RESULT = 2309;

        public static readonly short PET_MOVE_END = 2310;

        public static readonly short PET_MOVE_END_RESULT = 2311;

        public static readonly short PET_PREPARE_BUY = 2312;

        public static readonly short PET_PREPARE_BUY_RESULT = 2313;

        public static readonly short PET_APPEAR_RESULT = 2314;

        public static readonly short PET_PLACE = 2315;

        public static readonly short PET_ACTION = 2316;

        public static readonly short PET_TALK_RESULT = 2317;

        public static readonly short PET_FURNITURE_ACTION = 2318;

        public static readonly short PET_TREASURE_PROFILE = 2319;

        public static readonly short PET_TREASURE_PROFILE_RESULT = 2320;

        public static readonly short UPDATE_NUM_FOOTPRINT_TODAY = 4097;

        public static readonly short MISSION_COMPLETE = 2560;

        public static readonly short MISSION_COMPLETE_RESULT = 2561;

        public static readonly short STREAMING_SCHEDULER_RESULT = 2576;

        public static readonly short STREAMING_SCHEDULER_USER = 2577;

        public static readonly short STREAMING_SCHEDULER_USER_RESULT = 2578;

        public static readonly short CAMPAIGN_PONTA_GIVE_POINT = 1808;

        public static readonly short CAMPAIGN_PONTA_GIVE_POINT_RESULT = 1809;

        public static readonly short CAMPAIGN_PONTA_CHECK_POINT = 1810;

        public static readonly short CAMPAIGN_PONTA_CHECK_POINT_RESULT = 1811;

        public static readonly short MOVE_NPC = 3072;

        public static readonly short FRIEND_REQUEST_SEND = 3123;

        public static readonly short START_SOCIAL_GAME = 1098;

        public static readonly short START_SOCIAL_GAME_RESULT = 1099;

        public static readonly short FINISH_SOCIAL_GAME = 1100;

        public static readonly short FINISH_SOCIAL_GAME_RESULT = 1101;

        public static readonly short START_SHOP = 1066;

        public static readonly short START_SHOP_RESULT = 1067;

        public static readonly short FINISH_SHOP = 1068;

        public static readonly short FINISH_SHOP_RESULT = 1069;

        public static readonly short START_GACHA = 1082;

        public static readonly short START_GACHA_RESULT = 1083;

        public static readonly short FINISH_GACHA = 1084;

        public static readonly short FINISH_GACHA_RESULT = 1085;

        public static readonly short START_MENKOGACHA = 1114;

        public static readonly short START_MENKOGACHA_RESULT = 1115;

        public static readonly short FINISH_MENKOGACHA = 1116;

        public static readonly short FINISH_MENKOGACHA_RESULT = 1117;

        public static readonly short START_CINEMA_BALLOON = 1130;

        public static readonly short START_CINEMA_BALLOON_RESULT = 1131;

        public static readonly short FINISH_CINEMA_BALLOON = 1132;

        public static readonly short FINISH_CINEMA_BALLOON_RESULT = 1133;

        public static readonly short CHANNEL_CONFIG_RESULT = 2592;

        public static readonly short PIGG_CHANNEL_PROGRAM_INFO_RESULT = 2594;

        public static readonly short AKIBA_MONITOR_DATA = 3088;

        public static readonly short SEND_GAME_ACTIVITY_DATA = 3104;

        public static readonly short DOT_MONEY_POINT_EVENT_CHAT_RESULT = 3584;

        public static readonly short CHANNEL_FLOOR_ENTER_ROOM = 2598;

        public static readonly short CHANNEL_FLOOR_UPDATE_NICO_REQUEST = 2599;

        public static readonly short CHANNEL_FLOOR_UPDATE_NICO_RESULT = 2600;

        public static readonly short CHANNEL_FLOOR_UPDATE_MOYA_REQUEST = 2604;

        public static readonly short CHANNEL_FLOOR_UPDATE_MOYA_RESULT = 2605;

        public static readonly short CHANNEL_FLOOR_UPDATE_FAN_REQUEST = 2602;

        public static readonly short CHANNEL_FLOOR_UPDATE_FAN_RESULT = 2603;

        public static readonly short CHANNEL_FLOOR_TUTORIAL = 2614;

        public static readonly short CHANNEL_FLOOR_TUTORIAL_END = 2613;

        public static readonly short CHANNEL_FLOOR_UPDATE_BOOTH_STATE_REQUEST = 24579;

        public static readonly short CHANNEL_FLOOR_UPDATE_BOOTH_STATE_RESULT = 2596;

        public static readonly short CHANNEL_FLOOR_UPDATE_PROGRAM_REQUEST = 24836;

        public static readonly short CHANNEL_FLOOR_UPDATE_PROGRAM_RESULT = 2597;

        public static readonly short CHANNEL_FLOOR_NOTIFY_SKIP_PROGRAM = 24835;

        public static readonly short CHANNEL_FLOOR_PLAYER_INFO_REQUEST = 2611;

        public static readonly short CHANNEL_FLOOR_PLAYER_INFO_RESULT = 2612;

        public static readonly short CHANNEL_FLOOR_UPDATE_PLAYLIST_REQUEST = 2624;

        public static readonly short CHANNEL_FLOOR_UPDATE_PLAYLIST_RESULT = 2625;

        public static readonly short CHANNEL_FLOOR_NEXT_PROGRAM_REQUEST = 2626;

        public static readonly short CHANNEL_FLOOR_NEXT_PROGRAM_RESULT = 2627;

        public static readonly short CHANNEL_FLOOR_ROOM_HISTORY_REQUEST = 24837;

        public static readonly short CHANNEL_FLOOR_ROOM_HISTORY_RESULT = 24838;

        public static readonly short CHANNEL_PARTY_AVATAR_DATA_REQUEST = 25089;

        public static readonly short CHANNEL_PARTY_AVATAR_DATA_RESULT = 25090;

        public static readonly short CHANNEL_PARTY_SYNC_REQUEST = 25091;

        public static readonly short CHANNEL_PARTY_SYNC_CLEAR_REQUEST = 1028;

        public static readonly short CHANNEL_PARTY_SYNC_RESULT = 25092;

        public static readonly short CHANNEL_PARTY_ENTER_ROOM = 25093;

        public static readonly short CHANNEL_PARTY_UPDATE_PROGRAM_REQUEST = 2628;

        public static readonly short CHANNEL_PARTY_UPDATE_PROGRAM_RESULT = 2629;

        public static readonly short CHANNEL_PARTY_UPDATE_BOOTH_STATUS_REQUEST = 2632;

        public static readonly short CHANNEL_PARTY_UPDATE_BOOTH_STATUS_RESULT = 2633;

        public static readonly short CHANNEL_PARTY_UPDATE_PLAYLIST_REQUEST = 2641;

        public static readonly short CHANNEL_PARTY_UPDATE_PLAYLIST_RESULT = 2642;

        public static readonly short CHANNEL_PARTY_NOTIFY_SKIP_PROGRAM = 2657;

        public static readonly short CHANNEL_PARTY_UPDATE_NICO_REQUEST = 2659;

        public static readonly short CHANNEL_PARTY_UPDATE_NICO_RESULT = 2660;

        public static readonly short CHANNEL_PARTY_UPDATE_MOYA_REQUEST = 0;

        public static readonly short CHANNEL_PARTY_UPDATE_MOYA_RESULT = 0;

        public static readonly short CHANNEL_PARTY_GET_BOOTHCATALOG_REQUEST = 2661;

        public static readonly short CHANNEL_PARTY_GET_BOOTHCATALOG_RESULT = 2662;

        public static readonly short CHANNEL_PARTY_UPDATE_SELECT_BOOTH_REQUEST = 2663;

        public static readonly short CHANNEL_PARTY_UPDATE_SELECT_BOOTH_RESULT = 2664;

        public static readonly short CHANNEL_PARTY_NEXT_PROGRAM_REQUEST = 2673;

        public static readonly short CHANNEL_PARTY_NEXT_PROGRAM_RESULT = 2674;

        public static readonly short CHANNEL_PARTY_FORCE_MOVE_REQUEST = 2665;

        public static readonly short CHANNEL_PARTY_FORCE_MOVE_RESULT = 2672;

        public static readonly short CHANNEL_PARTY_FORCE_CLOSE_RESULT = 2677;

        public static readonly short CHANNEL_PARTY_REMOVE_FURNITURE = 2675;

        public static readonly short SEND_PENALTY_WEAK = 266;

        public static readonly short SEND_PENALTY_MIDDLE = 267;

        public static readonly short SEND_PENALTY_STRONG = 268;

        public static readonly short SEND_PENALTY_RESULT = 271;

        public static readonly short RECEIVE_PENALTY_RESULT = 272;

        public static readonly short ENTER_ROOM_CHECK_RESULT = 278;

        public static readonly short CREATE_GARDEN = 827;

        public static readonly short CREATE_GARDEN_RESULT = 828;

        public static readonly short FLASH_OVERREACTION_RESULT = 1046;

        public static readonly short ROOM_LOGIC_SET_MOVE = 2817;

        public static readonly short ROOM_LOGIC_SET_MOVE_RESULT = 2818;

        public static readonly short ROOM_LOGIC_SET_MOVE_BROADCAST = 2819;

        public static readonly short ROOM_LOGIC_GET_MOVE = 2820;

        public static readonly short ROOM_LOGIC_GET_MOVE_RESULT = 2821;

        public static readonly short ROOM_LOGIC_SET_MOVE_AND_TIME = 2822;

        public static readonly short ROOM_LOGIC_SET_MOVE_AND_TIME_RESULT = 2823;

        public static readonly short ROOM_LOGIC_SET_MOVE_AND_TIME_BROADCAST = 2824;

        public static readonly short ROOM_LOGIC_UPDATE_MOVE_AND_TIME = 2825;

        public static readonly short ROOM_LOGIC_UPDATE_MOVE_AND_TIME_RESULT = 2826;

        public static readonly short ROOM_LOGIC_UPDATE_MOVE_AND_TIME_BROADCAST = 2827;

        public static readonly short ROOM_LOGIC_GET_MOVE_AND_TIME = 2828;

        public static readonly short ROOM_LOGIC_GET_MOVE_AND_TIME_RESULT = 2829;

        public static readonly short UPDATE_FRIEND_REQUESTABLE = 3120;

        public static readonly short LIST_FRIEND_REQUESTABLE = 3121;

        public static readonly short LIST_FRIEND_REQUESTABLE_RESULT = 3122;

        public static readonly short FRIEND_ALLOW_UPDATE = 3124;

        public static readonly short CHECK_RESTORE_STORAGE_ARCHIVE = 3328;

        public static readonly short CHECK_RESTORE_STORAGE_ARCHIVE_RESULT = 3329;

        public static readonly short RESTORE_STORAGE_ARCHIVE = 3330;

        public static readonly short RESTORE_STORAGE_ARCHIVE_RESULT = 3331;

        public static readonly short RE_ENTER_ROOM_AFTER_STORAGE_ARCHIVE = 3332;

        public static readonly short SAVE_STORAGE_ARCHIVE = 3333;

        public static readonly short SAVE_STORAGE_ARCHIVE_RESULT = 3334;

        public static readonly short RESTORE_STORAGE_WITH_MANNEQUIN_RESULT = 3335;

        public static readonly short START_FEED = 3840;

        public static readonly short START_FEED_RESULT = 3841;

        public static readonly short FINISH_FEED = 3842;

        public static readonly short FINISH_FEED_RESULT = 3843;

        public static readonly short START_MAKEUP = 9472;

        public static readonly short START_MAKEUP_RESULT = 9473;

        public static readonly short FINISH_MAKEUP = 9474;

        public static readonly short FINISH_MAKEUP_RESULT = 9475;

        public static readonly short CHECK_PLACE_COSMETIC_ITEM = 9482;

        public static readonly short CHECK_PLACE_COSMETIC_ITEM_RESULT = 9483;

        public static readonly short PLACE_COSMETIC_ITEM = 9476;

        public static readonly short PLACE_COSMETIC_ITEM_RESULT = 9477;

        public static readonly short MOVE_COSMETIC_ITEM = 9478;

        public static readonly short MOVE_COSMETIC_ITEM_RESULT = 9479;

        public static readonly short REMOVE_COSMETIC_ITEM = 9480;

        public static readonly short REMOVE_COSMETIC_ITEM_RESULT = 9481;

        public static readonly short MENKO_NOTE_RESULT = 9728;

        public static readonly short PPOINT_CLEAR_CONDITION_CHAT_RESULT = 9984;

        public static readonly short CLEAR_TRAINING_CHAT = 10000;

        public static readonly short GET_CHAT_TICKET_DATA_RESULT = 4113;

        public static readonly short CHECK_AREA_GAME = 12288;

        public static readonly short CHECK_AREA_GAME_RESULT = 12289;

        public static readonly short AREA_GAME_JOIN = 12290;

        public static readonly short AREA_GAME_JOIN_RESULT = 12291;

        public static readonly short AREA_GAME_LEAVE = 12292;

        public static readonly short AREA_GAME_LEAVE_RESULT = 12293;

        public static readonly short AREA_GAME_PLAY = 12294;

        public static readonly short AREA_GAME_PLAY_RESULT = 12295;

        public static readonly short AREA_GAME_FIELD = 12296;

        public static readonly short AREA_GAME_FIELD_RESULT = 12297;

        public static readonly short AMEBA_SOCIAL_MAINTENANCE_RESULT = 21760;

        public static readonly short GET_CHAT_RANDOM_DROP_RESULT = 4352;

        public static readonly short GET_FRONT_CHAT_DATA = 28674;

        public static readonly short GET_FRONT_CHAT_DATA_RESULT = 28675;

        public static readonly short SET_FRONT_CHAT_DATA = 28672;

        public static readonly short SET_FRONT_CHAT_DATA_RESULT = 28673;

        public static readonly short SET_FRONT_CHAT_DATA_BLOADCAST = 28676;

        public static readonly short PLAY_NYANCATCH = 29184;

        public static readonly short PLAY_NYANCATCH_RESULT = 29185;

        public static readonly short LEAVE_NYANCATCH_FIELD = 29186;

        public static readonly short LEAVE_NYANCATCH_FIELD_RESULT = 29187;

        public static readonly short ENCOUNTER_NYANCATCH_FIELD_CAT = 29188;

        public static readonly short ENCOUNTER_NYANCATCH_FIELD_CAT_RESULT = 29189;

        public static readonly short REMOVE_AND_ADD_NYANCATCH_FIELD_CAT = 29190;

        public static readonly short REMOVE_AND_ADD_NYANCATCH_FIELD_CAT_RESULT = 29191;

        public static readonly short CONTINUE_NYANCATCH_FIELD = 29192;

        public static readonly short CONTINUE_NYANCATCH_FIELD_RESULT = 29193;

        public static readonly short GET_NYANCATCH_GAME_TABLE_STATUS = 29194;

        public static readonly short GET_NYANCATCH_GAME_TABLE_STATUS_RESULT = 29195;

        public static readonly short USE_NYANCATCH_BATTLE_ITEM_OR_SKILL = 29196;

        public static readonly short USE_NYANCATCH_BATTLE_ITEM_OR_SKILL_RESULT = 29197;

        public static readonly short CATCH_NYANCATCH_BATTLE_CAT = 29198;

        public static readonly short CATCH_NYANCATCH_BATTLE_CAT_RESULT = 29199;

        public static readonly short LEAVE_NYANCATCH_BATTLE = 29200;

        public static readonly short LEAVE_NYANCATCH_BATTLE_RESULT = 29201;

        public static readonly short ESCAPE_NYANCATCH_BATTLE_CAT = 29202;

        public static readonly short ESCAPE_NYANCATCH_BATTLE_CAT_RESULT = 29203;

        public static readonly short CONTINUE_NYANCATCH_BATTLE = 29204;

        public static readonly short CONTINUE_NYANCATCH_BATTLE_RESULT = 29205;

        public static readonly short NYANCORIUM_ADD_NYANCATCHCAT_BROADCAST = 848;

        public static readonly short NYANCORIUM_REMOVE_NYANCATCHCAT_BROADCAST = 849;

        public static readonly short NYANCORIUM_INIT = 850;

        public static readonly short NYANCORIUM_INIT_RESULT = 851;

        public static readonly short NYANCORIUM_ADD_NYANCATCHCAT = 852;

        public static readonly short NYANCORIUM_ADD_NYANCATCHCAT_RESULT = 853;

        public static readonly short NYANCORIUM_REMOVE_NYANCATCHCAT = 854;

        public static readonly short NYANCORIUM_REMOVE_NYANCATCHCAT_RESULT = 855;

        public static readonly short NYANCORIUM_EMPTY = 856;

        public static readonly short NYANCORIUM_EMPTY_RESULT = 857;

        public static readonly short NYANCORIUM_SHOW = 858;

        public static readonly short NYANCORIUM_SHOW_RESULT = 859;
    }
}
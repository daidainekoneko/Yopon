namespace Yopon.Pigg.Command
{
    public sealed class InfoMethod
    {
        /*
         * 正規表現による置換
         * 置換前: public static const (.*?):int = ([\d-]*?);
         * 置換後: public static readonly short $1 = $2;
         *
         * 最終更新日: 2017/07/09
         */

        public static readonly short ERROR = -255;

        public static readonly short NOTIFICATION = 144;

        public static readonly short ALERT_RESULT = 149;

        public static readonly short MAINTENANCE_RESULT = 146;

        public static readonly short FLASH_EOS_NOTIFICATION = 150;

        public static readonly short GET_SERVER_TIME = 147;

        public static readonly short GET_SERVER_TIME_RESULT = 148;

        public static readonly short CONF_NOTIFICATION = 149;

        public static readonly short PROCEED_TUTORIAL = 154;

        public static readonly short PROCEED_TUTORIAL_RESULT = 155;

        public static readonly short LOGIN = 256;

        public static readonly short LOGIN_RESULT = 257;

        public static readonly short CHECK_ANNOUNCE = 258;

        public static readonly short MUST_READ_RULES = 259;

        public static readonly short CREATE_USER = 272;

        public static readonly short CREATE_USER_RESULT = 273;

        public static readonly short START_CREATE_USER = 274;

        public static readonly short START_CREATE_USER_RESULT = 275;

        public static readonly short CREATE_PIGG_STEP = 276;

        public static readonly short GET_CONFLICTED_PIGG = 280;

        public static readonly short GET_CONFLICTED_PIGG_RESULT = 281;

        public static readonly short APPLY_CONFLICTED_PIGG = 282;

        public static readonly short APPLY_CONFLICTED_PIGG_RESULT = 283;

        public static readonly short GET_USER_BODY = 288;

        public static readonly short GET_USER_BODY_RESULT = 289;

        public static readonly short UPDATE_USER_BODY = 290;

        public static readonly short UPDATE_PROFILE_IMAGE = 291;

        public static readonly short UPDATE_PROFILE_IMAGE_RESULT = 292;

        public static readonly short GET_AVATAR_VIEW_LIST = 293;

        public static readonly short GET_AVATAR_VIEW_LIST_RESULT = 294;

        public static readonly short SEARCH_FRIEND_ID = 304;

        public static readonly short SEARCH_FRIEND_ID_RESULT = 305;

        public static readonly short SEARCH_FRIEND_NICKNAME = 306;

        public static readonly short SEARCH_FRIEND_NICKNAME_RESULT = 307;

        public static readonly short SEARCH_FRIEND_AMEMBER = 308;

        public static readonly short SEARCH_FRIEND_AMEMBER_RESULT = 309;

        public static readonly short SEARCH_FRIEND_NOW = 310;

        public static readonly short SEARCH_FRIEND_NOW_RESULT = 311;

        public static readonly short SEARCH_FRIEND_RECOMMEND = 312;

        public static readonly short SEARCH_FRIEND_RECOMMEND_RESULT = 313;

        public static readonly short GET_USER_PROFILE = 320;

        public static readonly short GET_USER_PROFILE_RESULT = 321;

        public static readonly short UPDATE_POINT_RESULT = 336;

        public static readonly short UPDATE_CONFIG_RESULT = 345;

        public static readonly short GET_CONFIG = 352;

        public static readonly short GET_CONFIG_RESULT = 353;

        public static readonly short UPDATE_CONFIG = 354;

        public static readonly short LIST_USER_ITEM = 512;

        public static readonly short LIST_USER_ITEM_RESULT = 513;

        public static readonly short DRESSUP = 528;

        public static readonly short DRESSUP_RESULT = 529;

        public static readonly short GET_MANNEQUIN_DETAIL = 550;

        public static readonly short GET_MANNEQUIN_DETAIL_RESULT = 551;

        public static readonly short GET_AREA_MANNEQUIN_DETAIL = 554;

        public static readonly short GET_AREA_MANNEQUIN_DETAIL_RESULT = 555;

        public static readonly short DRESSUP_MANNEQUIN = 546;

        public static readonly short DRESSUP_MANNEQUIN_RESULT = 547;

        public static readonly short LIST_USER_MANNEQUIN = 548;

        public static readonly short LIST_USER_MANNEQUIN_RESULT = 549;

        public static readonly short SWAP_MANNEQUIN = 552;

        public static readonly short SWAP_MANNEQUIN_RESULT = 553;

        public static readonly short OPEN_DRESSUP_MANNEQUIN = 556;

        public static readonly short OPEN_DRESSUP_MANNEQUIN_RESULT = 557;

        public static readonly short REQUEST_FRIENDSHIP = 768;

        public static readonly short APPROVE_FRIENDSHIP = 769;

        public static readonly short DELETE_FRIENDSHIP = 770;

        public static readonly short CANCEL_FRIENDSHIP = 771;

        public static readonly short APPROVE_FRIENDSHIP_RESULT = 772;

        public static readonly short REQUEST_FRIENDSHIP_RESULT = 773;

        public static readonly short DELETE_FRIENDSHIP_RESULT = 774;

        public static readonly short CANCEL_FRIENDSHIP_RESULT = 775;

        public static readonly short CHECK_FRIENDSHIP_REQUESTABLE = 776;

        public static readonly short CHECK_FRIENDSHIP_REQUESTABLE_RESULT = 777;

        public static readonly short LIST_FRIEND = 784;

        public static readonly short LIST_FRIEND_RESULT = 785;

        public static readonly short LIST_FRIENDSHIP_REQUEST = 786;

        public static readonly short LIST_FRIENDSHIP_REQUEST_RESULT = 787;

        public static readonly short LIST_CONNECTION_OTHERS = 788;

        public static readonly short LIST_CONNECTION_OTHERS_RESULT = 789;

        public static readonly short LIST_GIFT_HISTORY_REQUEST = 790;

        public static readonly short LIST_GIFT_HISTORY_RESULT = 791;

        public static readonly short NOTIFY_FRIEND_STATUS = 800;

        public static readonly short ADD_FAVORITE = 24576;

        public static readonly short ADD_FAVORITE_RESULT = 24577;

        public static readonly short REMOVE_FAVORITE = 24578;

        public static readonly short REMOVE_FAVORITE_RESULT = 24579;

        public static readonly short LIST_FAVORITE = 24580;

        public static readonly short LIST_FAVORITE_RESULT = 24581;

        public static readonly short ADD_MUTE_FAVORITE = 24582;

        public static readonly short ADD_MUTE_FAVORITE_RESULT = 24583;

        public static readonly short REMOVE_MUTE_FAVORITE = 24584;

        public static readonly short REMOVE_MUTE_FAVORITE_RESULT = 24585;

        public static readonly short REMOVE_OTHER_FAVORITE = 24592;

        public static readonly short REMOVE_OTHER_FAVORITE_RESULT = 24593;

        public static readonly short SEND_MESSAGE = 1024;

        public static readonly short SEND_MESSAGE_RESULT = 1025;

        public static readonly short RECEIVE_MESSAGE = 1026;

        public static readonly short NOTIFY_RECEIVED_MESSAGE = 1027;

        public static readonly short SEND_ARCHIVE_MESSAGE = 1040;

        public static readonly short SEND_ARCHIVE_MESSAGE_RESULT = 1044;

        public static readonly short LIST_ARCHIVE_MESSAGE = 1041;

        public static readonly short LIST_ARCHIVE_MESSAGE_RESULT = 1042;

        public static readonly short DELETE_ARCHIVE_MESSAGE = 1043;

        public static readonly short CHECK_BAN_WORD = 5633;

        public static readonly short CHECK_BAN_WORD_RESULT = 5634;

        public static readonly short CHECK_ZONING_ARCHIVE_MESSAGE = 357;

        public static readonly short CHECK_ZONING_ARCHIVE_MESSAGE_RESULT = 358;

        public static readonly short MAMA_CREATE = 1028;

        public static readonly short MAMA_CREATE_RESULT = 1029;

        public static readonly short LIST_AREA = 1280;

        public static readonly short LIST_AREA_RESULT = 1281;

        public static readonly short TRAVEL_AREA = 1282;

        public static readonly short TRAVEL_AREA_RESULT = 1283;

        public static readonly short GET_AREA = 1296;

        public static readonly short GET_AREA_RESULT = 1297;

        public static readonly short GET_USER_AREA = 1298;

        public static readonly short GET_USER_AREA_RESULT = 1299;

        public static readonly short DISPATCH_AREA = 1319;

        public static readonly short DISPATCH_AREA_RESULT = 1320;

        public static readonly short VISIT_RANDOM_USER_AREA = 1330;

        public static readonly short VISIT_RANDOM_USER_AREA_RESULT = 1331;

        public static readonly short GET_RANDOM_SELECT_AREA = 1321;

        public static readonly short GET_RANDOM_SELECT_AREA_RESULT = 1322;

        public static readonly short NOTIFY_USER_ROOM_ENTERED = 1312;

        public static readonly short LIST_AREA_BUNDLE = 1313;

        public static readonly short LIST_AREA_BUNDLE_RESULT = 1314;

        public static readonly short TRAVEL_BUNDLE = 1317;

        public static readonly short TRAVEL_BUNDLE_RESULT = 1318;

        public static readonly short LIST_AREA_TOP = 1315;

        public static readonly short LIST_AREA_TOP_RESULT = 1316;

        public static readonly short LIST_SPEAKAREA = 1344;

        public static readonly short LIST_SPEAKAREA_RESULT = 1345;

        public static readonly short LIST_SPEAKLOG = 1346;

        public static readonly short LIST_SPEAKLOG_RESULT = 1347;

        public static readonly short LIST_SPEAKUSER = 1348;

        public static readonly short LIST_SPEAKUSER_RESULT = 1349;

        public static readonly short RESERVE_SPEAKAREA = 1354;

        public static readonly short RESERVE_SPEAKAREA_RESULT = 1355;

        public static readonly short CANCEL_SPEAKAREA = 1356;

        public static readonly short CANCEL_SPEAKAREA_RESULT = 1357;

        public static readonly short CANCEL_RESERVE_AREA = 1358;

        public static readonly short CANCEL_RESERVE_AREA_RESULT = 1359;

        public static readonly short ADD_FAVORITE_AREA = 1350;

        public static readonly short ADD_FAVORITE_AREA_RESULT = 1351;

        public static readonly short REMOVE_FAVORITE_AREA = 1352;

        public static readonly short REMOVE_FAVORITE_AREA_RESULT = 1353;

        public static readonly short LOGIN_ENTER_QUEUE_START = 21505;

        public static readonly short GET_SHOP = 1360;

        public static readonly short GET_SHOP_RESULT = 1361;

        public static readonly short GET_ROOM_EXPANSION_SHOP = 1362;

        public static readonly short GET_ROOM_EXPANSION_SHOP_RESULT = 1363;

        public static readonly short GET_ROOM_ADDITION_SHOP = 1364;

        public static readonly short GET_ROOM_ADDITION_SHOP_RESULT = 1365;

        public static readonly short BUY_SHOP_ITEM = 1376;

        public static readonly short BUY_SHOP_ITEM_RESULT = 1377;

        public static readonly short GET_GIFT_SHOP_DETAIL = 1392;

        public static readonly short GET_GIFT_SHOP_DETAIL_RESULT = 1393;

        public static readonly short BUY_GIFT_ITEM = 1394;

        public static readonly short BUY_GIFT_ITEM_RESULT = 1395;

        public static readonly short INFO_QUEST_UPDATE_FIELD_STATUS = 1408;

        public static readonly short GET_SHOP_FURNITURE_DETAIL = 1378;

        public static readonly short GET_SHOP_FURNITURE_DETAIL_RESULT = 1379;

        public static readonly short GET_SHOP_BANNER = 1380;

        public static readonly short GET_SHOP_BANNER_RESULT = 1381;

        public static readonly short GET_SPEND_CAMPAIGN_ADS = 1488;

        public static readonly short GET_SPEND_CAMPAIGN_ADS_RESULT = 1489;

        public static readonly short PUSH_SPEND_CAMPAIGN_PAYMENT_RESULT = 1490;

        public static readonly short CHECK_SHOPPING_RELAY = 1520;

        public static readonly short CHECK_SHOPPING_RELAY_RESULT = 1521;

        public static readonly short GET_SALE_SHOP = 1408;

        public static readonly short GET_SALE_SHOP_RESULT = 1409;

        public static readonly short BUY_SALE_SHOP_ITEM = 1410;

        public static readonly short BUY_SALE_SHOP_ITEM_RESULT = 1411;

        public static readonly short GET_SALE_ANNOUNCE = 1412;

        public static readonly short GET_SALE_ANNOUNCE_RESULT = 1413;

        public static readonly short GET_SALE_POYON = 1414;

        public static readonly short GET_SALE_POYON_RESULT = 1415;

        public static readonly short GET_SALE_SHOP_REMAIN_INFO = 1418;

        public static readonly short GET_SALE_SHOP_REMAIN_INFO_RESULT = 1419;

        public static readonly short GET_SALE_SHOP_FURNITURE_DETAIL = 1416;

        public static readonly short GET_SALE_SHOP_FURNITURE_DETAIL_RESULT = 1417;

        public static readonly short GET_MULTIPLE_SHOP = 1424;

        public static readonly short GET_MULTIPLE_SHOP_RESULT = 1425;

        public static readonly short GET_MULTIPLE_SHOP_FURNITURE_DETAIL = 1426;

        public static readonly short GET_SHOP_COSME_DETAIL = 1427;

        public static readonly short GET_SHOP_COSME_DETAIL_RESULT = 1428;

        public static readonly short GET_BEGINNER_SHOP_COSME_DETAIL = 1429;

        public static readonly short GET_BEGINNER_SHOP_COSME_DETAIL_RESULT = 1430;

        public static readonly short GET_RENTAL_SHOP = 1504;

        public static readonly short GET_RENTAL_SHOP_RESULT = 1505;

        public static readonly short BUY_RENTAL_SHOP_ITEM = 1506;

        public static readonly short BUY_RENTAL_SHOP_ITEM_RESULT = 1507;

        public static readonly short GET_VIP_ANNOUNCE_EVENT = 1450;

        public static readonly short GET_VIP_ANNOUNCE_EVENT_RESULT = 1451;

        public static readonly short GET_VIP_NOTIFICATION = 1440;

        public static readonly short GET_VIP_NOTIFICATION_RESULT = 1441;

        public static readonly short GET_VIP_COUNT_INFO = 1442;

        public static readonly short GET_VIP_COUNT_INFO_RESULT = 1443;

        public static readonly short GET_VIP_SHOP = 1444;

        public static readonly short GET_VIP_SHOP_RESULT = 1445;

        public static readonly short BUY_VIP_SHOP_ITEM = 1446;

        public static readonly short BUY_VIP_SHOP_ITEM_RESULT = 1447;

        public static readonly short GET_VIP_SHOP_FURNITURE_DETAIL = 1448;

        public static readonly short GET_VIP_SHOP_FURNITURE_DETAIL_RESULT = 1449;

        public static readonly short GET_VIP_AREA_ERROR_INFO = 1472;

        public static readonly short GET_VIP_AREA_ERROR_INFO_RESULT = 1473;

        public static readonly short LIST_USER_FURNITURE = 1536;

        public static readonly short LIST_USER_FURNITURE_RESULT = 1537;

        public static readonly short LIST_ADMIN_FURNITURE = 1538;

        public static readonly short LIST_ADMIN_FURNITURE_RESULT = 1539;

        public static readonly short GET_FURNITURE_DETAIL = 1552;

        public static readonly short GET_FURNITURE_DETAIL_RESULT = 1553;

        public static readonly short TRASH_ITEM = 1808;

        public static readonly short TRASH_ITEM_RESULT = 1809;

        public static readonly short GET_SCRACTH = 2048;

        public static readonly short GET_SCRACH_RESULT = 2049;

        public static readonly short LIST_SCRATCH = 2050;

        public static readonly short LIST_SCRATCH_RESULT = 2051;

        public static readonly short CHOOSE_SCRATCH = 2052;

        public static readonly short OPEN_SCRATCH = 2064;

        public static readonly short OPEN_SCRATCH_RESULT = 2065;

        public static readonly short GET_FORTUNE = 2066;

        public static readonly short GET_FORTUNE_RESULT = 2067;

        public static readonly short GET_GAME_LOGIN_INCENTIVE = 2068;

        public static readonly short GET_GAME_LOGIN_INCENTIVE_RESULT = 2069;

        public static readonly short LIST_GOOD = 2305;

        public static readonly short LIST_GOOD_RESULT = 2306;

        public static readonly short START_GOOD_FEVER_RESULT = 2307;

        public static readonly short END_GOOD_FEVER_RESULT = 2308;

        public static readonly short LIST_ACTION = 4097;

        public static readonly short LIST_ACTION_RESULT = 4098;

        public static readonly short UPDATE_ACTION = 4099;

        public static readonly short FLASH_OVERREACTION_RESULT = 4100;

        public static readonly short LEAVE_FOOTPRINT = 4352;

        public static readonly short LEAVE_FOOTPRINT_RESULT = 4353;

        public static readonly short LIST_FOOTPRINT = 4354;

        public static readonly short LIST_FOOTPRINT_RESULT = 4355;

        public static readonly short LIST_ANNOUNCE_RESULT = 4136;

        public static readonly short LIST_ANNOUNCE_EVENT_RESULT = 4144;

        public static readonly short NOTIFY_ANNOUNCE_EVENT = 4145;

        public static readonly short NOTIFY_ANNOUNCE_EVENT_RESULT = 4146;

        public static readonly short GET_ANNOUNCE_DOKAN_INFO = 4152;

        public static readonly short GET_ANNOUNCE_DOKAN_INFO_RESULT = 4153;

        public static readonly short LIST_ANNOUNCE_QUEST_RESULT = 18176;

        public static readonly short UPDATE_QUEST_STATUS_START = 18177;

        public static readonly short UPDATE_QUEST_STATUS_CHECK_CLEAR = 18178;

        public static readonly short LIST_CALENDAR = 4147;

        public static readonly short LIST_CALENDAR_RESULT = 4148;

        public static readonly short LIST_ANNOUNCE_FIRST_DAY_RESULT = 4149;

        public static readonly short NOTIFY_ANNOUNCE_FIRST_DAY = 4150;

        public static readonly short NOTIFY_ANNOUNCE_FIRST_DAY_RESULT = 4151;

        public static readonly short LIST_LINK_RESULT = 4137;

        public static readonly short CREATE_CLUB = 4608;

        public static readonly short CREATE_CLUB_RESULT = 4609;

        public static readonly short LIST_CLUB_MEMBER = 4610;

        public static readonly short LIST_CLUB_MEMBER_RESULT = 4611;

        public static readonly short GET_CLUB_CARD = 4614;

        public static readonly short GET_CLUB_CARD_RESULT = 4615;

        public static readonly short UPDATE_CLUB_CONFIG = 4616;

        public static readonly short UPDATE_CLUB_CONFIG_RESULT = 4617;

        public static readonly short UPDATE_CLUB_USER_TYPE = 4624;

        public static readonly short UPDATE_CLUB_USER_TYPE_RESULT = 4625;

        public static readonly short REMOVE_CLUB_USER = 4626;

        public static readonly short REMOVE_CLUB_USER_RESULT = 4627;

        public static readonly short LIST_CLUB = 4628;

        public static readonly short LIST_CLUB_RESULT = 4629;

        public static readonly short REQUEST_CLUB_JOIN = 4630;

        public static readonly short REQUEST_CLUB_JOIN_RESULT = 4631;

        public static readonly short ADD_CLUB_MEMBER = 4632;

        public static readonly short ADD_CLUB_MEMBER_RESULT = 4633;

        public static readonly short INVITE_CLUB_MEMBER = 4640;

        public static readonly short INVITE_CLUB_MEMBER_RESULT = 4641;

        public static readonly short LIST_CLUB_INFO = 4642;

        public static readonly short LIST_CLUB_INFO_RESULT = 4643;

        public static readonly short CLUB_CONFIG = 4644;

        public static readonly short CLUB_CONFIG_RESULT = 4645;

        public static readonly short GET_EMBLEM = 4646;

        public static readonly short GET_EMBLEM_RESULT = 4647;

        public static readonly short NOTIFY_CLUB_ROOM_ENTERED = 4648;

        public static readonly short CLUB_MESSAGE = 4649;

        public static readonly short CLUB_MESSAGE_RESULT = 4656;

        public static readonly short ADD_CLUB_MESSAGE = 4657;

        public static readonly short REMOVE_CLUB_MESSAGE = 4658;

        public static readonly short CLUB_SEARCH = 4659;

        public static readonly short CLUB_SEARCH_RESULT = 4660;

        public static readonly short LIST_CLUB_MEMBER_WAIT = 4661;

        public static readonly short LIST_CLUB_MEMBER_WAIT_RESULT = 4662;

        public static readonly short LIST_CLUB_CATEGORY = 4663;

        public static readonly short LIST_CLUB_CATEGORY_RESULT = 4664;

        public static readonly short LIST_CLUB_REQUEST = 4665;

        public static readonly short LIST_CLUB_REQUEST_RESULT = 4672;

        public static readonly short REJECT_MEMBER = 4673;

        public static readonly short REJECT_MEMBER_RESULT = 4674;

        public static readonly short CLUB_VISITED = 1540;

        public static readonly short CLUB_MESSAGE_UP = 1541;

        public static readonly short LIST_CLUB_CONTRIBUTION = 4681;

        public static readonly short LIST_CLUB_CONTRIBUTION_RESULT = 4682;

        public static readonly short LIST_PET = 4865;

        public static readonly short LIST_PET_RESULT = 4866;

        public static readonly short BUY_PET = 4867;

        public static readonly short BUY_PET_RESULT = 4868;

        public static readonly short RELEASE_PET = 4869;

        public static readonly short RELEASE_PET_RESULT = 4870;

        public static readonly short GET_PET_PROFILE = 4871;

        public static readonly short GET_PET_PROFILE_RESULT = 4872;

        public static readonly short SET_PET_PROFILE = 4873;

        public static readonly short SET_PET_PROFILE_RESULT = 4874;

        public static readonly short BUY_PET_CONFIRM = 4875;

        public static readonly short BUY_PET_CONFIRM_RESULT = 4876;

        public static readonly short LIST_USER_ACTION_ITEM = 5121;

        public static readonly short LIST_USER_ACTION_ITEM_RESULT = 5122;

        public static readonly short USE_ACTION_ITEM = 5123;

        public static readonly short USE_ACTION_ITEM_RESULT = 5124;

        public static readonly short UPDATE_CONDITION_RESULT = 5125;

        public static readonly short CANCEL_CONDITION = 5126;

        public static readonly short INVITE_SEND_MAIL = 5377;

        public static readonly short INVITE_SEND_MAIL_RESULT = 5378;

        public static readonly short CHECK_SEND_MAIL = 5379;

        public static readonly short CHECK_SEND_MAIL_RESULT = 5380;

        public static readonly short CHECK_SEND_MAIL_RETURN = 5381;

        public static readonly short CHECK_SEND_MAIL_RETURN_RESULT = 5382;

        public static readonly short GET_USER_INVITE_INFO = 5383;

        public static readonly short GET_USER_INVITE_INFO_RESULT = 5384;

        public static readonly short LIST_USER_INVITE = 5385;

        public static readonly short LIST_USER_INVITE_RESULT = 5392;

        public static readonly short CHECK_INVITE = 5393;

        public static readonly short CHECK_INVITE_RESULT = 5394;

        public static readonly short CHECK_INVITE_MAIL_ADDRESS = 5395;

        public static readonly short CHECK_INVITE_MAIL_ADDRESS_RESULT = 5396;

        public static readonly short GET_USER_INVITE_COUNT = 5397;

        public static readonly short GET_USER_INVITE_COUNT_RESULT = 5398;

        public static readonly short GET_INVITE_INCENTIVE = 5399;

        public static readonly short GET_INVITE_INCENTIVE_RESULT = 5400;

        public static readonly short GET_SELF_INCENTIVE = 5401;

        public static readonly short GET_SELF_INCENTIVE_RESULT = 5408;

        public static readonly short GET_USER_CODE = 355;

        public static readonly short GET_USER_CODE_RESULT = 356;

        public static readonly short LIST_MISSION = 5889;

        public static readonly short LIST_MISSION_RESULT = 5890;

        public static readonly short CHALLENGE_BEGINNER = 5891;

        public static readonly short AREA_GAME_FIELD = 8704;

        public static readonly short AREA_GAME_FIELD_RESULT = 8705;

        public static readonly short GET_GAME_INIT = 6145;

        public static readonly short GET_GAME_INIT_RESULT = 6146;

        public static readonly short GET_GAME_UPDATE = 6147;

        public static readonly short GET_GAME_UPDATE_RESULT = 6148;

        public static readonly short GET_GAME_UPDATE_BY_METHOD = 6149;

        public static readonly short GET_GAME_UPDATE_BY_METHOD_RESULT = 6150;

        public static readonly short GET_MATCHING_GAME_AREA_STATUS = 6151;

        public static readonly short GET_MATCHING_GAME_AREA_STATUS_RESULT = 6152;

        public static readonly short UPDATE_MATCHING_GAME_AREA_STATUS = 6153;

        public static readonly short UPDATE_MATCHING_GAME_AREA_STATUS_RESULT = 6160;

        public static readonly short GET_USER_GAME_HISTORY = 6161;

        public static readonly short GET_USER_GAME_HISTORY_RESULT = 6162;

        public static readonly short GET_GACHA = 6401;

        public static readonly short GET_GACHA_RESULT = 6402;

        public static readonly short PLAY_GACHA = 6403;

        public static readonly short PLAY_GACHA_RESULT = 6404;

        public static readonly short PLAY_GACHA_STEPUP = 6409;

        public static readonly short PLAY_GACHA_STEPUP_RESULT = 6416;

        public static readonly short GET_GACHA_ITEMS_RATE = 6417;

        public static readonly short GET_GACHA_ITEMS_RATE_RESULT = 6418;

        public static readonly short GET_STREAMING_INFO = 8199;

        public static readonly short GET_STREAMING_INFO_RESULT = 8200;

        public static readonly short STREAMING_INTERNAL = 8201;

        public static readonly short SYNC_ENTER_ROOM_AREA_INTERNAL = 8208;

        public static readonly short SYNC_DO_ACTION_AREA_INTERNAL = 8209;

        public static readonly short SYNC_DO_MOVE_AREA_INTERNAL = 8210;

        public static readonly short SYNC_DO_MOVEEND_AREA_INTERNAL = 8211;

        public static readonly short SYNC_DO_TALK_AREA_INTERNAL = 8212;

        public static readonly short GET_WAITING_ROOM = 8213;

        public static readonly short GET_WAITING_ROOM_RESULT = 8214;

        public static readonly short SYNC_LEAVE_USER_AREA_INTERNAL = 8215;

        public static readonly short SYNC_ROOM_ACTION_AREA_INTERNAL = 8216;

        public static readonly short CASINO_ACCEPT_TERM_REQUEST = 8448;

        public static readonly short CASINO_ACCEPT_TERM = 8449;

        public static readonly short CASINO_GET_BALANCE = 8450;

        public static readonly short CASINO_GET_BALANCE_RESULT = 8451;

        public static readonly short CASINO_BUY_POINT_PREPARE = 8452;

        public static readonly short CASINO_BUY_POINT_PREPARE_RESULT = 8453;

        public static readonly short CASINO_BUY_POINT_EXECUTE = 8454;

        public static readonly short CASINO_BUY_POINT_EXECUTE_RESULT = 8455;

        public static readonly short CASINO_FREE_LOT = 8456;

        public static readonly short CASINO_FREE_LOT_RESULT = 8457;

        public static readonly short CASINO_LUCKY_ITEM_RESULT = 8464;

        public static readonly short CASINO_LUCKY_ITEM_SELECT_REQUEST = 8467;

        public static readonly short CASINO_LUCKY_ITEM_SELECT_RESULT = 8468;

        public static readonly short CASINO_POCKET_ITEM_LIST_REQUEST = 8469;

        public static readonly short CASINO_POCKET_ITEM_LIST_RESULT = 8470;

        public static readonly short CASINO_LUCKY_ITEM_AVAILABLE_LIST_REQUEST = 8471;

        public static readonly short CASINO_LUCKY_ITEM_AVAILABLE_LIST_RESULT = 8472;

        public static readonly short CASINO_CUMULATIVE_INCENTIVE_REQUEST = 8473;

        public static readonly short CASINO_CUMULATIVE_INCENTIVE_RESULT = 8480;

        public static readonly short CASINO_CHALLENGE_CHECK_REQUEST = 8481;

        public static readonly short CASINO_SHORT_TERM_CHALLENGE_GIVE_ITEM_RESULT = 8482;

        public static readonly short CASINO_MINNA_TERM_REQUEST = 8483;

        public static readonly short CASINO_MINNA_TERM_RESULT = 8484;

        public static readonly short CASINO_MINNA_PARTICIPATE_REQUEST = 8485;

        public static readonly short CASINO_MINNA_PARTICIPATE_RESULT = 8486;

        public static readonly short CASINO_MINNA_MOVE_PLAYAREA_REQUEST = 8487;

        public static readonly short CASINO_MINNA_MOVE_PLAYAREA_RESULT = 8488;

        public static readonly short CASINO_MINNA_RANK_IN_TEAM_REQUEST = 8489;

        public static readonly short CASINO_MINNA_RANK_IN_TEAM_RESULT = 8496;

        public static readonly short CASINO_MINNA_TEAM_RANK_AROUND5_REQUEST = 8497;

        public static readonly short CASINO_MINNA_TEAM_RANK_AROUND5_RESULT = 8498;

        public static readonly short CASINO_MINNA_TEAM_RANK_TOP5_REQUEST = 8499;

        public static readonly short CASINO_MINNA_TEAM_RANK_TOP5_RESULT = 8500;

        public static readonly short CASINO_MINNA_IS_AVAILABLE_REQUEST = 8501;

        public static readonly short CASINO_MINNA_IS_AVAILABLE_RESULT = 8502;

        public static readonly short CASINO_MINNA_IS_END_RESULT = 8504;

        public static readonly short CASINO_MINNA_RECORD_REQUEST = 8505;

        public static readonly short CASINO_MINNA_RECORD_RESULT = 8512;

        public static readonly short CASINO_MINNA_REMAINING_TIME_REQUEST = 8514;

        public static readonly short CASINO_MINNA_REMAINING_TIME_RESULT = 8515;

        public static readonly short CASINO_INCENTIVE_RESULT = 8516;

        public static readonly short CASINO_MINNA_TOP_REQUEST = 8517;

        public static readonly short CASINO_MINNA_TOP_RESULT = 8518;

        public static readonly short CASINO_MINNA_TEAM_REQUEST = 8519;

        public static readonly short CASINO_MINNA_TEAM_RESULT = 8520;

        public static readonly short CASINO_CHALLENGE_SHOW_MODULE_REQUEST = 8533;

        public static readonly short CASINO_CHALLENGE_SHOW_MODULE_RESULT = 8534;

        public static readonly short CASINO_CHALLENGE_NUM_ITEMS_AND_TIME_REMAIN_REQUEST = 8535;

        public static readonly short CASINO_CHALLENGE_NUM_ITEMS_AND_TIME_REMAIN_RESULT = 8536;

        public static readonly short CASINO_CHALLENGE_NEXT_EARN = 8537;

        public static readonly short CASINO_JEWELRY_WINDOW_TOP_REQUEST = 8538;

        public static readonly short CASINO_JEWELRY_WINDOW_TOP_RESULT = 8539;

        public static readonly short CASINO_JEWELRY_WINDOW_RANKING_REQUEST = 8540;

        public static readonly short CASINO_JEWELRY_WINDOW_RANKING_RESULT = 8541;

        public static readonly short CASINO_JEWELRY_WINDOW_TOP5_REQUEST = 8542;

        public static readonly short CASINO_JEWELRY_WINDOW_TOP5_RESULT = 8543;

        public static readonly short CASINO_JEWELRY_INCENTIVE_REQUEST = 8544;

        public static readonly short CASINO_JEWELRY_SHOW_RANK_WINDOW_RESULT = 8545;

        public static readonly short CASINO_JEWELRY_WINDOW_TOP_GAMEEND_RESULT = 8546;

        public static readonly short CASINO_SLOT_DE_GACHA_SHOW_MODULE_REQUEST = 8561;

        public static readonly short CASINO_SLOT_DE_GACHA_SHOW_MODULE_RESULT = 8562;

        public static readonly short CASINO_SLOT_DE_GATHA_TIME_REMAIN_REQUEST = 8563;

        public static readonly short CASINO_SLOT_DE_GATHA_TIME_REMAIN_RESULT = 8564;

        public static readonly short CASINO_MISSION_MIDDLE_PANEL_REQUEST = 8576;

        public static readonly short CASINO_MISSION_MIDDLE_PANEL_RESULT = 8577;

        public static readonly short CASINO_MISSION_START_PANEL_RESULT = 8578;

        public static readonly short CASINO_MISSION_STATUS_PANEL_REQUEST = 8579;

        public static readonly short CASINO_MISSION_STATUS_PANEL_RESULT = 8580;

        public static readonly short CASINO_MISSION_CLEAR_PANEL_RESULT = 8581;

        public static readonly short CASINO_MISSION_TIME_REMAIN_REQUEST = 8582;

        public static readonly short CASINO_MISSION_TIME_REMAIN_RESULT = 8583;

        public static readonly short CASINO_MISSION_SMALL_MISSION_RESULT = 8584;

        public static readonly short CASINO_SLOT_ROYALE_USERMODULE_TOP_REQUEST = 8585;

        public static readonly short CASINO_SLOT_ROYALE_USERMODULE_TOP_RESULT = 8586;

        public static readonly short CASINO_SLOT_ROYALE_USERMODULE_RANKING_REQUEST = 8587;

        public static readonly short CASINO_SLOT_ROYALE_USERMODULE_RANKING_RESULT = 8588;

        public static readonly short CASINO_SLOT_ROYALE_REMAINTIME_REQUEST = 8589;

        public static readonly short CASINO_SLOT_ROYALE_REMAINTIME_RESULT = 8590;

        public static readonly short CASINO_SLOT_ROYALE_AREAMODULE_CHALLENGE_REQUEST = 8591;

        public static readonly short CASINO_SLOT_ROYALE_AREAMODULE_CHALLENGE_RESULT = 8592;

        public static readonly short CASINO_SLOT_ROYALE_AREAMODULE_RANK_REQUEST = 8593;

        public static readonly short CASINO_SLOT_ROYALE_AREAMODULE_RANK_RESULT = 8594;

        public static readonly short CASINO_SLOT_ROYALE_START_POPUP_RESULT = 8595;

        public static readonly short CASINO_SLOT_ROYALE_PRE_ENTRY_REQUEST = 8596;

        public static readonly short CASINO_SLOT_ROYALE_PRE_ENTRY_RESULT = 8597;

        public static readonly short CASINO_SLOT_ROYALE_PRE_ENTRY_MODULE_RESULT = 8598;

        public static readonly short CASINO_SLOT_ROYALE_JACKPOT_MODULE_REQUEST = 8599;

        public static readonly short CASINO_SLOT_ROYALE_JACKPOT_MODULE_RESULT = 8600;

        public static readonly short CASINO_SLOT_ROYALE_JACKPOT_LAUNCHED_MODULE_RESULT = 8601;

        public static readonly short CASINO_SLOT_ROYALE_BUNDLELIST_REQUEST = 8720;

        public static readonly short CASINO_SLOT_ROYALE_BUNDLELIST_RESULT = 8721;

        public static readonly short DELETE_USER_CASINO_ITEM = 8490;

        public static readonly short DELETE_USER_CASINO_ITEM_RESULT = 8491;

        public static readonly short SEARCH_NOTICE_BOARD_MESSAGE = 8960;

        public static readonly short SEARCH_NOTICE_BOARD_MESSAGE_RESULT = 8961;

        public static readonly short CREATE_NOTICE_BOARD_MESSAGE = 8962;

        public static readonly short CREATE_NOTICE_BOARD_MESSAGE_RESULT = 8963;

        public static readonly short GET_NOTICE_BOARD_MESSAGE = 8964;

        public static readonly short GET_NOTICE_BOARD_MESSAGE_RESULT = 8965;

        public static readonly short UPDATE_NOTICE_BOARD_MESSAGE = 8966;

        public static readonly short UPDATE_NOTICE_BOARD_MESSAGE_RESULT = 8967;

        public static readonly short DELETE_NOTICE_BOARD_MESSAGE = 8968;

        public static readonly short DELETE_NOTICE_BOARD_MESSAGE_RESULT = 8969;

        public static readonly short GET_NOTICE_BOARD_MESSAGE_OF_AREA = 8970;

        public static readonly short GET_NOTICE_BOARD_MESSAGE_OF_AREA_RESULT = 8971;

        public static readonly short LIST_NOTICE_BOARD_MESSAGE_SUMMARY = 8972;

        public static readonly short LIST_NOTICE_BOARD_MESSAGE_SUMMARY_RESULT = 8973;

        public static readonly short AGREE_NOTICE_BOARD_PENALTY = 8974;

        public static readonly short AGREE_NOTICE_BOARD_PENALTY_RESULT = 8975;

        public static readonly short LIKE_NOTICE_BOARD_MESSAGE = 8976;

        public static readonly short LIKE_NOTICE_BOARD_MESSAGE_RESULT = 8977;

        public static readonly short GET_NOTICE_BOARD_RANKING = 8978;

        public static readonly short GET_NOTICE_BOARD_RANKING_RESULT = 8979;

        public static readonly short LIST_NOTICE_BOARD_RANKING = 8980;

        public static readonly short LIST_NOTICE_BOARD_RANKING_RESULT = 8981;

        public static readonly short CHECK_NOTICE_BOARD_RANKING = 8982;

        public static readonly short CHECK_NOTICE_BOARD_RANKING_RESULT = 8983;

        public static readonly short SEND_RECEIVED_APPROVAL = 8984;

        public static readonly short OPEN_NOTICE_BOARD_CREATE_PANEL = 8994;

        public static readonly short OPEN_NOTICE_BOARD_CREATE_PANEL_RESULT = 8995;

        public static readonly short GET_COLLECTION_STATUS = 9984;

        public static readonly short GET_COLLECTION_STATUS_RESULT = 9985;

        public static readonly short RECYCLE_DARATS_DATA = 9986;

        public static readonly short RECYCLE_DARATS_DATA_RESULT = 9987;

        public static readonly short RECYCLE_DARATS_PRIZE_DATA = 6405;

        public static readonly short RECYCLE_DARATS_PRIZE_DATA_RESULT = 6406;

        public static readonly short RECYCLE_DARATS_PRIZE_LIST_DATA = 6407;

        public static readonly short RECYCLE_DARATS_PRIZE_LIST_DATA_RESULT = 6408;

        public static readonly short VOTE_GET = 9216;

        public static readonly short VOTE_GET_RESULT = 9217;

        public static readonly short VOTE_GET_QUESTION = 9218;

        public static readonly short VOTE_GET_QUESTION_RESULT = 9219;

        public static readonly short VOTE_GET_SUMMARY = 9220;

        public static readonly short VOTE_GET_SUMMARY_RESULT = 9221;

        public static readonly short VOTE_SEND = 9222;

        public static readonly short VOTE_SEND_RESULT = 9223;

        public static readonly short VOTE_SEND_IMPRESSION = 9232;

        public static readonly short TREASURE_GET = 9472;

        public static readonly short TREASURE_RESULT = 9473;

        public static readonly short GET_MINITALK_CONFIG = 16384;

        public static readonly short GET_MINITALK_CONFIG_RESULT = 16385;

        public static readonly short CHECK_MINITALK_CONFIG = 16386;

        public static readonly short CHECK_MINITALK_CONFIG_RESULT = 16387;

        public static readonly short SEARCH_MINITALK_BUDDY = 16388;

        public static readonly short SEARCH_MINITALK_BUDDY_RESULT = 16389;

        public static readonly short STOP_MINITALK_SEARCH = 16390;

        public static readonly short STOP_MINITALK_SEARCH_RESULT = 16391;

        public static readonly short START_MINITALK = 16392;

        public static readonly short GET_MINITALK_PROFILE = 16393;

        public static readonly short GET_MINITALK_PROFILE_RESULT = 16400;

        public static readonly short STOP_MINITALK = 16401;

        public static readonly short STOP_MINITALK_RESULT = 16402;

        public static readonly short FINISH_MINITALK = 16403;

        public static readonly short GET_MINITALK_NPC_WORDS = 16404;

        public static readonly short GET_MINITALK_NPC_WORDS_RESULT = 16405;

        public static readonly short FINISH_MINITALK_TO_ROOM = 16406;

        public static readonly short FINISH_MINITALK_TO_ROOM_RESULT = 16407;

        public static readonly short CHECK_MINITALK_FRIENDSHIP_REQUESTABLE = 16408;

        public static readonly short CHECK_MINITALK_FRIENDSHIP_REQUESTABLE_RESULT = 16409;

        public static readonly short CHECK_ADMINMODE = 368;

        public static readonly short CHECK_ADMINMODE_RESULT = 369;

        public static readonly short LIST_GROUPMESSAGE_GROUP = 10241;

        public static readonly short LIST_GROUPMESSAGE_GROUP_RESULT = 10242;

        public static readonly short CREATE_GROUPMESSAGE_GROUP = 10243;

        public static readonly short CREATE_GROUPMESSAGE_GROUP_RESULT = 10244;

        public static readonly short UPDATE_GROUPMESSAGE_GROUP = 10245;

        public static readonly short UPDATE_GROUPMESSAGE_GROUP_RESULT = 10246;

        public static readonly short LIST_GROUPMESSAGE_MEMBER = 10247;

        public static readonly short LIST_GROUPMESSAGE_MEMBER_RESULT = 10248;

        public static readonly short LIST_GROUPMESSAGE_GROUP_MEMBER = 10249;

        public static readonly short LIST_GROUPMESSAGE_GROUP_MEMBER_RESULT = 10250;

        public static readonly short ADD_GROUPMESSAGE_GROUP_MEMBER = 10251;

        public static readonly short ADD_GROUPMESSAGE_GROUP_MEMBER_RESULT = 10252;

        public static readonly short REMOVE_GROUPMESSAGE_GROUP_MEMBER = 10253;

        public static readonly short REMOVE_GROUPMESSAGE_GROUP_MEMBER_RESULT = 10254;

        public static readonly short ADD_GROUPMESSAGE_MESSAGE = 10255;

        public static readonly short ADD_GROUPMESSAGE_MESSAGE_RESULT = 10256;

        public static readonly short LIST_GROUPMESSAGE_MESSAGE = 10257;

        public static readonly short LIST_GROUPMESSAGE_MESSAGE_RESULT = 10258;

        public static readonly short CHECK_GROUPMESSAGE_MESSAGE = 10259;

        public static readonly short BAN_GROUPMESSAGE = 10260;

        public static readonly short CONFIRM_GROUPMESSAGE_ALERT = 10261;

        public static readonly short MENKO_BUNDLE_GET = 10510;

        public static readonly short MENKO_BUNDLE_GET_RESULT = 10511;

        public static readonly short GET_MENKO_GACHA_RESULT = 10513;

        public static readonly short PLAY_MENKO_GACHA = 10514;

        public static readonly short PLAY_MENKO_GACHA_RESULT = 10515;

        public static readonly short MENKO_COLLECTION_GET = 10496;

        public static readonly short MENKO_COLLECTION_GET_RESULT = 10497;

        public static readonly short MENKO_COLLECTION_GET_RESULT_NOTE = 10500;

        public static readonly short GET_MENKO_NOTE = 10498;

        public static readonly short GET_MENKO_NOTE_RESULT = 10499;

        public static readonly short MENKO_TUTORIAL_GET = 10518;

        public static readonly short MENKO_TUTORIAL_GET_RESULT = 10519;

        public static readonly short PLAY_MENKO_TUTORIAL = 10520;

        public static readonly short MENKO_INSENTIVE_GET = 10516;

        public static readonly short MENKO_INSENTIVE_GET_RESULT = 10517;

        public static readonly short CHECK_PIGGDOME_TERM = 8202;

        public static readonly short CHECK_PIGGDOME_TERM_RESULT = 8203;

        public static readonly short AGREE_PIGGDOME_TERM = 8204;

        public static readonly short NOTIFY_MAGAZINE_SEEN = 12544;

        public static readonly short NOTIFY_LUCKY_ICON = 12800;

        public static readonly short GET_LUCKY_CONTENT = 12801;

        public static readonly short GET_LUCKY_CONTENT_RESULT = 12802;

        public static readonly short OPEN_LUCKY_PIECE = 12803;

        public static readonly short OPEN_LUCKY_PIECE_RESULT = 12804;

        public static readonly short GET_LOGIN_INCENTIVE_ICON = 13056;

        public static readonly short GET_LOGIN_INCENTIVE_ICON_RESULT = 13057;

        public static readonly short PROVIDE_LOGIN_INCENTIVE_ITEM = 13058;

        public static readonly short PROVIDE_LOGIN_INCENTIVE_ITEM_RESULT = 13059;

        public static readonly short LIST_CLUB_FURNITURE = 4675;

        public static readonly short LIST_CLUB_FURNITURE_RESULT = 4676;

        public static readonly short CHECK_CONTRIBUTE_CLUB_FURNITURE = 4677;

        public static readonly short CHECK_CONTRIBUTE_CLUB_FURNITURE_RESULT = 4678;

        public static readonly short CONTRIBUTE_CLUB_FURNITURE = 4679;

        public static readonly short CONTRIBUTE_CLUB_FURNITURE_RESULT = 4680;

        public static readonly short NOTIFY_CLUB_CONTRIBUTION = 1542;

        public static readonly short REMODEL_ROOM = 1540;

        public static readonly short REMODEL_ROOM_RESULT = 1541;

        public static readonly short GET_TICKET_SHOP = 13312;

        public static readonly short GET_TICKET_SHOP_RESULT = 13313;

        public static readonly short BUY_TICKET = 13314;

        public static readonly short BUY_TICKET_RESULT = 13315;

        public static readonly short COMMAND_TYPE_DRESSUP = 0;

        public static readonly short COMMAND_TYPE_BODY = 1;

        public static readonly short COMMAND_TYPE_COSME = 2;

        public static readonly short COMMAND_TYPE_INVITE = 3;

        public static readonly short COMMAND_TYPE_SNAPSHOT = 4;

        public static readonly short COMMAND_TYPE_CONTEST = 5;

        public static readonly short COMMAND_TYPE_DIARY = 6;

        public static readonly short CHECK_TWITTER_TOKEN_AVAILABLE = 12288;

        public static readonly short CHECK_TWITTER_TOKEN_AVAILABLE_RESULT = 12289;

        public static readonly short UPDATE_TWITTER_PROFILE_IMAGE = 12290;

        public static readonly short UPDATE_TWITTER_PROFILE_IMAGE_RESULT = 12291;

        public static readonly short SEND_TWITTER_DIRECT_MESSAGE = 17664;

        public static readonly short SEND_TWITTER_DIRECT_MESSAGE_RESULT = 17665;

        public static readonly short RESULT_SUCCESS = 0;

        public static readonly short RESULT_FAILED = 1;

        public static readonly short CHECK_FACEBOOK_TOKEN_AVAILABLE = 17152;

        public static readonly short CHECK_FACEBOOK_TOKEN_AVAILABLE_RESULT = 17153;

        public static readonly short LIST_SNS_FRIEND = 17408;

        public static readonly short LIST_SNS_FRIEND_RESULT = 17409;

        public static readonly short LIST_COSMETIC = 13568;

        public static readonly short LIST_COSMETIC_RESULT = 13569;

        public static readonly short MAKEUP = 13570;

        public static readonly short MAKEUP_RESULT = 13571;

        public static readonly short UPDATE_USER_SWF = 13572;

        public static readonly short GET_RANKING = 13824;

        public static readonly short GET_MAHJONG_RANKING_RESULT = 13825;

        public static readonly short GET_MAHJONG_RANKING_MORE = 13826;

        public static readonly short GET_MAHJONG_RANKING_MORE_RESULT = 13827;

        public static readonly short GET_MAHJONG_USER_RANKING = 13828;

        public static readonly short GET_MAHJONG_USER_RANKING_RESULT = 13829;

        public static readonly short GET_LR_CAMPAIGN = 14336;

        public static readonly short GET_LR_CAMPAIGN_RESULT = 14337;

        public static readonly short GET_LR_CAMPAIGN_QUEST_CLEAR_RESULT = 14338;

        public static readonly short GET_LR_CAMPAIGN_TIME_REMAIN = 14339;

        public static readonly short GET_LR_CAMPAIGN_TIME_REMAIN_RESULT = 14340;

        public static readonly short TAKEOFF_AKIBA_ONLY_ITEM = 544;

        public static readonly short TAKEOFF_AKIBA_ONLY_ITEM_RESULT = 545;

        public static readonly short GET_SNAPSHOT_TOKEN = 16640;

        public static readonly short GET_SNAPSHOT_TOKEN_RESULT = 16641;

        public static readonly short LIST_CHANNEL = 20480;

        public static readonly short LIST_CHANNEL_DATA = 20481;

        public static readonly short LINK_AREA_BUNDLE = 1328;

        public static readonly short LINK_AREA_BUNDLE_RESULT = 1329;

        public static readonly short LIST_CHANNEL_NEWS = 20482;

        public static readonly short LIST_CHANNEL_NEWS_RESULT = 20483;

        public static readonly short VJ_CHANNEL_USER_AREA = 20545;

        public static readonly short VJ_CHANNEL_USER_AREA_RESULT = 20546;

        public static readonly short BRAODCAST_CONFIG__REQUEST = 9728;

        public static readonly short BRAODCAST_CONFIG_RESULT = 9729;

        public static readonly short LIST_CHANNEL_PROGRAM = 20501;

        public static readonly short LIST_CHANNEL_PROGRAM_RESULT = 20502;

        public static readonly short VJ_FANLIST_REQUEST = 20484;

        public static readonly short VJ_FANLIST_RESULT = 20485;

        public static readonly short VJ_QUITFAN_REQUEST = 20997;

        public static readonly short VJ_QUITFAN_RESULT = 20998;

        public static readonly short VJ_SEARCH_KEYWORD_REQUEST = 20486;

        public static readonly short VJ_SEARCH_KEYWORD_RESULT = 20487;

        public static readonly short VJ_FAN_REMIND_REQUEST = 20488;

        public static readonly short VJ_LISTEN_FAN_NOTIFICATION_REQUEST = 20499;

        public static readonly short VJ_LISTEN_FAN_NOTIFICATION_RESULT = 20500;

        public static readonly short VJ_CHANGE_FAN_REMIND_REQUEST = 20489;

        public static readonly short VJ_CHANGE_FAN_REMIND_RESULT = 20496;

        public static readonly short VJ_FAN_REMIND_CONFIG_REQUEST = 20497;

        public static readonly short VJ_FAN_REMIND_CONFIG_RESULT = 20498;

        public static readonly short GET_HOT_VJ_REQUEST = 20503;

        public static readonly short GET_HOT_VJ_RESULT = 20504;

        public static readonly short GET_NEW_PARTY_REQUEST = 20505;

        public static readonly short GET_NEW_PARTY_RESULT = 20512;

        public static readonly short GET_HOT_PARTY_REQUEST = 20513;

        public static readonly short GET_HOT_PARTY_RESULT = 20514;

        public static readonly short GET_RECOMMEND_PARTY_REQUEST = 20515;

        public static readonly short GET_RECOMMEND_PARTY_RESULT = 20516;

        public static readonly short GET_THEME_PARTY_REQUEST = 20517;

        public static readonly short GET_THEME_PARTY_RESULT = 20518;

        public static readonly short GET_PARTY_HISTORY_REQUEST = 20537;

        public static readonly short GET_PARTY_HISTORY_RESULT = 20544;

        public static readonly short GET_PARTY_THEMES_REQUEST = 20519;

        public static readonly short GET_PARTY_THEMES_RESULT = 20520;

        public static readonly short GET_COMMENT_VISIBLE_REQUEST = 20521;

        public static readonly short GET_COMMENT_VISIBLE_RESULT = 20528;

        public static readonly short GET_CHANGE_COMMENT_VISIBLE_REQUEST = 20529;

        public static readonly short GET_CHANGE_COMMENT_VISIBLE_RESULT = 20530;

        public static readonly short GET_PARTY_BUNDLE_REQUEST = 20531;

        public static readonly short GET_PARTY_BUNDLE_RESULT = 20532;

        public static readonly short GET_SELF_PARTY_REQUEST = 20547;

        public static readonly short GET_SELF_PARTY_RESULT = 20548;

        public static readonly short CHANNEL_PARTY_POPULAR_THEMES_REQUEST = 21783;

        public static readonly short CHANNEL_PARTY_POPULAR_THEMES_RESULT = 21784;

        public static readonly short CHANNEL_PARTY_CREATE_PARTY_REQUEST = 21785;

        public static readonly short CHANNEL_PARTY_CREATE_PARTY_RESULT = 21798;

        public static readonly short CHANNEL_PARTY_MASTER_THEMES_REQUEST = 21799;

        public static readonly short CHANNEL_PARTY_MASTER_THEMES_RESULT = 21800;

        public static readonly short CHANNEL_PARTY_CHECK_PARTY_CREATEABLE_REQUEST = 20533;

        public static readonly short CHANNEL_PARTY_CHECK_PARTY_CREATEABLE_RESULT = 20534;

        public static readonly short CHANNEL_PARTY_GET_USER_INFOMATION_REQUEST = 20535;

        public static readonly short CHANNEL_PARTY_GET_USER_INFOMATION_RESULT = 20536;

        public static readonly short CHANNEL_PARTY_GET_AREA_DESIGN_REQUEST = 20549;

        public static readonly short CHANNEL_PARTY_GET_AREA_DESIGN_RESULT = 20550;

        public static readonly short GET_PARTY_SKILL_REQUEST = 20553;

        public static readonly short GET_PARTY_SKILL_RESULT = 20560;

        public static readonly short CHANNEL_PARTY_GET_EVENT_REQUEST = 20551;

        public static readonly short CHANNEL_PARTY_GET_EVENT_RESULT = 20552;

        public static readonly short GET_PARTY_SKILL_EXECUTE_REQUEST = 20553;

        public static readonly short GET_PARTY_SKILL_EXECUTE_RESULT = 20560;

        public static readonly short NOTIFY_MYGAME_STATUS = 16896;

        public static readonly short GET_MYGAME = 16897;

        public static readonly short GET_MYGAME_RESULT = 16898;

        public static readonly short GET_MYGAME_BUNDLE = 16899;

        public static readonly short GET_MYGAME_BUNDLE_RESLUT = 16900;

        public static readonly short SET_BIGG_EVENT_STATUS = 17920;

        public static readonly short SET_BIGG_EVENT_STATUS_RESULT = 17921;

        public static readonly short GET_BIGG_EVENT_STATUS = 17922;

        public static readonly short GET_BIGG_EVENT_STATUS_RESULT = 17923;

        public static readonly short GET_BIGG_EVENT_CONF_STATUS = 17924;

        public static readonly short GET_BIGG_EVENT_CONF_STATUS_RESULT = 17925;

        public static readonly short SET_BIGG_EVENT_RECORD = 17926;

        public static readonly short SET_BIGG_EVENT_RECORD_RESULT = 17927;

        public static readonly short GET_BIGG_EVENT_RECORD = 17928;

        public static readonly short GET_BIGG_EVENT_RECORD_RESULT = 17929;

        public static readonly short GET_EVENT_POINT_EXCHANGE_STATUS = 17952;

        public static readonly short GET_EVENT_POINT_EXCHANGE_STATUS_RESULT = 17953;

        public static readonly short EXCHANGE_EVENT_POINT = 17954;

        public static readonly short EXCHANGE_EVENT_POINT_RESULT = 17955;

        public static readonly short USER_SEEN_BEGINNER_HELP = 18176;

        public static readonly short PPOINT_CAMPAIGN_LIST = 18432;

        public static readonly short PPOINT_CAMPAIGN_LIST_RESULT = 18433;

        public static readonly short PPOINT_CLEAR_CONDITION_INFO_RESULT = 18434;

        public static readonly short PPOINT_PROVIDE_ITEM_LIST = 18435;

        public static readonly short PPOINT_PROVIDE_ITEM_LIST_RESULT = 18436;

        public static readonly short PPOINT_EXCHANGE_LIST = 18437;

        public static readonly short PPOINT_EXCHANGE_LIST_RESULT = 18438;

        public static readonly short PPOINT_DO_EXCHANGE = 18439;

        public static readonly short PPOINT_DO_EXCHANGE_RESULT = 18440;

        public static readonly short PPOINT_SEND_PROVISION_ID = 18441;

        public static readonly short PPOINT_SEND_PROVISION_ID_RESULT = 18442;

        public static readonly short UNREAD_CROSS_ANNOUNCE_RESULT = 18443;

        public static readonly short CHECK_CROSS_ANNOUNCE = 18444;

        public static readonly short CHECK_CROSS_ANNOUNCE_RESULT = 18445;

        public static readonly short PPOINT_CAMPAIGN_CLEAR = 18446;

        public static readonly short ONE_MESSAGE_SAVE = 370;

        public static readonly short LIST_STAMP = 18688;

        public static readonly short LIST_STAMP_RESULT = 18689;

        public static readonly short ANNOUNCE_GAME_BAR_RESULT = 8985;

        public static readonly short CHECK_ANNOUNCE_GAME_BAR = 8992;

        public static readonly short END_ANNOUNCE_GAME_BAR = 8993;

        public static readonly short CHECK_COMEBACK_CAMPAIGN = 20736;

        public static readonly short CHECK_COMEBACK_CAMPAIGN_RESULT = 20737;

        public static readonly short GET_COMEBACK_CAMPAIGN = 20738;

        public static readonly short GET_COMEBACK_CAMPAIGN_RESULT = 20739;

        public static readonly short LIST_COMEBACK_CAMPAIGN_TARGET_USERS = 20740;

        public static readonly short LIST_COMEBACK_CAMPAIGN_TARGET_USERS_RESULT = 20741;

        public static readonly short SEND_COMEBACK_CAMPAIGN = 20742;

        public static readonly short SEND_COMEBACK_CAMPAIGN_RESULT = 20743;

        public static readonly short LIST_COMEBACK_CAMPAIGN_SENT_USERS = 20744;

        public static readonly short LIST_COMEBACK_CAMPAIGN_SENT_USERS_RESULT = 20745;

        public static readonly short GET_COMEBACK_CAMPAIGN_REWARDS = 20752;

        public static readonly short GET_COMEBACK_CAMPAIGN_REWARDS_RESULT = 20753;

        public static readonly short OPEN_CONTEST_PANEL = 20754;

        public static readonly short OPEN_CONTEST_PANEL_RESULT = 20755;

        public static readonly short GET_CONTEST_LIST_PAGE = 20756;

        public static readonly short GET_CONTEST_LIST_PAGE_REUSLT = 20757;

        public static readonly short OPEN_CONTEST_USER_PANEL = 20758;

        public static readonly short OPEN_CONTEST_USER_PANEL_RESULT = 20759;

        public static readonly short SEND_NICE = 20762;

        public static readonly short SEND_NICE_RESULT = 20763;

        public static readonly short SEND_USER_POST = 20764;

        public static readonly short SEND_USER_POST_RESULT = 20765;

        public static readonly short UPDATE_CONTEST_OPEN_SETTING = 20766;

        public static readonly short UPDATE_CONTEST_OPEN_SETTING_RESULT = 20767;

        public static readonly short SHOW_CONTEST_ICON = 20768;

        public static readonly short GET_CONTEST_ARCHIVE = 20769;

        public static readonly short GET_CONTEST_ARCHIVE_RESULT = 20770;

        public static readonly short GET_CONTEST_STAT_IMAGE_INFO = 20771;

        public static readonly short GET_CONTEST_STAT_IMAGE_INFO_RESULT = 20772;

        public static readonly short NOTIFY_GATHER_TIME = 21506;

        public static readonly short LIST_TRAINING = 20992;

        public static readonly short LIST_TRAINING_RESULT = 20993;

        public static readonly short GET_TRAINING_ICON = 20994;

        public static readonly short GET_TRAINING_ICON_RESULT = 20995;

        public static readonly short CLEAR_TRAINING = 20996;

        public static readonly short SEND_GIFT_LOG = 156;

        public static readonly short CHECK_AMEGOLD_EXCHANGEABLE_FOR_AS_COIN = 21248;

        public static readonly short CHECK_AMEGOLD_EXCHANGEABLE_FOR_AS_COIN_RESULT = 21249;

        public static readonly short EXCHANGE_AMEGOLD_FOR_AS_COIN = 21250;

        public static readonly short EXCHANGE_AMEGOLD_FOR_AS_COIN_RESULT = 21251;

        public static readonly short LIMIT_COIN_NOTIFICATION_RESULT = 21265;

        public static readonly short GET_AMEBA_SOCIAL_MAINTENANCE = 21760;

        public static readonly short AMEBA_SOCIAL_MAINTENANCE_RESULT = 21761;

        public static readonly short GET_STORAGE_ARCHIVE_LIST = 22016;

        public static readonly short GET_STORAGE_ARCHIVE_LIST_RESULT = 22017;

        public static readonly short UPDATE_STORAGE_ARCHIVE_TITLE = 22018;

        public static readonly short UPDATE_STORAGE_ARCHIVE_TITLE_RESULT = 22019;

        public static readonly short GET_BEGINNER_SHOP = 22528;

        public static readonly short GET_BEGINNER_SHOP_RESULT = 22529;

        public static readonly short BEGINNER_SHOP_ICON = 22530;

        public static readonly short GET_BEGINNER_SHOP_ANNOUNCE_RESULT = 22531;

        public static readonly short BUY_BEGINNER_SHOP_ITEM = 22532;

        public static readonly short BUY_BEGINNER_SHOP_ITEM_RESULT = 22533;

        public static readonly short GET_PIGGSHOP = 22534;

        public static readonly short GET_PIGGSHOP_RESULT = 22535;

        public static readonly short GET_PIGGSHOP_CATEGORY = 22536;

        public static readonly short GET_PIGGSHOP_CATEGORY_RESULT = 22537;

        public static readonly short GET_PIGGSHOP_ITEM_TOP_RESULT = 22544;

        public static readonly short GET_PIGGSHOP_GACHA_RESULT = 22538;

        public static readonly short GET_PIGGSHOP_RECOMMEND_RESULT = 22539;

        public static readonly short GET_PIGGSHOP_SERIES = 22540;

        public static readonly short GET_PIGGSHOP_SERIES_RESULT = 22541;

        public static readonly short GET_PIGG_SHOP_ITEM_RANKING = 1385;

        public static readonly short GET_PIGG_SHOP_ITEM_RANKING_RESULT = 1386;

        public static readonly short GET_FAVORITE_SHOP = 22560;

        public static readonly short GET_FAVORITE_SHOP_RESULT = 22561;

        public static readonly short GET_HISTORY_SHOP = 22562;

        public static readonly short GET_HISTORY_SHOP_RESULT = 22563;

        public static readonly short SAVE_FAVORITE_SHOP = 22564;

        public static readonly short SAVE_FAVORITE_SHOP_RESULT = 22565;

        public static readonly short SAVE_BLUK_FAVORITE_SHOP = 22566;

        public static readonly short SAVE_BLUK_FAVORITE_SHOP_RESULT = 22567;

        public static readonly short BULK_BUYING_SHOP_ITEM = 29280;

        public static readonly short BULK_BUYING_SHOP_ITEM_RESULT = 29281;

        public static readonly short CLICK_PIGG_SHOP_ITEM = 22542;

        public static readonly short CLICK_PIGG_SHOP_ITEM_RESULT = 22543;

        public static readonly short PROVIDE_DIARY = 22272;

        public static readonly short PROVIDE_DIARY_RESULT = 22273;

        public static readonly short GET_DIARY = 22274;

        public static readonly short GET_DIARY_RESULT = 22275;

        public static readonly short GET_DIARY_PAGE_MORE = 22276;

        public static readonly short GET_DIARY_PAGE_MORE_RESULT = 22277;

        public static readonly short GET_DIARY_CONFIG = 22278;

        public static readonly short GET_DIARY_CONFIG_RESULT = 22279;

        public static readonly short SAVE_DIARY_CONFIG = 22280;

        public static readonly short SAVE_DIARY_CONFIG_RESULT = 22281;

        public static readonly short SEND_DIARY_MITAYO = 22282;

        public static readonly short SEND_DIARY_MITAYO_RESULT = 22283;

        public static readonly short GET_DIARY_COMMENT_MORE = 22284;

        public static readonly short GET_DIARY_COMMENT_MORE_RESULT = 22285;

        public static readonly short REMOVE_DIARY_COMMENT = 22286;

        public static readonly short REMOVE_DIARY_COMMENT_RESULT = 22287;

        public static readonly short SAVE_DIARY_COMMENT = 22288;

        public static readonly short SAVE_DIARY_COMMENT_RESULT = 22289;

        public static readonly short SAVE_DIARY_PAGE = 22290;

        public static readonly short SAVE_DIARY_PAGE_RESULT = 22291;

        public static readonly short EDIT_DIARY_PAGE = 22292;

        public static readonly short EDIT_DIARY_PAGE_RESULT = 22293;

        public static readonly short REMOVE_DIARY_PAGE = 22294;

        public static readonly short REMOVE_DIARY_PAGE_RESULT = 22295;

        public static readonly short GET_DIARY_ACTIVITY_FEED = 22296;

        public static readonly short GET_DIARY_ACTIVITY_FEED_RESULT = 22297;

        public static readonly short GET_DIARY_MITAYO_USER = 22304;

        public static readonly short GET_DIARY_MITAYO_USER_RESULT = 22305;

        public static readonly short GET_DIARY_IMAGE_LIST = 22306;

        public static readonly short GET_DIARY_IMAGE_LIST_RESULT = 22307;

        public static readonly short UPDATE_READ_DIARY_NOTIFICATION = 22308;

        public static readonly short UPDATE_READ_DIARY_NOTIFICATION_RESULT = 22309;

        public static readonly short UPDATE_READ_ALL_DIARY_NOTIFICATION = 22310;

        public static readonly short UPDATE_READ_ALL_DIARY_NOTIFICATION_RESULT = 22311;

        public static readonly short GET_DIARY_PAGE_FROM_NOTIFICATION = 22312;

        public static readonly short GET_DIARY_PAGE_FROM_NOTIFICATION_RESULT = 22313;

        public static readonly short REMOVE_DIARY_IMAGE = 22314;

        public static readonly short REMOVE_DIARY_IMAGE_RESULT = 22315;

        public static readonly short SHARE_DIARY_PAGE = 22316;

        public static readonly short SHARE_DIARY_PAGE_RESULT = 22317;

        public static readonly short GET_DIARY_SHARE = 22318;

        public static readonly short GET_DIARY_SHARE_RESULT = 22319;

        public static readonly short GET_DIARY_ACTIVITY_SUMMARY = 22329;

        public static readonly short GET_DIARY_ACTIVITY_SUMMARY_RESULT = 22330;

        public static readonly short GET_DIARY_COMMENT = 22331;

        public static readonly short GET_DIARY_COMMENT_RESULT = 22332;

        public static readonly short GET_SIMPLE_USER_PROFILE = 22336;

        public static readonly short GET_SIMPLE_USER_PROFILE_RESULT = 22337;

        public static readonly short GET_FEED_TOP_POPULAR_FEED_CONTENTS = 22334;

        public static readonly short GET_FEED_TOP_POPULAR_FEED_CONTENTS_RESULT = 22335;

        public static readonly short UPDATE_READ_DIARY_NOTIFICATION_SUMMARY = 22340;

        public static readonly short UPDATE_READ_DIARY_NOTIFICATION_SUMMARY_RESULT = 22341;

        public static readonly short GET_FEED_TOP = 22320;

        public static readonly short GET_FEED_TOP_RESULT = 22321;

        public static readonly short GET_FEED_PAGE_INDEX_LIST = 22322;

        public static readonly short GET_FEED_PAGE_INDEX_LIST_RESULT = 22323;

        public static readonly short GET_FEED_PAGE_CONTENTS = 22324;

        public static readonly short GET_FEED_PAGE_CONTENTS_RESILT = 22325;

        public static readonly short GET_FEED_VIEW_AVATAR_DATA = 22326;

        public static readonly short GET_FEED_VIEW_AVATAR_DATA_RESULT = 22327;

        public static readonly short UNSET_NEW_MARK_TARGET_DIARY = 22338;

        public static readonly short UNSET_NEW_MARK_TARGET_DIARY_RESULT = 22339;

        public static readonly short LOG_READ_FEED_PAGE = 22342;

        public static readonly short READ_FEED_TYPE = 22343;

        public static readonly short GET_DIARY_IMAGE = 22344;

        public static readonly short GET_DIARY_IMAGE_RESULT = 22345;

        public static readonly short LIST_BLOCK_USER = 24832;

        public static readonly short LIST_BLOCK_USER_RESULT = 24833;

        public static readonly short REMOVE_BLOCK_USER = 24834;

        public static readonly short REMOVE_BLOCK_USER_RESULT = 24835;

        public static readonly short LIST_BAN_USER = 24836;

        public static readonly short LIST_BAN_USER_RESULT = 24837;

        public static readonly short ANALYSIS_LOG = 22784;

        public static readonly short ANALYSIS_SESSION_LOG = 22816;

        public static readonly short PIGG_KPI_LOG = 22800;

        public static readonly short ANALYSIS_SHOP_RANKING_LOG = 1384;

        public static readonly short GET_DOT_MONEY_POINT = 25088;

        public static readonly short GET_DOT_MONEY_POINT_RESULT = 25089;

        public static readonly short DOT_MONEY_POINT_EVENT_INFO_RESULT = 25091;

        public static readonly short DOT_MONEY_AGP_NOTIFICATION_RESULT = 25090;

        public static readonly short GET_TICKET_DATA_RESULT = 25344;

        public static readonly short GET_SHOP_INFO = 25600;

        public static readonly short GET_SHOP_INFO_RESULT = 25601;

        public static readonly short GET_SHOP_SERACH_BOX = 25616;

        public static readonly short GET_SHOP_SERACH_BOX_RESULT = 25617;

        public static readonly short GET_RANDOM_DROP = 25345;

        public static readonly short GET_RANDOM_DROP_RESULT = 25346;

        public static readonly short GET_RANDOM_DROP_INFO = 25347;

        public static readonly short GET_RANDOM_DROP_INFO_RESULT = 25348;

        public static readonly short GET_RECAST_RIGHT_CONTENT = 25857;

        public static readonly short GET_RECAST_RIGHT_CONTENT_RESULT = 25858;

        public static readonly short PROVIDE_RECAST_RIGHT_CONTENT = 25859;

        public static readonly short PROVIDE_RECAST_RIGHT_CONTENT_RESULT = 25860;

        public static readonly short GET_RANDOM_DROP_BOX_INFO = 25349;

        public static readonly short GET_RANDOM_DROP_BOX_INFO_RESULT = 25350;

        public static readonly short GET_RANDOM_DROP_LOTTERY_INFO = 25351;

        public static readonly short GET_RANDOM_DROP_LOTTERY_INFO_RESULT = 25352;

        public static readonly short GET_FRONT_INFO_DATA = 28674;

        public static readonly short GET_FRONT_INFO_DATA_RESULT = 28675;

        public static readonly short SET_FRONT_INFO_DATA = 28672;

        public static readonly short SET_FRONT_INFO_DATA_RESULT = 28673;

        public static readonly short GET_MEDAL_GAME_AREA = 28678;

        public static readonly short GET_MEDAL_GAME_AREA_RESULT = 28679;

        public static readonly short GET_USER_MEDAL = 28688;

        public static readonly short GET_USER_MEDAL_RESULT = 28689;

        public static readonly short PROVIDE_BONUS_MEDAL = 28690;

        public static readonly short PROVIDE_BONUS_MEDAL_RESULT = 28691;

        public static readonly short GET_MEDAL_SHOP = 28692;

        public static readonly short GET_MEDAL_SHOP_RESULT = 28693;

        public static readonly short BUY_MEDAL = 28694;

        public static readonly short BUY_MEDAL_RESULT = 28695;

        public static readonly short GET_NYANCATCH_MEDAL_GAME_AREA = 28928;

        public static readonly short GET_NYANCATCH_MEDAL_GAME_AREA_RESULT = 28929;

        public static readonly short OPEN_NYANCATCH_POCHETTE = 28944;

        public static readonly short OPEN_NYANCATCH_POCHETTE_RESULT = 28945;

        public static readonly short EQUIP_NYANCATCH_POCHETTE_ITEM = 28946;

        public static readonly short EQUIP_NYANCATCH_POCHETTE_ITEM_RESULT = 28947;

        public static readonly short OPEN_NYANCATCH_PICTURE_BOOK_TOP = 28950;

        public static readonly short OPEN_NYANCATCH_PICTURE_BOOK_TOP_RESULT = 28951;

        public static readonly short OPEN_NYANCATCH_PICTURE_BOOK_STAGE = 28952;

        public static readonly short OPEN_NYANCATCH_PICTURE_BOOK_STAGE_RESULT = 28953;

        public static readonly short GET_NYANCATCH_OPENAREA = 28960;

        public static readonly short GET_NYANCATCH_OPENAREA_RESULT = 28961;

        public static readonly short SAVE_MYRANKING = 29184;

        public static readonly short EMPATHY_MYRANKING = 29185;

        public static readonly short MYRANKING_LIST_UPDATE = 29186;

        public static readonly short GET_MYRANKING_LIST = 29187;

        public static readonly short GET_MYRANKING_LIST_RESULT = 29188;

        public static readonly short GET_USER_BALANCE = 29296;

        public static readonly short GET_USER_BALANCE_RESULT = 29297;

        public static readonly short OPEN_WORLD_CHAT_TOP = 29264;

        public static readonly short OPEN_WORLD_CHAT_TOP_RESULT = 29265;

        public static readonly short CLOSE_WORLD_CHAT_TOP = 29266;

        public static readonly short CREATE_WORLD_CHAT_TOPIC = 29267;

        public static readonly short BACK_TO_WORLD_CHAT_TOP = 29268;

        public static readonly short OPEN_WORLD_CHAT_TOPIC = 29270;

        public static readonly short OPEN_WORLD_CHAT_TOPIC_RESULT = 29271;

        public static readonly short POST_WORLD_CHAT = 29272;

        public static readonly short OPEN_WORLD_CHAT_SETTING = 29273;

        public static readonly short OPEN_WORLD_CHAT_SETTING_RESULT = 29280;

        public static readonly short WORLD_CHAT_SAVE_SETTING = 29281;

        public static readonly short CREATE_WORLD_CHAT_TOPIC_RESULT = 29282;

        public static readonly short OPEN_WORLD_CHAT_INFO = 29283;

        public static readonly short OPEN_WORLD_CHAT_INFO_RESULT = 29284;

        public static readonly short WORLD_CHAT_NEWS_RESULT = 29285;

        public static readonly short GET_USER_LOTTERY = 29301;

        public static readonly short GET_USER_LOTTERY_RESULT = 29302;

        public static readonly short GET_LOTTERY = 29303;

        public static readonly short GET_LOTTERY_RESULT = 29304;

        public static readonly short GET_ANNOUNCE_LOTTERY = 29305;

        public static readonly short GET_ANNOUNCE_LOTTERY_RESULT = 29306;

        public static readonly short NOTIFY_POINT_BALANCE_RESULT = 32;

        public static readonly short NOTIFY_NEW_PIGG_ITEM_RESULT = 33;
    }
}
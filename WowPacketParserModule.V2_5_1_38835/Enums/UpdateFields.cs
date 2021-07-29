namespace WowPacketParserModule.V2_5_1_38835.Enums
{
    public enum ObjectField
    {
        OBJECT_GUID                                                       = 0x0000,      // Size: 4, Flags: (All)
        OBJECT_ENTRY_ID                                                   = 0x0004,      // Size: 1, Flags: (ViewerDependent)
        OBJECT_DYNAMIC_FLAGS                                              = 0x0005,      // Size: 1, Flags: (ViewerDependent, Urgent)
        OBJECT_SCALE                                                      = 0x0006,      // Size: 1, Flags: (All)
        OBJECT_END                                                        = 0x0007,
    }

    public enum ObjectDynamicField
    {
        OBJECT_DYNAMIC_END                                                = 0x0000,
    }

    public enum ItemField
    {
        ITEM_OWNER                                                        = ObjectField.OBJECT_END + 0x0000,      // Size: 4, Flags: (All)
        ITEM_CONTAINED_IN                                                 = ObjectField.OBJECT_END + 0x0004,      // Size: 4, Flags: (All)
        ITEM_CREATOR                                                      = ObjectField.OBJECT_END + 0x0008,      // Size: 4, Flags: (All)
        ITEM_GIFT_CREATOR                                                 = ObjectField.OBJECT_END + 0x000C,      // Size: 4, Flags: (All)
        ITEM_STACK_COUNT                                                  = ObjectField.OBJECT_END + 0x0010,      // Size: 1, Flags: (Owner)
        ITEM_EXPIRATION                                                   = ObjectField.OBJECT_END + 0x0011,      // Size: 1, Flags: (Owner)
        ITEM_SPELL_CHARGES                                                = ObjectField.OBJECT_END + 0x0012,      // Size: 5, Flags: (Owner)
        ITEM_DYNAMIC_FLAGS                                                = ObjectField.OBJECT_END + 0x0017,      // Size: 1, Flags: (All)
        ITEM_ENCHANTMENT                                                  = ObjectField.OBJECT_END + 0x0018,      // Size: 39, Flags: (All)
        ITEM_PROPERTY_SEED                                                = ObjectField.OBJECT_END + 0x003F,      // Size: 1, Flags: (All)
        ITEM_RANDOM_PROPERTIES_ID                                         = ObjectField.OBJECT_END + 0x0040,      // Size: 1, Flags: (All)
        ITEM_DURABILITY                                                   = ObjectField.OBJECT_END + 0x0041,      // Size: 1, Flags: (Owner)
        ITEM_MAX_DURABILITY                                               = ObjectField.OBJECT_END + 0x0042,      // Size: 1, Flags: (Owner)
        ITEM_CREATE_PLAYED_TIME                                           = ObjectField.OBJECT_END + 0x0043,      // Size: 1, Flags: (All)
        ITEM_MODIFIERS_MASK                                               = ObjectField.OBJECT_END + 0x0044,      // Size: 1, Flags: (Owner)
        ITEM_CONTEXT                                                      = ObjectField.OBJECT_END + 0x0045,      // Size: 1, Flags: (All)
        ITEM_ARTIFACT_XP                                                  = ObjectField.OBJECT_END + 0x0046,      // Size: 2, Flags: (Owner)
        ITEM_ITEM_APPEARANCE_MOD_ID                                       = ObjectField.OBJECT_END + 0x0048,      // Size: 1, Flags: (Owner)
        ITEM_END                                                          = ObjectField.OBJECT_END + 0x0049,
    }

    public enum ItemDynamicField
    {
        ITEM_DYNAMIC_MODIFIERS                                            = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,      // Flags: (Owner)
        ITEM_DYNAMIC_BONUS_LIST_IDS                                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0001,      // Flags: (Owner, Unk0x100)
        ITEM_DYNAMIC_ARTIFACT_POWERS                                      = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0002,      // Flags: (Owner)
        ITEM_DYNAMIC_GEMS                                                 = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0003,      // Flags: (Owner)
        ITEM_DYNAMIC_END                                                  = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0004,
    }

    public enum ContainerField
    {
        CONTAINER_SLOTS                                                   = ItemField.ITEM_END + 0x0000,      // Size: 144, Flags: (All)
        CONTAINER_NUM_SLOTS                                               = ItemField.ITEM_END + 0x0090,      // Size: 1, Flags: (All)
        CONTAINER_END                                                     = ItemField.ITEM_END + 0x0091,
    }

    public enum ContainerDynamicField
    {
        CONTAINER_DYNAMIC_END                                             = ItemDynamicField.ITEM_DYNAMIC_END + 0x0000,
    }

    public enum UnitField
    {
        UNIT_CHARM                                                        = ObjectField.OBJECT_END + 0x0000,      // Size: 4, Flags: (All)
        UNIT_SUMMON                                                       = ObjectField.OBJECT_END + 0x0004,      // Size: 4, Flags: (All)
        UNIT_CRITTER                                                      = ObjectField.OBJECT_END + 0x0008,      // Size: 4, Flags: (Self)
        UNIT_CHARMED_BY                                                   = ObjectField.OBJECT_END + 0x000C,      // Size: 4, Flags: (All)
        UNIT_SUMMONED_BY                                                  = ObjectField.OBJECT_END + 0x0010,      // Size: 4, Flags: (All)
        UNIT_CREATED_BY                                                   = ObjectField.OBJECT_END + 0x0014,      // Size: 4, Flags: (All)
        UNIT_DEMON_CREATOR                                                = ObjectField.OBJECT_END + 0x0018,      // Size: 4, Flags: (All)
        UNIT_LOOK_AT_CONTROLLER_TARGET                                    = ObjectField.OBJECT_END + 0x001C,      // Size: 4, Flags: (All)
        UNIT_TARGET                                                       = ObjectField.OBJECT_END + 0x0020,      // Size: 4, Flags: (All)
        UNIT_BATTLE_PET_COMPANION_GUID                                    = ObjectField.OBJECT_END + 0x0024,      // Size: 4, Flags: (All)
        UNIT_BATTLE_PET_DBID                                              = ObjectField.OBJECT_END + 0x0028,      // Size: 2, Flags: (All)
        UNIT_CHANNEL_DATA                                                 = ObjectField.OBJECT_END + 0x002A,      // Size: 2, Flags: (All, Urgent)
        UNIT_SUMMONED_BY_HOME_REALM                                       = ObjectField.OBJECT_END + 0x002C,      // Size: 1, Flags: (All)
        UNIT_BYTES1                                                       = ObjectField.OBJECT_END + 0x002D,      // Size: 1, Flags: (All) Nested: (Race, ClassId, PlayerClassId, Sex)
        UNIT_DISPLAY_POWER                                                = ObjectField.OBJECT_END + 0x002E,      // Size: 1, Flags: (All)
        UNIT_OVERRIDE_DISPLAY_POWER_ID                                    = ObjectField.OBJECT_END + 0x002F,      // Size: 1, Flags: (All)
        UNIT_HEALTH                                                       = ObjectField.OBJECT_END + 0x0030,      // Size: 2, Flags: (ViewerDependent)
        UNIT_POWER                                                        = ObjectField.OBJECT_END + 0x0032,      // Size: 6, Flags: (All, UrgentSelfOnly)
        UNIT_MAX_HEALTH                                                   = ObjectField.OBJECT_END + 0x0038,      // Size: 2, Flags: (ViewerDependent)
        UNIT_MAX_POWER                                                    = ObjectField.OBJECT_END + 0x003A,      // Size: 6, Flags: (All)
        UNIT_MOD_POWER_REGEN                                              = ObjectField.OBJECT_END + 0x0040,      // Size: 6, Flags: (Self, Owner, UnitAll)
        UNIT_LEVEL                                                        = ObjectField.OBJECT_END + 0x0046,      // Size: 1, Flags: (All)
        UNIT_EFFECTIVE_LEVEL                                              = ObjectField.OBJECT_END + 0x0047,      // Size: 1, Flags: (All)
        UNIT_CONTENT_TUNING_ID                                            = ObjectField.OBJECT_END + 0x0048,      // Size: 1, Flags: (All)
        UNIT_SCALING_LEVEL_MIN                                            = ObjectField.OBJECT_END + 0x0049,      // Size: 1, Flags: (All)
        UNIT_SCALING_LEVEL_MAX                                            = ObjectField.OBJECT_END + 0x004A,      // Size: 1, Flags: (All)
        UNIT_SCALING_LEVEL_DELTA                                          = ObjectField.OBJECT_END + 0x004B,      // Size: 1, Flags: (All)
        UNIT_SCALING_FACTION_GROUP                                        = ObjectField.OBJECT_END + 0x004C,      // Size: 1, Flags: (All)
        UNIT_SCALING_HEALTH_ITEM_LEVEL_CURVE_ID                           = ObjectField.OBJECT_END + 0x004D,      // Size: 1, Flags: (All)
        UNIT_SCALING_DAMAGE_ITEM_LEVEL_CURVE_ID                           = ObjectField.OBJECT_END + 0x004E,      // Size: 1, Flags: (All)
        UNIT_FACTION_TEMPLATE                                             = ObjectField.OBJECT_END + 0x004F,      // Size: 1, Flags: (All)
        UNIT_VIRTUAL_ITEMS                                                = ObjectField.OBJECT_END + 0x0050,      // Size: 6, Flags: (All)
        UNIT_FLAGS                                                        = ObjectField.OBJECT_END + 0x0056,      // Size: 1, Flags: (All, Urgent)
        UNIT_FLAGS2                                                       = ObjectField.OBJECT_END + 0x0057,      // Size: 1, Flags: (All, Urgent)
        UNIT_FLAGS3                                                       = ObjectField.OBJECT_END + 0x0058,      // Size: 1, Flags: (All, Urgent)
        UNIT_AURA_STATE                                                   = ObjectField.OBJECT_END + 0x0059,      // Size: 1, Flags: (All)
        UNIT_ATTACK_ROUND_BASE_TIME                                       = ObjectField.OBJECT_END + 0x005A,      // Size: 2, Flags: (All)
        UNIT_RANGED_ATTACK_ROUND_BASE_TIME                                = ObjectField.OBJECT_END + 0x005C,      // Size: 1, Flags: (Self)
        UNIT_BOUNDING_RADIUS                                              = ObjectField.OBJECT_END + 0x005D,      // Size: 1, Flags: (All)
        UNIT_COMBAT_REACH                                                 = ObjectField.OBJECT_END + 0x005E,      // Size: 1, Flags: (All)
        UNIT_DISPLAY_ID                                                   = ObjectField.OBJECT_END + 0x005F,      // Size: 1, Flags: (ViewerDependent, Urgent)
        UNIT_DISPLAY_SCALE                                                = ObjectField.OBJECT_END + 0x0060,      // Size: 1, Flags: (ViewerDependent, Urgent)
        UNIT_NATIVE_DISPLAY_ID                                            = ObjectField.OBJECT_END + 0x0061,      // Size: 1, Flags: (All, Urgent)
        UNIT_NATIVE_X_DISPLAY_SCALE                                       = ObjectField.OBJECT_END + 0x0062,      // Size: 1, Flags: (All, Urgent)
        UNIT_MOUNT_DISPLAY_ID                                             = ObjectField.OBJECT_END + 0x0063,      // Size: 1, Flags: (All, Urgent)
        UNIT_MIN_DAMAGE                                                   = ObjectField.OBJECT_END + 0x0064,      // Size: 1, Flags: (Self, Owner, Empath)
        UNIT_MAX_DAMAGE                                                   = ObjectField.OBJECT_END + 0x0065,      // Size: 1, Flags: (Self, Owner, Empath)
        UNIT_MIN_OFF_HAND_DAMAGE                                          = ObjectField.OBJECT_END + 0x0066,      // Size: 1, Flags: (Self, Owner, Empath)
        UNIT_MAX_OFF_HAND_DAMAGE                                          = ObjectField.OBJECT_END + 0x0067,      // Size: 1, Flags: (Self, Owner, Empath)
        UNIT_BYTES2                                                       = ObjectField.OBJECT_END + 0x0068,      // Size: 1, Flags: (All) Nested: (StandState, PetLoyaltyIndex, VisFlags, AnimTier)
        UNIT_PET_NUMBER                                                   = ObjectField.OBJECT_END + 0x0069,      // Size: 1, Flags: (All)
        UNIT_PET_NAME_TIMESTAMP                                           = ObjectField.OBJECT_END + 0x006A,      // Size: 1, Flags: (All)
        UNIT_PET_EXPERIENCE                                               = ObjectField.OBJECT_END + 0x006B,      // Size: 1, Flags: (Owner)
        UNIT_PET_NEXT_LEVEL_EXPERIENCE                                    = ObjectField.OBJECT_END + 0x006C,      // Size: 1, Flags: (Owner)
        UNIT_MOD_CASTING_SPEED                                            = ObjectField.OBJECT_END + 0x006D,      // Size: 1, Flags: (All)
        UNIT_MOD_SPELL_HASTE                                              = ObjectField.OBJECT_END + 0x006E,      // Size: 1, Flags: (All)
        UNIT_MOD_HASTE                                                    = ObjectField.OBJECT_END + 0x006F,      // Size: 1, Flags: (All)
        UNIT_MOD_RANGED_HASTE                                             = ObjectField.OBJECT_END + 0x0070,      // Size: 1, Flags: (All)
        UNIT_MOD_HASTE_REGEN                                              = ObjectField.OBJECT_END + 0x0071,      // Size: 1, Flags: (All)
        UNIT_MOD_TIME_RATE                                                = ObjectField.OBJECT_END + 0x0072,      // Size: 1, Flags: (All)
        UNIT_CREATED_BY_SPELL                                             = ObjectField.OBJECT_END + 0x0073,      // Size: 1, Flags: (All)
        UNIT_NPC_FLAGS                                                    = ObjectField.OBJECT_END + 0x0074,      // Size: 2, Flags: (All, ViewerDependent)
        UNIT_EMOTE_STATE                                                  = ObjectField.OBJECT_END + 0x0076,      // Size: 1, Flags: (All)
        UNIT_BYTES3                                                       = ObjectField.OBJECT_END + 0x0077,      // Size: 1, Flags: (Owner) Nested: (TrainingPointsUsed, TrainingPointsTotal)
        UNIT_STATS                                                        = ObjectField.OBJECT_END + 0x0078,      // Size: 5, Flags: (Self, Owner)
        UNIT_STAT_POS_BUFF                                                = ObjectField.OBJECT_END + 0x007D,      // Size: 5, Flags: (Self, Owner)
        UNIT_STAT_NEG_BUFF                                                = ObjectField.OBJECT_END + 0x0082,      // Size: 5, Flags: (Self, Owner)
        UNIT_RESISTANCES                                                  = ObjectField.OBJECT_END + 0x0087,      // Size: 7, Flags: (Self, Owner, Empath)
        UNIT_RESISTANCE_BUFF_MODS_POSITIVE                                = ObjectField.OBJECT_END + 0x008E,      // Size: 7, Flags: (Self, Owner)
        UNIT_RESISTANCE_BUFF_MODS_NEGATIVE                                = ObjectField.OBJECT_END + 0x0095,      // Size: 7, Flags: (Self, Owner)
        UNIT_BASE_MANA                                                    = ObjectField.OBJECT_END + 0x009C,      // Size: 1, Flags: (All)
        UNIT_BASE_HEALTH                                                  = ObjectField.OBJECT_END + 0x009D,      // Size: 1, Flags: (Self, Owner)
        UNIT_BYTES4                                                       = ObjectField.OBJECT_END + 0x009E,      // Size: 1, Flags: (All) Nested: (SheatheState, PvpFlags, PetFlags, ShapeshiftForm)
        UNIT_ATTACK_POWER                                                 = ObjectField.OBJECT_END + 0x009F,      // Size: 1, Flags: (Self, Owner)
        UNIT_ATTACK_POWER_MOD_POS                                         = ObjectField.OBJECT_END + 0x00A0,      // Size: 1, Flags: (Self, Owner)
        UNIT_ATTACK_POWER_MOD_NEG                                         = ObjectField.OBJECT_END + 0x00A1,      // Size: 1, Flags: (Self, Owner)
        UNIT_ATTACK_POWER_MULTIPLIER                                      = ObjectField.OBJECT_END + 0x00A2,      // Size: 1, Flags: (Self, Owner)
        UNIT_RANGED_ATTACK_POWER                                          = ObjectField.OBJECT_END + 0x00A3,      // Size: 1, Flags: (Self, Owner)
        UNIT_RANGED_ATTACK_POWER_MOD_POS                                  = ObjectField.OBJECT_END + 0x00A4,      // Size: 1, Flags: (Self, Owner)
        UNIT_RANGED_ATTACK_POWER_MOD_NEG                                  = ObjectField.OBJECT_END + 0x00A5,      // Size: 1, Flags: (Self, Owner)
        UNIT_RANGED_ATTACK_POWER_MULTIPLIER                               = ObjectField.OBJECT_END + 0x00A6,      // Size: 1, Flags: (Self, Owner)
        UNIT_SET_ATTACK_SPEED_AURA                                        = ObjectField.OBJECT_END + 0x00A7,      // Size: 1, Flags: (Self, Owner)
        UNIT_LIFESTEAL                                                    = ObjectField.OBJECT_END + 0x00A8,      // Size: 1, Flags: (Self, Owner)
        UNIT_MIN_RANGED_DAMAGE                                            = ObjectField.OBJECT_END + 0x00A9,      // Size: 1, Flags: (Self, Owner)
        UNIT_MAX_RANGED_DAMAGE                                            = ObjectField.OBJECT_END + 0x00AA,      // Size: 1, Flags: (Self, Owner)
        UNIT_POWER_COST_MODIFIER                                          = ObjectField.OBJECT_END + 0x00AB,      // Size: 7, Flags: (Self, Owner)
        UNIT_POWER_COST_MULTIPLIER                                        = ObjectField.OBJECT_END + 0x00B2,      // Size: 7, Flags: (Self, Owner)
        UNIT_MAX_HEALTH_MODIFIER                                          = ObjectField.OBJECT_END + 0x00B9,      // Size: 1, Flags: (Self, Owner)
        UNIT_HOVER_HEIGHT                                                 = ObjectField.OBJECT_END + 0x00BA,      // Size: 1, Flags: (All)
        UNIT_MIN_ITEM_LEVEL_CUTOFF                                        = ObjectField.OBJECT_END + 0x00BB,      // Size: 1, Flags: (All)
        UNIT_MIN_ITEM_LEVEL                                               = ObjectField.OBJECT_END + 0x00BC,      // Size: 1, Flags: (All)
        UNIT_MAX_ITEM_LEVEL                                               = ObjectField.OBJECT_END + 0x00BD,      // Size: 1, Flags: (All)
        UNIT_WILD_BATTLE_PET_LEVEL                                        = ObjectField.OBJECT_END + 0x00BE,      // Size: 1, Flags: (All)
        UNIT_BATTLE_PET_COMPANION_NAME_TIMESTAMP                          = ObjectField.OBJECT_END + 0x00BF,      // Size: 1, Flags: (All)
        UNIT_INTERACT_SPELL_ID                                            = ObjectField.OBJECT_END + 0x00C0,      // Size: 1, Flags: (All)
        UNIT_STATE_SPELL_VISUAL_ID                                        = ObjectField.OBJECT_END + 0x00C1,      // Size: 1, Flags: (ViewerDependent, Urgent)
        UNIT_STATE_ANIM_ID                                                = ObjectField.OBJECT_END + 0x00C2,      // Size: 1, Flags: (ViewerDependent, Urgent)
        UNIT_STATE_ANIM_KIT_ID                                            = ObjectField.OBJECT_END + 0x00C3,      // Size: 1, Flags: (ViewerDependent, Urgent)
        UNIT_STATE_WORLD_EFFECT_ID                                        = ObjectField.OBJECT_END + 0x00C4,      // Size: 4, Flags: (ViewerDependent, Urgent)
        UNIT_SCALE_DURATION                                               = ObjectField.OBJECT_END + 0x00C8,      // Size: 1, Flags: (All)
        UNIT_LOOKS_LIKE_MOUNT_ID                                          = ObjectField.OBJECT_END + 0x00C9,      // Size: 1, Flags: (All)
        UNIT_LOOKS_LIKE_CREATURE_ID                                       = ObjectField.OBJECT_END + 0x00CA,      // Size: 1, Flags: (All)
        UNIT_LOOK_AT_CONTROLLER_ID                                        = ObjectField.OBJECT_END + 0x00CB,      // Size: 1, Flags: (All)
        UNIT_GUILD_GUID                                                   = ObjectField.OBJECT_END + 0x00CC,      // Size: 4, Flags: (All)
        UNIT_END                                                          = ObjectField.OBJECT_END + 0x00D0,
    }

    public enum UnitDynamicField
    {
        UNIT_DYNAMIC_PASSIVE_SPELLS                                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,      // Flags: (All, Urgent)
        UNIT_DYNAMIC_WORLD_EFFECTS                                        = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0001,      // Flags: (All, Urgent)
        UNIT_DYNAMIC_CHANNEL_OBJECTS                                      = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0002,      // Flags: (All, Urgent)
        UNIT_DYNAMIC_END                                                  = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0003,
    }

    public enum PlayerField
    {
        PLAYER_DUEL_ARBITER                                               = UnitField.UNIT_END + 0x0000,      // Size: 4, Flags: (All)
        PLAYER_WOW_ACCOUNT                                                = UnitField.UNIT_END + 0x0004,      // Size: 4, Flags: (All)
        PLAYER_LOOT_TARGET_GUID                                           = UnitField.UNIT_END + 0x0008,      // Size: 4, Flags: (All)
        PLAYER_PLAYER_FLAGS                                               = UnitField.UNIT_END + 0x000C,      // Size: 1, Flags: (All)
        PLAYER_PLAYER_FLAGS_EX                                            = UnitField.UNIT_END + 0x000D,      // Size: 1, Flags: (All)
        PLAYER_GUILD_RANK_ID                                              = UnitField.UNIT_END + 0x000E,      // Size: 1, Flags: (All)
        PLAYER_GUILD_DELETE_DATE                                          = UnitField.UNIT_END + 0x000F,      // Size: 1, Flags: (All)
        PLAYER_GUILD_LEVEL                                                = UnitField.UNIT_END + 0x0010,      // Size: 1, Flags: (All)
        PLAYER_BYTES1                                                     = UnitField.UNIT_END + 0x0011,      // Size: 1, Flags: (All) Nested: (PartyType, NumBankSlots, NativeSex, Inebriation)
        PLAYER_BYTES2                                                     = UnitField.UNIT_END + 0x0012,      // Size: 1, Flags: (All) Nested: (PvpTitle, ArenaFaction, PvpRank)
        PLAYER_DUEL_TEAM                                                  = UnitField.UNIT_END + 0x0013,      // Size: 1, Flags: (All)
        PLAYER_GUILD_TIME_STAMP                                           = UnitField.UNIT_END + 0x0014,      // Size: 1, Flags: (All)
        PLAYER_QUEST_LOG                                                  = UnitField.UNIT_END + 0x0015,      // Size: 400, Flags: (Party)
        PLAYER_VISIBLE_ITEMS                                              = UnitField.UNIT_END + 0x01A5,      // Size: 38, Flags: (All)
        PLAYER_PLAYER_TITLE                                               = UnitField.UNIT_END + 0x01CB,      // Size: 1, Flags: (All)
        PLAYER_FAKE_INEBRIATION                                           = UnitField.UNIT_END + 0x01CC,      // Size: 1, Flags: (All)
        PLAYER_VIRTUAL_PLAYER_REALM                                       = UnitField.UNIT_END + 0x01CD,      // Size: 1, Flags: (All)
        PLAYER_CURRENT_SPEC_ID                                            = UnitField.UNIT_END + 0x01CE,      // Size: 1, Flags: (All)
        PLAYER_TAXI_MOUNT_ANIM_KIT_ID                                     = UnitField.UNIT_END + 0x01CF,      // Size: 1, Flags: (All)
        PLAYER_AVG_ITEM_LEVEL                                             = UnitField.UNIT_END + 0x01D0,      // Size: 4, Flags: (All)
        PLAYER_CURRENT_BATTLE_PET_BREED_QUALITY                           = UnitField.UNIT_END + 0x01D4,      // Size: 1, Flags: (All)
        PLAYER_HONOR_LEVEL                                                = UnitField.UNIT_END + 0x01D5,      // Size: 1, Flags: (All)
        PLAYER_CUSTOMIZATION_CHOICES                                      = UnitField.UNIT_END + 0x01D6,      // Size: 72, Flags: (All)
        PLAYER_END                                                        = UnitField.UNIT_END + 0x021E,
    }

    public enum PlayerDynamicField
    {
        PLAYER_DYNAMIC_ARENA_COOLDOWNS                                    = UnitDynamicField.UNIT_DYNAMIC_END + 0x0000,      // Flags: (All)
        PLAYER_DYNAMIC_END                                                = UnitDynamicField.UNIT_DYNAMIC_END + 0x0001,
    }

    public enum ActivePlayerField
    {
        ACTIVE_PLAYER_INV_SLOTS                                           = PlayerField.PLAYER_END + 0x0000,      // Size: 516, Flags: (All)
        ACTIVE_PLAYER_FARSIGHT_OBJECT                                     = PlayerField.PLAYER_END + 0x0204,      // Size: 4, Flags: (All)
        ACTIVE_PLAYER_COMBO_TARGET                                        = PlayerField.PLAYER_END + 0x0208,      // Size: 4, Flags: (All)
        ACTIVE_PLAYER_SUMMONED_BATTLE_PET_GUID                            = PlayerField.PLAYER_END + 0x020C,      // Size: 4, Flags: (All)
        ACTIVE_PLAYER_KNOWN_TITLES                                        = PlayerField.PLAYER_END + 0x0210,      // Size: 12, Flags: (All)
        ACTIVE_PLAYER_COINAGE                                             = PlayerField.PLAYER_END + 0x021C,      // Size: 2, Flags: (All)
        ACTIVE_PLAYER_XP                                                  = PlayerField.PLAYER_END + 0x021E,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_NEXT_LEVEL_XP                                       = PlayerField.PLAYER_END + 0x021F,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_TRIAL_XP                                            = PlayerField.PLAYER_END + 0x0220,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_SKILL                                               = PlayerField.PLAYER_END + 0x0221,      // Size: 896, Flags: (All)
        ACTIVE_PLAYER_CHARACTER_POINTS                                    = PlayerField.PLAYER_END + 0x05A1,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MAX_TALENT_TIERS                                    = PlayerField.PLAYER_END + 0x05A2,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_TRACK_CREATURE_MASK                                 = PlayerField.PLAYER_END + 0x05A3,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_TRACK_RESOURCE_MASK                                 = PlayerField.PLAYER_END + 0x05A4,      // Size: 2, Flags: (All)
        ACTIVE_PLAYER_MAINHAND_EXPERTISE                                  = PlayerField.PLAYER_END + 0x05A6,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_OFFHAND_EXPERTISE                                   = PlayerField.PLAYER_END + 0x05A7,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_RANGED_EXPERTISE                                    = PlayerField.PLAYER_END + 0x05A8,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_COMBAT_RATING_EXPERTISE                             = PlayerField.PLAYER_END + 0x05A9,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_BLOCK_PERCENTAGE                                    = PlayerField.PLAYER_END + 0x05AA,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_DODGE_PERCENTAGE                                    = PlayerField.PLAYER_END + 0x05AB,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_DODGE_PERCENTAGE_FROM_ATTRIBUTE                     = PlayerField.PLAYER_END + 0x05AC,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PARRY_PERCENTAGE                                    = PlayerField.PLAYER_END + 0x05AD,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PARRY_PERCENTAGE_FROM_ATTRIBUTE                     = PlayerField.PLAYER_END + 0x05AE,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_CRIT_PERCENTAGE                                     = PlayerField.PLAYER_END + 0x05AF,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_RANGED_CRIT_PERCENTAGE                              = PlayerField.PLAYER_END + 0x05B0,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_OFFHAND_CRIT_PERCENTAGE                             = PlayerField.PLAYER_END + 0x05B1,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_SPELL_CRIT_PERCENTAGE                               = PlayerField.PLAYER_END + 0x05B2,      // Size: 7, Flags: (All)
        ACTIVE_PLAYER_SHIELD_BLOCK                                        = PlayerField.PLAYER_END + 0x05B9,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MASTERY                                             = PlayerField.PLAYER_END + 0x05BA,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_SPEED                                               = PlayerField.PLAYER_END + 0x05BB,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_AVOIDANCE                                           = PlayerField.PLAYER_END + 0x05BC,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_STURDINESS                                          = PlayerField.PLAYER_END + 0x05BD,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_VERSATILITY                                         = PlayerField.PLAYER_END + 0x05BE,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_VERSATILITY_BONUS                                   = PlayerField.PLAYER_END + 0x05BF,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PVP_POWER_DAMAGE                                    = PlayerField.PLAYER_END + 0x05C0,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PVP_POWER_HEALING                                   = PlayerField.PLAYER_END + 0x05C1,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_EXPLORED_ZONES                                      = PlayerField.PLAYER_END + 0x05C2,      // Size: 384, Flags: (All)
        ACTIVE_PLAYER_REST_INFO                                           = PlayerField.PLAYER_END + 0x0742,      // Size: 4, Flags: (All)
        ACTIVE_PLAYER_MOD_DAMAGE_DONE_POS                                 = PlayerField.PLAYER_END + 0x0746,      // Size: 7, Flags: (All)
        ACTIVE_PLAYER_MOD_DAMAGE_DONE_NEG                                 = PlayerField.PLAYER_END + 0x074D,      // Size: 7, Flags: (All)
        ACTIVE_PLAYER_MOD_DAMAGE_DONE_PERCENT                             = PlayerField.PLAYER_END + 0x0754,      // Size: 7, Flags: (All)
        ACTIVE_PLAYER_MOD_HEALING_DONE_POS                                = PlayerField.PLAYER_END + 0x075B,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MOD_HEALING_PERCENT                                 = PlayerField.PLAYER_END + 0x075C,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MOD_HEALING_DONE_PERCENT                            = PlayerField.PLAYER_END + 0x075D,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MOD_PERIODIC_HEALING_DONE_PERCENT                   = PlayerField.PLAYER_END + 0x075E,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_WEAPON_DMG_MULTIPLIERS                              = PlayerField.PLAYER_END + 0x075F,      // Size: 3, Flags: (All)
        ACTIVE_PLAYER_WEAPON_ATK_SPEED_MULTIPLIERS                        = PlayerField.PLAYER_END + 0x0762,      // Size: 3, Flags: (All)
        ACTIVE_PLAYER_MOD_SPELL_POWER_PERCENT                             = PlayerField.PLAYER_END + 0x0765,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MOD_RESILIENCE_PERCENT                              = PlayerField.PLAYER_END + 0x0766,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_OVERRIDE_SPELL_POWER_BY_AP_PERCENT                  = PlayerField.PLAYER_END + 0x0767,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_OVERRIDE_AP_BY_SPELL_POWER_PERCENT                  = PlayerField.PLAYER_END + 0x0768,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MOD_TARGET_RESISTANCE                               = PlayerField.PLAYER_END + 0x0769,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MOD_TARGET_PHYSICAL_RESISTANCE                      = PlayerField.PLAYER_END + 0x076A,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_LOCAL_FLAGS                                         = PlayerField.PLAYER_END + 0x076B,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_BYTES1                                              = PlayerField.PLAYER_END + 0x076C,      // Size: 1, Flags: (All) Nested: (GrantableLevels, MultiActionBars, LifetimeMaxRank, NumRespecs)
        ACTIVE_PLAYER_AMMO_ID                                             = PlayerField.PLAYER_END + 0x076D,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PVP_MEDALS                                          = PlayerField.PLAYER_END + 0x076E,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_BUYBACK_PRICE                                       = PlayerField.PLAYER_END + 0x076F,      // Size: 12, Flags: (All)
        ACTIVE_PLAYER_BUYBACK_TIMESTAMP                                   = PlayerField.PLAYER_END + 0x077B,      // Size: 12, Flags: (All)
        ACTIVE_PLAYER_BYTES2                                              = PlayerField.PLAYER_END + 0x0787,      // Size: 1, Flags: (All) Nested: (TodayHonorableKills, YesterdayHonorableKills)
        ACTIVE_PLAYER_BYTES3                                              = PlayerField.PLAYER_END + 0x0788,      // Size: 1, Flags: (All) Nested: (LastWeekHonorableKills, ThisWeekHonorableKills)
        ACTIVE_PLAYER_THIS_WEEK_CONTRIBUTION                              = PlayerField.PLAYER_END + 0x0789,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_LIFETIME_HONORABLE_KILLS                            = PlayerField.PLAYER_END + 0x078A,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_YESTERDAY_CONTRIBUTION                              = PlayerField.PLAYER_END + 0x078B,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_LAST_WEEK_CONTRIBUTION                              = PlayerField.PLAYER_END + 0x078C,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_LAST_WEEK_RANK                                      = PlayerField.PLAYER_END + 0x078D,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_WATCHED_FACTION_INDEX                               = PlayerField.PLAYER_END + 0x078E,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_COMBAT_RATINGS                                      = PlayerField.PLAYER_END + 0x078F,      // Size: 32, Flags: (All)
        ACTIVE_PLAYER_PVP_INFO                                            = PlayerField.PLAYER_END + 0x07AF,      // Size: 72, Flags: (All)
        ACTIVE_PLAYER_MAX_LEVEL                                           = PlayerField.PLAYER_END + 0x07F7,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_SCALING_PLAYER_LEVEL_DELTA                          = PlayerField.PLAYER_END + 0x07F8,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MAX_CREATURE_SCALING_LEVEL                          = PlayerField.PLAYER_END + 0x07F9,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_NO_REAGENT_COST_MASK                                = PlayerField.PLAYER_END + 0x07FA,      // Size: 4, Flags: (All)
        ACTIVE_PLAYER_PET_SPELL_POWER                                     = PlayerField.PLAYER_END + 0x07FE,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PROFESSION_SKILL_LINE                               = PlayerField.PLAYER_END + 0x07FF,      // Size: 2, Flags: (All)
        ACTIVE_PLAYER_UI_HIT_MODIFIER                                     = PlayerField.PLAYER_END + 0x0801,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_UI_SPELL_HIT_MODIFIER                               = PlayerField.PLAYER_END + 0x0802,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_HOME_REALM_TIME_OFFSET                              = PlayerField.PLAYER_END + 0x0803,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_MOD_PET_HASTE                                       = PlayerField.PLAYER_END + 0x0804,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_BYTES4                                              = PlayerField.PLAYER_END + 0x0805,      // Size: 1, Flags: (All) Nested: (LocalRegenFlags, AuraVision, NumBackpackSlots)
        ACTIVE_PLAYER_OVERRIDE_SPELLS_ID                                  = PlayerField.PLAYER_END + 0x0806,      // Size: 1, Flags: (All, UrgentSelfOnly)
        ACTIVE_PLAYER_LFG_BONUS_FACTION_ID                                = PlayerField.PLAYER_END + 0x0807,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_LOOT_SPEC_ID                                        = PlayerField.PLAYER_END + 0x0808,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_OVERRIDE_ZONE_PVP_TYPE                              = PlayerField.PLAYER_END + 0x0809,      // Size: 1, Flags: (All, UrgentSelfOnly)
        ACTIVE_PLAYER_BAG_SLOT_FLAGS                                      = PlayerField.PLAYER_END + 0x080A,      // Size: 4, Flags: (All)
        ACTIVE_PLAYER_BANK_BAG_SLOT_FLAGS                                 = PlayerField.PLAYER_END + 0x080E,      // Size: 7, Flags: (All)
        ACTIVE_PLAYER_QUEST_COMPLETED                                     = PlayerField.PLAYER_END + 0x0815,      // Size: 1750, Flags: (All)
        ACTIVE_PLAYER_HONOR                                               = PlayerField.PLAYER_END + 0x0EEB,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_HONOR_NEXT_LEVEL                                    = PlayerField.PLAYER_END + 0x0EEC,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PVP_TIER_MAX_FROM_WINS                              = PlayerField.PLAYER_END + 0x0EED,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_PVP_LAST_WEEKS_TIER_MAX_FROM_WINS                   = PlayerField.PLAYER_END + 0x0EEE,      // Size: 1, Flags: (All)
        ACTIVE_PLAYER_BYTES5                                              = PlayerField.PLAYER_END + 0x0EEF,      // Size: 1, Flags: (All) Nested: (InsertItemsLeftToRight, PvpRankProgress)
        ACTIVE_PLAYER_END                                                 = PlayerField.PLAYER_END + 0x0EF0,
    }

    public enum ActivePlayerDynamicField
    {
        ACTIVE_PLAYER_DYNAMIC_RESEARCH                                    = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0000,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_RESEARCH_SITES                              = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0001,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_RESEARCH_SITE_PROGRESS                      = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0002,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_DAILY_QUESTS_COMPLETED                      = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0003,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_AVAILABLE_QUEST_LINE_X_QUEST_IDS            = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0004,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_HEIRLOOMS                                   = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0005,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_HEIRLOOM_FLAGS                              = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0006,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_TOYS                                        = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0007,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_TRANSMOG                                    = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0008,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_CONDITIONAL_TRANSMOG                        = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x0009,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_SELF_RES_SPELLS                             = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x000A,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_CHARACTER_RESTRICTIONS                      = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x000B,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_SPELL_FLAT_MOD_BY_LABEL                     = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x000C,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_SPELL_PCT_MOD_BY_LABEL                      = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x000D,      // Flags: (All)
        ACTIVE_PLAYER_DYNAMIC_END                                         = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x000E,
    }

    public enum GameObjectField
    {
        GAME_OBJECT_CREATED_BY                                            = ObjectField.OBJECT_END + 0x0000,      // Size: 4, Flags: (All)
        GAME_OBJECT_GUILD_GUID                                            = ObjectField.OBJECT_END + 0x0004,      // Size: 4, Flags: (All)
        GAME_OBJECT_DISPLAY_ID                                            = ObjectField.OBJECT_END + 0x0008,      // Size: 1, Flags: (ViewerDependent, Urgent)
        GAME_OBJECT_FLAGS                                                 = ObjectField.OBJECT_END + 0x0009,      // Size: 1, Flags: (All, Urgent)
        GAME_OBJECT_PARENT_ROTATION                                       = ObjectField.OBJECT_END + 0x000A,      // Size: 4, Flags: (All)
        GAME_OBJECT_FACTION_TEMPLATE                                      = ObjectField.OBJECT_END + 0x000E,      // Size: 1, Flags: (All)
        GAME_OBJECT_LEVEL                                                 = ObjectField.OBJECT_END + 0x000F,      // Size: 1, Flags: (All)
        GAME_OBJECT_BYTES1                                                = ObjectField.OBJECT_END + 0x0010,      // Size: 1, Flags: (All, Urgent) Nested: (State, TypeID, ArtKit, PercentHealth)
        GAME_OBJECT_SPELL_VISUAL_ID                                       = ObjectField.OBJECT_END + 0x0011,      // Size: 1, Flags: (All, ViewerDependent, Urgent)
        GAME_OBJECT_STATE_SPELL_VISUAL_ID                                 = ObjectField.OBJECT_END + 0x0012,      // Size: 1, Flags: (ViewerDependent, Urgent)
        GAME_OBJECT_SPAWN_TRACKING_STATE_ANIM_ID                          = ObjectField.OBJECT_END + 0x0013,      // Size: 1, Flags: (ViewerDependent, Urgent)
        GAME_OBJECT_SPAWN_TRACKING_STATE_ANIM_KIT_ID                      = ObjectField.OBJECT_END + 0x0014,      // Size: 1, Flags: (ViewerDependent, Urgent)
        GAME_OBJECT_STATE_WORLD_EFFECT_ID                                 = ObjectField.OBJECT_END + 0x0015,      // Size: 4, Flags: (ViewerDependent, Urgent)
        GAME_OBJECT_CUSTOM_PARAM                                          = ObjectField.OBJECT_END + 0x0019,      // Size: 1, Flags: (All, Urgent)
        GAME_OBJECT_END                                                   = ObjectField.OBJECT_END + 0x001A,
    }

    public enum GameObjectDynamicField
    {
        GAME_OBJECT_DYNAMIC_ENABLE_DOODAD_SETS                            = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,      // Flags: (All)
        GAME_OBJECT_DYNAMIC_END                                           = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0001,
    }

    public enum DynamicObjectField
    {
        DYNAMIC_OBJECT_CASTER                                             = ObjectField.OBJECT_END + 0x0000,      // Size: 4, Flags: (All)
        DYNAMIC_OBJECT_TYPE                                               = ObjectField.OBJECT_END + 0x0004,      // Size: 1, Flags: (All)
        DYNAMIC_OBJECT_SPELL_X_SPELL_VISUAL_ID                            = ObjectField.OBJECT_END + 0x0005,      // Size: 1, Flags: (All)
        DYNAMIC_OBJECT_SPELL_ID                                           = ObjectField.OBJECT_END + 0x0006,      // Size: 1, Flags: (All)
        DYNAMIC_OBJECT_RADIUS                                             = ObjectField.OBJECT_END + 0x0007,      // Size: 1, Flags: (All)
        DYNAMIC_OBJECT_CAST_TIME                                          = ObjectField.OBJECT_END + 0x0008,      // Size: 1, Flags: (All)
        DYNAMIC_OBJECT_END                                                = ObjectField.OBJECT_END + 0x0009,
    }

    public enum DynamicObjectDynamicField
    {
        DYNAMIC_OBJECT_DYNAMIC_END                                        = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,
    }

    public enum CorpseField
    {
        CORPSE_OWNER                                                      = ObjectField.OBJECT_END + 0x0000,      // Size: 4, Flags: (All)
        CORPSE_PARTY_GUID                                                 = ObjectField.OBJECT_END + 0x0004,      // Size: 4, Flags: (All)
        CORPSE_GUILD_GUID                                                 = ObjectField.OBJECT_END + 0x0008,      // Size: 4, Flags: (All)
        CORPSE_DISPLAY_ID                                                 = ObjectField.OBJECT_END + 0x000C,      // Size: 1, Flags: (All)
        CORPSE_ITEMS                                                      = ObjectField.OBJECT_END + 0x000D,      // Size: 19, Flags: (All)
        CORPSE_BYTES1                                                     = ObjectField.OBJECT_END + 0x0020,      // Size: 1, Flags: (All) Nested: (RaceID, Sex, ClassID, Padding)
        CORPSE_FLAGS                                                      = ObjectField.OBJECT_END + 0x0021,      // Size: 1, Flags: (All)
        CORPSE_DYNAMIC_FLAGS                                              = ObjectField.OBJECT_END + 0x0022,      // Size: 1, Flags: (ViewerDependent)
        CORPSE_FACTION_TEMPLATE                                           = ObjectField.OBJECT_END + 0x0023,      // Size: 1, Flags: (All)
        CORPSE_CUSTOMIZATION_CHOICES                                      = ObjectField.OBJECT_END + 0x0024,      // Size: 72, Flags: (All)
        CORPSE_END                                                        = ObjectField.OBJECT_END + 0x006C,
    }

    public enum CorpseDynamicField
    {
        CORPSE_DYNAMIC_END                                                = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,
    }

    public enum AreaTriggerField
    {
        AREA_TRIGGER_OVERRIDE_SCALE_CURVE                                 = ObjectField.OBJECT_END + 0x0000,      // Size: 7, Flags: (All, Urgent)
        AREA_TRIGGER_EXTRA_SCALE_CURVE                                    = ObjectField.OBJECT_END + 0x0007,      // Size: 7, Flags: (All, Urgent)
        AREA_TRIGGER_CASTER                                               = ObjectField.OBJECT_END + 0x000E,      // Size: 4, Flags: (All)
        AREA_TRIGGER_DURATION                                             = ObjectField.OBJECT_END + 0x0012,      // Size: 1, Flags: (All)
        AREA_TRIGGER_TIME_TO_TARGET                                       = ObjectField.OBJECT_END + 0x0013,      // Size: 1, Flags: (All, Urgent)
        AREA_TRIGGER_TIME_TO_TARGET_SCALE                                 = ObjectField.OBJECT_END + 0x0014,      // Size: 1, Flags: (All, Urgent)
        AREA_TRIGGER_TIME_TO_TARGET_EXTRA_SCALE                           = ObjectField.OBJECT_END + 0x0015,      // Size: 1, Flags: (All, Urgent)
        AREA_TRIGGER_SPELL_ID                                             = ObjectField.OBJECT_END + 0x0016,      // Size: 1, Flags: (All)
        AREA_TRIGGER_SPELL_FOR_VISUALS                                    = ObjectField.OBJECT_END + 0x0017,      // Size: 1, Flags: (All)
        AREA_TRIGGER_SPELL_X_SPELL_VISUAL_ID                              = ObjectField.OBJECT_END + 0x0018,      // Size: 1, Flags: (All)
        AREA_TRIGGER_BOUNDS_RADIUS2D                                      = ObjectField.OBJECT_END + 0x0019,      // Size: 1, Flags: (ViewerDependent, Urgent)
        AREA_TRIGGER_DECAL_PROPERTIES_ID                                  = ObjectField.OBJECT_END + 0x001A,      // Size: 1, Flags: (All)
        AREA_TRIGGER_CREATING_EFFECT_GUID                                 = ObjectField.OBJECT_END + 0x001B,      // Size: 4, Flags: (All)
        AREA_TRIGGER_END                                                  = ObjectField.OBJECT_END + 0x001F,
    }

    public enum AreaTriggerDynamicField
    {
        AREA_TRIGGER_DYNAMIC_END                                          = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,
    }

    public enum SceneObjectField
    {
        SCENE_OBJECT_SCRIPT_PACKAGE_ID                                    = ObjectField.OBJECT_END + 0x0000,      // Size: 1, Flags: (All)
        SCENE_OBJECT_RND_SEED_VAL                                         = ObjectField.OBJECT_END + 0x0001,      // Size: 1, Flags: (All)
        SCENE_OBJECT_CREATED_BY                                           = ObjectField.OBJECT_END + 0x0002,      // Size: 4, Flags: (All)
        SCENE_OBJECT_SCENE_TYPE                                           = ObjectField.OBJECT_END + 0x0006,      // Size: 1, Flags: (All)
        SCENE_OBJECT_END                                                  = ObjectField.OBJECT_END + 0x0007,
    }

    public enum SceneObjectDynamicField
    {
        SCENE_OBJECT_DYNAMIC_END                                          = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,
    }

    public enum ConversationField
    {
        CONVERSATION_LAST_LINE_END_TIME                                   = ObjectField.OBJECT_END + 0x0000,      // Size: 1, Flags: (ViewerDependent)
        CONVERSATION_END                                                  = ObjectField.OBJECT_END + 0x0001,
    }

    public enum ConversationDynamicField
    {
        CONVERSATION_DYNAMIC_ACTORS                                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0000,      // Flags: (All)
        CONVERSATION_DYNAMIC_LINES                                        = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0001,      // Flags: (Unk0x100)
        CONVERSATION_DYNAMIC_END                                          = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x0002,
    }
}

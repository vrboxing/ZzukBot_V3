﻿using System;

namespace ZzukBot.Constants
{
    /// <summary>
    ///     Enums for all kind of things
    /// </summary>
    public static class Enums
    {
        /// <summary>
        ///     Type of units that can send chat messages
        /// </summary>
        public enum ChatSenderType
        {
            Player = 1,
            Npc = 2
        }

        /// <summary>
        /// CombatPosition used in CustomClasses
        /// </summary>
        public enum CombatPosition
        {
            Before = 1,
            Behind = 2,
            Kite = 3,
            RunAway = 4
        }

        /// <summary>
        /// Quest states of a NPC
        /// </summary>
        public enum NpcQuestOfferState
        {
            /// <summary>
            /// None
            /// </summary>
            None = 0,
            /// <summary>
            /// NPC offers a quest but its not yet acceptable (a silver !)
            /// </summary>
            OffersQuestNotAcceptable = 1,
            /// <summary>
            /// NPC offers a quest but the quest is out of the characters level range (no yellow !)
            /// </summary>
            OffersQuestLowLevel = 2,
            /// <summary>
            /// We can turn in a quest at that NPC but we havnt completed it yet (silver ?)
            /// </summary>
            CanTurnInNotCompleteable = 3,
            /// <summary>
            /// The NPC offers a quest (yellow !)
            /// </summary>
            OffersQuest = 5,
            /// <summary>
            /// We can turn in a quest at that NPC (yellow ?)
            /// </summary>
            CanTurnIn = 7,
        }


        /// <summary>
        /// Gather types of WoW
        /// </summary>
        public enum GatherType
        {
            None = -1,
            Herbalism = 2,
            Mining = 3
        }

        /// <summary>
        /// Skills in WoW
        /// </summary>
        public enum Skills : short
        {
            FROST = 6,
            FIRE = 8,
            ARMS = 26,
            COMBAT = 38,
            SUBTLETY = 39,
            POISONS = 40,
            SWORDS = 43,
            AXES = 44,
            BOWS = 45,
            GUNS = 46,
            BEAST_MASTERY = 50,
            SURVIVAL = 51,
            MACES = 54,
            TWOHAND_SWORDS = 55,
            HOLY = 56,
            SHADOW = 78,
            DEFENSE = 95,
            LANG_COMMON = 98,
            RACIAL_DWARVEN = 101,
            LANG_ORCISH = 109,
            LANG_DWARVEN = 111,
            LANG_DARNASSIAN = 113,
            LANG_TAURAHE = 115,
            DUAL_WIELD = 118,
            RACIAL_TAUREN = 124,
            ORC_RACIAL = 125,
            RACIAL_NIGHT_ELF = 126,
            FIRST_AID = 129,
            FERAL_COMBAT = 134,
            LANG_THALASSIAN = 137,
            STAVES = 136,
            LANG_DRACONIC = 138,
            LANG_DEMON_TONGUE = 139,
            LANG_TITAN = 140,
            LANG_OLD_TONGUE = 141,
            SURVIVAL2 = 142,
            RIDING_HORSE = 148,
            RIDING_WOLF = 149,
            RIDING_RAM = 152,
            RIDING_TIGER = 150,
            SWIMING = 155,
            TWOHAND_MACES = 160,
            UNARMED = 162,
            MARKSMANSHIP = 163,
            BLACKSMITHING = 164,
            LEATHERWORKING = 165,
            ALCHEMY = 171,
            TWOHAND_AXES = 172,
            DAGGERS = 173,
            THROWN = 176,
            HERBALISM = 182,
            GENERIC_DND = 183,
            RETRIBUTION = 184,
            COOKING = 185,
            MINING = 186,
            PET_IMP = 188,
            PET_FELHUNTER = 189,
            TAILORING = 197,
            ENGINERING = 202,
            PET_SPIDER = 203,
            PET_VOIDWALKER = 204,
            PET_SUCCUBUS = 205,
            PET_INFERNAL = 206,
            PET_DOOMGUARD = 207,
            PET_WOLF = 208,
            PET_CAT = 209,
            PET_BEAR = 210,
            PET_BOAR = 211,
            PET_CROCILISK = 212,
            PET_CARRION_BIRD = 213,
            PET_GORILLA = 215,
            PET_CRAB = 214,
            PET_RAPTOR = 217,
            PET_TALLSTRIDER = 218,
            RACIAL_UNDED = 220,
            CROSSBOWS = 226,
            SPEARS = 227,
            WANDS = 228,
            POLEARMS = 229,
            ATTRIBUTE_ENCHANCEMENTS = 230,
            SLAYER_TALENTS = 231,
            MAGIC_TALENTS = 233,
            DEFENSIVE_TALENTS = 234,
            PET_SCORPID = 236,
            ARCANE = 237,
            PET_TURTLE = 251,
            FURY = 256,
            PROTECTION = 257,
            BEAST_TRAINING = 261,
            PROTECTION2 = 267,
            PET_TALENTS = 270,
            PLATE_MAIL = 293,
            ASSASSINATION = 253,
            LANG_GNOMISH = 313,
            LANG_TROLL = 315,
            ENCHANTING = 333,
            DEMONOLOGY = 354,
            AFFLICTION = 355,
            FISHING = 356,
            ENHANCEMENT = 373,
            RESTORATION = 374,
            ELEMENTAL_COMBAT = 375,
            SKINNING = 393,
            LEATHER = 414,
            CLOTH = 415,
            MAIL = 413,
            SHIELD = 433,
            FIST_WEAPONS = 473,
            TRACKING_BEAST = 513,
            TRACKING_HUMANOID = 514,
            TRACKING_DEMON = 516,
            TRACKING_UNDEAD = 517,
            TRACKING_DRAGON = 518,
            TRACKING_ELEMENTAL = 519,
            RIDING_RAPTOR = 533,
            RIDING_MECHANOSTRIDER = 553,
            RIDING_UNDEAD_HORSE = 554,
            RESTORATION2 = 573,
            BALANCE = 574,
            DESTRUCTION = 593,
            HOLY2 = 594,
            DISCIPLINE = 613,
            LOCKPICKING = 633,
            PET_BAT = 653,
            PET_HYENA = 654,
            PET_OWL = 655,
            PET_WIND_SERPENT = 656,
            LANG_GUTTERSPEAK = 673,
            RIDING_KODO = 713,
            RACIAL_TROLL = 733,
            RACIAL_GNOME = 753,
            RACIAL_HUMAN = 754,
            JEWELCRAFTING = 755,
            RACIAL_BLOODELF = 756,
            PET_EVENT_REMOTECONTROL = 758,
            LANG_DRAENEI = 759,
            DRAENEI_RACIAL = 760,
            PET_FELGUARD = 761,
            RIDING = 762,
            PET_DRAGONHAWK = 763,
            PET_NETHER_RAY = 764,
            PET_SPOREBAT = 765,
            PET_WARP_STALKER = 766,
            PET_RAVAGER = 767,
            PET_SERPENT = 768,
            INTERNAL = 769,
        }

        /// <summary>
        /// Qualities of WoW Items
        /// </summary>
        public enum ItemQuality
        {
            Poor = 0,
            Common = 1,
            Uncommon = 2,
            Rare = 3,
            Epic = 4,
            Legendary = 5,
        }

        /// <summary>
        /// UnitFlags
        /// </summary>
        [Flags]
        public enum UnitFlags
        {
            UNIT_FLAG_FLEEING = 0x00800000,
            UNIT_FLAG_CONFUSED = 0x00400000,
            UNIT_FLAG_IN_COMBAT = 0x00080000,
            UNIT_FLAG_SKINNABLE = 0x04000000,
            UNIT_FLAG_STUNNED = 0x00040000,
            UNIT_FLAG_DISABLE_MOVE = 0x00000004,
            UNIT_FLAG_SILENCED = 0x00002000
        }

        /// <summary>
        /// MovementFlags enum
        /// </summary>
        [Flags]
        public enum MovementFlags
        {
            None = 0x0,
            Front = 0x00000001,
            Back = 0x00000002,
            Left = 0x00000010,
            Right = 0x00000020,
            StrafeLeft = 0x00000004,
            StrafeRight = 0x00000008,

            Swimming = 0x00200000,
            jumping = 0x00002000,
            Falling = 0x0000A000,
            Levitate = 0x70000000
        }

        /// <summary>
        ///     Classes of WoW
        /// </summary>
        public enum ClassId : byte
        {
            Warrior = 1,
            Paladin = 2,
            Hunter = 3,
            Rogue = 4,
            Priest = 5,
            Shaman = 7,
            Mage = 8,
            Warlock = 9,
            Druid = 11
        }

        /// <summary>
        ///     ControlBits used for movement
        /// </summary>
        [Flags]
        public enum ControlBits
        {
            Nothing = 0x00000000,
            CtmWalk = 0x00001000,
            Front = 0x00000010,
            Back = 0x00000020,
            Left = 0x00000100,
            Right = 0x00000200,
            StrafeLeft = 0x00000040,
            StrafeRight = 0x00000080
        }

        /// <summary>
        /// NpcFlags - taken straight from mangos (some might be incorrect in conclusion)
        /// </summary>
        [Flags]
        public enum NpcFlags
        {
            UNIT_NPC_FLAG_NONE = 0x00000000,
            UNIT_NPC_FLAG_GOSSIP = 0x00000001,       // 100%
            UNIT_NPC_FLAG_QUESTGIVER = 0x00000002,       // guessed, probably ok
            UNIT_NPC_FLAG_VENDOR = 0x00000004,       // 100%
            UNIT_NPC_FLAG_FLIGHTMASTER = 0x00000008,       // 100%
            UNIT_NPC_FLAG_TRAINER = 0x00000010,       // 100%
            UNIT_NPC_FLAG_SPIRITHEALER = 0x00000020,       // guessed
            UNIT_NPC_FLAG_SPIRITGUIDE = 0x00000040,       // guessed
            UNIT_NPC_FLAG_INNKEEPER = 0x00000080,       // 100%
            UNIT_NPC_FLAG_BANKER = 0x00000100,       // 100%
            UNIT_NPC_FLAG_PETITIONER = 0x00000200,       // 100% 0xC0000 = guild petitions
            UNIT_NPC_FLAG_TABARDDESIGNER = 0x00000400,       // 100%
            UNIT_NPC_FLAG_BATTLEMASTER = 0x00000800,       // 100%
            UNIT_NPC_FLAG_AUCTIONEER = 0x00001000,       // 100%
            UNIT_NPC_FLAG_STABLEMASTER = 0x00002000,       // 100%
            UNIT_NPC_FLAG_REPAIR = 0x00004000,       // 100%
            UNIT_NPC_FLAG_OUTDOORPVP = 0x20000000, // custom flag for outdoor pvp creatures || Custom flag
        }

        /// <summary>
        ///     The different ranks of creatures
        /// </summary>
        public enum CreatureRankTypes
        {
            Normal = 0,
            Elite = 1,
            RareElite = 2,
            Boss = 3,
            Rare = 4
        }

        /// <summary>
        /// Types of creatures
        /// </summary>
        public enum CreatureType
        {
            Beast = 1,
            Dragonkin = 2,
            Demon = 3,
            Elemental = 4,
            Giant = 5,
            Undead = 6,
            Humanoid = 7,
            Critter = 8,
            Mechanical = 9,
            NotSpecified = 10,
            Totem = 11,
        }

        /// <summary>
        ///     Character equipment slots
        /// </summary>
        public enum EquipSlot
        {
            Head = 1,
            Neck = 2,
            Shoulders = 3,
            Back = 15,
            Chest = 5,
            Shirt = 4,
            Tabard = 19,
            Wrist = 9,
            MainHand = 16,
            OffHand = 17,
            Ranged = 18,
            Hands = 10,
            Waist = 6,
            Legs = 7,
            Feet = 8,
            Finger1 = 11,
            Finger2 = 12,
            Trinket1 = 13,
            Trinket2 = 14
        }

        /// <summary>
        ///     The different types of Gossip Options in WoW
        /// </summary>
        public enum GossipTypes
        {
            gossip = 0,
            vendor = 1,
            taxi = 2,
            trainer = 3,
            healer = 4,
            binder = 5,
            banker = 6,
            petition = 7,
            tabard = 8,
            battlemaster = 9,
            auctioneer = 10
        }

        /// <summary>
        ///     Login states (login, charselect)
        /// </summary>
        public enum LoginStates
        {
            login,
            charselect
        }

        /// <summary>
        ///     Types of Quest-Frames (Accept, Continue, Complete, None)
        /// </summary>
        public enum QuestFrameState
        {
            Accept = 1,
            Continue = 2,
            Complete = 3,
            Greeting = 0
        }

        /// <summary>
        ///     The state of a quest selectable in a gossip dialog (complete, accept etc.)
        /// </summary>
        public enum QuestGossipState
        {
            Accepted = 3,
            Available = 5,
            Completeable = 4
        }

        /// <summary>
        ///     Quest-objective types: Kill, Collect or Event
        /// </summary>
        public enum QuestObjectiveTypes : byte
        {
            Kill = 1,
            Collect = 2,
            Event = 3
        }

        /// <summary>
        ///     The possible states of an accepted quest
        /// </summary>
        public enum QuestState
        {
            Completed = 1,
            InProgress = 0,
            Failed = -1
        }

        /// <summary>
        ///     Possible reactions of units
        /// </summary>
        public enum UnitReaction
        {
            Neutral = 3,
            Friendly = 4,

            // Guards of the other faction are for example hostile 2.
            // All other hostile mobs I met are just hostile.
            Hostile = 1,
            Hostile2 = 0
        }

        /// <summary>
        ///     Different types of WoW objects
        /// </summary>
        public enum WoWObjectTypes : byte
        {
            OT_NONE = 0,
            OT_ITEM = 1,
            OT_CONTAINER = 2,
            OT_UNIT = 3,
            OT_PLAYER = 4,
            OT_GAMEOBJ = 5,
            OT_DYNOBJ = 6,
            OT_CORPSE = 7
        }
    }
}
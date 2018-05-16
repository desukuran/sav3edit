﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Threading.Tasks;

namespace save3edit
{
    class Items
    {
        public static string[] itemNames =
        {
            "Empty",
            "Wood Sword",
            "Iron Blade",
            "SteelSaber",
            "Lode Sword",
            "Red Katana",
            "Flint Edge",
            "Dark Saber",
            "Aeon Blade",
            "Demon Edge",
            "AlloyBlade",
            "Star Sword",
            "VedicBlade",
            "Kali Blade",
            "Shiva Edge",
            "Bolt Sword",
            "Slasher",
            "Bronze Bow",
            "Iron Bow",
            "Lode Bow",
            "Robin Bow",
            "Sage Bow",
            "Dream Bow",
            "CometArrow",
            "SonicArrow",
            "Valkerye",
            "Siren",
            "DUMMY BOW",
            "DUMMY BOW",
            "DUMMY BOW",
            "DUMMY BOW",
            "Air Gun",
            "Dart Gun",
            "Auto Gun",
            "PicoMagnum",
            "Plasma Gun",
            "Ruby Gun",
            "Dream Gun",
            "Megablast",
            "Shock Wave",
            "Wonder Shot",
            "Graedus",
            "DUMMY GUN",
            "DUMMY GUN",
            "DUMMY GUN",
            "DUMMY GUN",
            "Tin Arm",
            "Hammer Arm",
            "MirageHand",
            "Stone Arm",
            "DoomFinger",
            "Magma Hand",
            "MegatonArm",
            "Big Hand",
            "Kaiser Arm",
            "Giga Arm",
            "Terra Arm",
            "Crisis Arm",
            "DUMMY ARM",
            "BronzeEdge",
            "Iron Sword",
            "Masamune (I)",
            "FlashBlade",
            "Pearl Edge",
            "Rune Blade",
            "BraveSword",
            "Masamune (II)",
            "Demon Hit",
            "Fist (I)",
            "Fist (II)",
            "Fist (III)",
            "Iron Fist",
            "Bronze Fist",
            "DUMMY FIST",
            "DUMMY FIST",
            "DarkScythe",
            "Hurricane",
            "StarScythe",
            "DoomSickle",
            "Mop",
            "Bent Sword",
            "Bent Hilt",
            "Masamune (0)",
            "Swallow",
            "Slasher 2",
            "Rainbow",
            "DUMMY",
            "DUMMY",
            "DUMMY",
            "DUMMY",
            "DUMMY",
            "Hide Tunic",
            "Karate Gi",
            "BronzeMail",
            "MaidenSuit",
            "Iron Suit",
            "Titan Vest",
            "Gold Suit",
            "Ruby Vest",
            "Dark Mail",
            "Mist Robe",
            "Meso Mail",
            "Lumin Robe",
            "Flash Mail",
            "Lode Vest",
            "Aeon Suit",
            "ZodiacCape",
            "Nova Armor",
            "PrismDress",
            "Moon Armor",
            "Ruby Armor",
            "RavenArmor",
            "Gloom Cape",
            "White Mail",
            "Black Mail",
            "Blue Mail",
            "Red Mail",
            "White Vest",
            "Black Vest",
            "Blue Vest",
            "Red Vest",
            "Taban Vest",
            "Taban Suit",
            "DUMMY HELMET",
            "Hide Cap",
            "BronzeHelm",
            "Iron Helm",
            "Beret",
            "Gold Helm",
            "Rock Helm",
            "CeraTopper",
            "Glow Helm",
            "Lode Helm",
            "Aeon Helm",
            "Prism Helm",
            "Doom Helm",
            "Dark Helm",
            "Gloom Helm",
            "Safe Helm",
            "Taban Helm",
            "Sight Cap",
            "Memory Cap",
            "Time Hat",
            "Vigil Hat",
            "OzziePants",
            "Haste Helm",
            "R'bow Helm",
            "MermaidCap",
            "DUMMY ACCESSORY",
            "Bandana",
            "Ribbon",
            "PowerGlove",
            "Defender",
            "MagicScarf",
            "Amulet",
            "Dash Ring",
            "Hit Ring",
            "Power Ring",
            "Magic Ring",
            "Wall Ring",
            "SilverErng",
            "Gold Erng",
            "SilverStud",
            "Gold Stud",
            "SightScope",
            "Charm Top",
            "Rage Band",
            "FrenzyBand",
            "Third Eye",
            "Wallet",
            "GreenDream",
            "Berserker",
            "PowerScarf",
            "Speed Belt",
            "Black Rock",
            "Blue Rock",
            "SilverRock",
            "White Rock",
            "Gold Rock",
            "Hero Medal",
            "MuscleRing",
            "Flea Vest",
            "Magic Seal",
            "Power Seal",
            "Relic",
            "SeraphSong",
            "Sun Shades",
            "PrismSpecs",
            "DUMMY ITEM",
            "Tonic",
            "Mid Tonic",
            "Full Tonic",
            "Ether",
            "Mid Ether",
            "Full Ether",
            "Elixir",
            "HyperEther",
            "MegaElixir",
            "Heal",
            "Revive",
            "Shelter",
            "Power Meal",
            "Lapis",
            "Barrier",
            "Shield",
            "Power Tab",
            "Magic Tab",
            "Speed Tab",
            "Petal",
            "Fang",
            "Horn",
            "Feather",
            "Seed",
            "Bike Key",
            "Pendant",
            "Gate Key",
            "PrsimShard",
            "C. Trigger",
            "Tools",
            "Jerky",
            "DreamStone",
            "Race Log",
            "Moon Stone",
            "Sun Stone",
            "Ruby Knife",
            "Yakra Key",
            "Clone",
            "Toma's Pop",
            "2 Petals",
            "2 Fangs",
            "2 Horns",
            "2 Feathers",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM",
            "DUMMY ITEM"
        };

        public static string ItemHex2Name(int id)
        {
            if (id > 0xFF || id < 0)
                id = 00;

            return itemNames[id];
        }
    }
}
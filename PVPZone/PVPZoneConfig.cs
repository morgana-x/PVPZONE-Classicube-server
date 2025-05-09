﻿using PVPZone.Game.Player;
using System.Collections.Generic;

namespace PVPZone
{
    public class PVPZoneConfig_Player
    {
        public int MaxHealth = 10;

        public int MaxHealthGolden = 10;

        public int MaxHunger = 10;

        public int DefaultHealth = 10;

        public int HungerExhausted = 4;
        public int HungerStarving = 0;

        public int HungerDecayInterval = 60;
        public int HungerStarveInterval = 20;

        public int HealInterval = 10;

    }
    public class PVPZoneConfig_XP
    {
        public string ChatPrefix = "%5[%e{lvl}%5] ";
        public string XPMsg_LevelUp = "%5] {pl} %aleveled up to level %e{lvl}%a!";
        public string XPMsg_XPUp = "%a+%e{xp}%axp";
        public uint XPReward_Kill = 5;
        public uint XPReward_Die = 2;
    }
    public class PVPZoneConfig_Item {
        public string XPMessage = "%cYou need to be level %e{xp}+%c to use this item!";
        public string Cooldownmessage = "%cCooldown: %e{time} %fseconds!";
        public float LootItemSpawnInteveral = 5f;
        public float LootItemExpiryTime = 60f;
        public int LootItemMax = 100;
    }

    public class PVPZoneConfig_Round
    {
        public int Countdown = 10;
    }
    public class PVPZoneConfig_Damage
    {
        public Dictionary<DamageReason.DamageType, string[]> DeathMessages = new Dictionary<DamageReason.DamageType, string[]>()
        {
            [DamageReason.DamageType.None] = new string[] { "{vicColor}{vicName} %fdied a %emysterious %fdeath!" },
            [DamageReason.DamageType.Fall] = new string[] { "{vicColor}{vicName} %efell %fto their death!" },
            [DamageReason.DamageType.Punch] = new string[] { 
                "{vicColor}{vicName} %fwas %ebeaten to a pulp %fby {atkColor}{atkName}%f!", 
                "{vicColor}{vicName} %fstood no chance in a fist fight against {atkColor}{atkName}%f!" 
            },
            [DamageReason.DamageType.Arrow] = new string[] {
                "{vicColor}{vicName} %fwas %eshot %fby {atkColor}{atkName}%f!",
            },
            [DamageReason.DamageType.Snowball] = new string[] {
                "{vicColor}{vicName} %fwas %esnowed %fby {atkColor}{atkName}%f!",
            },
            [DamageReason.DamageType.Explosion] = new string[] {
                "{vicColor}{vicName} %fwas %eblown to pieces %fby {atkColor}{atkName}%f!",
            },
            [DamageReason.DamageType.Debris] = new string[] {
                "{vicColor}{vicName}%e had thier skull shattered by falling debris!",
            },
            [DamageReason.DamageType.Frozen] = new string[] {
                "{vicColor}{vicName} %fwas %bfrozen%f to %cdeath %fby {atkColor}{atkName}%f!",
            },
            [DamageReason.DamageType.Sword] = new string[] {
                "{vicColor}{vicName} %fwas %estabbed to death %fby {atkColor}{atkName}%f!",
            },
            [DamageReason.DamageType.Mace] = new string[] {
                "{vicColor}{vicName} %fwas %ecrushed with a mace %fby {atkColor}{atkName}%f!",
            },
            [DamageReason.DamageType.Fire] = new string[] {
                "{vicColor}{vicName} %eperished in %cflames!",
            },
            [DamageReason.DamageType.Poison] = new string[] {
                "{vicColor}{vicName} %ewas %2poisioned%e to death %fby {atkColor}{atkName}%f!",
            }
        };
    }
    public class PVPZoneConfig
    {
        public PVPZoneConfig_Player Player = new PVPZoneConfig_Player();
        public PVPZoneConfig_Damage Damage = new PVPZoneConfig_Damage();
        public PVPZoneConfig_Item   Item   = new PVPZoneConfig_Item();
        public PVPZoneConfig_XP     XP     = new PVPZoneConfig_XP();
        public PVPZoneConfig_Round  Round  = new PVPZoneConfig_Round();
    }
}

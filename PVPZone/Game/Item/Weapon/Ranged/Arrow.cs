﻿using PVPZone.Game.Player;

namespace PVPZone.Game.Item.Weapon.Ranged
{
    public class Arrow : PVPZoneItem
    {
        public override bool Use(PVPPlayer player)
        {
            return false;
        }

        public Arrow(ushort id, ushort textureId = 0, string Name="") : base(id, textureId, Name)
        {
            this.RemoveOnUse = false;
            this.XPLevelRequired = 0;
            this.PickupAmount = 10;
        }
    }
}

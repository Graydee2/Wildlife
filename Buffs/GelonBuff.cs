﻿using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class GelonBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Gelon");
            Description.SetDefault("Increases minion slots by 1");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.maxMinions++;
			
        }
    }
}

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Animals
{
	public class GoldTurtle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gold Turtle");
            

        }
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.noMelee = true;
			item.useTime = 10;
			item.value = 500000;
			item.useStyle = 1;
			item.consumable = true;
			item.noUseGraphic = true;
		}
		  public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, mod.NPCType("GoldTurtle"));
            return true;
        }
        
	}
}

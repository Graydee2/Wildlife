using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Animals
{
	public class Turkey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Turkey");
            

        }
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = false;
			item.useAnimation = 15;
			item.noMelee = true;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.noUseGraphic = true;
		}
		  public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, mod.NPCType("Turkey"));
            return true;
        }
        
	}
}

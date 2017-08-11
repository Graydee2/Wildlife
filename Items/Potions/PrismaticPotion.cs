using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Potions
{
	public class PrismaticPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Prismatic Potion");
           Tooltip.SetDefault("Gives 40 extra mana");

        }
		 public override void SetDefaults()
        {
         
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 30;
          
            item.value = 2500;
            item.rare = 5;
            item.buffType = mod.BuffType("PrismaticBuff");
            item.buffTime = 15000;
           // return;
        }
		
       
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(null, "FrostShine", 1);
			recipe.AddIngredient(502, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}
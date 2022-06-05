﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eggpack.Elements.Tools
{
	public class ThingiteAxe : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 32;
			item.height = 28;
			item.useTime = 16;
			item.useAnimation = 16;
			item.axe = 14;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4.5f;
			item.value = 12500;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ThingiteBar", 8);
			recipe.AddRecipeGroup("Wood", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
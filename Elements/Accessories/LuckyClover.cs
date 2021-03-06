using eggpack.Elements.Tiles;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eggpack.Elements.Accessories
{
	public class LuckyClover : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("+4% critical strike chance");
		}
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 40000;
			item.rare = ItemRarityID.White;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Blinkroot, 2);
			recipe.AddIngredient(ItemID.Daybloom, 3);
			recipe.AddIngredient(ItemID.Sunflower);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicCrit += 4;
			player.rangedCrit += 4;
			player.meleeCrit += 4;
			player.thrownCrit += 4;
		}
	}
}
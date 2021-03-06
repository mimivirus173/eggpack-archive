using Terraria.ID;
using Terraria.ModLoader;
using eggpack;

namespace eggpack.Elements.Items.Tile
{
	public class ThingiteOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Elements.Tiles.Ore.ThingiteOreTile>();
			item.width = 12;
			item.height = 12;
			item.value = 3750;
			item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Tier3Ore");
			recipe.AddRecipeGroup("Tier4Ore");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
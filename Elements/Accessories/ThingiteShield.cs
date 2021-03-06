using eggpack.Elements.Tiles;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eggpack.Elements.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class ThingiteShield : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.value = 100000;
			item.rare = ItemRarityID.Blue;
			item.accessory = true;
			item.defense = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ThingiteBar", 7);
			recipe.AddRecipeGroup(RecipeGroupID.Wood, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using eggpack.Elements.Tiles;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eggpack.Elements.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class ReinforcedShield : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 250000;
			item.rare = ItemRarityID.Blue;
			item.accessory = true;
			item.defense = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shackle);
			recipe.AddIngredient(null, "WoodenShield");
			recipe.AddIngredient(null, "ThingiteShield");
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using eggpack.Elements.Tiles;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eggpack.Elements.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class HellstoneShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("+5% critical strike chance");
		}
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
			recipe.AddIngredient(null, "ReinforcedShield");
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicCrit += 5;
			player.rangedCrit += 5;
			player.meleeCrit += 5;
			player.thrownCrit += 5;
		}
	}
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eggpack.Elements.Weapons
{
	public class ThingiteSword : ModItem
	{
		public override void SetDefaults() 
		{
			item.damage = 17;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 50000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.scale = 1.2f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ThingiteBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
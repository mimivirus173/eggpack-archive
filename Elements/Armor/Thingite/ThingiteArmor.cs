using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;

namespace eggpack.Elements.Armor.Thingite
{
	[AutoloadEquip(EquipType.Head)]
	public class ThingiteHelmet : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.value = 27500;
			item.rare = ItemRarityID.Blue;
			item.defense = 6;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ModContent.ItemType<ThingiteHelmet>() && body.type == ModContent.ItemType<ThingiteBreastplate>() && legs.type == ModContent.ItemType<ThingiteGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+2 defense, slightly increased movement speed";
			player.statDefense += 2;
			player.moveSpeed += 0.02f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ThingiteBar", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}


	[AutoloadEquip(EquipType.Body)]
	public class ThingiteBreastplate : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 18;
			item.value = 32500;
			item.rare = ItemRarityID.Blue;
			item.defense = 6;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ThingiteBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}


	[AutoloadEquip(EquipType.Legs)]
	public class ThingiteGreaves : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 25000;
			item.rare = ItemRarityID.Blue;
			item.defense = 5;
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
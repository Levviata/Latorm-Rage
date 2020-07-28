using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Crimson
{
	public class HellCoreCrimson : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HellCore Crimson");
			Tooltip.SetDefault("This make sound, beat beat...\nbeat beat... best dont shake this...");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 4;
		}
		public override void AddRecipes()
		{
		
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 20);
			recipe.AddIngredient(ItemID.CrimtaneBar, 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Corruption
{
	public class HellCoreCorruption : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HellCore Corruption");
			Tooltip.SetDefault("put this in your ear, ... what you hear?... yeah... T H E  V O I D");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 6;
		}
		public override void AddRecipes()
		{
		
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 20);
			recipe.AddIngredient(ItemID.DemoniteBar, 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

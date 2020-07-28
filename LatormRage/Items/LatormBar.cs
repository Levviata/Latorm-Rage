using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items
{
	public class LatormBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Latorm Bar");
			Tooltip.SetDefault("HardMode ingot");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 4;
		}
		public override void AddRecipes()
		{
		
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LatormOre", 2);
			recipe.AddIngredient(ItemID.Obsidian, 5);
			recipe.AddIngredient(ItemID.Hellstone, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

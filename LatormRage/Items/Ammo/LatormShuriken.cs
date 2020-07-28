using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Ammo
{
	public class LatormShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Latorm Shuriken");
			Tooltip.SetDefault("50% of getting normal shurikens\nGood for killing many enemies");
		}
		public override void SetDefaults()
		{
		item.maxStack = 999;
        item.damage = 10;
        item.ranged = true;
		item.consumable = true;
        item.width = 3;
        item.height = 25;
        item.knockBack = 1;
        item.value = 150;
        item.rare = 4;
		item.ammo = AmmoID.Bullet;
        item.shoot = mod.ProjectileType("Shuriken");
        item.shootSpeed = 9f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shuriken, 200);
			recipe.AddIngredient(null, "LatormBar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 125);
			recipe.AddRecipe();
		}
	}
}

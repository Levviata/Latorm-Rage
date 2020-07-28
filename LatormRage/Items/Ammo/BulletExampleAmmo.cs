using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Ammo
{
	public class BulletExampleAmmo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BulletExampleAmmo");
			Tooltip.SetDefault("Like a meteor bullet but with penetracion and more damage");
		}
		public override void SetDefaults()
		{
		item.maxStack = 999;
        item.damage = 12;
        item.ranged = true;
		item.consumable = true;
        item.width = 3;
        item.height = 25;
        item.knockBack = 1;
        item.value = 150;
        item.rare = 4;
		item.ammo = AmmoID.Bullet;
        item.shoot = mod.ProjectileType("BulletExampleSprite");
        item.shootSpeed = 35;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 100);
			recipe.AddIngredient(null, "LatormBar", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}

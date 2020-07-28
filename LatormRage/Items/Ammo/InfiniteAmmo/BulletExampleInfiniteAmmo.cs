using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Ammo.InfiniteAmmo
{
	public class BulletExampleInfiniteAmmo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BulletExampleInfiniteAmmo");
			Tooltip.SetDefault("Mod example");
		}
		public override void SetDefaults()
		{
        item.damage = 10;
        item.ranged = true;
        item.width = 3;
        item.height = 25;
        item.knockBack = 1;
        item.value = 150;
        item.rare = 4;
		item.ammo = AmmoID.Bullet;
        item.shoot = mod.ProjectileType("BulletExampleSprite");
        item.shootSpeed = 6f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 99999);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

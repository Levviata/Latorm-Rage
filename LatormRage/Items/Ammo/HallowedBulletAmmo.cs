using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Ammo
{
	public class HallowedBulletAmmo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HallowedBullet Ammo");
			Tooltip.SetDefault("HIPER BULLET");
		}
		public override void SetDefaults()
		{
		item.maxStack = 999;
        item.damage = 15;
        item.ranged = true;
		item.consumable = true;
        item.width = 3;
        item.height = 25;
        item.knockBack = 2;
        item.value = 150;
        item.rare = 7;
		item.ammo = AmmoID.Bullet;
        item.shoot = mod.ProjectileType("HallowedBulletSprite");
        item.shootSpeed = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BulletExampleAmmo", 100);
			recipe.AddIngredient(ItemID.HallowedBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}

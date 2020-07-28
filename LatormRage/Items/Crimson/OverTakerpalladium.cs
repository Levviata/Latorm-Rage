using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace LatormRage.Items.Crimson
{
	public class OverTakerpalladium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Over Taker");
			Tooltip.SetDefault("A pretty good post plantera gun");
		}
		public override void SetDefaults()
		{
        item.damage = 33;
        item.ranged = true;
        item.width = 42; 
        item.height = 18; 
        item.useTime = 11; 
        item.useAnimation = 20;
        item.useStyle = 5; 
        item.noMelee = true;
        item.knockBack = 5;
        item.value = 1000; 
        item.rare = 10;
		item.UseSound = SoundID.Item41;
        item.autoReuse = true;
		item.shoot = 10;
        item.shootSpeed = 22f;
        item.useAmmo = AmmoID.Bullet;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
{
    int numberProjectiles = 1 + Main.rand.Next(2);
  
    for (int i = 0; i < numberProjectiles; i++)
    {
        Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(1));
        Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
    }
    Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 35f;
  
    if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
    {
        position += muzzleOffset;
    }
  
    return true;
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HellCoreCrimson", 3);
			recipe.AddIngredient(null, "LatormStrikerPalladium", 1);
	        recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

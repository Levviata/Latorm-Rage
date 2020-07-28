using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;



namespace LatormRage.Items.TwoOres.LatormStrikerPalladium
{
	public class LatormStrikerPalladium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Latorm Striker");
			Tooltip.SetDefault("Just a better shotgun");
		}
		public override void SetDefaults()
		{
        item.damage = 18;
        item.ranged = true;
        item.width = 25; 
		item.knockBack = 5;
        item.height = 28; 
        item.useTime = 35; 
        item.useAnimation = 20;
        item.useStyle = 5; 
        item.noMelee = true;
        item.value = 10000; 
        item.rare = 3;
		item.UseSound = SoundID.Item36;
        item.autoReuse = true;
		item.shoot = 10;
        item.shootSpeed = 6;
        item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LatormBar" ,15);
			recipe.AddIngredient(ItemID.Shotgun, 1);
			recipe.AddIngredient(ItemID.PalladiumBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	

public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
{
    int numberProjectiles = 5 + Main.rand.Next(2);
  
    for (int i = 0; i < numberProjectiles; i++)
    {
        Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
        Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
    }
    Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 35f;
  
    if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
    {
        position += muzzleOffset;
    }
  
    return true;
    }
  }
}
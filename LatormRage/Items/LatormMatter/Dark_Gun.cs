using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace LatormRage.Items.LatormMatter
{
	public class Dark_Gun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Gun");
			Tooltip.SetDefault("obscure");
		}
		public override void SetDefaults()
		{
        item.damage = 3;
        item.ranged = true;
        item.width = 32; 
        item.height = 26; 
        item.useTime = 25; 
        item.useAnimation = 25;
        item.useStyle = 5; 
        item.noMelee = true;
        item.knockBack = 3;
        item.value = 1000; 
        item.rare = 10;
		item.UseSound = SoundID.Item39;
        item.autoReuse = false;
		item.shoot = 22;
        item.shootSpeed = 22;
        item.useAmmo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HellCoreCorruption", 3);
			recipe.AddIngredient(null, "LatormStrikerCobalt", 1);
	        recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

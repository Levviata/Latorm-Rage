using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items 
{
    public class LatormSword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Latorm Sword");
			Tooltip.SetDefault("Copper but better");
		}
        public override void SetDefaults()
        {
            item.damage = 10;       			
            item.melee = true;          
            item.width = 27;            
            item.height = 27;           
            item.useTime = 35;         
            item.useAnimation = 35;   
            item.useStyle = 1;      
            item.knockBack = 1;    
            item.value = 1000;      
            item.rare = -1;
            item.UseSound = SoundID.Item1;    
            item.autoReuse = true;                          
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LatormBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
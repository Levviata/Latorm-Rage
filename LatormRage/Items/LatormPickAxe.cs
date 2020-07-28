using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items 
{
    public class LatormPickAxe : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Latorm Pickaxe");
		}
        public override void SetDefaults()
        {
            item.damage = 2;		
            item.melee = true;          
            item.width = 32;            
            item.height = 32;           
            item.useTime = 35;         
            item.useAnimation = 35;   
            item.useStyle = 1;      
            item.knockBack = 1;    
            item.value = 1000;      
            item.rare = -1;
			item.pick = 45;
            item.UseSound = SoundID.Item1;    
            item.autoReuse = true;  
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LatormBar", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
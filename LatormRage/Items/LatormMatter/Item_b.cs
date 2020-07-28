using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.LatormMatter
{
    public class Item_b : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stabber");
			Tooltip.SetDefault("finally a good short sword");
		}
        public override void SetDefaults()
        {
            item.damage = 8;		
            item.melee = true;          
            item.width = 27;            
            item.height = 27;           
            item.useTime = 12;         
            item.useAnimation = 12;   
            item.useStyle = 1;      
            item.knockBack = 5;    
            item.value = 1000;      
            item.rare = -1;
            item.UseSound = SoundID.Item1;    
            item.autoReuse = true; 
            item.useTurn = true;
            item.shoot = mod.ProjectileType("Projectile3");
            item.shootSpeed = 10;                               
        }
	}
}
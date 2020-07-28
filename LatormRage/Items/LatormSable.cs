using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items 
{
    public class LatormSable : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Latorm Sable");
			Tooltip.SetDefault("Spawn's a projectile that follows you for 10 secs\nthat can damage enemies if it makes contact.\nIf its equiped on a acccessory slot\ngive's 0.15%+ movement speed");
		}
        public override void SetDefaults()
        {
            item.damage = 1;       
            item.accessory = true;			
            item.melee = true;          
            item.width = 27;            
            item.height = 27;           
            item.useTime = 10;         
            item.useAnimation = 10;   
            item.useStyle = 1;      
            item.knockBack = 1;    
            item.value = 1000;      
            item.rare = -1;
            item.UseSound = SoundID.Item1;    
            item.autoReuse = true; 
            item.useTurn = true;
            item.shoot = mod.ProjectileType("Proyectil");
            item.shootSpeed = 8;                               
        }
			    public override void UpdateAccessory(Player player, bool hidevisual)
		{
		player.moveSpeed += 0.015f;
		}
	}
}
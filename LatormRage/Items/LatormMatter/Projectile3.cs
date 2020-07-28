using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace LatormRage.Items.LatormMatter   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class Projectile3 : ModProjectile
    {
        public override void SetDefaults()
        {  
            projectile.width = 12;     //Set the hitbox width
            projectile.height = 12;       //Set the hitbox height
            projectile.friendly = true;    //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.penetrate = 3;
            projectile.aiStyle = 3;			//Tells the game how many enemies it can hit before being destroyed. -1 = never
            projectile.tileCollide = true;
            projectile.timeLeft = 600; 		//Tells the game whether or not it can collide with a tile
            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water        
            projectile.melee = true;  //Tells the game whether it is a melee projectile or not
 
        }
    }
}
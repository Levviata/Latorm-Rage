using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Projectiles
{

    public class Proyectil : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 20;     
            projectile.height = 31;
            projectile.friendly = true;    
            projectile.melee = true;        
            projectile.tileCollide = true;     
			projectile.aiStyle = 2;
            projectile.timeLeft = 600; 
            projectile.ignoreWater = true; 
        }
        public override void AI()         
        {                                                         
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}
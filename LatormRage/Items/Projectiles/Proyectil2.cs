using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Projectiles
{

    public class Proyectil2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 18;     
            projectile.height = 18;
            projectile.friendly = true;    
            projectile.melee = true;        
            projectile.tileCollide = true; 
            projectile.penetrate = 2;    
			projectile.aiStyle = 2;
            projectile.timeLeft = 600; 
            projectile.ignoreWater = true; 
        }
    }
}
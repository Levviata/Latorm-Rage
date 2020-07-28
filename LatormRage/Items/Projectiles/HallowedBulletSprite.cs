using System; //what sources the code uses, these sources allow for calling of terraria functions, existing system functions and microsoft vector functions (probably more)
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Projectiles //where it's stored. Replace Mod with the name of your mod. This file is stored in the folder \Mod Sources\(mod name, folder can't have spaces)\Projectiles.
{
    public class HallowedBulletSprite : ModProjectile //the class of the projectile
    {
        public override void SetDefaults()
        {
            projectile.width = 3;
			projectile.penetrate = 5;
            projectile.height = 20; //sprite is 20 pixels tall
            projectile.aiStyle = 1; //clones the bullet aiStyle
            projectile.friendly  = true; //player projectile
            projectile.ranged = true; //ranged projectile
            projectile.timeLeft = 600; //lasts for 600 frames/ticks. Terraria runs at 60FPS, so it lasts 10 seconds.
            aiType = ProjectileID.Bullet; //This clones the exact AI of the vanilla projectile Bullet.
        }
        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }
    }
}
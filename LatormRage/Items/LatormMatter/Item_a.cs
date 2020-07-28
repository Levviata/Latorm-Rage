using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace LatormRage.Items.LatormMatter 
{
    public class Item_a : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotating Stick");
			Tooltip.SetDefault("Spinning go brrr");
		}
        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 138;
            item.height = 140;
            item.useTime = 10; 
            item.useAnimation = 10;
            item.channel = true;
            item.useStyle = 100;
            item.knockBack = 8f; 
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 3;                   
            item.shoot = mod.ProjectileType("Projectile4"); 
            item.noUseGraphic = true;
        }
 
        public override bool UseItemFrame(Player player)
        {
            player.bodyFrame.Y = 3 * player.bodyFrame.Height;
            return true;
        }
    }
}
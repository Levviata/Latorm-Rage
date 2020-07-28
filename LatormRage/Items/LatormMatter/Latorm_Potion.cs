using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
 
namespace LatormRage.Items.LatormMatter
{
    public class Latorm_Potion : ModItem
    {
		public override void SetStaticDefaults()
         {
          DisplayName.SetDefault("Latorm Potion");
          Tooltip.SetDefault("Gives life regeneration and 8 increased defense");
         }
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 2;
            item.buffType = mod.BuffType("Buff2");    //this is where you put your Buff name
            item.buffTime = 18000;    //this is the buff duration        20000 = 6 min
            return;
        }
		  public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<LatormBar>(), 1);
			recipe.AddIngredient(ItemID.IronskinPotion, 1);
			recipe.AddIngredient(ItemID.RegenerationPotion, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}
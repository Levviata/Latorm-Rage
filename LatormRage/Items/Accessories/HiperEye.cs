using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Accessories

{
    public class HiperEye : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Hiper Eye");
            Tooltip.SetDefault("0.37%+ Melee Damage");

        }

        public override void SetDefaults()

        {

            item.width = 79;

            item.height = 36;

            item.value = 10000;

            item.rare = 3;

            item.accessory = true;

        }



        public override void UpdateAccessory(Player player, bool hideVisual)

        {
		    player.meleeDamage += 0.37f;
        }


        public override void AddRecipes()  //How to craft this item

        {

            ModRecipe recipe = new ModRecipe (mod);

			recipe.AddIngredient(null, "MetalFusionEye", 1);
            recipe.AddIngredient(null, "HardModeEye", 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
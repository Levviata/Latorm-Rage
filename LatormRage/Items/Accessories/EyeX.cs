using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Accessories

{
    public class EyeX : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Eye X");
            Tooltip.SetDefault("0.45%+ Melee Damage");

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
		    player.meleeDamage += 0.45f;
        }


        public override void AddRecipes()  //How to craft this item

        {

            ModRecipe recipe = new ModRecipe (mod);

			recipe.AddIngredient(null, "HiperEye", 1);
			recipe.AddIngredient(null, "LatormEye", 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
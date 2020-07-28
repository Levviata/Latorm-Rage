using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Accessories

{
    public class LatormEye : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Latorm Eye");
            Tooltip.SetDefault("0.08%+ Melee Damage");

        }

        public override void SetDefaults()

        {

            item.width = 36;

            item.height = 36;

            item.value = 10000;

            item.rare = -1;

            item.accessory = true;

        }



        public override void UpdateAccessory(Player player, bool hideVisual)

        {
		    player.meleeDamage += 0.08f;
        }


        public override void AddRecipes()  //How to craft this item

        {

            ModRecipe recipe = new ModRecipe (mod);

			recipe.AddIngredient(null, "LatormBar" , 20);
			recipe.SetResult(this);
			recipe.AddRecipe();

            recipe.AddTile(TileID.Anvils);
        }
    }
}
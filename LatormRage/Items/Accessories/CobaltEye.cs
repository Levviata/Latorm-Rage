using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Accessories

{
    public class CobaltEye : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Cobalt Eye");
            Tooltip.SetDefault("0.12%+ Melee Damage and 1+ defense");

        }

        public override void SetDefaults()

        {

            item.width = 36;

            item.height = 36;

            item.value = 10000;

            item.rare = 3;

            item.accessory = true;

        }



        public override void UpdateAccessory(Player player, bool hideVisual)

        {
		    player.meleeDamage += 0.12f;
        }


        public override void AddRecipes()  //How to craft this item

        {

            ModRecipe recipe = new ModRecipe (mod);

			recipe.AddIngredient(ItemID.CobaltBar, 30);
            recipe.AddIngredient(ItemID.CobaltShield, 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
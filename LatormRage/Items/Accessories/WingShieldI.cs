using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Accessories

{
     [AutoloadEquip(EquipType.Wings)]
    public class WingShieldI : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Wing Shield I");
            Tooltip.SetDefault("Give's fly, 0.02% melee atack and 1+ defense");

        }

        public override void SetDefaults()

        {

            item.width = 22;

            item.height = 20;

            item.value = 10000;

            item.rare = 4;

            item.accessory = true;

        }



        public override void UpdateAccessory(Player player, bool hideVisual)

        {
		    player.meleeDamage += 0.02f;
			player.statDefense += 1;
            player.wingTimeMax = 10;  //wings Height

        }



        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)

        {

            ascentWhenFalling = 0.85f;

            ascentWhenRising = 0.15f;

            maxCanAscendMultiplier = 1f;

            maxAscentMultiplier = 3f;

            constantAscend = 0.135f;

        }



        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)

        {

            speed = 2f;

            acceleration *= 2.5f;

        }



        public override void AddRecipes()  //How to craft this item

        {

            ModRecipe recipe = new ModRecipe (mod);

			recipe.AddIngredient(null, "LatormWings", 1);
			recipe.AddIngredient(ItemID.CobaltShield, 1);
		    recipe.SetResult(this);
			recipe.AddRecipe();
            recipe.AddTile(TileID.Anvils);
        }	
    }
}
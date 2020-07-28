using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Wings

{
     [AutoloadEquip(EquipType.Wings)]
    public class LatormWings : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Latorm Wings");
            Tooltip.SetDefault("Fly Fly!\n0.2%+ Melee Damage");

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
            recipe.AddIngredient(null, "LatormBar", 20);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
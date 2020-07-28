using System.Collections.Generic;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace LatormRage.Items.Accessories

{
    public class AttackEmblem : ModItem

    {

        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Attack Emblem");
            Tooltip.SetDefault("40%+ Melee Damage 10- defense 90%- movement speed");

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
		    player.meleeDamage += 0.40f;
			player.statDefense -= 10;
			player.moveSpeed -= 0.90f;
        }
    }
}
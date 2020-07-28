
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

namespace LatormRage.Items.Armour
{
    [AutoloadEquip(EquipType.Body)]
    public class LatormChestplate : ModItem
    {
	public override void SetStaticDefaults() {

          DisplayName.SetDefault("Latorm Chestplate");
          Tooltip.SetDefault("");

        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddIngredient(ItemType<LatormBar>(), 35);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<LatormHelmet>() && legs.type == ItemType<LatormGreaves>();;
        }

        public override void UpdateArmorSet(Player player)
        {
			player.setBonus = "\n2+ defense\n+0.3% melee speed\n+0.1% melee damage";
	        player.statDefense += 2;
            player.meleeSpeed += 0.03f;
			player.meleeDamage += 0.01f;
        }
    }
}

using LatormRage.Items.Armour;
using LatormRage.Items.Boss;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Bags
{
public class bag1 : ModItem
{
public override int BossBagNPC => mod.NPCType("LatormMatter");
public override void SetStaticDefaults()
{
DisplayName.SetDefault("Latorm Matter Bag");
Tooltip.SetDefault("<right> to open");
}

public override void SetDefaults()
{
item.width = 40;
item.height = 40;
item.value = 10000;
item.rare = ItemRarityID.Expert;
item.maxStack = 999;
item.expert = false;
item.consumable = true;
}
public override void OpenBossBag(Player player)
{
	int choice = Main.rand.Next(3);
			if (choice == 0)
			{
			player.QuickSpawnItem(mod.ItemType("Item_b"));
			}
			if (choice == 1)
			{
			player.QuickSpawnItem(mod.ItemType("Item_a"));
			}
			if (choice == 2)
			{
			player.QuickSpawnItem(mod.ItemType("Dark_Gun"));
			}
            player.QuickSpawnItem(mod.ItemType("Latorm_Potion"));
			player.QuickSpawnItem(mod.ItemType("Latorm_Potion"));
			player.QuickSpawnItem(mod.ItemType("Latorm_Potion"));
			player.QuickSpawnItem(mod.ItemType("Latorm_Potion"));
			player.QuickSpawnItem(mod.ItemType("Latorm_Potion"));
		}
//player.QuickSpawnItem(mod.ItemType(""))
/*if (Main.rand.Next(100) == 0)
{
player.QuickSpawnItem(mod.ItemType(""))
}*/
}

}

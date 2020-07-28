using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.Ores //"TileExample" its the mod name, change with your's.
{
	public class PolishedLatorm : ModItem //"LatormOre" its the item name, change with your's.
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Polished Latorm");
			Tooltip.SetDefault("You can see yourself with this");
		}
		public override void SetDefaults()
		{
			item.width = 16; 
			item.height = 16;
			item.maxStack = 999; //how many blocks/ore/etc you can stack
			item.value = Item.sellPrice(silver: 50); //change silver to copper/gold/platinium to change the value of the item, remember you cant pass 100th when you're putting copper/silver/gold.
			item.rare = 4; //https://terraria.gamepedia.com/Rarity official page of rarity (dont put (-13) because its a 1.4 color/rarity)
			item.autoReuse = true; //true = you dont need to click again to attack/put the block/etc, false = you need to click again so you can attack/put the block/etc.
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("PolishedLatormTexture"); //remember dont put here "LatormOre" because its the item, you need to put here the texture "TileExample1", that will appear when you create a world.
		}
	}
}

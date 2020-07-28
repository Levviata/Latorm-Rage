using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace LatormRage.Items.Tiles //TileExample its the mod name, change with your's
{
	public class LatormOreTexture : ModTile	//TileExample1 its the item name, change with your's
	{
	
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true; //you can see the specifications of each code line on here https://github.com/tModLoader/tModLoader/wiki/Basic-Tile
			Main.tileMergeDirt[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = mod.DustType("Hellstone");
			drop = mod.ItemType("LatormOre"); //change "LatormOre" to your's ore name, if you're confused dont put "TileExample1" in here, ("TileExample1" is the texture that will appear when you create the world) put "LatormOre" (I suppose that you're asking "why i need to put "OreName" and not "TileExample1" Because "OreName" its the item that you gonna obtain, "TileExample1" again its the texture that appear when you creates a world)
			AddMapEntry(new Color(200, 200, 200));
			minPick = 45; //the minimum pickaxe power to pick the ore/block.
            mineResist = 5f; //you last more picking the ore/block.	(for these that are new f = float, when you reach 10 you dont need to quit the f you just do "item.blabla = 10f;" "item.blabla = 100f;", you never quit the f) 
		}
	
                      //remember to change "LatormOre" and "TileExample1" to your item name!
     }
}
	
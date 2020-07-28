using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation; //i recommend to putting this on all the codes you gonna make.

namespace LatormRage.Items //"TileExample" its the mod name, change with your's.
{
    public class LatormOreGeneration : ModWorld //on "LatormOreGeneration" put your mod name, like this "OreNameGeneration" (its not required to put "Generation" its only to specify) or "OreName" (or if you dont want put what you want only dont put special character's, like "Ore Name" "Ore/Name" "OreºName" etc).
    {
        private const int saveVersion = 0;
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex == -1)
            {
                return;
            }
            tasks.Insert(ShiniesIndex + 1, new PassLegacy("Custom Mod Ores", delegate (GenerationProgress progress) //idk, make test's.
            {
                progress.Message = "Generating latorm..."; //the message that appears when you create a world.
                                                                                                                                                                                                                                         //Put your custom tile block name (you have 2 sprites for the ore to appear 1º "TitleExample1" you need to put that name on here, dont put the ore name because its doesnt gonna work).
                for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)                                                                                                                                      //      |
                {                                                                                                                                                                                                                      //       |
                    WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("LatormOreTexture"), false, 0f, 0f, false, true);
                }                                                                                                   //       |
                                                                                                        		   //where the ore appears, you can change so it will appears
            }));                                                                                                  //on the surface etc, but tbh i dont know the code so search it lol,
			                                                                                                     //here's the tmodloader oficial page https://github.com/tModLoader/tModLoader/wiki.
        }

    }
}

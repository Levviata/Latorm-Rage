using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LatormRage.Items.LatormMatter
{
	public class Buff2 : ModBuff
	{
		public override void SetDefaults()
		{
         Main.buffNoTimeDisplay[Type] = false;
		 DisplayName.SetDefault("Latorm Effect");
		 Description.SetDefault("life regeneration and 8 increased defense");
		}
     		public override void Update(Player player, ref int buffIndex)
			{
				player.lifeRegen = +3;
				player.statDefense += 8;
			}
	}
}

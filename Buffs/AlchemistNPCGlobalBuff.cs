using Terraria;
using Terraria.ModLoader;

namespace AlchemistNPC.Buffs
{
	public class AlchemistNPCGlobalBuffs : GlobalBuff
	{
		public override void Update(int type, Player player, ref int buffIndex)
		{
			if (AlchemistNPC.KeepBuffs)
			{
				if (type != 71 && type != 73 && type != 74 && type != 75 && type != 76 && type != 77 && type != 78 && type != 79)
				{
					if (Main.debuff[type] == false)
					{
					Main.persistentBuff[type] = true;
					}
				}
			}
			if (!AlchemistNPC.KeepBuffs)
			{
				if (type != 71 && type != 73 && type != 74 && type != 75 && type != 76 && type != 77 && type != 78 && type != 79)
				{
					if (Main.debuff[type] == false)
					{
					Main.persistentBuff[type] = false;
					}
				}
			}
		}
	}
}
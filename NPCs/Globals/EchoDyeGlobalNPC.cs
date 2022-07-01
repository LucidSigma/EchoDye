using EchoDyeMod.Content.Items.Dyes;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EchoDyeMod.NPCs
{
    public class EchoDyeGlobalNPC
        : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            Player player = Main.LocalPlayer;

            switch (type)
            {
                case NPCID.DyeTrader:
                    if (player.ZoneGraveyard)
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<EchoDye>());
                        ++nextSlot;
                    }

                    break;
            }
        }
    }
}

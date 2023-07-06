using EchoDyeMod.Content.Items.Dyes;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EchoDyeMod.NPCs
{
    public class EchoDyeGlobalNPC
        : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            switch (shop.NpcType)
            {
                case NPCID.DyeTrader:
                    shop.Add(new Item(ModContent.ItemType<EchoDye>()), Condition.InGraveyard);

                    break;

                default:
                    break;
            }
        }
    }
}

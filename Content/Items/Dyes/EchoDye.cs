using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace EchoDyeMod.Content.Items.Dyes
{
    public class EchoDye
        : ModItem
    {
        public override void SetStaticDefaults()
        {
            if (Main.dedServ)
            {
                return;
            }

            GameShaders.Armor.BindShader(
                Item.type,
                new ArmorShaderData(
                    new Ref<Effect>(EffectManager.EchoEffect.Value),
                    "EchoDyePass"
                )
            );

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }

        public override void SetDefaults()
        {
            // TODO: Rarity, sell price, et cetera.
            int dye = Item.dye;
            Item.CloneDefaults(ItemID.GelDye);

            Item.dye = dye;
        }
    }
}
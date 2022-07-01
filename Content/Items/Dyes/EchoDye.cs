using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
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
            if (Main.dedServ || !EffectManager.EchoEffect.HasValue)
            {
                return;
            }

            GameShaders.Armor.BindShader(
                Item.type,
                new ArmorShaderData(
                    new Ref<Effect>(EffectManager.EchoEffect.Value.Effect.Value),
                    EffectManager.EchoEffect.Value.PassName
                )
            );

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }

        public override void SetDefaults()
        {
            int dye = Item.dye;
            Item.CloneDefaults(ItemID.FogboundDye);

            Item.dye = dye;
        }

        // TODO: Localisation.
    }
}

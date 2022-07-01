using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace EchoDyeMod
{
    public static class EffectManager
    {
        public struct EffectData
        {
            public Asset<Effect> Effect { get; private set; }
            public string PassName { get; private set; }

            public EffectData(in Asset<Effect> effect, in string passName)
            {
                this.Effect = effect;
                this.PassName = passName;
            }
        }

        public static EffectData? EchoEffect { get; private set; } = null;

        internal static void Load()
        {
            if (Main.netMode == NetmodeID.Server)
            {
                return;
            }

            EchoEffect = new EffectData(
                EchoDyeMod.Instance.Assets.Request<Effect>(
                    $"{EchoDyeMod.AssetPath}Effects/EchoShader/EchoEffect",
                    AssetRequestMode.ImmediateLoad
                ),
                "EchoDyePass"
            );
        }

        internal static void Unload()
        {
            EchoEffect = null;
        }
    }
}

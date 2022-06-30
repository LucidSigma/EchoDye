using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;

namespace EchoDyeMod
{
    public static class EffectManager
    {
        public static Asset<Effect> EchoEffect { get; private set; } = null;

        internal static void Load()
        {
            if (Main.netMode == NetmodeID.Server)
            {
                return;
            }

            EchoEffect = EchoDyeMod.Instance.Assets.Request<Effect>(
                "Assets/Effects/EchoShader/EchoEffect",
                AssetRequestMode.ImmediateLoad
            );
        }

        internal static void Unload()
        {
            EchoEffect = null;
        }
    }
}

using Terraria;
using Terraria.ModLoader;

namespace EchoDyeMod
{
    public class EchoDyeMod
        : Mod
    {
        public const string AssetPath = $"{nameof(EchoDyeMod)}/Assets/";

        internal static EchoDyeMod Instance { get; private set; } = null;

        public override void Load()
        {
            Instance = this;

            if (Main.dedServ)
            {
                return;
            }

            // ContentAutoloadingEnabled = true;
            EffectManager.Load();
        }

        public override void Unload()
        {
            EffectManager.Unload();
        }
    }
}
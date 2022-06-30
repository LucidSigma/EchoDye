using Terraria;
using Terraria.ModLoader;

namespace EchoDyeMod
{
    public class EchoDyeMod
        : Mod
    {
        public const string AssetPath = $"{nameof(EchoDyeMod)}/Assets/";

        internal static EchoDyeMod Instance { get; private set; } = null;

        public EchoDyeMod()
        {
            ContentAutoloadingEnabled = true;
        }

        public override void Load()
        {
            Instance = this;

            if (Main.dedServ)
            {
                return;
            }

            EffectManager.Load();
        }

        public override void Unload()
        {
            EffectManager.Unload();
        }
    }
}
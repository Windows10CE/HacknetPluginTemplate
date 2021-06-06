using BepInEx;
using BepInEx.Hacknet;

namespace HacknetPluginTemplate
{
    [BepInPlugin(ModGUID, ModName, ModVer)]
    public class HacknetPluginTemplate : HacknetPlugin
    {
        public const string ModGUID = "com.Windows10CE.Template";
        public const string ModName = "If you leave these the same, I will kill you.";
        public const string ModVer = "1.0.0";

        public override bool Load()
        {
            return true;
        }
    }
}
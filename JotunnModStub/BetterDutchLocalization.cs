using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;

namespace EstonianLocalization
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class BetterDutchLocalization : BaseUnityPlugin
    {
        public const string PluginGUID = "com.pnutbuttrcrepes.BetterDutchLocalization";
        public const string PluginName = "BetterDutchLocalization";
        public const string PluginVersion = "0.0.1";

        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            Jotunn.Logger.LogInfo("BetterDutchLocalization has landed");
        }
    }
}


using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace MoreFogColorsPlugin
{

    [BepInPlugin(Guid, "HolloFoxes' More Fog Colors Plugin", Version)]
    public class MoreFogColorsPlugin : BaseUnityPlugin
    {
        // constants
        public const string Guid = "org.hollofox.plugins.MoreFogColors";
        internal const string Version = "1.0.0.0";

        /// <summary>
        /// Awake plugin
        /// </summary>
        void Awake()
        {
            Debug.Log("More Fog Colors Plug-in loaded");
            ModdingUtils.Initialize(this, Logger);
            var harmony = new Harmony(Guid);
            harmony.PatchAll();
        }
    }
}

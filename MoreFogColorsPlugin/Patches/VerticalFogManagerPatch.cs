using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using Runtime.Scripts;
using UnityEngine;

namespace MoreFogColorsPlugin.Patches
{
    [HarmonyPatch(typeof(BoardVerticalFogManager), "OnSetupInternals")]
    public class VerticalFogManagerPatch
    {
        static bool Prefix(List<BoardVerticalFogManager.VerticalColorIndexSetting> ____verticalFogColorIndexSetting)
        {
            if (____verticalFogColorIndexSetting.All(vcis => vcis.Name != "yellow"))
                ____verticalFogColorIndexSetting.AddRange(
                new []
                    {
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.black, Name = "black"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.blue, Name = "blue"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.clear, Name = "clear"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.cyan, Name = "cyan"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.gray, Name = "gray"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.green, Name = "green"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.grey, Name = "grey"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.magenta, Name = "magenta"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.red, Name = "red"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.white, Name = "white"},
                        new BoardVerticalFogManager.VerticalColorIndexSetting{FogColor = Color.yellow, Name = "yellow"},
                    }
                );
            return true;
        }
    }
}

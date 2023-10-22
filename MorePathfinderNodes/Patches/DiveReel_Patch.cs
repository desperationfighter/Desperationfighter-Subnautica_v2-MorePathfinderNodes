using HarmonyLib;

namespace MorePathfinderNodes.Patch
{

    [HarmonyPatch(typeof(DiveReel))]
    [HarmonyPatch(nameof(DiveReel.Start))]
    public static class DiveReel_maxNodes_Patch
    {
        [HarmonyPostfix]
        private static void PostFix(DiveReel __instance)
        {
            __instance.maxNodes = Plugin.ICMConfig.MaxNodes;
            __instance.energyCostPerDisc = Plugin.ICMConfig.Energyusagepernode;
        }
    }
}

using HarmonyLib;
using Steamworks;
using System;

namespace CustomName
{
    [HarmonyPatch(typeof(SteamFriends))]
    internal class PlayerPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch("GetPersonaName")]
        static void GetPersonaName(ref string __result)
        {
            if (!string.IsNullOrEmpty(Configs.name.Value))
                __result = Configs.name.Value;
        }
    }
}

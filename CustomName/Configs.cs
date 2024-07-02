using BepInEx.Configuration;

namespace CustomName
{
    internal class Configs
    {
        internal static ConfigEntry<string> name;

        internal static void Load(BepinPlugin plugin)
        {
            name = plugin.Config.Bind("CustomName", "Name", "");
        }
    }
}

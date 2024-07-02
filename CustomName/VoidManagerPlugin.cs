using VoidManager.MPModChecks;

namespace CustomName
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107";

        public override string Description => "Allows the user to set a custom username";
    }
}

using VoidManager.CustomGUI;
using static UnityEngine.GUILayout;

namespace CustomName
{
    internal class GUI : ModSettingsMenu
    {
        private string nameString = Configs.name.Value;

        public override string Name() => "Custom Name";

        public override void Draw()
        {
            BeginHorizontal();
            Label("Player Name:");
            nameString = TextField(nameString, MinWidth(80));
            FlexibleSpace();
            if (Button("Apply"))
            {
                Configs.name.Value = nameString;
            }
            if (Button("Reset"))
            {
                Configs.name.Value = "";
                nameString = "";
            }
            EndHorizontal();
            Label("");
            Label("Restarting the game may be required for full effect");
        }
    }
}

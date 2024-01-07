using Bark.GUI;
using GorillaNetworking;

namespace Bark.Modules.Misc
{
    public class Lobby : BarkModule
    {

        public static readonly string DisplayName = "Join BORK Code";

        protected override void OnEnable()
        {
            if (!MenuController.Instance.Built) return;
            base.OnEnable();
            Plugin.Instance.JoinLobby("BORK_MOD", "MODDED_MODDED_CASUALCASUAL");
            this.enabled = false;
        }
        public override string GetDisplayName()
        {
            return DisplayName;
        }

        public override string Tutorial()
        {
            return "Joins the official BORK Mod code";
        }

        protected override void Cleanup() { }   
    }
}

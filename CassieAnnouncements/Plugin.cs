using EXILED;

namespace CassieAnnouncements
{
    public class Plugin : EXILED.Plugin
    {
        private EventHandlers EventHandlers;
        public const string version = "1.0";
        public const string lastModified = "2020/04/30 20:30 UTC";

        public static string announcement1;
        public static string announcement2;
        public static string announcement3;
        public static string announcement4;
        public static string announcement5;
        public static string announcement6;
        public static string announcement7;
        public static string announcement8;
        public static string announcement9;
        public static string announcement10;

        public static bool updateChecker;


        public override void OnEnable()
        {
            Log.Info("CassieAnnouncements v" + lastModified + " by SomewhatSane. Last Modified: " + lastModified + ".");
            Log.Info("Loading configuration.");

            announcement1 = Plugin.Config.GetString("ca_announcement1", "A");
            announcement2 = Plugin.Config.GetString("ca_announcement2", "A");
            announcement3 = Plugin.Config.GetString("ca_announcement3", "A");
            announcement4 = Plugin.Config.GetString("ca_announcement4", "A");
            announcement5 = Plugin.Config.GetString("ca_announcement5", "A");
            announcement6 = Plugin.Config.GetString("ca_announcement6", "A");
            announcement7 = Plugin.Config.GetString("ca_announcement7", "A");
            announcement8 = Plugin.Config.GetString("ca_announcement8", "A");
            announcement9 = Plugin.Config.GetString("ca_announcement9", "A");
            announcement10 = Plugin.Config.GetString("ca_announcement10", "A");
            updateChecker = Plugin.Config.GetBool("ca_checkforupdates", true);
           
            _ = UpdateCheck.CheckForUpdate();

            Log.Info("Registering Event Handlers.");

            EventHandlers = new EventHandlers(this);
            Events.RemoteAdminCommandEvent += EventHandlers.OnRACommand;

            Log.Info("Done.");
        }

        public override void OnDisable()
        {
            Events.RemoteAdminCommandEvent -= EventHandlers.OnRACommand;
            EventHandlers = null;
            Log.Info("Disabled.");
        }

        public override void OnReload() { }

        public override string getName { get; } = "CassieAnnouncements";
    }
}

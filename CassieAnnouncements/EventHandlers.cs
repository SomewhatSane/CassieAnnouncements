using EXILED;
using EXILED.Extensions;

namespace CassieAnnouncements
{
    public class EventHandlers
    {
        public EXILED.Plugin plugin;
        public EventHandlers(EXILED.Plugin plugin) => this.plugin = plugin;

        public void OnRACommand(ref RACommandEvent ev)
        {
            ReferenceHub sender = ev.Sender.SenderId == "SERVER CONSOLE" || ev.Sender.SenderId == "GAME CONSOLE" ? PlayerManager.localPlayer.GetPlayer() : Player.GetPlayer(ev.Sender.SenderId);
            string[] args = ev.Command.Split(' ');

            switch(args[0].ToLower())
            {
                case "ca1":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement1, false, true);
                    break;
                case "ca2":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement2, false, true);
                    break;
                case "ca3":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement3, false, true);
                    break;
                case "ca4":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement4, false, true);
                    break;
                case "ca5":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement5, false, true);
                    break;
                case "ca6":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement6, false, true);
                    break;
                case "ca7":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement7, false, true);
                    break;
                case "ca8":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement8, false, true);
                    break;
                case "ca9":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement9, false, true);
                    break;
                case "ca10":
                    ev.Allow = false;
                    if (!sender.CheckPermission("ca.announce"))
                    {
                        ev.Sender.RAMessage("Permission denied.");
                        return;
                    }
                    Cassie.CassieMessage(Plugin.announcement10, false, true);
                    break;
            }
        }
    }
}

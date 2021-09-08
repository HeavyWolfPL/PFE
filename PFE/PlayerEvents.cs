using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs;
using System;

namespace XFE
{
    public class PlayerEvents
    {
        public Plugin plugin;
        public PlayerEvents(Plugin plugin) => this.plugin = plugin;

		public void OnPlayerDeath(DyingEventArgs ev)
		{
            if (Plugin.Singleton.Config.Roles.Contains(ev.Target.Role))
            {
                try
                {
                    for (int i = 0; i < Plugin.Singleton.Config.Magnitude; i++)
                    {
                        new ExplosiveGrenade(ItemType.GrenadeHE, ev.Target) { FuseTime = Plugin.Singleton.Config.Delay }.SpawnActive(ev.Target.Position, ev.Target);
                        Log.Debug($"Player {ev.Target.Nickname} ({ev.Target.Role}) has exploded ({ev.Target.Position}) with a {Plugin.Singleton.Config.Delay} delay.", Plugin.Singleton?.Config?.Debug ?? false);
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"XFE has encountered a problem while trying to make an explosion. Error available below: \n{e} \n--------- End of Error ---------");
                }
            }
        }
	}
}

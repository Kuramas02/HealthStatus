using System;
using Exiled.API.Features;

namespace HealthStatus
{

    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Kurama#7251";
        public override string Name { get; } = "HealthStatus";
        public override string Prefix { get; } = "HealthStatus";
        public override Version RequiredExiledVersion => new Version(3, 7, 2);
        public override Version Version => new Version(1, 0, 0);
        
        public static Plugin Instance;
        
        private EventHandlers handler;

        public override void OnEnabled()
        {
            handler = new EventHandlers();
            Instance = this;
            Exiled.Events.Handlers.Player.Hurting += EventHandlers.OnMain;
            Exiled.Events.Handlers.Player.ItemUsed += EventHandlers.OnUseHeal;
            Exiled.Events.Handlers.Player.Died += EventHandlers.OnDeath;
            Exiled.Events.Handlers.Player.Spawning += EventHandlers.OnSpawn;

            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            handler = null;
            Exiled.Events.Handlers.Player.Hurting -= EventHandlers.OnMain;
            Exiled.Events.Handlers.Player.ItemUsed -= EventHandlers.OnUseHeal;
            Exiled.Events.Handlers.Player.Died -= EventHandlers.OnDeath;
            Exiled.Events.Handlers.Player.Spawning -= EventHandlers.OnSpawn;

            base.OnDisabled();
        }
    }
}
using System;
using Exiled.Events.EventArgs;
using MEC;

namespace HealthStatus
{
    public class EventHandlers
    {
        public static void OnMain(HurtingEventArgs ev)
        {

            if (ev.Target.Health >= 90)
            {
                ev.Target.RankName = string.Empty;
                Timing.CallDelayed(delay: 0, () =>
                {
                    ev.Target.RankName = ($"{Plugin.Instance.Config.Normal}");
                    ev.Target.RankColor = $"{Plugin.Instance.Config.NormalColor}";
                });
            }
            else if (ev.Target.Health >= 50)
            {
                ev.Target.RankName = string.Empty;
                Timing.CallDelayed(delay: 0, () =>
                {
                    ev.Target.RankName = ($"{Plugin.Instance.Config.Light}");
                    ev.Target.RankColor = $"{Plugin.Instance.Config.LightColor}";
                });
            }
            else if (ev.Target.Health >= 20)
            {
                ev.Target.RankName = string.Empty;
                Timing.CallDelayed(delay: 0, () =>
                {
                    ev.Target.RankName = ($"{Plugin.Instance.Config.Badly}");
                    ev.Target.RankColor = $"{Plugin.Instance.Config.BadlyColor}";
                });
            }
            else if (ev.Target.Health >= 1)
            {
                ev.Target.RankName = string.Empty;
                Timing.CallDelayed(delay: 0, () =>
                {
                    ev.Target.RankName = ($"{Plugin.Instance.Config.Dead}");
                    ev.Target.RankColor = $"{Plugin.Instance.Config.DeadColor}";
                });
            }
        }

        public static void OnUseHeal(UsedItemEventArgs ev)
        {
            if (ev.Item.IsUsing)
            {
                if (ev.Item.Type == ItemType.Adrenaline)
                {
                    if (ev.Player.Health >= 90)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Normal}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.NormalColor}";
                        });
                    }
                    else if (ev.Player.Health >= 50)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Normal}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.NormalColor}";
                        });
                    }
                    else if (ev.Player.Health >= 20)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Light}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.LightColor}";
                        });
                    }
                    else if (ev.Player.Health >= 1)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Badly}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.BadlyColor}";
                        });
                    }
                }
                if (ev.Item.Type == ItemType.Medkit)
                {
                    if (ev.Player.Health >= 90)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Normal}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.NormalColor}";
                        });
                    }
                    else if (ev.Player.Health >= 50)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Normal}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.NormalColor}";
                        });
                    }
                    else if (ev.Player.Health >= 20)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Light}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.LightColor}";
                        });
                    }
                    else if (ev.Player.Health >= 1)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Badly}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.BadlyColor}";
                        });
                    }
                }
                if (ev.Item.Type == ItemType.Painkillers)
                {
                    if (ev.Player.Health >= 90)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Normal}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.NormalColor}";
                        });
                    }
                    else if (ev.Player.Health >= 50)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Light}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.LightColor}";
                        });
                    }
                    else if (ev.Player.Health >= 20)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Light}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.LightColor}";
                        });
                    }
                    else if (ev.Player.Health >= 1)
                    {
                        ev.Player.RankName = string.Empty;
                        Timing.CallDelayed(delay: 0, () =>
                        {
                            ev.Player.RankName = ($"{Plugin.Instance.Config.Badly}");
                            ev.Player.RankColor = $"{Plugin.Instance.Config.BadlyColor}";
                        });
                    }
                }
            }
        }

        public static void OnDeath(DiedEventArgs ev)
        {
            Timing.CallDelayed(delay: 2, () =>
            {
                ev.Target.RankName = string.Empty;
            });
        }

        public static void OnSpawn(SpawningEventArgs ev)
        {
            ev.Player.RankName = String.Empty;
            Timing.CallDelayed(delay: 1, () =>
            {
                ev.Player.RankName = ($"{Plugin.Instance.Config.Normal}");
                ev.Player.RankColor = $"{Plugin.Instance.Config.NormalColor}";
            });
        }

    }
}
using System;
using Exiled.Events.EventArgs;
using MEC;

namespace HealthStatus
{
    public class EventHandlers
    {
        public static void OnMain(HurtingEventArgs ev)
        {
            if (Plugin.Instance.Config.BadgeWork)
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
            
            if (Plugin.Instance.Config.CustomInfoWork)
            {
                if (ev.Target.Health >= 90)
                {
                    ev.Target.CustomInfo = string.Empty;
                    Timing.CallDelayed(delay: 0, () =>
                    {
                        ev.Target.CustomInfo = ($"{Plugin.Instance.Config.Normalinfo}");
                    });
                }
                else if (ev.Target.Health >= 50)
                {
                    ev.Target.CustomInfo = string.Empty;
                    Timing.CallDelayed(delay: 0, () =>
                    {
                        ev.Target.CustomInfo = ($"{Plugin.Instance.Config.Lightinfo}");
                    });
                }
                else if (ev.Target.Health >= 20)
                {
                    ev.Target.CustomInfo = string.Empty;
                    Timing.CallDelayed(delay: 0, () =>
                    {
                        ev.Target.CustomInfo = ($"{Plugin.Instance.Config.Badlyinfo}");
                    });
                }
                else if (ev.Target.Health >= 1)
                {
                    ev.Target.CustomInfo = string.Empty;
                    Timing.CallDelayed(delay: 0, () =>
                    {
                        ev.Target.CustomInfo = ($"{Plugin.Instance.Config.Deadinfo}");
                    });
                }
            }
        }

        public static void OnUseHeal(UsedItemEventArgs ev)
        {
            if (Plugin.Instance.Config.BadgeWork)
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

            
            if (Plugin.Instance.Config.CustomInfoWork)
            {
                if (ev.Item.IsUsing)
                {
                    if (ev.Item.Type == ItemType.Adrenaline)
                    {
                        if (ev.Player.Health >= 90)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Normalinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 50)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Normalinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 20)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Lightinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 1)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Badlyinfo}");
                            });
                        }
                    }

                    if (ev.Item.Type == ItemType.Medkit)
                    {
                        if (ev.Player.Health >= 90)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Normalinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 50)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Normalinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 20)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Lightinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 1)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Badlyinfo}");
                            });
                        }
                    }

                    if (ev.Item.Type == ItemType.Painkillers)
                    {
                        if (ev.Player.Health >= 90)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Normalinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 50)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Lightinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 20)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Lightinfo}");
                            });
                        }
                        else if (ev.Player.Health >= 1)
                        {
                            ev.Player.CustomInfo = string.Empty;
                            Timing.CallDelayed(delay: 0, () =>
                            {
                                ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Badlyinfo}");
                            });
                        }
                    }
                }
            }
        }

        public static void OnDeath(DiedEventArgs ev)
        {
            if (Plugin.Instance.Config.BadgeWork)
            {
                Timing.CallDelayed(delay: 2, () =>
                {
                    ev.Target.RankName = string.Empty;
                });
            }

            if (Plugin.Instance.Config.CustomInfoWork)
            {
                Timing.CallDelayed(delay: 2, () =>
                {
                    ev.Target.CustomInfo = string.Empty;
                });
            }
        }

        public static void OnSpawn(SpawningEventArgs ev)
        {
            if (Plugin.Instance.Config.BadgeWork)
            {
                ev.Player.RankName = String.Empty;
                Timing.CallDelayed(delay: 1, () =>
                {
                    ev.Player.RankName = ($"{Plugin.Instance.Config.Normal}");
                    ev.Player.RankColor = $"{Plugin.Instance.Config.NormalColor}";
                });
            }

            if (Plugin.Instance.Config.CustomInfoWork)
            {
                ev.Player.CustomInfo = String.Empty;
                Timing.CallDelayed(delay: 1, () =>
                {
                    ev.Player.CustomInfo = ($"{Plugin.Instance.Config.Normalinfo}");
                });
            }
        }
    }
}
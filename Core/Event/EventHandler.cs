using Core.Enums;
using Core.Models.Config;
using System;

namespace Core.Event
{
    public delegate void SleepdiscoverEventHandler(SleepStatus sleepStatus);
    public delegate void AppConfigEventHandler(ConfigModel oldConfig, ConfigModel newConfig);
    public delegate void DateTimeObserverEventHandler(object sender, DateTime e);
}

using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class TimerFactory : IComponentFactory
    {
        public string ComponentName => "TimerRevamped";

        public string Description => "Displays the current run time, and provides many customization options.";

        public ComponentCategory Category => ComponentCategory.Timer;

        public IComponent Create(LiveSplitState state) => new Timer();

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.8.0");
    }
}

using System;

namespace Examples.Mvvms
{
    public class CommandManager
    {
        public static event EventHandler RequerySuggested;

        public static void Configure(INotifyApplicationStateChanged notifyApplicationStateChanged)
        {
            if (notifyApplicationStateChanged == null) throw new ArgumentNullException(nameof(notifyApplicationStateChanged));

            notifyApplicationStateChanged.Idle += ApplicationOnIdle;
        }

        private static void ApplicationOnIdle(object sender, EventArgs eventArgs)
        {
            InvalidateRequerySuggested();
        }

        public static void InvalidateRequerySuggested()
        {
            RequerySuggested?.Invoke(new object(), EventArgs.Empty);
        }
    }
}
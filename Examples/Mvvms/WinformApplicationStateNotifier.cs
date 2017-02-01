using System;
using System.Windows.Forms;

namespace Examples.Mvvms
{
    public class WinformApplicationStateNotifier : INotifyApplicationStateChanged
    {
        public event EventHandler Idle
        {
            add { Application.Idle += value; }
            remove { Application.Idle -= value; }
        }
    }
}

using System;

namespace Examples.Mvvms
{
    public interface INotifyApplicationStateChanged
    {
        event EventHandler Idle;
    }
}
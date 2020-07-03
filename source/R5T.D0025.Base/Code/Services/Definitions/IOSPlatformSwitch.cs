using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace R5T.D0025
{
    public interface IOSPlatformSwitch
    {
        void Switch(OSPlatform oSPlatform, Action windowsAction, Action osxAction, Action linuxAction);
        Task SwitchAsync(OSPlatform oSPlatform, Func<Task> windowsActionAsync, Func<Task> osxActionAsync, Func<Task> linuxActionAsync);
    }
}

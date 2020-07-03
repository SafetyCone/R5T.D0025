using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using D0024Utilities = R5T.D0024.Utilities;


namespace R5T.D0025.Default
{
    public class OSPlatformSwitch : IOSPlatformSwitch
    {
        public void Switch(OSPlatform oSPlatform, Action windowsAction, Action osxAction, Action linuxAction)
        {
            if(oSPlatform == OSPlatform.Windows)
            {
                windowsAction();

                return;
            }

            if(oSPlatform == OSPlatform.OSX)
            {
                osxAction();

                return;
            }

            if(oSPlatform == OSPlatform.Linux)
            {
                linuxAction();

                return;
            }

            throw D0024Utilities.GetUnknownOSPlatformException();
        }

        public Task SwitchAsync(OSPlatform oSPlatform, Func<Task> windowsActionAsync, Func<Task> osxActionAsync, Func<Task> linuxActionAsync)
        {
            if (oSPlatform == OSPlatform.Windows)
            {
                var task = windowsActionAsync();

                return task;
            }

            if (oSPlatform == OSPlatform.OSX)
            {
                var task = osxActionAsync();

                return task;
            }

            if (oSPlatform == OSPlatform.Linux)
            {
                var task = linuxActionAsync();

                return task;
            }

            throw D0024Utilities.GetUnknownOSPlatformException();
        }
    }
}

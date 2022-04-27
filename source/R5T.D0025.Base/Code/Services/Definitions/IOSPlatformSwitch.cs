using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0025
{
    [ServiceDefinitionMarker]
    public interface IOSPlatformSwitch : IServiceDefinition
    {
        void Switch(OSPlatform oSPlatform, Action windowsAction, Action osxAction, Action linuxAction);
        Task SwitchAsync(OSPlatform oSPlatform, Func<Task> windowsActionAsync, Func<Task> osxActionAsync, Func<Task> linuxActionAsync);
    }
}

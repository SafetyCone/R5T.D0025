using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0025.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OSPlatformSwitch"/> implementation of <see cref="IOSPlatformSwitch"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOSPlatformSwitch(this IServiceCollection services)
        {
            services.AddSingleton<IOSPlatformSwitch, OSPlatformSwitch>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OSPlatformSwitch"/> implementation of <see cref="IOSPlatformSwitch"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOSPlatformSwitch> AddOSPlatformSwitchAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IOSPlatformSwitch>(() => services.AddOSPlatformSwitch());
            return serviceAction;
        }
    }
}

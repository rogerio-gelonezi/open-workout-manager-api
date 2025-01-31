﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.Services.IoC
{
    public static class MainStartup
    {
        public static IServiceCollection AuthStartup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);
            services.AddIdentity(configuration);
            services.AddInjections();

            return services;
        }
    }
}

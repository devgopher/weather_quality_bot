﻿using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherQuality.Integration.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCachedLocationService(this IServiceCollection services)
    {
        services
            .AddSingleton<IMemoryCache, MemoryCache>()
            .AddScoped<OsmLocationService>()
            .AddScoped<ILocationService, CachedOsmLocationService>()
            .AddHttpClient<OsmLocationService>();

        return services;
    }
}
﻿using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.DependencyInjection.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class SingletonAttribute(Type? serviceType = null, Type? implementationType = null,
        string? key = null, bool isEnumerable = false) : ServiceAttribute(ServiceLifetime.Singleton, serviceType, implementationType, key, isEnumerable)
    {
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class SingletonAttribute<TService>(Type? implementationType = null, string? key = null,
        bool isEnumerable = false) : ServiceAttribute(ServiceLifetime.Singleton, typeof(TService), implementationType, key, isEnumerable)
    {
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public sealed class SingletonAttribute<TService, TImplementation>(string? key = null, bool isEnumerable = false)
        : ServiceAttribute(ServiceLifetime.Singleton, typeof(TService), typeof(TImplementation), key, isEnumerable)
        where TImplementation : class, TService
    {
    }
}
﻿namespace Microsoft.Extensions.DependencyInjection.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class ServiceAttribute(ServiceLifetime lifetime, Type? serviceType = null, 
        Type? implementationType = null, string? key = null, bool isEnumerable = false) : Attribute
    {
        public ServiceLifetime Lifetime { get; } = lifetime;

        public Type? ServiceType { get; } = serviceType;

        public Type? ImplementationType { get; } = implementationType;

        public string? Key { get; } = key;

        public bool IsEnumerable { get; } = isEnumerable;
    }
}

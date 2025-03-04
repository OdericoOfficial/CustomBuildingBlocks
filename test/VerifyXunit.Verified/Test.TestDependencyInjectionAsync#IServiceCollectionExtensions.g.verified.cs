﻿//HintName: IServiceCollectionExtensions.g.cs
// <auto-generated />

using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class IServiceCollectionExtensions
    {
        internal static IServiceCollection AddRegisteredServices(this IServiceCollection services)
        {
            services.AddHostedService<DependencyInjectionTest.TestClassHostedService>();
            services.TryAddSingleton(typeof(DependencyInjectionTest.EmptySingletonClassTestZero));
            services.TryAddSingleton(typeof(DependencyInjectionTest.EmptySingletonClassTestZeroUnbound<,>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.EmptySingletonClassTestZeroKeyed), "ZeroKeyed");
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.EmptySingletonClassTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound");
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZero), typeof(DependencyInjectionTest.SingletonClassTestZero));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZeroUnbound<,>), typeof(DependencyInjectionTest.SingletonClassTestZeroUnbound<,>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZeroKeyed), "ZeroKeyed", typeof(DependencyInjectionTest.SingletonClassTestZeroKeyed));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound", typeof(DependencyInjectionTest.SingletonClassTestZeroKeyedUnbound<,>));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZeroEnumerable), typeof(DependencyInjectionTest.SingletonClassTestZeroEnumerable));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZeroEnumerableUnbound<,>), typeof(DependencyInjectionTest.SingletonClassTestZeroEnumerableUnbound<,>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZeroKeyedEnumerable), "ZeroKeyedEnumerable", typeof(DependencyInjectionTest.SingletonClassTestZeroKeyedEnumerable));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestZeroKeyedEnumerableUnbound<,>), "ZeroKeyedEnumerableUnbound", typeof(DependencyInjectionTest.SingletonClassTestZeroKeyedEnumerableUnbound<,>));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestOne), typeof(DependencyInjectionTest.SingletonClassTestOne));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestOneKeyed), "OneKeyed", typeof(DependencyInjectionTest.SingletonClassTestOneKeyed));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestOneEnumerable), typeof(DependencyInjectionTest.SingletonClassTestOneEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonClassTestOneKeyedEnumerable), "OneKeyedEnumerable", typeof(DependencyInjectionTest.SingletonClassTestOneKeyedEnumerable)));
            services.TryAddScoped(typeof(DependencyInjectionTest.EmptyScopedClassTestZero));
            services.TryAddScoped(typeof(DependencyInjectionTest.EmptyScopedClassTestZeroUnbound<,>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.EmptyScopedClassTestZeroKeyed), "ZeroKeyed");
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.EmptyScopedClassTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound");
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZero), typeof(DependencyInjectionTest.ScopedClassTestZero));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZeroUnbound<,>), typeof(DependencyInjectionTest.ScopedClassTestZeroUnbound<,>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZeroKeyed), "ZeroKeyed", typeof(DependencyInjectionTest.ScopedClassTestZeroKeyed));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound", typeof(DependencyInjectionTest.ScopedClassTestZeroKeyedUnbound<,>));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZeroEnumerable), typeof(DependencyInjectionTest.ScopedClassTestZeroEnumerable));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZeroEnumerableUnbound<,>), typeof(DependencyInjectionTest.ScopedClassTestZeroEnumerableUnbound<,>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZeroKeyedEnumerable), "ZeroKeyedEnumerable", typeof(DependencyInjectionTest.ScopedClassTestZeroKeyedEnumerable));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestZeroKeyedEnumerableUnbound<,>), "ZeroKeyedEnumerableUnbound", typeof(DependencyInjectionTest.ScopedClassTestZeroKeyedEnumerableUnbound<,>));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestOne), typeof(DependencyInjectionTest.ScopedClassTestOne));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestOneKeyed), "OneKeyed", typeof(DependencyInjectionTest.ScopedClassTestOneKeyed));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestOneEnumerable), typeof(DependencyInjectionTest.ScopedClassTestOneEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedClassTestOneKeyedEnumerable), "OneKeyedEnumerable", typeof(DependencyInjectionTest.ScopedClassTestOneKeyedEnumerable)));
            services.TryAddTransient(typeof(DependencyInjectionTest.EmptyTransientClassTestZero));
            services.TryAddTransient(typeof(DependencyInjectionTest.EmptyTransientClassTestZeroUnbound<,>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.EmptyTransientClassTestZeroKeyed), "ZeroKeyed");
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.EmptyTransientClassTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound");
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZero), typeof(DependencyInjectionTest.TransientClassTestZero));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZeroUnbound<,>), typeof(DependencyInjectionTest.TransientClassTestZeroUnbound<,>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZeroKeyed), "ZeroKeyed", typeof(DependencyInjectionTest.TransientClassTestZeroKeyed));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound", typeof(DependencyInjectionTest.TransientClassTestZeroKeyedUnbound<,>));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZeroEnumerable), typeof(DependencyInjectionTest.TransientClassTestZeroEnumerable));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZeroEnumerableUnbound<,>), typeof(DependencyInjectionTest.TransientClassTestZeroEnumerableUnbound<,>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZeroKeyedEnumerable), "ZeroKeyedEnumerable", typeof(DependencyInjectionTest.TransientClassTestZeroKeyedEnumerable));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestZeroKeyedEnumerableUnbound<,>), "ZeroKeyedEnumerableUnbound", typeof(DependencyInjectionTest.TransientClassTestZeroKeyedEnumerableUnbound<,>));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestOne), typeof(DependencyInjectionTest.TransientClassTestOne));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestOneKeyed), "OneKeyed", typeof(DependencyInjectionTest.TransientClassTestOneKeyed));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestOneEnumerable), typeof(DependencyInjectionTest.TransientClassTestOneEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientClassTestOneKeyedEnumerable), "OneKeyedEnumerable", typeof(DependencyInjectionTest.TransientClassTestOneKeyedEnumerable)));
            services.AddHostedService<DependencyInjectionTest.TestAssemblyHostedService>();
            services.TryAddSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestZero));
            services.TryAddSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestZeroBound<string, int>));
            services.TryAddSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestZeroUnbound<,>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestZeroKeyed), "ZeroKeyed");
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestZeroKeyedBound<string, int>), "ZeroKeyedBound");
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound");
            services.TryAddSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestOne));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.EmptySingletonAssemblyTestOneKeyed), "OneKeyed");
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZero), typeof(DependencyInjectionTest.SingletonAssemblyTestZero));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroBound<string, int>), typeof(DependencyInjectionTest.SingletonAssemblyTestZeroBound<string, int>));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroUnbound<,>), typeof(DependencyInjectionTest.SingletonAssemblyTestZeroUnbound<,>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroKeyed), "ZeroKeyed", typeof(DependencyInjectionTest.SingletonAssemblyTestZeroKeyed));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroKeyedBound<string, int>), "ZeroKeyedBound", typeof(DependencyInjectionTest.SingletonAssemblyTestZeroKeyedBound<string, int>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound", typeof(DependencyInjectionTest.SingletonAssemblyTestZeroKeyedUnbound<,>));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroEnumerable), typeof(DependencyInjectionTest.SingletonAssemblyTestZeroEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroEnumerableBound<string, int>), typeof(DependencyInjectionTest.SingletonAssemblyTestZeroEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroEnumerableUnbound<,>), typeof(DependencyInjectionTest.SingletonAssemblyTestZeroEnumerableUnbound<,>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroKeyedEnumerable), "ZeroKeyedEnumerable", typeof(DependencyInjectionTest.SingletonAssemblyTestZeroKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroKeyedEnumerableBound<string, int>), "ZeroKeyedBoundEnumerable", typeof(DependencyInjectionTest.SingletonAssemblyTestZeroKeyedEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestZeroKeyedEnumerableUnbound<,>), "ZeroKeyedUnboundEnumerable", typeof(DependencyInjectionTest.SingletonAssemblyTestZeroKeyedEnumerableUnbound<,>)));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOne), typeof(DependencyInjectionTest.SingletonAssemblyTestOne));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOneBound<string, int>), typeof(DependencyInjectionTest.SingletonAssemblyTestOneBound<string, int>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOneKeyed), "OneKeyed", typeof(DependencyInjectionTest.SingletonAssemblyTestOneKeyed));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOneKeyedBound<string, int>), "OneKeyedBound", typeof(DependencyInjectionTest.SingletonAssemblyTestOneKeyedBound<string, int>));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOneEnumerable), typeof(DependencyInjectionTest.SingletonAssemblyTestOneEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOneEnumerableBound<string, int>), typeof(DependencyInjectionTest.SingletonAssemblyTestOneEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOneKeyedEnumerable), "OneKeyedEnumerable", typeof(DependencyInjectionTest.SingletonAssemblyTestOneKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestOneKeyedEnumerableBound<string, int>), "OneKeyedBoundEnumerable", typeof(DependencyInjectionTest.SingletonAssemblyTestOneKeyedEnumerableBound<string, int>)));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwo), typeof(DependencyInjectionTest.SingletonAssemblyTestTwo));
            services.TryAddSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwoBound<string, int>), typeof(DependencyInjectionTest.SingletonAssemblyTestTwoBound<string, int>));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwoKeyed), "TwoKeyed", typeof(DependencyInjectionTest.SingletonAssemblyTestTwoKeyed));
            services.TryAddKeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwoKeyedBound<string, int>), "TwoKeyedBound", typeof(DependencyInjectionTest.SingletonAssemblyTestTwoKeyedBound<string, int>));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwoEnumerable), typeof(DependencyInjectionTest.SingletonAssemblyTestTwoEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Singleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwoEnumerableBound<string, int>), typeof(DependencyInjectionTest.SingletonAssemblyTestTwoEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwoKeyedEnumerable), "TwoKeyedEnumerable", typeof(DependencyInjectionTest.SingletonAssemblyTestTwoKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedSingleton(typeof(DependencyInjectionTest.Abstractions.ISingletonAssemblyTestTwoKeyedEnumerableBound<string, int>), "TwoKeyedBoundEnumerable", typeof(DependencyInjectionTest.SingletonAssemblyTestTwoKeyedEnumerableBound<string, int>)));
            services.TryAddScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestZero));
            services.TryAddScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestZeroBound<string, int>));
            services.TryAddScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestZeroUnbound<,>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestZeroKeyed), "ZeroKeyed");
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestZeroKeyedBound<string, int>), "ZeroKeyedBound");
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound");
            services.TryAddScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestOne));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.EmptyScopedAssemblyTestOneKeyed), "OneKeyed");
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZero), typeof(DependencyInjectionTest.ScopedAssemblyTestZero));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroBound<string, int>), typeof(DependencyInjectionTest.ScopedAssemblyTestZeroBound<string, int>));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroUnbound<,>), typeof(DependencyInjectionTest.ScopedAssemblyTestZeroUnbound<,>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroKeyed), "ZeroKeyed", typeof(DependencyInjectionTest.ScopedAssemblyTestZeroKeyed));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroKeyedBound<string, int>), "ZeroKeyedBound", typeof(DependencyInjectionTest.ScopedAssemblyTestZeroKeyedBound<string, int>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound", typeof(DependencyInjectionTest.ScopedAssemblyTestZeroKeyedUnbound<,>));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroEnumerable), typeof(DependencyInjectionTest.ScopedAssemblyTestZeroEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroEnumerableBound<string, int>), typeof(DependencyInjectionTest.ScopedAssemblyTestZeroEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroEnumerableUnbound<,>), typeof(DependencyInjectionTest.ScopedAssemblyTestZeroEnumerableUnbound<,>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroKeyedEnumerable), "ZeroKeyedEnumerable", typeof(DependencyInjectionTest.ScopedAssemblyTestZeroKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroKeyedEnumerableBound<string, int>), "ZeroKeyedBoundEnumerable", typeof(DependencyInjectionTest.ScopedAssemblyTestZeroKeyedEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestZeroKeyedEnumerableUnbound<,>), "ZeroKeyedUnboundEnumerable", typeof(DependencyInjectionTest.ScopedAssemblyTestZeroKeyedEnumerableUnbound<,>)));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOne), typeof(DependencyInjectionTest.ScopedAssemblyTestOne));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOneBound<string, int>), typeof(DependencyInjectionTest.ScopedAssemblyTestOneBound<string, int>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOneKeyed), "OneKeyed", typeof(DependencyInjectionTest.ScopedAssemblyTestOneKeyed));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOneKeyedBound<string, int>), "OneKeyedBound", typeof(DependencyInjectionTest.ScopedAssemblyTestOneKeyedBound<string, int>));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOneEnumerable), typeof(DependencyInjectionTest.ScopedAssemblyTestOneEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOneEnumerableBound<string, int>), typeof(DependencyInjectionTest.ScopedAssemblyTestOneEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOneKeyedEnumerable), "OneKeyedEnumerable", typeof(DependencyInjectionTest.ScopedAssemblyTestOneKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestOneKeyedEnumerableBound<string, int>), "OneKeyedBoundEnumerable", typeof(DependencyInjectionTest.ScopedAssemblyTestOneKeyedEnumerableBound<string, int>)));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwo), typeof(DependencyInjectionTest.ScopedAssemblyTestTwo));
            services.TryAddScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwoBound<string, int>), typeof(DependencyInjectionTest.ScopedAssemblyTestTwoBound<string, int>));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwoKeyed), "TwoKeyed", typeof(DependencyInjectionTest.ScopedAssemblyTestTwoKeyed));
            services.TryAddKeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwoKeyedBound<string, int>), "TwoKeyedBound", typeof(DependencyInjectionTest.ScopedAssemblyTestTwoKeyedBound<string, int>));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwoEnumerable), typeof(DependencyInjectionTest.ScopedAssemblyTestTwoEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwoEnumerableBound<string, int>), typeof(DependencyInjectionTest.ScopedAssemblyTestTwoEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwoKeyedEnumerable), "TwoKeyedEnumerable", typeof(DependencyInjectionTest.ScopedAssemblyTestTwoKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedScoped(typeof(DependencyInjectionTest.Abstractions.IScopedAssemblyTestTwoKeyedEnumerableBound<string, int>), "TwoKeyedBoundEnumerable", typeof(DependencyInjectionTest.ScopedAssemblyTestTwoKeyedEnumerableBound<string, int>)));
            services.TryAddTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestZero));
            services.TryAddTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestZeroBound<string, int>));
            services.TryAddTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestZeroUnbound<,>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestZeroKeyed), "ZeroKeyed");
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestZeroKeyedBound<string, int>), "ZeroKeyedBound");
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound");
            services.TryAddTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestOne));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.EmptyTransientAssemblyTestOneKeyed), "OneKeyed");
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZero), typeof(DependencyInjectionTest.TransientAssemblyTestZero));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroBound<string, int>), typeof(DependencyInjectionTest.TransientAssemblyTestZeroBound<string, int>));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroUnbound<,>), typeof(DependencyInjectionTest.TransientAssemblyTestZeroUnbound<,>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroKeyed), "ZeroKeyed", typeof(DependencyInjectionTest.TransientAssemblyTestZeroKeyed));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroKeyedBound<string, int>), "ZeroKeyedBound", typeof(DependencyInjectionTest.TransientAssemblyTestZeroKeyedBound<string, int>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroKeyedUnbound<,>), "ZeroKeyedUnbound", typeof(DependencyInjectionTest.TransientAssemblyTestZeroKeyedUnbound<,>));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroEnumerable), typeof(DependencyInjectionTest.TransientAssemblyTestZeroEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroEnumerableBound<string, int>), typeof(DependencyInjectionTest.TransientAssemblyTestZeroEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroEnumerableUnbound<,>), typeof(DependencyInjectionTest.TransientAssemblyTestZeroEnumerableUnbound<,>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroKeyedEnumerable), "ZeroKeyedEnumerable", typeof(DependencyInjectionTest.TransientAssemblyTestZeroKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroKeyedEnumerableBound<string, int>), "ZeroKeyedBoundEnumerable", typeof(DependencyInjectionTest.TransientAssemblyTestZeroKeyedEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestZeroKeyedEnumerableUnbound<,>), "ZeroKeyedUnboundEnumerable", typeof(DependencyInjectionTest.TransientAssemblyTestZeroKeyedEnumerableUnbound<,>)));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOne), typeof(DependencyInjectionTest.TransientAssemblyTestOne));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOneBound<string, int>), typeof(DependencyInjectionTest.TransientAssemblyTestOneBound<string, int>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOneKeyed), "OneKeyed", typeof(DependencyInjectionTest.TransientAssemblyTestOneKeyed));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOneKeyedBound<string, int>), "OneKeyedBound", typeof(DependencyInjectionTest.TransientAssemblyTestOneKeyedBound<string, int>));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOneEnumerable), typeof(DependencyInjectionTest.TransientAssemblyTestOneEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOneEnumerableBound<string, int>), typeof(DependencyInjectionTest.TransientAssemblyTestOneEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOneKeyedEnumerable), "OneKeyedEnumerable", typeof(DependencyInjectionTest.TransientAssemblyTestOneKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestOneKeyedEnumerableBound<string, int>), "OneKeyedBoundEnumerable", typeof(DependencyInjectionTest.TransientAssemblyTestOneKeyedEnumerableBound<string, int>)));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwo), typeof(DependencyInjectionTest.TransientAssemblyTestTwo));
            services.TryAddTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwoBound<string, int>), typeof(DependencyInjectionTest.TransientAssemblyTestTwoBound<string, int>));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwoKeyed), "TwoKeyed", typeof(DependencyInjectionTest.TransientAssemblyTestTwoKeyed));
            services.TryAddKeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwoKeyedBound<string, int>), "TwoKeyedBound", typeof(DependencyInjectionTest.TransientAssemblyTestTwoKeyedBound<string, int>));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwoEnumerable), typeof(DependencyInjectionTest.TransientAssemblyTestTwoEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.Transient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwoEnumerableBound<string, int>), typeof(DependencyInjectionTest.TransientAssemblyTestTwoEnumerableBound<string, int>)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwoKeyedEnumerable), "TwoKeyedEnumerable", typeof(DependencyInjectionTest.TransientAssemblyTestTwoKeyedEnumerable)));
            services.TryAddEnumerable(ServiceDescriptor.KeyedTransient(typeof(DependencyInjectionTest.Abstractions.ITransientAssemblyTestTwoKeyedEnumerableBound<string, int>), "TwoKeyedBoundEnumerable", typeof(DependencyInjectionTest.TransientAssemblyTestTwoKeyedEnumerableBound<string, int>)));
            return services;
        }
    }
}

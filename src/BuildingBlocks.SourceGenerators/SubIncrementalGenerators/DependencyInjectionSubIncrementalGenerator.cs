﻿using System.Collections.Immutable;
using System.Text;
using BuildingBlocks.SourceGenerators.Abstractions;
using BuildingBlocks.SourceGenerators.Sources;
using Microsoft.CodeAnalysis;
using static BuildingBlocks.SourceGenerators.Sources.DependencyInjectionSource;

namespace BuildingBlocks.SourceGenerators.SubIncrementalGenerators
{
    internal class DependencyInjectionSubIncrementalGenerator : SubIncrementalGenerator<DependencyInjectionSubIncrementalGenerator, DependencyInjectionSource>
    {
        public override void RegisterOutput(SourceProductionContext context, ImmutableArray<DependencyInjectionSource> sources)
        {
            var builder = new StringBuilder();
            builder.AppendLine(@"// <auto-generated />

using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class IServiceCollectionExtensions
    {
        internal static IServiceCollection AddMarkedServices(this IServiceCollection services)
        {");
            foreach (var item in sources)
            {

            }
        }

        private string GetTryAddExpression(AttributeType attribute, DependencyInjectionSource source, string fix)
        {
            var builder = new StringBuilder();
            
            if ((attribute & AttributeType.Enumerable) != AttributeType.None)
            {
                builder.Append("services.TryAddEnumerable(ServiceDescriptor.");
                if ((attribute & AttributeType.Keyed) != AttributeType.None)
                    builder.Append($"Keyed{fix}<{source.ServiceFullName}");
                else
                    builder.Append($"{fix}<{source.ServiceFullName}");

                if (source.ImplementationFullName is not null)
                    builder.Append($", {source.ImplementationFullName}");

                builder.Append(">()");
            }


            return builder.ToString();  
        }
    }
}

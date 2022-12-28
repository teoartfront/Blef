﻿using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo(assemblyName: "Blef.Modules.Games.Application")]
[assembly: InternalsVisibleTo(assemblyName: "Blef.Modules.Games.Infrastructure")]
[assembly: InternalsVisibleTo(assemblyName: "Blef.Modules.Games.Domain.Tests")]

namespace Blef.Modules.Games.Domain;

internal static class Extensions
{
    internal static IServiceCollection AddDomain(this IServiceCollection services) =>
        services;
}
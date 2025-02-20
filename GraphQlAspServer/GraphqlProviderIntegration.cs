using HotChocolate.Execution.Configuration;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Projections;
using HotChocolate.Data.Sorting;
using HotChocolate.Execution.Configuration;
using HotChocolate.Internal;

namespace GraphQlAspServer;

public static class GraphqlProviderIntegration
{
    public static IServiceCollection IntegrateGraphQLProvider(this IServiceCollection services)
    {
        var gqlCfg = services.AddGraphQLServer();
        IntegrateGraphQLProvider(gqlCfg);
        return services;
    }

    private static IRequestExecutorBuilder IntegrateGraphQLProvider(IRequestExecutorBuilder services)
    {
        services
        //.AddQueryType<BaseQueries>()
        //.AddTypeExtension<AppleQueries>()
        //.AddMutationType<BaseMutations>()
        //.AddTypeExtension<AppleMutations>()
        .AddFiltering()
        .AddSorting();

        return services;
    }
}

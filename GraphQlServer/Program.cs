using GraphQL;

//using HotChocolate.AspNetCore;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQlServer;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //builder.AddGraphQLServer()
        //.AddQueryType<Query>();

        var app = builder.Build();


        app.Run();
    }
}


using HotChocolate;

namespace GraphQlAspServer;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        builder.Services.AddGraphQLServer();

        builder.Services.IntegrateGraphQLProvider();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseRouting();

        //app.UseEndpoints(endpoints =>
        //{
        //    endpoints.MapGraphQL().AllowAnonymous();
        //});

        app.MapGraphQL("/graphql").AllowAnonymous();

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}

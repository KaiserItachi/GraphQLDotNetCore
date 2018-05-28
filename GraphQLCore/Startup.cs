using GraphQL;
using GraphQLSample;
using GraphQLSample.GraphqlMutation;
using GraphQLSample.GraphqlQuery;
using GraphQLSample.GraphqlTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Transports.WebSockets;
using Microsoft.Extensions.DependencyInjection;
using GraphQLSample.GraphqlSchema;
using GraphQL.Types;

namespace GraphQLCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Repository>();
            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            services.AddSingleton<AccountType>();
            services.AddSingleton<BranchType>();
            services.AddSingleton<AccountInputType>();
            services.AddSingleton<GraphqlQuery>();
            services.AddSingleton<GraphqlMutation>();
            services.AddSingleton<GraphqlSchema>();

            services.AddGraphQLHttp();
            services.AddGraphQLWebSocket<GraphqlSchema>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseWebSockets();
            app.UseGraphQLWebSocket<GraphqlSchema>(new GraphQLWebSocketsOptions());
            app.UseGraphQLHttp<GraphqlSchema>(new GraphQLHttpOptions());
        }
    }
}

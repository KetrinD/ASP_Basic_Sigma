using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace ASP_Basic_Sigma
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseMvc(builder => builder.MapRoute("defaultRoute", 
                "api/{controller=demo}/{action=gethello}" ));

            var customRouteHandler = new RouteHandler(context => 
            { 
                var routeValues = context.GetRouteData().Values;
                return context.Response.WriteAsync($"Your route data: {string.Join(", ", routeValues)}");
            });

            var routeBuilder = new RouteBuilder(app, customRouteHandler);
            routeBuilder.MapGet("customRouter/{name}",
                context =>
                {
                    var name_1 = context.GetRouteValue("name");
                    return context.Response.WriteAsync($"Hi, {name_1}");
                }
                );

            var router = routeBuilder.Build();
            app.UseRouter(router);

        }
    }
}

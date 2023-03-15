using Microsoft.OpenApi.Models;

namespace QueensBeauty.API.DI
{
    public static class SwaggerDi
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "QueensBeauty.API",
                    Version = "v1",
                    Description = "Microservices HTTP API."
                });

                // Set the comments path for the Swagger JSON and UI.
               // var xmlFile
            });



            return services;
        }
    }
}

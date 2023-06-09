﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using UMaTLMS.API.Attributes;

namespace UMaTLMS.API
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services,
            IConfiguration configuration, IWebHostEnvironment hostEnvironment)
        {
            services.InstallDefaults()
                .AddHttpContextAccessor()
                .InstallSwagger(configuration)
                .AddCore(configuration)
                .AddInfrastructure(configuration, hostEnvironment);
        }

        private static IServiceCollection InstallDefaults(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(CustomValidationAttribute));
            });
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddEndpointsApiExplorer()
                .InstallCors();
            return services;
        }

        private static IServiceCollection InstallCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(opts =>
                {
                    opts.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
            return services;
        }

        private static IServiceCollection InstallSwagger(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "UMaT Lecture Management API",
                    Contact = new OpenApiContact
                    {
                        Email = "kofigyasidev@gmail.com",
                        Name = "Kofi Gyasi",
                        Url = new Uri("https://kaygyasi.vercel.app")
                    },
                    Description = "An API for managing lectures at UMaT."
                });

                options.CustomOperationIds(description =>
                    description.TryGetMethodInfo(out var methodInfo)
                        ? methodInfo.Name : description.RelativePath);

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization using the bearer scheme",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {new OpenApiSecurityScheme{Reference = new OpenApiReference()
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }}, new List<string>()}
            });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
            return services;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WasWebServerCore.Infrastructure.Authorization.RolesToPermission;
using WasWebServerCore.Infrastructure.Services;
using WasWebServerCore.Filters;
using WasWebServerCore.DataTransferObjects.SdsDto;
using WasWebServerCore.DataBaseContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using WasWebServerNew.Infrastructure.OPC;
using WasWebServerNew.Context;
using WasWebServerNew.Services;

namespace WasWebServerCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

            Mapper.Initialize(cfg =>
            {
            });

          Configuration = configuration;

            
        }



        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options => options.AddPolicy(
                "CorsPolicy",
                builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()));
            services.AddControllersWithViews()
                .AddNewtonsoftJson(op => op.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver());

            ConfigureAuthService(services);

            services.AddSwaggerGen(options =>
            {
                var info = new OpenApiInfo
                {
                    Title = "WAS HTTP API",
                    Version = "v1",
                    Description = "The WAS Microservice HTTP API.",
                };
                options.SwaggerDoc("v1", info);
                // Locate the XML file being generated by ASP.NET...
                //var xmlFile = $"{typeof(Startup).Assembly.GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //// ... and tell Swagger to use those XML comments.
                //options.IncludeXmlComments(xmlPath, true);
                var securityScheme = new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        Implicit = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri($"{Configuration.GetValue<string>("IdentityUrlExternal")}/connect/authorize"),
                            TokenUrl = new Uri($"{Configuration.GetValue<string>("IdentityUrlExternal")}/connect/token"),
                            Scopes = new Dictionary<string, string>
                            {
                                { "WasWebServer", "WasWebServer API" },
                            },
                        },
                    },
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer undefined\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                };
                options.AddSecurityDefinition("oauth2", securityScheme);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "oauth2",
                            },
                        },
                        Array.Empty<string>()
                    },
                });
                //options.OperationFilter<AuthorizeCheckOperationFilter>();
            });




            services.AddScoped<TenantProvider>();


            //services.AddDbContext<JDWWheelContext>();

            services.AddTransient<SorterSubWorkTaskService>();

            services.AddTransient<SorterDrSubWorkTaskServices>();

            services.AddTransient<SorterDrSubWorkTaskServices>();
            services.AddTransient<SorterOvSubWorkTaskServices>();
            
            services.AddHttpClient();

            services.AddMemoryCache();

            //token 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContextFactory<JDWWheelContext>((sp, opts) =>
            {
                var tenantProvider = sp.GetRequiredService<TenantProvider>();
               opts.UseSqlServer($"Server=.; Database={tenantProvider.GetTenant()};User ID=sa;password=Kengic@123;");
            }, ServiceLifetime.Scoped);
            services.AddTransient<IIdentityService, IdentityService>();
            // Register the Permission policy handlers
            services.AddSingleton<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();
            services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)

        {

            if (env.IsDevelopment())

            {

                app.UseDeveloperExceptionPage();

            }

            else

            {

                app.UseExceptionHandler("/Home/Error");

            }

            app.UsePathBase("/apigateway/waswebserver");

            app.UseStaticFiles();

            app.UseRouting();



            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");
            
           app.UseEndpoints(endpoints =>
           
           {
           
               endpoints.MapControllerRoute(
           
                   name: "default",
           
                   pattern: "swagger");
           
           });

            app.UseSwagger();

            app.UseSwaggerUI(

                c =>

                {

                    c.SwaggerEndpoint("/apigateway/waswebserver/swagger/v1/swagger.json", "WasWebServerApi V1");

                    c.OAuthClientId("AngularMaterial_Swagger");

                    c.OAuthAppName("WasWebServerApi Swagger UI");

                    c.DocumentTitle = "WasWebServerApi Swagger UI";

                }

            );

        }
        public void ConfigureAuthService(IServiceCollection services)
        {
            services.AddAuthorization();

            services.AddAuthentication(options =>

            {

                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>

            {

                options.Authority = Configuration.GetValue<string>("IdentityUrlExternal");

                options.RequireHttpsMetadata = false;

                options.Audience = "WasWebServer";

                options.TokenValidationParameters.ValidateIssuer = false;

            });

        }


    }
}

using DocumentationWebSiteApi.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DocumentationWebSiteApi.Database.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using DocumentationWebSiteApi.Database.Enumerations;

namespace DocumentationWebSiteApi.Extentions
{
    public static class WebApplicationExtentions
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddServices(builder.Configuration);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));
            builder.Services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit = 104857600;
            });

            builder.Services.AddAuthentication(o =>
            {
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               }).AddJwtBearer(o =>
               {
                   o.TokenValidationParameters = new TokenValidationParameters
                   {
                       ClockSkew = TimeSpan.FromDays(1),
                       ValidateLifetime = true,
                       ValidateAudience = true,
                       ValidateIssuer = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = builder.Configuration["JwtOptions:ValidIssuer"],
                       ValidAudience = builder.Configuration["JwtOptions:ValidAudience"],
                       IssuerSigningKey = new SymmetricSecurityKey(
                           Encoding.UTF8.GetBytes(builder.Configuration["JwtOptions:SecretKey"]!))
                   };
                   o.Events = new JwtBearerEvents
                   {
                       OnAuthenticationFailed = context =>
                       {
                           Console.WriteLine(context.Exception);
                           return Task.CompletedTask;
                       }
                   };
               });

             builder.Services.AddAuthorization(options =>
             {
                 options.AddPolicy("Admin", polisy =>
                 {
                     polisy.RequireClaim("Roles", Roles.admin.ToString());
                 });
             });

             builder.Services.AddAuthorization(options =>
             {
                 options.AddPolicy("Employee", polisy =>
                 {
                     polisy.RequireClaim("Roles", Roles.Employee.ToString());
                 });
             });

            builder.Services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.FullName);

                options.SwaggerDoc("V1", new OpenApiInfo()
                {
                    Version = "V1",
                    Title = "DocumentationWebSiteApi"
                });

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Bearer Authentication",
                    Type = SecuritySchemeType.Http
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                          Reference = new OpenApiReference()
                          {
                              Id = "Bearer",
                              Type = ReferenceType.SecurityScheme
                          }
                        },
                          new List<string>()
                    }
                });
            });

                builder.Services.AddCors(o => o.AddPolicy("AddCors", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                }));
        }

        public static async Task ConfigurePipelineAsync(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/V1/swagger.json", "DocumentationWebSiteApi");
                });
            }

            app.UseCors("AddCors");

            app.UseHttpsRedirection();
            app.UseRequestLocalization();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.MapControllers();

            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<AppDbContext>();
            try
            {
                await context.Database.MigrateAsync();
                Console.WriteLine("Migrations applied successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error applying migrations: {ex.Message}");
            }
        }
    }
}

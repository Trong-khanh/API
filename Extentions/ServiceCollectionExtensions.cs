using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using webAPI.DBContext;
using webAPI.Services;
using webAPI.Services.IServices;

namespace webAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection service)
        {
            service.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(AppSettings.ConnectionString));

            return service;
        }

        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IBookService, BookService>();
            service.AddScoped<IJwtUtils, IJwtUtils>();
            return service;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection service)
        {
            //auto mapper config
            var mapper = MappingConfig.RegisterMaps().CreateMapper();
            service.AddSingleton(mapper);
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return service;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection service)
        {
            service.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApiKhanhPhong", Version = "v1" });
            });
            return service;
        }
    }
}
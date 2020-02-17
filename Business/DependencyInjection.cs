using AutoMapper;
using Business.Manager;
using Business.Repositories;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services, string connection)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddDataAccess(connection);


            services.AddScoped<ILanguageManager, LanguageManager>();
            services.AddScoped<ITradeManager, TradeManager>();

            return services;
        }
    }
}

using Desafio.BL.Automapper;
using Desafio.BL.Interfaces;
using Desafio.DAL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.BL.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceConnector(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
            services.AddTransient<IProductoService, ProductoService>();
            services.AddRepositoryConnector();
            return services;
        }
    }
}

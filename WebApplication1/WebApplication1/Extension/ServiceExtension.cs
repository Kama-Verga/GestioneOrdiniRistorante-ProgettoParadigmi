using GestioneOrdiniRistorante.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions;
using GestioneOrdiniRistorante.Application.Service.Interface;
using GestioneOrdiniRistorante.Application.Service;
using GestioneOrdiniRistorante.Service;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace GestioneOrdiniRistorante.Infrastructure.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddModelServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDBContent>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MyDBContent"));
            });


            services.AddScoped<UtenteRepo>();
            services.AddScoped<ProdottoRepo>();

            return services;
        }
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ServiceUtenteInt, ServiceUtente>();
            services.AddScoped<ServiceOrdineInt, ServiceOrdine>();
            return services;
        }

    }
}

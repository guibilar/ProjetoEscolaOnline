using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using OnlineSchool.App.Extensions;
using OnlineSchool.Busness.Interfaces;
using OnlineSchool.Busness.Notificacoes;
using OnlineSchool.Data.Context;
using OnlineSchool.Data.Repository;

namespace OnlineSchool.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<EscolaDbContext>();
            services.AddScoped<ICarreiraRepository, CarreiraRepository>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IMaterialDeApoioRepository, MaterialDeApoioRepository>();

            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}

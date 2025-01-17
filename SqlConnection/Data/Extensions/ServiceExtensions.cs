using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SqlWebApi.Business.ValidationRules;
using SqlWebApi.Data.Repositories;
using SqlWebApi.Models;
namespace SqlWebApi.Data.Extensions { 
    public static class ServicesExtensions {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {   
            services.AddScoped<ICompanyRepository, CompanyRepository>(); 
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IPlatformRepository, PlatformRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            
            return services;
        }
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            // FluentValidation i�in eklentileri IServiceCollection �zerinden yap�land�r�yoruz.
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();

            // GameValidator'� ve di�er validat�rleri bulmas� i�in FluentValidation yap�land�rmas�
            services.AddValidatorsFromAssemblyContaining<GameValidator>();
            services.AddMediatR();
            services.AddControllers(); // AddControllers �a�r�s� en son olabilir.
            
            return services;
        }



    }
}
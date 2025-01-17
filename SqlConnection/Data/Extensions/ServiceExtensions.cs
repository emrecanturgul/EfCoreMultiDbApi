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
            // FluentValidation için eklentileri IServiceCollection üzerinden yapýlandýrýyoruz.
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();

            // GameValidator'ý ve diðer validatörleri bulmasý için FluentValidation yapýlandýrmasý
            services.AddValidatorsFromAssemblyContaining<GameValidator>();
            services.AddMediatR();
            services.AddControllers(); // AddControllers çaðrýsý en son olabilir.
            
            return services;
        }



    }
}
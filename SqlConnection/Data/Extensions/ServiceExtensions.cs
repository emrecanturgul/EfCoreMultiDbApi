using Microsoft.Extensions.DependencyInjection;
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

      
    }
}
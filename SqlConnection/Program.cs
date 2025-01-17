using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using SqlWebApi.Data;
using SqlWebApi.Data.Extensions;

namespace SqlConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
                
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Add services to the container.
            builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddControllers();
            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDataAccessServices();
            builder.Services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
            });
            var app = builder.Build();
            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json","SqlWebApi v1"));
                
            }
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<SqlDbContext>();
                dbContext.Database.Migrate();  
            }
            app.UseHttpsRedirection();


            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
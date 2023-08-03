using JsonApi.DbContexts;
using JsonApiDotNetCore.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace JsonApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddJsonApi<ApplicationDbContext>(options =>
                {
                    options.Namespace = "api";
                    options.UseRelativeLinks = true;
                    options.IncludeTotalResourceCount = true;

#if DEBUG
                    options.IncludeExceptionStackTraceInErrors = true;
                    options.IncludeRequestBodyInErrors = true;
                    options.SerializerOptions.WriteIndented = true;
#endif
                });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseJsonApi();

            app.MapControllers();

            app.Run();
        }
    }
}
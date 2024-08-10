
using FatInterface.Core.Interfaces.Repositories;
using FatInterface.Core.Interfaces.Services;
using FatInterface.Core.Services;
using FatInterface.Infra.Repositories;

namespace FatInterface
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
            builder.Services.AddSingleton<IPersonRepository, PersonRepository>();
            builder.Services.AddSingleton<IMovieRepository, MovieRepository>();
            builder.Services.AddSingleton<IPersonService, PersonService>();
            builder.Services.AddSingleton<IMovieService, MovieService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

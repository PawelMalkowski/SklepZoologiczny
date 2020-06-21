using SklepZoologiczny.Api.Sql;
using SklepZoologiczny.Api.Sql.Migrations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using FluentValidation;
using SklepZoologiczny.Api.BindingModels;
using SklepZoologiczny.Api.Middlewares;
using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Api.Validation;
using SklepZoologiczny.Api.DAOConfigurations;
using SklepZoologiczny.Services.User;
using SklepZoologiczny.IServices.User;
using SklepZoologiczny.IData.User;
using FluentValidation.AspNetCore;
using SklepZoologiczny.Api.User;
using SklepZoologiczny.Services.Zamowienie;
using SklepZoologiczny.IServices.Zamowienie;
using SklepZoologiczny.IData.Zamowienie;
using SklepZoologiczny.Api.zamowienie;
using SklepZoologiczny.Services.Akcesoria;
using SklepZoologiczny.IServices.Akcesoria;
using SklepZoologiczny.IData.Akcesoria;
using SklepZoologiczny.Api.akcesoria;

namespace SklepZoologiczny.Api
{
    public class Startup
    {
        //Reprezentuje zestaw właściwości konfiguracyjnych aplikacji klucz / wartość. (np z pliku appsettings.json)
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        

        public void ConfigureServices(IServiceCollection services)
        {
            //rejestracja DbContextu, użycie providera MySQL i pobranie danych o bazie z appsettings.json

            services.AddDbContext<SklepZoologicznyDbContext>(options => options
                .UseMySQL(Configuration.GetConnectionString("SklepZoologicznyDbContext")));
            services.AddTransient<DatabaseSeed>();
           services.AddScoped<IValidator<EditUser>, EditUserValidator>();
            services.AddScoped<IValidator<IServices.Requests.CreateUser>, CreateUserValidator>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IValidator<EditZamowienie>, EditZamowienieValidator>();
            services.AddScoped<IValidator<IServices.Requests.CreateZamowienie>, CreatZamowienieValidator>();
            services.AddScoped<IZamowienieService, ZamowienieService>();
           services.AddScoped<IZamowienieRepository, ZamowienieRepository>();
            services.AddScoped<IValidator<EditAkcesoria>, EditAkcesoriaValidator>();
            services.AddScoped<IValidator<IServices.Requests.CreateAkcesoria>, CreateAkcesoriaValidator>();
            services.AddScoped<IAkcesoriaService, AkcesoriaService>();
            services.AddScoped<IAkcesoriaRepository, AkcesoriaRepository>();
            services.AddMvc()
              .AddJsonOptions(options =>
              {
                   options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
               })
               .AddFluentValidation();

            services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.UseApiBehavior = false;
            });

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<SklepZoologicznyDbContext>();
                var databaseSeed = serviceScope.ServiceProvider.GetRequiredService<DatabaseSeed>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                databaseSeed.Seed();
            }
            app.UseMiddleware<ErrorHandlerMiddleware>();
            app.UseApiVersioning();
            app.UseMvc();
        }
    }
}
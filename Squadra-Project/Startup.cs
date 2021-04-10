using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Squadra_Project.Adapter;
using Squadra_Project.Bordas.Adapter;
using Squadra_Project.Context;
using Squadra_Project.Repositorios;
using Squadra_Project.Services;
using Squadra_Project.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
            (Configuration.GetConnectionString("urlSquadra")));

            services.AddScoped<ICarroService, CarroService>();


            services.AddScoped<IAdicionarCarroUseCase, AdicionarCarroUseCase>();
            services.AddScoped<IAtualizarCarroUseCase, AtualizarCarroUseCase>();
            services.AddScoped<IRemoverCarroUseCase, RemoverCarroUseCase>();
            services.AddScoped<IRetornarCarroPorIdUseCase, RetornarCarroPorIdUseCase>();
            services.AddScoped<IRetornarListaCarroUseCase, RetornarListaCarroUseCase>();


            services.AddScoped<IRepositorioCarros, RepositorioCarros>();

            services.AddScoped<IAdicionarCarroAdapter, AdicionarCarroAdapter>();
            services.AddScoped<IAtualizarCarroAdapter, AtualizarCarroAdapter>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Squadra-Project", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Squadra_Project v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

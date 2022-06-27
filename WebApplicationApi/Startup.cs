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
using PatternDAL.DbContexts;
using PatternDAL.Repositories;
using PatternShared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApi.Adapters;
using WebApplicationApi.RptData;
using WebApplicationApi.Services;

namespace WebApplicationApi
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
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    ef => ef.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)),
                    ServiceLifetime.Scoped);

            services.AddDbContext<ApplicationDbContext1>(options =>
                    options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    ef => ef.MigrationsAssembly(typeof(ApplicationDbContext1).Assembly.FullName)),
                    ServiceLifetime.Scoped);


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplicationApi", Version = "v1" });
            });

            services.AddTransient<IPersonaRepository, PersonaRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<ICuentaRepository, CuentaRepository>();
            services.AddTransient<IMovimientosRepository, MovimientosRepository>();

            services.AddTransient<IPersonaAdapter, PersonaAdapter>();
            services.AddTransient<IClienteAdapter, ClienteAdapter>();
            services.AddTransient<ICuentaAdapter, CuentaAdapter>();
            services.AddTransient<IMovimientosAdapter, MovimientosAdapter>();

            services.AddTransient<IUnitOfWorkService, UnitOfWorkService>();

            services.AddTransient<IPersonaService, PersonaService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<ICuentaService, CuentaService>();
            services.AddTransient<IMovimientosService, MovimientosService>();
            services.AddTransient<IReporte, ReporteService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplicationApi v1"));
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

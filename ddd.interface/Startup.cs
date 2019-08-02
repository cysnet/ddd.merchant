using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ddd.domain.Implements;
using ddd.domain.Interfaces;
using ddd.insfrastructure.Interfaces;
using ddd.respository;
using ddd.service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ddd.api
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
            services.AddDbContext<BalanceEFCoreContext>(options =>
            {
                options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Balance;Trusted_Connection=True;", b => b.MigrationsAssembly("ddd.interface"));
                
            });
            services.AddScoped<IBalanceRespository, BalanceRespository>();
            services.AddScoped<IUnitOfWork, EFCoreUnitOfWork>();
            services.AddScoped<BalanceService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetService<BalanceEFCoreContext>();
                db.Database.Migrate();
            }
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossGaming.Business.Abstract;
using CrossGaming.Business.Concrete;
using CrossGaming.DataAccess.Abstract;
using CrossGaming.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CrossGaming.API
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
            #region DependcyInjection
            services.AddScoped<IPlayerDal, EfPlayerDal>();
            services.AddScoped<IPlayerService, PlayerManager>();
            services.AddScoped<IBotDal, EfBotDal>();
            services.AddScoped<IBotService, BotManager>();
            services.AddScoped<IAbilityService, AbilityManager>();
            services.AddScoped<IAbilityDal, EfAbilityDal>();
            services.AddScoped<IMatchService, MatchManager>();
            services.AddScoped<IMatchDal, EfMatchDal>();
            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

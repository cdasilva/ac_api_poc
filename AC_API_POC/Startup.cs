using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentCenter.Code;
using AssessmentCenter.Models.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace AssessmentCenter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                // Allows the accept header to negotiate the content type (JSON or XML) instead 
                // of using the extension (.json or .xml) in the route.
                options.RespectBrowserAcceptHeader = true;
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddXmlSerializerFormatters()
                .AddJsonOptions(options =>
                {
                    // This helps maintain the case sensitivity when displaying JSON results. (e.g. OID vs. oid)
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });

            services.AddAuthentication("Basic")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("Basic", null);

            services.AddDbContext<AssessmentCenterContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

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

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}

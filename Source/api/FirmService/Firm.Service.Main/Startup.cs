using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Firm.Service.Repository;
using Firm.Service.Repository.Contracts;
using Firm.Service.BLL.Contracts;
using Firm.Service.BLL;
using Serilog;

namespace Firm.Service.Main
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //get connection string from app settings json file
            var connection = Configuration.GetConnectionString("SqlConnection");
            //register FirmBbContext
            services.AddDbContext<FirmDbContext>(options => options.UseSqlServer(connection));
            //Service specific DI
            services.AddScoped<IAccountsProcessor, AccountsProcessor>();
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddAutoMapper(typeof(ModelToDtoMapping));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", Configuration.GetSection("v1SwaggerDocInfo").Get<OpenApiInfo>());
                c.DocInclusionPredicate((version, desc) =>
                {
                    var versions = desc.CustomAttributes()
                    .OfType<Microsoft.AspNetCore.Mvc.ApiVersionAttribute>()
                    .SelectMany(attr => attr.Versions);
                    var maps = desc.CustomAttributes()
                    .OfType<Microsoft.AspNetCore.Mvc.MapToApiVersionAttribute>()
                    .SelectMany(attr => attr.Versions)
                    .ToArray();

                    //  condition below to default them under "v1".
                    return versions.Any(v => $"v{v}" == version) && (maps.Length == 0 || maps.Any(v => $"v{v}" == version)) || (version == "v1" && !versions.Any());
                });
            });
            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = false;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ApiVersionReader = new UrlSegmentApiVersionReader();
            });
            services.AddVersionedApiExplorer(options =>
            {
                options.SubstituteApiVersionInUrl = true;
            });

            services.AddSingleton(Log.Logger);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "Feuji Integrated Resource Management APIs V1");
            });
            app.UseSerilogRequestLogging();
        }

    }
}

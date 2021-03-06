using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AccountingOfWorkers.Data;
using AccountingOfWorkers.Data.interfaces;
using AccountingOfWorkers.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AccountingOfWorkers
{
    public class Startup
    {
        private readonly IConfigurationRoot _confString;

        public Startup(IHostEnvironment hostEnvironment)
        {
            _confString = new ConfigurationBuilder()
                .SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("dbsettings.json")
                .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContent>(options => options
                .UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IEmployees, EmployeeRepository>();
            services.AddTransient<IWorkingDays, WorkingDayRepository>();

            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();

            DBObjects.Initial(app);
        }
    }
}

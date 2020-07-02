using System.Threading.Tasks;
using HelpLocally.Infrastructure;
using HelpLocally.Web.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelpLocally.Web
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
            services.AddRazorPages()
                .AddRazorRuntimeCompilation()
                .AddRazorPagesOptions(options =>
                {
                    // options.Conventions.AuthorizeFolder("/Users");
                    options.Conventions.AuthorizeFolder("/Companies");
                    options.Conventions.AuthorizeFolder("/OfferTypes");
                    options.Conventions.AuthorizePage("/Offers/Create");
                    options.Conventions.AuthorizePage("/Offers/Edit");
                });
            services.AddDbContext<HelpLocallyContext>(builder =>
                builder.UseNpgsql(Configuration.GetConnectionString("HelpLocallyConnectionString")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();

            services.AddAuthorization(options => { });
            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.LoginPath = new PathString("/Login/");
                    options.LogoutPath = new PathString("/Logout/");
                    options.AccessDeniedPath = new PathString("/Permissions/");
                    options.Cookie = new CookieBuilder
                    {
                        Path = "/",
                        SameSite = SameSiteMode.None,
                        SecurePolicy = CookieSecurePolicy.SameAsRequest
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            InitializeDatabase<HelpLocallyContext>(app).Wait();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
        }

        private static async Task InitializeDatabase<T>(IApplicationBuilder app) where T : DbContext
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<T>();
            await context.Database.MigrateAsync();
        }
    }
}
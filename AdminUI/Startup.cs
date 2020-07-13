using AdminUI.Date;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AdminUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string LimitRequests = "_LimitRequests";//���������
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            #region ���ݿ���������
            services.AddDbContext<NFineDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DB"));
            });
            #endregion
            #region ע��ӿڷ���
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            #endregion


            #region ��¼��֤
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => {
                    options.LoginPath = "/login";//��֤ʧ�ܷ��ص�½ҳ��
                });
            services.Configure<CookiePolicyOptions>(options => {
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            #endregion

            #region ����
            services.AddCors(option =>
            {
                option.AddPolicy(LimitRequests, policy =>
                {
                    policy.AllowAnyOrigin().WithMethods("GET", "POST", "HEAD", "PUT", "DELETE", "OPTIONS");
                });
            });
            #endregion

            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseStaticFiles();

            app.UseRouting();


            //��֤�м��
            app.UseAuthentication();

            app.UseAuthorization();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
             app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
         
             app.UseSwaggerUI(c =>
             {
                 c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
             });

            #region Cors ��������
            app.UseCors(LimitRequests);
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

           
        }
    }
}

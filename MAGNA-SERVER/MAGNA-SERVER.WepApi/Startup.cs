using MAGNA_SERVER.Abstractions;
using MAGNA_SERVER.Application;
using MAGNA_SERVER.DataAccess;
using MAGNA_SERVER.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MAGNA_SERVER.Services;
using AutoMapper;
using MAGNA_SERVER.WebApi.Mapping;
using MAGNA_SERVER.WebApi.Config;
using System.IO;

namespace MAGNA_SERVER.WebApi
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

            services.AddControllers();
            /*configure swagger doc*/
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MAGNA_SERVER.WepApi", Version = "v1" });
                //Set the comments path for the Swagger JSON an UI
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            /*configure the database service we indicate the layer where the migration will be carried out*/
            services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("MAGNA-SERVER.DataAccess")));

            /*configure the token needed by the client for queries*/
            services.Configure<JwtConfig>(Configuration.GetSection("jwtConfig"));
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(jwt =>
            {
                var key = Encoding.ASCII.GetBytes(Configuration["JwtConfig:Secret"]);

                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    RequireExpirationTime = false,
                    ValidateLifetime = true
                };
            });

            /*add a default identity*/
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
             .AddEntityFrameworkStores<ApiDbContext>();

            /*When an application type object is requested, it creates the instance (dependency injection).*/
            services.AddScoped(typeof(IApplication<>), typeof(Application<>)); 
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IDbContext<>), typeof(DbContext<>));
            services.AddScoped(typeof(ITokenHandlerService), typeof(TokenHandlerService));

            /*mapper*/
            var mapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            //services.AddScoped(typeof(IMapper), typeof(Mapper));
            services.AddMvc();
        }

        /*This method gets called by the runtime. Use this method to configure the HTTP request pipeline.*/
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                /*Enable middleware to serve generated Swagger as a Json endpoint*/
                app.UseSwagger();
                /*use the swagger app to read the file*/
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MAGNA_SERVER.WepApi v1");
                });
            }

            app.UseHttpsRedirection();
            /*agregamos nuestro middleware dentro del pipeline*/
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseRouting();
            app.UseAuthorization();
            /*enable the middleware to use the authentication scheme*/
            app.UseAuthentication();    

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

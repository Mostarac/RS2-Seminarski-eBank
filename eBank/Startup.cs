using eBank.WebAPI.Database;
using eBank.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eBank.Model.Requests;
using eBank.WebAPI.Services;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using eBank.WebAPI.Security;
using eBank.WebAPI.Filters;

namespace eBank
{
    /*public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }*/

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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eBank API", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "basic"
                              }
                          },
                          new string[] {}
                    }
                });
            });

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICRUDService<Model.Loan, LoanSearchRequest, LoanUpsertRequest, LoanUpsertRequest>, LoanService>();
            services.AddScoped<IService<Model.City, object>, BaseService<Model.City, object, WebAPI.Database.City>>();
            services.AddScoped<IService<Model.Role, object>, BaseService<Model.Role, object, WebAPI.Database.Role>>();
            services.AddScoped<IService<Model.Currency, object>, BaseService<Model.Currency, object, WebAPI.Database.Currency>>();
            services.AddScoped<IService<Model.AccountType, object>, BaseService<Model.AccountType, object, WebAPI.Database.AccountType>>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ILoanOrderService, LoanOrderService>();
            services.AddScoped<ILoanOrderTransactionService, LoanOrderTransactionService>();

            //var connection = @"Server=.;Database=eBankTest;Trusted_Connection=True;ConnectRetryCount=0"; //pre-docker
            //var connection = @"Server=db;Database=eProdaja;username=sa;password=qweasd;ConnectRetryCount=0";

            services.AddDbContext<eBankContext>(options => options.UseSqlServer(Configuration.GetConnectionString("eBankDev")));

            //Added code after services.AddControllers() to combat JSON exception "possible-object-cycle-was-detected-which-is-not-supported"
            services.AddControllers(x => x.Filters.Add<ErrorFilter>()).AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Register the Swagger generator, defining 1 or more Swagger documents

            /*services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TheCodeBuzz-Service", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header."
                });
                c.OperationFilter<AuthOperationFilter>();
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            */

            services.AddAuthentication("BasicAuthentication")
              .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eBank API V1"); 
                c.RoutePrefix = "";
            });


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

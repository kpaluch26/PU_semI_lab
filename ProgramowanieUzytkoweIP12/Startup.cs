using CQRS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Model;
using Model.DTO;
using RepositoryPattern;
using System.Collections.Generic;

namespace ProgramowanieUzytkoweIP12
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
            services.AddDbContext<Database>();
            services.AddScoped<BooksRepository>();
            services.AddScoped<AuthorRepository>();
            services.AddScoped<CommandBus>();
            services.AddScoped<QueryBus>();
            services.AddScoped<ICommandHandler<AddBookCommand>, AddBookCommandHandler>();
            services.AddScoped<ICommandHandler<DeleteBookCommand>, DeleteBookCommandHandler>();
            services.AddScoped<IQueryHandler<GetBooksQuery, List<BookDTO>>, GetBooksQueryHandler>();
            services.AddControllers(); 
            services.AddSwaggerGen(); //konfiguracja swaggera
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger(); //konfiguracja swaggera
            app.UseSwaggerUI(); //konfiguracja swaggera

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

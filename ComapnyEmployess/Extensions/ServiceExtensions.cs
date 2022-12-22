


using Microsoft.EntityFrameworkCore;

namespace ComapnyEmployess.Extensions
{
    public static class ServiceExtensions
    {

        //ADD CORS
        public static void ConfigureCors(this IServiceCollection services) =>
         services.AddCors(options =>
         {
             options.AddPolicy("CorsPolicy", builder =>
             builder.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());
         });


        // IIS integration
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
              services.Configure<IISOptions>(options =>
              {

              });

        //add logger
        public static void ConfigureLoggerService(this IServiceCollection services) =>
             services.AddSingleton<ILoggerManager, LoggerManager>();

        //add repsoitory
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
                 services.AddScoped<IRepositoryManager, RepositoryManager>();

        //add services
        //public static void ConfigureServiceManager(this IServiceCollection services) =>
        //        services.AddScoped<IServiceManager, ServiceManager>();

        //public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        //    services.AddDbContext<RepositoryContext>(opts =>
        //    opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureSqlContext(this IServiceCollection services,  IConfiguration configuration) =>
            services.AddSqlServer<RepositoryContext>((configuration.GetConnectionString("sqlConnection")));






    }
}

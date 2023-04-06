using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PageBuilderRCL.Consts;
using PageBuilderRCL.Data;
using PageBuilderRCL.Data.Exceptions;
using PageBuilderRCL.Data.MongoDb;

namespace PageBuilderRCL;

public static class PageBuilderExtensions
{
    public static void AddPageBuilder(this IServiceCollection services)
    {
        services.AddPageBuilderMongoDbContext();
        services.AddScoped(typeof(IPageBuilderRclRepository<>), typeof(PageBuilderRclMongoRepository<>));
    }

    public static void UsePageBuilder(this IApplicationBuilder app)
    {
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapAreaControllerRoute(
                name: "PageBuilderRclAreaDefault",
                areaName: AreaNames.PageBuilderRcl,
                pattern: Endpoints.Prefix + "/{controller=Home}/{action=Index}/{id?}"
            );
        });
    }

    private static void AddPageBuilderMongoDbContext(this IServiceCollection services)
    {
        services.AddSingleton(_ =>
        {
            var configuration = _.GetRequiredService<IConfiguration>();
            var connectionString = configuration.GetConnectionString(PageBuilderRclMongoDefaults.DbName);
            if (string.IsNullOrEmpty(connectionString))
                throw new DbContextCannotInstantiatedException(nameof(PageBuilderRclMongoDbContext));
            var dbContext = new PageBuilderRclMongoDbContext(connectionString);
            return dbContext;
        });
    }

}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PageBuilderRCL.Consts;

namespace PageBuilderRCL;

public static class PageBuilderExtensions
{
    public static void AddPageBuilder(this IServiceCollection services)
    {
    }

    public static void UsePageBuilder(this IApplicationBuilder app)
    {
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapAreaControllerRoute(
                name: "PageBuilderAreaDefault",
                areaName: AreaNames.PageBuilder,
                pattern: Endpoints.Prefix + "/{controller=Home}/{action=Index}/{id?}"
            );
        });
    }
}

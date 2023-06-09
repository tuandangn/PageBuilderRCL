using PageBuilderRCL;

var builder = WebApplication.CreateBuilder(args);
//services
{
    builder.Services.AddControllersWithViews();
    builder.Services.AddPageBuilder();
}

var app = builder.Build();
//pipeline
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();
    app.UseAuthorization();
    app.UsePageBuilder();
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
}
app.Run();
using Microsoft.AspNetCore.Mvc;

namespace PageBuilderRCL.Web.Areas.Admin.Controllers;

public sealed class HomeController : AdminBaseController
{
    public IActionResult Index() => View();
}

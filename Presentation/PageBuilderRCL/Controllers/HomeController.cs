using Microsoft.AspNetCore.Mvc;

namespace PageBuilderRCL.Controllers
{
    public sealed class HomeController : PageBuilderBaseController
    {
        public IActionResult Index() => View();
    }
}

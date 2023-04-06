using Microsoft.AspNetCore.Mvc;

namespace PageBuilderRCL.Controllers
{
    public sealed class HomeController : PageBuilderRclBaseController
    {
        public IActionResult Index() => View();
    }
}

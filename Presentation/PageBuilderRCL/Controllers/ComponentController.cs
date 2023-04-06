using Microsoft.AspNetCore.Mvc;

namespace PageBuilderRCL.Controllers;

public sealed class ComponentController : PageBuilderRclBaseController
{
    public IActionResult Index() => View();
}

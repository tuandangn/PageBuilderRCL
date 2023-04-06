using Microsoft.AspNetCore.Mvc;

namespace PageBuilderRCL.Controllers;

public sealed class ComponentController : PageBuilderBaseController
{
    public IActionResult Index() => View();
}

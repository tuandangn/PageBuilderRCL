using Microsoft.AspNetCore.Mvc;

namespace PageBuilderRCL.Controllers;

public sealed class PageController : PageBuilderRclBaseController
{
    public IActionResult Index() => RedirectToAction(nameof(List));

    public IActionResult List() => View();

    public IActionResult Create(string url)
    {
        if (string.IsNullOrEmpty(url))
            return RedirectToAction(nameof(List));
        return View();
    }
}

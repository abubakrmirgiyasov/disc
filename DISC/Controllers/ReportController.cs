using Microsoft.AspNetCore.Mvc;

namespace DISC.Controllers;

public class ReportController : Controller
{
    public IActionResult Compose()
    {
        return View();
    }
}

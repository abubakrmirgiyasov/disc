using Microsoft.AspNetCore.Mvc;

namespace DISC.Controllers;

public class DictionaryController : Controller
{
    public IActionResult Dictionary()
    {
        return View();
    }
}

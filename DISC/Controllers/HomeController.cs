using DISC.Controllers.Logics;
using DISC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DISC.Controllers;

public class HomeController : Controller
{
    private readonly IDbRequests _requests;

    public HomeController(IDbRequests requests)
    {
        _requests = requests;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(Users user)
    {
        var id = await _requests.CreateUser(user);
        return Redirect($"/Parts/First/{id}");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
using DISC.Controllers.Logics;
using DISC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace DISC.Controllers;

public class PartsController : Controller
{
    private readonly IDbRequests _requests;

    public PartsController(IDbRequests requests)
    {
        _requests = requests;
    }

    [HttpGet("Parts/First/{id:Guid}")]
    public async Task<IActionResult> First(Guid id, int? page)
    {
        ViewModel model = new()
        {
            User = _requests.GetUser(id),
            FirstPartQuiz = _requests.GetQuizzes(),
            FirstPartPagination = await _requests.Pagination(page)
        };

        if (model.User == null)
        {
            return Redirect("/");
        }

        return View(model);
    }

    public IActionResult Second()
    {
        return View();
    }
}

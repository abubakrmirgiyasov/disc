using DISC.Controllers.Logics;
using DISC.Models;
using DISC.Models.Parts;
using Microsoft.AspNetCore.Mvc;

namespace DISC.Controllers;

public class FirstPartController : Controller
{
    private readonly IDbRequests _requests;
    private readonly ApplicationDbContext _context;

    public FirstPartController(IDbRequests requests, ApplicationDbContext context)
    {
        _requests = requests;
        _context = context;
    }

    [HttpGet("FirstPart/Quiz/{id:Guid}")]
    public async Task<IActionResult> Quiz(Guid id, int? page)
    {
        ViewModel model = new()
        {
            User = _requests.GetUser(id),
            FirstPart = await _requests.Pagination(page, _context.FirstPartQuizzes)
        };

        if (model.User == null)
        {
            return Redirect("/");
        }

        return View(model);
    }
}

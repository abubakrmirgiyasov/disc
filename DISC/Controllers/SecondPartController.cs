using DISC.Controllers.Logics;
using DISC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DISC.Controllers;

public class SecondPartController : Controller
{
    private readonly IDbRequests _requests;
    private readonly ApplicationDbContext _context;

    public SecondPartController(IDbRequests requests, ApplicationDbContext context)
    {
        _requests = requests;
        _context = context;
    }

    [HttpGet("SecondPart/Quiz/{id:Guid}")]
    public async Task<IActionResult> QuizAsync(Guid id, int? page)
    {
        ViewModel model = new()
        {
            User = _requests.GetUser(id),
            SecondPart = await _requests.Pagination(page, _context.SecondPartQuizzes)
        };

        if (model.User == null)
        {
            return Redirect("/");
        }

        return View(model);
    }
}

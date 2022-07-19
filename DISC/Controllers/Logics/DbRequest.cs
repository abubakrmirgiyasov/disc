using DISC.Models;
using Microsoft.EntityFrameworkCore;

namespace DISC.Controllers.Logics;

public class DbRequests : IDbRequests
{
    private readonly ApplicationDbContext _context;

    public DbRequests(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> CreateUser(Users user)
    {
        _context.Add(user);
        await _context.SaveChangesAsync();
        return user.Id;
    }

    public Users GetUser(Guid id)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == id);
        return user;
    }

    public List<FirstPartQuiz> GetQuizzes()
    {
        var quiz = _context.FirstPartQuizzes.ToList();
        return quiz;
    }

    public async Task<PaginatedList<FirstPartQuiz>> Pagination(int? pageNumber)
    {
        var quizzes = from q in _context.FirstPartQuizzes
                      select q;

        int pageSize = 1;

        return await PaginatedList<FirstPartQuiz>.CreateAsync(quizzes.AsNoTracking(), pageNumber ?? 1, pageSize);
    }
}

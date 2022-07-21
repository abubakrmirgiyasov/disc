using DISC.Models;
using DISC.Models.Parts;
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

    public List<FirstQuiz> GetQuizzes()
    {
        var quiz = _context.FirstPartQuizzes.ToList();
        return quiz;
    }

    public async Task<PaginatedList<T>> Pagination<T>(int? pageNumber, DbSet<T> list) 
        where T : class
    {
        var quizzes = from q in list
                      select q;

        int pageSize = 1;

        return await PaginatedList<T>.CreateAsync(quizzes.AsNoTracking(), pageNumber ?? 1, pageSize);
    }

    public FirstAnswer AddAnswer(FirstAnswer answer)
    {
        _context.Add(answer);
        _context.SaveChanges();
        return answer;
    }
}

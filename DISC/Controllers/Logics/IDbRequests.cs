using DISC.Models;
using DISC.Models.Parts;
using Microsoft.EntityFrameworkCore;

namespace DISC.Controllers.Logics;

public interface IDbRequests
{
    Users GetUser(Guid id);

    Task<Guid> CreateUser(Users user);

    List<FirstQuiz> GetQuizzes();
    
    FirstAnswer AddAnswer(FirstAnswer answer);

    Task<PaginatedList<T>> Pagination<T>(int? pageNumber, DbSet<T> list) where T : class;
}

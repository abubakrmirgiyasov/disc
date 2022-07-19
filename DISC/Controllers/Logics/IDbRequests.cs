using DISC.Models;

namespace DISC.Controllers.Logics;

public interface IDbRequests
{
    Users GetUser(Guid id);

    Task<Guid> CreateUser(Users user);

    List<FirstPartQuiz> GetQuizzes();

    Task<PaginatedList<FirstPartQuiz>> Pagination(int? pageNumber);
}

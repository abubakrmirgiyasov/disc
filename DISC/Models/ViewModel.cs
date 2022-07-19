namespace DISC.Models;

public class ViewModel
{
    public Users User { get; set; }

    public IEnumerable<FirstPartQuiz> FirstPartQuiz { get; set; }

    public PaginatedList<FirstPartQuiz> FirstPartPagination { get; set; }
}

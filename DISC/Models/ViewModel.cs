using DISC.Models.Parts;

namespace DISC.Models;

public class ViewModel
{
    public Users User { get; set; }

    public PaginatedList<FirstQuiz> FirstPart { get; set; }

    public PaginatedList<SecondQuiz> SecondPart { get; set; }
}

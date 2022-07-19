using System.ComponentModel.DataAnnotations;

namespace DISC.Models;

public class Users
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; }

    public string SecondName { get; set; }

    public string? LastName { get; set; }

    public string Gender { get; set; }
}

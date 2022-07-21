namespace DISC.Models.Parts;

public class FirstAnswer
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public int QuistionNum { get; set; }

    public int Minimum { get; set; }

    public int Maximum { get; set; }
}

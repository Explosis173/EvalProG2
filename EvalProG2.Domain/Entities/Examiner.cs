namespace EvalProG2.Domain.Entities;

public class Examiner
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Job { get; set; } = string.Empty;
    public int ExamDays { get; set; } = default;
}

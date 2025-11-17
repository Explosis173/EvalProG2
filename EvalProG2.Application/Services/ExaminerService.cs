using EvalProG2.Application.Interfaces.Services;
using EvalProG2.Domain.Entities;

namespace EvalProG2.Application.Services;

public class ExaminerService : IExaminerService
{
    public List<Examiner> GetAllAsync()
    {
        var exList = new List<Examiner>();
        exList.Add(new Examiner()
        {
            ExamDays = 3,
            Id = 1,
            Title = "Dr. Smith",
            Job = "Professor"
        });
        return exList;
    }

}
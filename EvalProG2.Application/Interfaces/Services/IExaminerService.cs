using EvalProG2.Domain.Entities;

namespace EvalProG2.Application.Interfaces.Services;

public interface IExaminerService
{
    List<Examiner> GetAllAsync();
}
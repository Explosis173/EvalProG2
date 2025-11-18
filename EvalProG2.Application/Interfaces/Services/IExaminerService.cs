using EvalProG2.Domain.Entities;

namespace EvalProG2.Application.Interfaces.Services;

public interface IExaminerService
{ 
    Task<List<Examiner>> GetAllAsync();

    Task AddAsync(Examiner examiner);

    Task UpdateAsync(Examiner examiner);

    Task DeleteAsync(int id);
}
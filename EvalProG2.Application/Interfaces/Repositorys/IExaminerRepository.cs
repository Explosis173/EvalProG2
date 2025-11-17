using EvalProG2.Domain.Entities;

namespace EvalProG2.Application.Interfaces.Repositorys;

public interface IExaminerRepository
{ 
    Task<List<Examiner>> GetAllAsync();

    Task AddAsync(Examiner examiner);

    Task UpdateAsync(Examiner examiner);
}
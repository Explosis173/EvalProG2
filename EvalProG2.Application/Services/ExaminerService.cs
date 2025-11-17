using EvalProG2.Application.Interfaces.Repositorys;
using EvalProG2.Application.Interfaces.Services;
using EvalProG2.Domain.Entities;

namespace EvalProG2.Application.Services;

public class ExaminerService : IExaminerService
{
    private readonly IExaminerRepository _examinerRepository;
    public ExaminerService(IExaminerRepository examinerRepository)
    {
        _examinerRepository = examinerRepository;
    }
    public async Task<List<Examiner>> GetAllAsync()
    {
        return await _examinerRepository.GetAllAsync();
    }

    public async Task AddAsync(Examiner examiner)
    {
        await _examinerRepository.AddAsync(examiner);
    }
    
    public async Task UpdateAsync(Examiner examiner)
    {
        await _examinerRepository.UpdateAsync(examiner);
    }
}
using EvalProG2.Application.Interfaces.Repositorys;
using EvalProG2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvalProG2.Infrastructure.Repositorys;

public class ExaminerRepository : IExaminerRepository
{
    private readonly AppDbContext _context;

    public ExaminerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Examiner>> GetAllAsync()
    {
        return await _context.Examiner.ToListAsync();
    }
    
    public async Task AddAsync(Examiner examiner)
    {
        _context.Examiner.Add(examiner);
        await _context.SaveChangesAsync();
    }
    
    public async Task UpdateAsync(Examiner examiner)
    {
        _context.Examiner.Update(examiner);
        await _context.SaveChangesAsync();
    }
}
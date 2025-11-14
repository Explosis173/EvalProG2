using EvalProG2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvalProG2.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Examiner> Examiners => Set<Examiner>();
}
using EvalProG2.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvalProG2.Infrastructure.Configurations;

public class ExaminerConfiguration : IEntityTypeConfiguration<Examiner>
{
    public void Configure(EntityTypeBuilder<Examiner> builder)
    {
        builder.ToTable("Examiner");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Title).IsRequired();
        
        builder.Property(x => x.ExamDays).IsRequired();
        
        builder.Property(x => x.Job).IsRequired();
    }
}
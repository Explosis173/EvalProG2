using EvalProG2.Application.Interfaces.Repositorys;
using EvalProG2.Application.Interfaces.Services;
using EvalProG2.Application.Services;
using EvalProG2.Infrastructure.Repositorys;

namespace EvalProG2.Web.ApplicationStart;

public static class DependencyInjection
{ 
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IExaminerService, ExaminerService>();
        services.AddScoped<IExaminerRepository, ExaminerRepository>();

        return services;
    }
}
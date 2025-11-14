using EvalProG2.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvalProG2.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExaminerController : ControllerBase
{
    private readonly IExaminerService _service;

    public ExaminerController(IExaminerService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(_service.GetAllAsync());
}

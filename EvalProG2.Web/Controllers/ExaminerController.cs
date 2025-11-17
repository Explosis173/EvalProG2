using EvalProG2.Application.Interfaces.Services;
using EvalProG2.Domain.Entities;
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
    {
        return Ok(await _service.GetAllAsync());
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromQuery]Examiner examiner)
    {
        await _service.AddAsync(examiner);
        return Ok();
    }
    
    [HttpPut]
    public async Task<IActionResult> Update([FromQuery]Examiner examiner)
    {
        await _service.UpdateAsync(examiner);
        return Ok();
    }
}

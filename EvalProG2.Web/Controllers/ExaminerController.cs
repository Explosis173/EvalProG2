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
    public async Task<IActionResult> GetAllExaminer()
    {
        try
        {
            return Ok(await _service.GetAllAsync());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Add Examiner nicht funktioniert");
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddExaminer([FromQuery]Examiner examiner)
    {
        try
        {
            await _service.AddAsync(examiner);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Add Examiner nicht funktioniert");
        }
        return Ok();
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateExaminer([FromQuery]Examiner examiner)
    {
        try
        {
            await _service.UpdateAsync(examiner);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Update Examiner nicht funktioniert");
        }
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteExaminer([FromQuery] int id)
    {
        try
        {
            await _service.DeleteAsync(id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Delete Examiner nicht funktioniert");
        }
        return Ok();
    }
}

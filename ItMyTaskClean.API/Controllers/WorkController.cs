using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItMyTaskClean.Application.DTOs.Request;
using ItMyTaskClean.Application.DTOs.Response;
using ItMyTaskClean.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ItMyTaskClean.API.Controllers;

[ApiController]
[Route("api/works")]
public class WorkController : ControllerBase
{
    private readonly IWorksService _worksService;
    public WorkController(IWorksService worksService)
    {
        _worksService = worksService;
    }
    [HttpGet]
    public async Task <ActionResult<List<WorkSmallInfo>>> GetAllWorks()
    {
        var works = await _worksService.GetSelectAsync();
        return Ok(works);
    }
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetWorkByIdAsync(Guid id)
    {
        var work = await _worksService.GetAsync(id);
        if (work == null)
        {
            return NotFound();
        }
        return Ok(work);    
    }
    [HttpPost]
    public async Task<IActionResult> AddWorkAsync([FromBody] WorkParamsRequest workParams)
    {
        await _worksService.CreateAsync(workParams);
        return Ok();
    }
    [HttpPut("{id:guid}")]
    public async Task<ActionResult> UpdateWork(Guid id, [FromBody] WorkParamsRequest workParams)
    {
        try
        {
            await _worksService.UpdateAsync(id, workParams);
            return NoContent();
        }
        catch (Exception ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteWork(Guid id)
    {
        try
        {
            await _worksService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return NotFound(new { message = ex.Message });

        }
    }
}

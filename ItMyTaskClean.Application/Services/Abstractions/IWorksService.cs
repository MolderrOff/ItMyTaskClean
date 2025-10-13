using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItMyTaskClean.Application.DTOs.Request;
using ItMyTaskClean.Application.DTOs.Response;
using ItMyTaskClean.Domain.Entities;

namespace ItMyTaskClean.Application.Services.Abstractions;

public interface IWorksService
{
    Task CreateAsync(WorkParamsRequest workParams);
    Task DeleteAsync(Guid id);
    Task<List<WorkSmallInfo>> GetSelectAsync();
    Task<Work?> GetAsync(Guid id);
    Task UpdateAsync(Guid id, WorkParamsRequest workParams);
}

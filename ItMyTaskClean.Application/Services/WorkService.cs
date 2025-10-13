using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItMyTaskClean.Application.DTOs.Request;
using ItMyTaskClean.Application.DTOs.Response;
using ItMyTaskClean.Application.Services.Abstractions;
using ItMyTaskClean.Domain.Entities;
using ItMyTaskClean.Domain.Repositories;

namespace ItMyTaskClean.Application.Services;

public class WorkService : IWorksService
{
    private readonly IWorkRepository _workRepository;
    public WorkService(IWorkRepository workRepository)
    {
        _workRepository = workRepository;
    }
    public async Task<List<WorkSmallInfo>> GetSelectAsync()
    {
        var works = await _workRepository.GetAllAsync();
        return works.Select(w => new WorkSmallInfo(w.Id, w.NameTask, w.TaskNumber, w.Description, w.Customer, w.AdressTask, w.Price)).ToList();
    }
    public async Task<Work?> GetAsync(Guid id)
    {
        return await _workRepository.GetByIdAsync(id);
    }

    public async Task CreateAsync(WorkParamsRequest workParams)
    {
        var work = Work.Create(
            Guid.NewGuid(),
            workParams.NameTask,
            workParams.TaskNumber,
            workParams.Description,
            workParams.Customer,
            workParams.AdressTask,
            workParams.Price);
        await _workRepository.AddAsync(work);
    }
    public async Task UpdateAsync(Guid id, WorkParamsRequest workParams)
    {
        var work = await _workRepository.GetByIdAsync(id);
        if (work == null)
        {
            throw new Exception("Task not found");
        }
        work.Update(workParams.NameTask, workParams.TaskNumber, workParams.Description, workParams.Customer, workParams.AdressTask, workParams.Price);
        await _workRepository.UpdateAsync(work);
    }    
    public async Task DeleteAsync(Guid id)
    {
        var work = await _workRepository.GetByIdAsync(id);
        if(work == null)
        {
            throw new Exception("Task not found");
        }
        await _workRepository.DeleteAsync(work);
    }






}

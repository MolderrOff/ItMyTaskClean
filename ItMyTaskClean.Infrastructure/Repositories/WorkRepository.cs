using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItMyTaskClean.Domain.Entities;
using ItMyTaskClean.Domain.Repositories;
using ItMyTaskClean.Infrastructure.Persistens;
using Microsoft.EntityFrameworkCore;

namespace ItMyTaskClean.Infrastructure.Repositories;

public class WorkRepository : IWorkRepository
{
    private readonly ApplicationDbContext _dbContext;
    public WorkRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddAsync(Work entity)
    {
        await _dbContext.Works.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Work entity)
    {
        _dbContext.Works.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Work>> GetAllAsync()
         => await _dbContext.Works.AsQueryable().ToListAsync();

    public async Task<Work?> GetByIdAsync(Guid id)
         => await _dbContext.Works.FirstOrDefaultAsync(x => x.Id == id);

    public Task GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Work entity)
    {
        _dbContext.Works.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}

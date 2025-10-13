using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItMyTaskClean.Domain.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    public Task AddAsync(TEntity entity); //почему public Task AddAsync зарезервированное
    public Task UpdateAsync(TEntity entity);
    public Task DeleteAsync(TEntity entity);
    public Task GetByNameAsync(string name);

}

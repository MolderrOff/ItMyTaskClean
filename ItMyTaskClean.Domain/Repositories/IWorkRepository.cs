using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItMyTaskClean.Domain.Entities;

namespace ItMyTaskClean.Domain.Repositories
{
    public interface IWorkRepository : IRepository<Work>
    {
        public Task<Work?> GetByIdAsync(Guid id);
        public Task<IEnumerable<Work>> GetAllAsync();
    }
}

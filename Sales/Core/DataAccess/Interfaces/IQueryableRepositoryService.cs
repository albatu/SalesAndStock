using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Interfaces
{
    public interface IQueryableRepositoryService<T> where T : class, IEntity, new()
    {
        IQueryable<T> Tables { get; }
    }
}

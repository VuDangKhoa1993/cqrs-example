using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

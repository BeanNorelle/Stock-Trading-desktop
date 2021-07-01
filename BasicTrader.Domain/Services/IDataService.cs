using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace BasicTrader.Domain.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int Id);
        Task<T> Create(T entity);
        Task<T> Update(int Id, T entity);
        Task<bool> Delete(int Id);
    }
}

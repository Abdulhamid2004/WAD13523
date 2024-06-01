using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAD13523.DAL.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllItems();
        Task<T> GetItemByID(int id);
        Task AddItem(T entity);
        Task UpdateItem(T entity);
        Task DeleteItem(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppRepository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        T FindById(int Id);
    }
}

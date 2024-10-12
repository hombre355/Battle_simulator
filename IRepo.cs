//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Tektonux_Coding_Challenge
{
    public interface IRepository<T>
    {
        void Add(T item);
        T GetById(string id);
        IEnumerable<T> GetAll();
        void Remove(string id);
    }
}

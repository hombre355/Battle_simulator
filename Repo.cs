using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Tektonux_Coding_Challenge
{
    public class Repository<T> : IRepository<T> where T : ITransformer
    {
        private readonly Dictionary<string, T> _storage = new Dictionary<string, T>();

        public void Add(T item)
        {
            // see if i can get rid of Tranformor and make it more generic
            if (_storage.ContainsKey(item.Name))
                throw new InvalidOperationException("Transformer already exists.");
            _storage[item.Name] = item;
        }

        public T GetById(string id)
        {
            return _storage.ContainsKey(id) ? _storage[id] : default;
        }

        public IEnumerable<T> GetAll()
        {
            return _storage.Values.ToList();
        }

        public void Remove(string id)
        {
            if (_storage.ContainsKey(id))
                _storage.Remove(id);
            else
                // see if i can get rid of Tranformor and make it more generic
                throw new InvalidOperationException("Transformer not found.");
        }
    }
}

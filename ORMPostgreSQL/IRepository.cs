using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMPostgreSQL
{
    internal interface IRepository<T>
    {
        void Create(T item);
        T[] Read();
        void Update(int id, T newItem);
        void Delete(int Id);
    }
}

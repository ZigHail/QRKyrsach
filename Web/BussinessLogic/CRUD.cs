using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Web.BussinessLogic
{
    public abstract class CRUD<T>
    {
        public abstract void Add(T t);
        public abstract void Delete(T t);
        public abstract void Update(T t);
        public abstract T Read(int id);

        public List<T> All { get; set; }
        

        public virtual List<T> GetAll()
        {
            return new List<T>();
        }
    }
}

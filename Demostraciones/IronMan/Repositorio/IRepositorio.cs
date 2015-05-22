using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMan.Repositorio
{
    public interface IRepositorio<T>
    {
        void Guardar(T entidad, int id);
        T GetPorId(int id);
        IQueryable<T> GetTodos();
    }
}

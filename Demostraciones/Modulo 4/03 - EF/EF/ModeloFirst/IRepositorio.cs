using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloFirst
{
    public interface IRepositorio<T>
    {
        void Guardar(T entidad);
        void Actualizar(T entidad);
        T GetPorId(int id);
        IQueryable<T> GetTodos();
    }

}

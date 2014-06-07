using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMan.Gestores
{
    public interface IGestor<T> where T :class
    {
        void Guardar(T entidad);
        void Habilitar(T entidad);
        void Deshabilitar(T entidad);
        T Obtener(int id);
        IList<T> Listar();
        bool Validar(T entidad);

    }
}

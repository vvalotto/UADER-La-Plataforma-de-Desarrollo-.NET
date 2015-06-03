using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;

namespace IronMan.LibreriaMVP.Views
{
    public interface IEventoEditView : IView
    {
        /*Especificacion de la interfaz de una vista que tiene en cuenta
         * las acciones de edición de la entidad* y los metodos para mostra
         * en formularios*/
        event Action Guardar;
        event Action Cancelar;
        event Action Volver;

        void MostrarEvento(int _eId);

    }
}

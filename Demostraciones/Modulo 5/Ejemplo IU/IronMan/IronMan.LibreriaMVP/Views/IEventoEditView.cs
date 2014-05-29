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
        event Action Guardar;
        event Action Cancelar;
        event Action Volver;

        void MostrarEvento(int _eId);

    }
}

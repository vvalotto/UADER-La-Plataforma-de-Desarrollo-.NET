using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.LibreriaMVP.Views;

namespace IronMan.LibreriaMVP.Presenters
{
    public abstract class BasePresenter<TVista> where TVista : class, IView

    {
        private readonly TVista _vista;

        private readonly INavegacionServicio _navegacionServicio;

        public BasePresenter(TVista vista)
        {
            if (vista == null) throw new ArgumentNullException("Vista");
            _vista = vista;
        }

        public BasePresenter(TVista vista, INavegacionServicio navigationService)
        {
            if (vista == null) throw new ArgumentNullException("view");
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _vista = vista;
            _navegacionServicio = navigationService;
        }

        public IView Vista
        {
            get
            {
                return _vista;
            }
        }

        public INavegacionServicio Navegacion
        {
            get
            {
                return _navegacionServicio;
            }
        }

        public abstract void Inicializar();
    }
}

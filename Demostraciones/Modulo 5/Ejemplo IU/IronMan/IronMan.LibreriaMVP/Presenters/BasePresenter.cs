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
        private readonly TVista __vista;

        private readonly INavegacionServicio _navegacionServicio;

        public BasePresenter(TVista vista)
        {
            if (vista == null) throw new ArgumentNullException("Vista");
            __vista = vista;
        }

        public BasePresenter(TVista vista, INavegacionServicio navigationService)
        {
            if (vista == null) throw new ArgumentNullException("view");
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            __vista = vista;
            _navegacionServicio = navigationService;
        }

        public IView Vista
        {
            get
            {
                return __vista;
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

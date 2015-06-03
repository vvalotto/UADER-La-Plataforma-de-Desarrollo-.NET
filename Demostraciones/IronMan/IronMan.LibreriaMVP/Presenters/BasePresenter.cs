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
        /* Clase Abstracta para la definición del Presenter
        Contiene una relacion con la vista a traves de la interfaz IView 
        para poder manejar los eventos de la lista
        */
        private readonly TVista _vista;

        private readonly INavegacionServicio _navegacionServicio;

        #region Constructor
        public BasePresenter(TVista vista)
        {
            /*Constructor donde se le asocia la vista correspondiente */
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
        #endregion

        #region Propiedades Públicas
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
        #endregion

        public abstract void Inicializar();
    }
}

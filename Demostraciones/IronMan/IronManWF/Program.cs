using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronMan.Gestores;
using IronMan.LibreriaMVP.Presenters;
using IronMan.LibreriaMVP.Views;

namespace IronManWF
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frmEventos());

            //var _frmEventoMVP = new frmEventoMVP();
            //var _eGestor = new EventoGestor();
            //var _eventoListPresenter = new EventoListPresenter(_frmEventoMVP, _eGestor);

            //_frmEventoMVP.Cerrar += () =>
            //    {
            //        Application.Exit();
            //    };

            //Application.Run(_frmEventoMVP);
            frmIronMan _frmIroMan = new frmIronMan();
            Application.Run(_frmIroMan);
        }
    }
}

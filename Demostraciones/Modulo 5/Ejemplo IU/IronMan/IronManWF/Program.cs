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
            
            //Aplicacion sin MVP
            //frmEventos _frmEventos = new frmEventos();
            //Application.Run(_frmEventos);

            //Aplicacion con MVP
            frmIronMan _frmIroMan = new frmIronMan();
            Application.Run(_frmIroMan);
        }
    }
}

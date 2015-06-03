using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EjemploMVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Form2 form2 = new Form2();
            IModelo model = new ModeloInc();
            IControlador controlador1 = new ControladorIncremento(form, model);
            IControlador controlador2 = new ControladorIncremento(form2, model);
            Application.Run(form);
            Application.Run(form2);
        }
    }
}

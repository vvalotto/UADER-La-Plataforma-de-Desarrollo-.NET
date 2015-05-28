using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCWinForm.Modelo;
using IronMan.DTO;
using IronMan.Dominio;
using MVCWinForm.Vista;
using MVCWinForm.Controlador;

namespace MVCWinForm
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormListaEventos vListarEventos = new FormListaEventos();
            ListaEventoObservado listaEventos = new ListaEventoObservado();
            ControladorListarEvento controlador = new ControladorListarEvento(vListarEventos, listaEventos);
            listaEventos.AgregarObservador(vListarEventos);
            vListarEventos.AdjuntarControlador(controlador);

            //Form2 vista2 = new Form2();
            //IModelo modelo = new ModeloInc();
            //IControlador controlador1 = new ControladorIncremento(vista1, modelo);
            //IControlador controlador2 = new ControladorIncremento(vista2, modelo);
            Application.Run(vListarEventos);
            //Application.Run(vista2);

            //ListaEventoObservado _listaEvento = new ListaEventoObservado();
            //ObservadorEvento1 _obs1 = new ObservadorEvento1();
            //ObservadorEvento2 _obs2 = new ObservadorEvento2();
            //EventoDTO _evento = new EventoDTO();

            //_listaEvento.AgregarObservador(_obs1);
            //_listaEvento.AgregarObservador(_obs2);

            //_evento.Nombre = "Centenario";
            //_evento.Comentario = "Festejo";
            //_evento.Lugar = "Santo Tome";
            //_evento.Fecha = DateTime.Today;
            //_evento.EstaHabilitado = true;

            //_listaEvento.AgregarEvento(_evento);

            //Console.Read();


        }
    }
}

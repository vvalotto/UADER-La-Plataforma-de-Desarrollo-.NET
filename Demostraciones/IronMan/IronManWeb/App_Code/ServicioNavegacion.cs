using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IronMan.LibreriaMVP.Views;
using System.Collections.Specialized;

/// <summary>
/// Descripción breve de ServicioNavegacion
/// </summary>
public class NavegacionServicio: INavegacionServicio
{
        public void GoTo(ViewPages viewPages)
        {
            GoTo(viewPages, null);
        }

        public void GoTo(ViewPages viewPages, NameValueCollection parameters)
        {
            HttpContext currentContext = HttpContext.Current;
            string redirectUrl = string.Empty;

            switch (viewPages)
            {
                case ViewPages.Eventos:
                    redirectUrl = "~/ListaEventos.aspx";
                    break;
                case ViewPages.EventoDetalles:
                    redirectUrl = "~/Evento.aspx";
                    break;
                case ViewPages.Confirmacion:
                    redirectUrl = "~/Confirmacion.aspx";
                    break;
                case ViewPages.Error:
                    redirectUrl = "~/Erroaspx";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("viewPages");
            }

            currentContext.Response.Redirect(redirectUrl, true);
        }
	
}
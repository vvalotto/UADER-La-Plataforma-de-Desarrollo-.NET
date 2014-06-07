using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ClienteService : IClienteService
    {

        public Clientes GetCliente(int IDCliente)
        {
            var ctx = new ProyectosDataContext();
            var cliente = (from cli in ctx.Clientes
                           where cli.IDCliente == IDCliente
                           select cli)
                           .SingleOrDefault();
            return cliente;
        }

        public List<Clientes> GetClientes()
        {
            var ctx = new ProyectosDataContext();
            return (from cli in ctx.Clientes
                    select cli)
                    .ToList();
        }

        public int InsertarCliente(Clientes Cli)
        {
            var ctx = new ProyectosDataContext();
            ctx.Clientes.InsertOnSubmit(Cli);
            ctx.SubmitChanges();
            return Cli.IDCliente;
        }

        public Clientes ActualizarCliente(Clientes Cli)
        {
            Clientes unCliente = new Clientes();
            try
            {
                var ctx = new ProyectosDataContext();
                var cliente = (from cli in ctx.Clientes
                               where cli.IDCliente == Cli.IDCliente
                               select cli)
                               .SingleOrDefault();
                if (cliente != null)
                {
                    cliente.IDCliente = Cli.IDCliente;
                    cliente.Nombre = Cli.Nombre;
                    cliente.IDContacto = Cli.IDContacto;
                    cliente.Web = Cli.Web;
                    cliente.Calle = Cli.Calle;
                    cliente.Numero = Cli.Numero;
                    cliente.Piso = Cli.Piso;
                    cliente.Departamento = Cli.Departamento;
                    cliente.Cuidad = Cli.Cuidad;
                    cliente.Provincia = Cli.Provincia;
                    cliente.Pais = Cli.Pais;
                    cliente.Telefono = Cli.Telefono;

                    ctx.SubmitChanges();
                }
               unCliente = cliente;
            }
            catch (Exception e)
            {
                string t = e.Message;
            }
            return unCliente;
        }

        public void EliminarCliente(Clientes Cli)
        {
            var ctx = new ProyectosDataContext();
            var cliente = (from cli in ctx.Clientes
                           where cli.IDCliente == Cli.IDCliente
                           select cli)
                           .SingleOrDefault();
            if (cliente != null)
            {
                ctx.Clientes.DeleteOnSubmit(cliente);

                ctx.SubmitChanges();
            }
                 
        }
    }
}

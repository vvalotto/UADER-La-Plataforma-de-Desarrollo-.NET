using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var ctx = new northwindEntities())
            //{
            //    var clientes = from c in ctx.Customers
            //                   select c;
                
            //    foreach (Customers c in clientes)
            //    {
            //        listBox1.Items.Add(c.CompanyName);
            //    }
            //}

            try
            {
                using( var ctx = new northwindEntities())
                {
                    var _repClientes = new Repositorio<Customers>(ctx);

                    var clientes = _repClientes.GetTodos();

                    foreach (Customers c in clientes)
                    {
                        listBox1.Items.Add(c.CompanyName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _nombreCliente = listBox1.SelectedItem.ToString();
            
            var _cliente = new Customers();

            try
            {
                using (var ctx = new northwindEntities())
                {
                    var _clientes = from c in ctx.Customers
                                   where c.CompanyName == _nombreCliente
                                   select c;

                    _cliente = _clientes.SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
            textBox1.Text = _cliente.CompanyName;
            textBox2.Text = _cliente.ContactName;
            textBox3.Text = _cliente.Address;
            textBox4.Text = _cliente.City;
            textBox5.Text = _cliente.Region;
        }
    }
}

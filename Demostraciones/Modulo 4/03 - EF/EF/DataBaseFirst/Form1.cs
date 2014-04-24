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
            using (var ctx = new northwindEntities())
            {
                var clientes = from c in ctx.Customers
                               select c;
                
                foreach (Customers c in clientes)
                {
                    listBox1.Items.Add(c.CompanyName);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reposicion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Su Nombre", "AVISO");

            if (cliente != "")
            {
                cajero cj = new cajero();
                this.Hide();
                
                cj.txtcliente.Text = string.Concat("Cliente: ", cliente);
                cj.clientes = cliente;
                cj.Show();
            }


        }
    }
}

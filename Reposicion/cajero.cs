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
    public partial class cajero : Form
    {
        public cajero()
        {
            InitializeComponent();
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            txtcliente
        }
        public string clientes;
        public int saldo;
        public int transacciones;

        private void cajero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAJEROBDDataSet.Cajero' Puede moverla o quitarla según sea necesario.
           
            saldo = 1000;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clientes2 cl = new Clientes2();
            cl.SET(transacciones.ToString(),clientes,saldo.ToString());

            MessageBox.Show("CLIENTE: " +clientes+"\nSALDO:"+saldo+"Numero de Transacciones:", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deposito = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que desea depositar", "AVISO");

            Clientes2 cl = new Clientes2();
            cl.SET(transacciones.ToString(), clientes, saldo.ToString());
           
            

                saldo = saldo + Convert.ToInt32(deposito);
                MessageBox.Show("La treansaccion se ralizo con exito");
                cajeroTableAdapter1.Insert(cl.DevolverClientes(),cl.DevolverSaldo());
                    

                transacciones++;

            
           
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            string deposito = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que desea retirar", "AVISO");

            Clientes2 cl = new Clientes2();
            cl.SET(transacciones.ToString(), clientes, saldo.ToString());
            if (deposito != "")
            {
                if (Convert.ToDouble(deposito) <= Convert.ToDouble(cl.DevolverSaldo()))
                {

                    saldo = saldo - Convert.ToInt32(deposito);
                    MessageBox.Show("La treansaccion se ralizo con exito");
                    cajeroTableAdapter1.Insert(cl.DevolverClientes(), cl.DevolverSaldo());


                    transacciones++;

                }
                else
                {
                    MessageBox.Show("EL saldo es infuciente para realizar la transaccion ");
                }
            }
            transacciones++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saldo <= 200)
            {
                saldo = saldo - 600;
                MessageBox.Show("La treansaccion se ralizo con exito");
            }
            else
            {
                MessageBox.Show("EL saldo es infuciente para realizar la transaccion ");
            }

            transacciones++;
        }

        
        

        private void button4_Click(object sender, EventArgs e)
        {
            if (saldo<=600) {
                saldo =saldo- 600;
                MessageBox.Show("La treansaccion se ralizo con exito");
            }
            else{
                MessageBox.Show("EL saldo es infuciente para realizar la transaccion ");
            }

            transacciones++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su Saldo es: "+saldo,"aviso");
            transacciones++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reportesss n = new reportesss();
            this.Hide();
            n.Show();
                
        }
    }
}

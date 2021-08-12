using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposicion
{
    class Cliente
    {
      
        static protected string NumerodeTransacciones;
        static protected string clientes;
        static protected string saldo;

        public void SET(string Transacciones,string cliente, string saldos)
        {

            NumerodeTransacciones = Transacciones;
            clientes = cliente;
            saldo = saldos; 
        }


        public void SET(string Transacciones)
        {

            NumerodeTransacciones = Transacciones;

        }


        public string DevolverTransacciones()
        {
            return NumerodeTransacciones;
        }

        public string DevolverClientes()
        {
            return clientes;
        }

        public string DevolverSaldo()
        {
            return saldo;
        }

    }
}

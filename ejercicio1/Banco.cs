using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace operacionesBancarias.dominio
{
    /*
    * La clase Banco implementa el patrón de diseño Singleton
    * porque sólo puede haber un objeto del tipo Banco
    */
    class Banco
    {
        /*
        * La variable de referencia qua almacena la instancia de Banco.
        */
        private static Banco instanciaBanco = new Banco();
        public static Banco getBanco()
        {
            return instanciaBanco;
        }

        private const double PORCENTAJE_CAJA_AHORRO = 3.5;
        private ArrayList clientes;
        private int numeroDeClientes;

        private Banco()
        {
            clientes = new ArrayList();
        }

        public void AgregaCliente(String p, String a)
        {
            clientes.Add(new Cliente(p, a));
            numeroDeClientes = clientes.Count;
        }
        public Cliente GetCliente(int indiceCliente)
        {
            return (Cliente)clientes[indiceCliente];
        }

        public void OrdenarClientes()
        {
            clientes.Sort();
        }

        public int NumeroDeClientes
        {
            get
            {
                return numeroDeClientes;
            }
        }
    }
}

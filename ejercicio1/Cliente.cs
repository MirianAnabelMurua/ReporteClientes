using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace operacionesBancarias.dominio
{
    class Cliente : IComparable
    {
        // Atributos para datos
        private String primerNombre;
        private String apellido;
        // Atributos para la agregación
        private ArrayList cuentas;
        private int numeroDeCuentas = 0;

        public Cliente(String p, String a)
        {
            primerNombre = p;
            apellido = a;
            cuentas = new ArrayList();
        }

        public void AgregaCuenta(Cuenta cta)
        {
            cuentas.Add(cta);
            numeroDeCuentas = cuentas.Count;
        }
        public Cuenta GetCuenta(int indiceCuenta)
        {
            return (Cuenta)cuentas[indiceCuenta];
        }

        public String PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }
        public String Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int NumeroDeCuentas
        {
            get
            {
                return numeroDeCuentas;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Cliente elOtro = obj as Cliente;
            if (elOtro != null)
            {
                int aux = apellido.CompareTo(elOtro.apellido);
                if (aux != 0) return aux;
                aux = primerNombre.CompareTo(elOtro.primerNombre);
                if (aux != 0) return aux;
                return 0;
            }
            else
                throw new ArgumentException("El objeto no es un cliente");
        }
        /***
        *   Paso 1 - Retornar cadena formada con el apellido, 
        *       una coma, un espacio en blanco y el primer nombre
        ***/

        public override string ToString()
        {
            return apellido + ", " + primerNombre;
        }
    }
}

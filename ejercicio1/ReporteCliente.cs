using System;
using System.Text;
using operacionesBancarias.dominio;
using System.IO;

namespace operacionesBancarias.reportes
{
    class ReporteCliente
    {
        /***
        *   Paso 4 - Renombrar el método GenerarReporte con 
        *       el nombre GuardarReporteEnDisco 
        ***/
        public static void GuardarReporteEnDisco()
        {
            Banco banco = Banco.getBanco();
            Cliente cliente;
            string path = @"C:\Reporte.txt";

            FileInfo fi = new FileInfo(path);
            if (fi.Exists == true)
            {
                fi.Delete();
            }

            using (StreamWriter sw = fi.CreateText())
            {
                sw.WriteLine();
                sw.WriteLine("\t\t\tREPORTE DE CLIENTES");
                sw.WriteLine("\t\t\t====================");

                for (int indiceCliente = 0; indiceCliente < banco.NumeroDeClientes; indiceCliente++)
                {
                    cliente = banco.GetCliente(indiceCliente);

                    sw.WriteLine();
                    sw.WriteLine("Cliente: "
                           + cliente.Apellido + ", "
                           + cliente.PrimerNombre);

                    for (int indiceCuenta = 0; indiceCuenta < cliente.NumeroDeCuentas; indiceCuenta++)
                    {
                        Cuenta cuenta = cliente.GetCuenta(indiceCuenta);
                        String tipoCuenta = "";

                        // Determinar el tipo de cuenta
                        if (cuenta is CajaDeAhorro)
                        {
                            tipoCuenta = "Caja de Ahorro";
                        }
                        else if (cuenta is CuentaCorriente)
                        {
                            tipoCuenta = "Cuenta Corriente";
                        }
                        else
                        {
                            tipoCuenta = "Tipo de Cuenta Desconocido";
                        }
                        // Imprimir el balance actual de la cuenta
                        sw.WriteLine("    " + tipoCuenta + ": el balance actual es "
                                 + cuenta.Balance);
                    }
                }
            }
        }

        /***
        *   Paso 5 - Generar un nuevo método estático llamado Reporte el cual 
        *       retornará una cadena con el formato de salida del reporte 
        ***/
        public static string Reporte()
        {
            Banco banco = Banco.getBanco();
            Cliente cliente;
            StringBuilder _reporte = new StringBuilder();

            _reporte.Append("\t\t\tREPORTE DE CLIENTES");
            _reporte.Append(Environment.NewLine);
            _reporte.Append("\t\t\t====================");

            for (int indiceCliente = 0; indiceCliente < banco.NumeroDeClientes; indiceCliente++)
            {
                cliente = banco.GetCliente(indiceCliente);

                _reporte.Append(Environment.NewLine);
                _reporte.Append("Cliente: "
                       + cliente.Apellido + ", "
                       + cliente.PrimerNombre);

                for (int indiceCuenta = 0; indiceCuenta < cliente.NumeroDeCuentas; indiceCuenta++)
                {
                    Cuenta cuenta = cliente.GetCuenta(indiceCuenta);
                    String tipoCuenta = "";

                    // Determinar el tipo de cuenta
                    if (cuenta is CajaDeAhorro)
                    {
                        tipoCuenta = "Caja de Ahorro";
                    }
                    else if (cuenta is CuentaCorriente)
                    {
                        tipoCuenta = "Cuenta Corriente";
                    }
                    else
                    {
                        tipoCuenta = "Tipo de Cuenta Desconocido";
                    }
                    // Imprimir el balance actual de la cuenta
                    _reporte.Append("    " + tipoCuenta + ": el balance actual es "
                             + cuenta.Balance);
                }
            }
            return _reporte.ToString();
        }
    }
}


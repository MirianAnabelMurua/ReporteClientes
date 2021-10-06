using System;
using System.Windows.Forms;
using operacionesBancarias.dominio;
using operacionesBancarias.reportes;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        private Banco banco = Banco.getBanco();
        private Cliente _cliente;

        public Form1()
        {
            InitializeComponent();
            banco.AgregaCliente("Juan", "Perez");
            _cliente = banco.GetCliente(0);
            /***
            *   Paso 6 - Agregar cliente del banco al ComboBox cbxClientes  
            ***/
            cbxClientes.Items.Add(_cliente);
            _cliente.AgregaCuenta(new CuentaCorriente(200.00, 500.00));
            _cliente.AgregaCuenta(new CajaDeAhorro(500.00, 0.05));

            banco.AgregaCliente("Oscar", "Toma");
            _cliente = banco.GetCliente(1);
            /***
            *   Paso 7 - Agregar cliente del banco al ComboBox cbxClientes 
            ***/
            cbxClientes.Items.Add(_cliente);
            _cliente.AgregaCuenta(new CuentaCorriente(200.00));
            _cliente.AgregaCuenta(new CajaDeAhorro(700.00, 0.05));

            banco.AgregaCliente("Pedro", "García");
            _cliente = banco.GetCliente(2);
            /***
            *   Paso 8 - Agregar cliente del banco al ComboBox cbxClientes             
            ***/
            cbxClientes.Items.Add(_cliente);
            _cliente.AgregaCuenta(new CuentaCorriente(500.00));
            _cliente.AgregaCuenta(new CajaDeAhorro(900.00, 0.05));

            banco.AgregaCliente("Maria", "Soley");
            _cliente = banco.GetCliente(3);
            /***
            *   Paso 9 - Agregar cliente del banco al ComboBox cbxClientes  
            ***/
            cbxClientes.Items.Add(_cliente);
            // Maria y Oscar tienen una caja de ahorros en común
            _cliente.AgregaCuenta(banco.GetCliente(1).GetCuenta(1));
            banco.OrdenarClientes();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "99999";

            /***
            *   Paso 10 - Agregar los manejadores de eventos para el maskedTextBox1  
            ***/
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);

            cbxOperacion.SelectedIndex = 0;
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = cbxClientes.SelectedItem as Cliente;
            /***
            *   Paso 11 - Limpiar de Items el cbxCuentas para volverlo a 
            *       llenar según las cuentas de cada cliente 
            ***/
            cbxCuentas.Items.Clear();
            /***
            *   Paso 12 -	Seleccionar el ítem 0 del cbxOperacion 
            *       para asegurarse que siempre haya una cuenta seleccionada y no tener que validar la selección 
            ***/
            cbxOperacion.SelectedIndex = 0;
            for (int i = 0; i < c.NumeroDeCuentas; i++)
            {
                cbxCuentas.Items.Add(c.GetCuenta(i));
            }

            cbxCuentas.SelectedIndex = 0;
            /***
            *   Paso 13 - Obtener el objeto del tipo Cuenta  
            ***/
            Cuenta cta = cbxCuentas.SelectedItem as Cuenta;
            /***
            *   Paso 14 - Asignar el balance de la cuenta al txtbBalance  
            ***/
            txtbBalance.Text = cta.Balance.ToString();
        }

        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "Ingreso Rechazado - Demasiados Datos";
                toolTip1.Show("No se pueden ingresar números. Borrar algunos caracteres para ingresar datos.", maskedTextBox1, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Ingreso Rechazado - Fin del Campo";
                toolTip1.Show("No se pueden agregar caracteres extras al final de este campo numérico.", maskedTextBox1, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Ingreso Rechazado";
                toolTip1.Show("Se pueden ingresar sólo caracteres numéricos (0-9) en este campo.", maskedTextBox1, 0, -20, 5000);
            }
        }

        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // El globo informativo es visible por 5 segundos; si el usuario escribe cualquier datos
            // este desaparece por si mismo
            toolTip1.Hide(maskedTextBox1);
        }

        private void btRealizarOperacion_Click(object sender, EventArgs e)
        {
            string strCantidad = maskedTextBox1.Text.Trim();
            int cantidad;


            /***
            *   Paso 15 - Obtener el objeto del tipo Cliente 
            ***/
            Cliente c = cbxClientes.SelectedItem as Cliente;

            if (c == null)
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cuenta cta = cbxCuentas.SelectedItem as Cuenta;

            /***
            *   Paso 16 - Validar que la referencia al objeto del tipo Cuenta 
            ***/
            if (cta == null)
            {
                MessageBox.Show("Debe seleccionar una Cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (strCantidad == null || strCantidad.Length == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cantidad = Int32.Parse(strCantidad);
            }

            /***
            *   Paso 17 - Basándose en el índice del ComboBox cbxOperacion 
            *       se sabe que el elemento 0 es la operación Retira, 
            *       sino es Deposita. Usar la referencia al objeto de tipo 
            *       cuenta para realizar la operación apropiada en base a la 
            *       cantidad obtenida del maskedTextBox1. 
            ***/
            if (cbxOperacion.SelectedIndex == 0)
            {
                // Es un retiro
                try
                {
                    cta.Retira(cantidad);
                }
                catch (ExcepcionSobregiro e1)
                {
                    MessageBox.Show("Excepción: " + e1.Message + "   Deficit: "
                            + e1.Deficit, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Es un depósito
                cta.Deposita(cantidad);
            }

            /***
            *   Paso 18 - Asignar el balance de la cuenta al txtbBalance 
            ***/
            txtbBalance.Text = cta.Balance.ToString();
            /***
            *   Paso 19 - Actualizar el reporte que se muestra 
            *       luego de cada operación en txtBReporte. 
            ***/
            txtBReporte.Text = ReporteCliente.Reporte();
        }

        private void cbxCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            /***
            *   Paso 20 - Recuperar el objeto del tipo Cuenta cada vez que cambia la selección   
            ***/
            Cuenta cta = cbxCuentas.SelectedItem as Cuenta;
            /***
            *   Paso 21 -  Asignar el balance de la cuenta al txtbBalance  
            ***/
            txtbBalance.Text = cta.Balance.ToString();
        }

        private void btGuardarReporte_Click(object sender, EventArgs e)
        {
            /***
            *   Paso 22 - Guardar el reporte en disco  
            ***/
            ReporteCliente.GuardarReporteEnDisco();
        }
    }
}

namespace ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCuentas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxOperacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtbBalance = new System.Windows.Forms.TextBox();
            this.btRealizarOperacion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBReporte = new System.Windows.Forms.TextBox();
            this.btGuardarReporte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(88, 5);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(121, 21);
            this.cbxClientes.TabIndex = 1;
            this.cbxClientes.SelectedIndexChanged += new System.EventHandler(this.cbxClientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuentas:";
            // 
            // cbxCuentas
            // 
            this.cbxCuentas.FormattingEnabled = true;
            this.cbxCuentas.Location = new System.Drawing.Point(331, 5);
            this.cbxCuentas.Name = "cbxCuentas";
            this.cbxCuentas.Size = new System.Drawing.Size(121, 21);
            this.cbxCuentas.TabIndex = 3;
            this.cbxCuentas.SelectedIndexChanged += new System.EventHandler(this.cbxCuentas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operación";
            // 
            // cbxOperacion
            // 
            this.cbxOperacion.FormattingEnabled = true;
            this.cbxOperacion.Items.AddRange(new object[] {
            "Retira",
            "Deposita"});
            this.cbxOperacion.Location = new System.Drawing.Point(88, 49);
            this.cbxOperacion.Name = "cbxOperacion";
            this.cbxOperacion.Size = new System.Drawing.Size(121, 21);
            this.cbxOperacion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(331, 41);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(54, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Balance:";
            // 
            // txtbBalance
            // 
            this.txtbBalance.Enabled = false;
            this.txtbBalance.Location = new System.Drawing.Point(270, 137);
            this.txtbBalance.Name = "txtbBalance";
            this.txtbBalance.Size = new System.Drawing.Size(100, 20);
            this.txtbBalance.TabIndex = 9;
            // 
            // btRealizarOperacion
            // 
            this.btRealizarOperacion.Location = new System.Drawing.Point(195, 85);
            this.btRealizarOperacion.Name = "btRealizarOperacion";
            this.btRealizarOperacion.Size = new System.Drawing.Size(125, 23);
            this.btRealizarOperacion.TabIndex = 10;
            this.btRealizarOperacion.Text = "Realizar Operación";
            this.btRealizarOperacion.UseVisualStyleBackColor = true;
            this.btRealizarOperacion.Click += new System.EventHandler(this.btRealizarOperacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBReporte);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 137);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte";
            // 
            // txtBReporte
            // 
            this.txtBReporte.Location = new System.Drawing.Point(7, 20);
            this.txtBReporte.Multiline = true;
            this.txtBReporte.Name = "txtBReporte";
            this.txtBReporte.Size = new System.Drawing.Size(576, 111);
            this.txtBReporte.TabIndex = 0;
            // 
            // btGuardarReporte
            // 
            this.btGuardarReporte.Location = new System.Drawing.Point(492, 85);
            this.btGuardarReporte.Name = "btGuardarReporte";
            this.btGuardarReporte.Size = new System.Drawing.Size(75, 60);
            this.btGuardarReporte.TabIndex = 12;
            this.btGuardarReporte.Text = "Guardar Reporte en Disco";
            this.btGuardarReporte.UseVisualStyleBackColor = true;
            this.btGuardarReporte.Click += new System.EventHandler(this.btGuardarReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 322);
            this.Controls.Add(this.btGuardarReporte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRealizarOperacion);
            this.Controls.Add(this.txtbBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxOperacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCuentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCuentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxOperacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbBalance;
        private System.Windows.Forms.Button btRealizarOperacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBReporte;
        private System.Windows.Forms.Button btGuardarReporte;

    }
}


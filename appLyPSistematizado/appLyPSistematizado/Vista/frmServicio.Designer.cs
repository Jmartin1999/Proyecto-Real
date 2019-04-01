namespace appLyPSistematizado.Vista
{
    partial class frmServicio
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
            this.lblDocumento = new System.Windows.Forms.Label();
            this.btnAtras22 = new System.Windows.Forms.Button();
            this.txtBuscar22 = new System.Windows.Forms.TextBox();
            this.btnBuscar22 = new System.Windows.Forms.Button();
            this.btnEliminar22 = new System.Windows.Forms.Button();
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.btnModificar22 = new System.Windows.Forms.Button();
            this.gbxcliente = new System.Windows.Forms.GroupBox();
            this.chbsalida = new System.Windows.Forms.CheckBox();
            this.cmbTarifa22 = new System.Windows.Forms.ComboBox();
            this.cmbempleado22 = new System.Windows.Forms.ComboBox();
            this.cmbAutomovil22 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTipoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrada22 = new System.Windows.Forms.TextBox();
            this.btnguarda22 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre11 = new System.Windows.Forms.TextBox();
            this.txtSalida22 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
            this.gbxcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(653, 24);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(34, 13);
            this.lblDocumento.TabIndex = 22;
            this.lblDocumento.Text = "Placa";
            // 
            // btnAtras22
            // 
            this.btnAtras22.Location = new System.Drawing.Point(670, 401);
            this.btnAtras22.Name = "btnAtras22";
            this.btnAtras22.Size = new System.Drawing.Size(104, 37);
            this.btnAtras22.TabIndex = 28;
            this.btnAtras22.Text = "Ticket";
            this.btnAtras22.UseVisualStyleBackColor = true;
            // 
            // txtBuscar22
            // 
            this.txtBuscar22.Location = new System.Drawing.Point(707, 21);
            this.txtBuscar22.Name = "txtBuscar22";
            this.txtBuscar22.Size = new System.Drawing.Size(204, 20);
            this.txtBuscar22.TabIndex = 23;
            // 
            // btnBuscar22
            // 
            this.btnBuscar22.Location = new System.Drawing.Point(947, 16);
            this.btnBuscar22.Name = "btnBuscar22";
            this.btnBuscar22.Size = new System.Drawing.Size(94, 30);
            this.btnBuscar22.TabIndex = 27;
            this.btnBuscar22.Text = "buscar";
            this.btnBuscar22.UseVisualStyleBackColor = true;
            // 
            // btnEliminar22
            // 
            this.btnEliminar22.Location = new System.Drawing.Point(1057, 16);
            this.btnEliminar22.Name = "btnEliminar22";
            this.btnEliminar22.Size = new System.Drawing.Size(88, 30);
            this.btnEliminar22.TabIndex = 26;
            this.btnEliminar22.Text = "Eliminar";
            this.btnEliminar22.UseVisualStyleBackColor = true;
            this.btnEliminar22.Click += new System.EventHandler(this.btnEliminar22_Click);
            // 
            // dgvServicio
            // 
            this.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicio.Location = new System.Drawing.Point(490, 52);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.Size = new System.Drawing.Size(680, 340);
            this.dgvServicio.TabIndex = 25;
            this.dgvServicio.DoubleClick += new System.EventHandler(this.dgvServicio_DoubleClick);
            // 
            // btnModificar22
            // 
            this.btnModificar22.Location = new System.Drawing.Point(229, 275);
            this.btnModificar22.Name = "btnModificar22";
            this.btnModificar22.Size = new System.Drawing.Size(91, 36);
            this.btnModificar22.TabIndex = 21;
            this.btnModificar22.Text = "Modificar";
            this.btnModificar22.UseVisualStyleBackColor = true;
            this.btnModificar22.Click += new System.EventHandler(this.btnModificar22_Click);
            // 
            // gbxcliente
            // 
            this.gbxcliente.Controls.Add(this.chbsalida);
            this.gbxcliente.Controls.Add(this.cmbTarifa22);
            this.gbxcliente.Controls.Add(this.cmbempleado22);
            this.gbxcliente.Controls.Add(this.cmbAutomovil22);
            this.gbxcliente.Controls.Add(this.label9);
            this.gbxcliente.Controls.Add(this.label8);
            this.gbxcliente.Controls.Add(this.txtTipoa);
            this.gbxcliente.Controls.Add(this.btnModificar22);
            this.gbxcliente.Controls.Add(this.label1);
            this.gbxcliente.Controls.Add(this.txtEntrada22);
            this.gbxcliente.Controls.Add(this.btnguarda22);
            this.gbxcliente.Controls.Add(this.label5);
            this.gbxcliente.Controls.Add(this.label2);
            this.gbxcliente.Controls.Add(this.txtnombre11);
            this.gbxcliente.Controls.Add(this.txtSalida22);
            this.gbxcliente.Controls.Add(this.label4);
            this.gbxcliente.Controls.Add(this.label3);
            this.gbxcliente.Location = new System.Drawing.Point(36, 107);
            this.gbxcliente.Name = "gbxcliente";
            this.gbxcliente.Size = new System.Drawing.Size(432, 317);
            this.gbxcliente.TabIndex = 24;
            this.gbxcliente.TabStop = false;
            this.gbxcliente.Text = "Registro de Entrada y Salida ";
            // 
            // chbsalida
            // 
            this.chbsalida.AutoSize = true;
            this.chbsalida.Location = new System.Drawing.Point(209, 73);
            this.chbsalida.Name = "chbsalida";
            this.chbsalida.Size = new System.Drawing.Size(15, 14);
            this.chbsalida.TabIndex = 22;
            this.chbsalida.UseVisualStyleBackColor = true;
            this.chbsalida.CheckedChanged += new System.EventHandler(this.chbsalida_CheckedChanged);
            // 
            // cmbTarifa22
            // 
            this.cmbTarifa22.FormattingEnabled = true;
            this.cmbTarifa22.Location = new System.Drawing.Point(209, 208);
            this.cmbTarifa22.Name = "cmbTarifa22";
            this.cmbTarifa22.Size = new System.Drawing.Size(204, 21);
            this.cmbTarifa22.TabIndex = 20;
            // 
            // cmbempleado22
            // 
            this.cmbempleado22.FormattingEnabled = true;
            this.cmbempleado22.Location = new System.Drawing.Point(209, 153);
            this.cmbempleado22.Name = "cmbempleado22";
            this.cmbempleado22.Size = new System.Drawing.Size(204, 21);
            this.cmbempleado22.TabIndex = 17;
            this.cmbempleado22.SelectedIndexChanged += new System.EventHandler(this.cmbempleado22_SelectedIndexChanged);
            // 
            // cmbAutomovil22
            // 
            this.cmbAutomovil22.FormattingEnabled = true;
            this.cmbAutomovil22.Location = new System.Drawing.Point(209, 98);
            this.cmbAutomovil22.Name = "cmbAutomovil22";
            this.cmbAutomovil22.Size = new System.Drawing.Size(204, 21);
            this.cmbAutomovil22.TabIndex = 16;
            this.cmbAutomovil22.SelectedIndexChanged += new System.EventHandler(this.cmbAutomovil22_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombres del  Empleados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Automovil";
            // 
            // txtTipoa
            // 
            this.txtTipoa.Location = new System.Drawing.Point(209, 127);
            this.txtTipoa.Name = "txtTipoa";
            this.txtTipoa.Size = new System.Drawing.Size(204, 20);
            this.txtTipoa.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha-Hora de entrada";
            // 
            // txtEntrada22
            // 
            this.txtEntrada22.Location = new System.Drawing.Point(209, 44);
            this.txtEntrada22.Name = "txtEntrada22";
            this.txtEntrada22.Size = new System.Drawing.Size(204, 20);
            this.txtEntrada22.TabIndex = 2;
            // 
            // btnguarda22
            // 
            this.btnguarda22.Location = new System.Drawing.Point(78, 275);
            this.btnguarda22.Name = "btnguarda22";
            this.btnguarda22.Size = new System.Drawing.Size(91, 36);
            this.btnguarda22.TabIndex = 20;
            this.btnguarda22.Text = "Registrar";
            this.btnguarda22.UseVisualStyleBackColor = true;
            this.btnguarda22.Click += new System.EventHandler(this.btnguarda22_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha-Hora de Salida";
            // 
            // txtnombre11
            // 
            this.txtnombre11.Location = new System.Drawing.Point(209, 181);
            this.txtnombre11.Name = "txtnombre11";
            this.txtnombre11.Size = new System.Drawing.Size(204, 20);
            this.txtnombre11.TabIndex = 8;
            // 
            // txtSalida22
            // 
            this.txtSalida22.Location = new System.Drawing.Point(230, 70);
            this.txtSalida22.Name = "txtSalida22";
            this.txtSalida22.Size = new System.Drawing.Size(183, 20);
            this.txtSalida22.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Documento del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha y Hora Actualizado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "label10";
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(807, 401);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(104, 37);
            this.btnFactura.TabIndex = 30;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.btnAtras22);
            this.Controls.Add(this.txtBuscar22);
            this.Controls.Add(this.btnBuscar22);
            this.Controls.Add(this.btnEliminar22);
            this.Controls.Add(this.dgvServicio);
            this.Controls.Add(this.gbxcliente);
            this.Name = "frmServicio";
            this.Text = "frmServicio";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).EndInit();
            this.gbxcliente.ResumeLayout(false);
            this.gbxcliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Button btnAtras22;
        private System.Windows.Forms.TextBox txtBuscar22;
        private System.Windows.Forms.Button btnBuscar22;
        private System.Windows.Forms.Button btnEliminar22;
        private System.Windows.Forms.DataGridView dgvServicio;
        private System.Windows.Forms.Button btnModificar22;
        private System.Windows.Forms.GroupBox gbxcliente;
        private System.Windows.Forms.ComboBox cmbTarifa22;
        private System.Windows.Forms.ComboBox cmbempleado22;
        private System.Windows.Forms.ComboBox cmbAutomovil22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTipoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntrada22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre11;
        private System.Windows.Forms.TextBox txtSalida22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguarda22;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbsalida;
        private System.Windows.Forms.Button btnFactura;
    }
}
namespace appLyPSistematizado.Vista
{
    partial class frmMensualidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensualidad));
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnEliminar11 = new System.Windows.Forms.Button();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.gbxcliente = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.gpAutomovil = new System.Windows.Forms.GroupBox();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPagos = new System.Windows.Forms.TabPage();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtPlaca3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarPlaca = new System.Windows.Forms.Button();
            this.txtPlaca2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabCliente.SuspendLayout();
            this.gbxcliente.SuspendLayout();
            this.gpAutomovil.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServicio
            // 
            this.btnServicio.Location = new System.Drawing.Point(737, 422);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(75, 23);
            this.btnServicio.TabIndex = 24;
            this.btnServicio.Text = "atras";
            this.btnServicio.UseVisualStyleBackColor = true;
            // 
            // btnEliminar11
            // 
            this.btnEliminar11.Location = new System.Drawing.Point(955, 44);
            this.btnEliminar11.Name = "btnEliminar11";
            this.btnEliminar11.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar11.TabIndex = 23;
            this.btnEliminar11.Text = "Eliminar";
            this.btnEliminar11.UseVisualStyleBackColor = true;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.gbxcliente);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(846, 496);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Registro Cliente";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // gbxcliente
            // 
            this.gbxcliente.Controls.Add(this.btnPagar);
            this.gbxcliente.Controls.Add(this.gpAutomovil);
            this.gbxcliente.Controls.Add(this.gbCliente);
            this.gbxcliente.Controls.Add(this.dgvBuscar);
            this.gbxcliente.Controls.Add(this.pictureBox1);
            this.gbxcliente.Location = new System.Drawing.Point(3, 6);
            this.gbxcliente.Name = "gbxcliente";
            this.gbxcliente.Size = new System.Drawing.Size(840, 484);
            this.gbxcliente.TabIndex = 19;
            this.gbxcliente.TabStop = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(666, 359);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(114, 59);
            this.btnPagar.TabIndex = 38;
            this.btnPagar.Text = "Pago$$$";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // gpAutomovil
            // 
            this.gpAutomovil.Controls.Add(this.btnVehiculo);
            this.gpAutomovil.Controls.Add(this.txtPlaca);
            this.gpAutomovil.Controls.Add(this.cmbTipo);
            this.gpAutomovil.Controls.Add(this.label15);
            this.gpAutomovil.Controls.Add(this.label8);
            this.gpAutomovil.Controls.Add(this.label5);
            this.gpAutomovil.Controls.Add(this.btnModificar);
            this.gpAutomovil.Controls.Add(this.txtObservacion);
            this.gpAutomovil.Location = new System.Drawing.Point(397, 28);
            this.gpAutomovil.Name = "gpAutomovil";
            this.gpAutomovil.Size = new System.Drawing.Size(417, 211);
            this.gpAutomovil.TabIndex = 35;
            this.gpAutomovil.TabStop = false;
            this.gpAutomovil.Text = "Vehiculo";
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(31, 159);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(99, 38);
            this.btnVehiculo.TabIndex = 24;
            this.btnVehiculo.Text = "Buscar Vehiculo";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(116, 42);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 23;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Bicicleta"});
            this.cmbTipo.Location = new System.Drawing.Point(116, 69);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(100, 21);
            this.cmbTipo.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Tipo Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Observaciones";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(224, 154);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 43);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Registrar Vehiculo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(116, 96);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(100, 20);
            this.txtObservacion.TabIndex = 21;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblId);
            this.gbCliente.Controls.Add(this.txtDocumento);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.btnRegistrar);
            this.gbCliente.Location = new System.Drawing.Point(6, 28);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(385, 211);
            this.gbCliente.TabIndex = 34;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(290, 68);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = ":";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(147, 47);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 15;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(147, 108);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre y Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Documento";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(241, 154);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(123, 43);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar Cliente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(128, 259);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(513, 200);
            this.dgvBuscar.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-251, -61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1342, 606);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tbPagos);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 522);
            this.tabControl1.TabIndex = 30;
            // 
            // tbPagos
            // 
            this.tbPagos.Controls.Add(this.lblAutomovil);
            this.tbPagos.Controls.Add(this.lblTiempo);
            this.tbPagos.Controls.Add(this.btnPago);
            this.tbPagos.Controls.Add(this.dgvPagos);
            this.tbPagos.Controls.Add(this.txtTipo);
            this.tbPagos.Controls.Add(this.txtObservaciones);
            this.tbPagos.Controls.Add(this.txtPlaca3);
            this.tbPagos.Controls.Add(this.label6);
            this.tbPagos.Controls.Add(this.btnBuscarPlaca);
            this.tbPagos.Controls.Add(this.txtPlaca2);
            this.tbPagos.Controls.Add(this.label4);
            this.tbPagos.Controls.Add(this.pictureBox3);
            this.tbPagos.Location = new System.Drawing.Point(4, 22);
            this.tbPagos.Name = "tbPagos";
            this.tbPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagos.Size = new System.Drawing.Size(846, 496);
            this.tbPagos.TabIndex = 1;
            this.tbPagos.Text = "Registro Pagos";
            this.tbPagos.UseVisualStyleBackColor = true;
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(49, 62);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(10, 13);
            this.lblAutomovil.TabIndex = 14;
            this.lblAutomovil.Text = ":";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(683, 25);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(10, 13);
            this.lblTiempo.TabIndex = 13;
            this.lblTiempo.Text = ":";
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(313, 445);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(130, 41);
            this.btnPago.TabIndex = 12;
            this.btnPago.Text = "Registrar Pago ";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(147, 179);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(458, 204);
            this.dgvPagos.TabIndex = 11;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(332, 131);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 9;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(441, 128);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(113, 36);
            this.txtObservaciones.TabIndex = 7;
            // 
            // txtPlaca3
            // 
            this.txtPlaca3.Location = new System.Drawing.Point(207, 131);
            this.txtPlaca3.Name = "txtPlaca3";
            this.txtPlaca3.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Automovil";
            // 
            // btnBuscarPlaca
            // 
            this.btnBuscarPlaca.Location = new System.Drawing.Point(398, 51);
            this.btnBuscarPlaca.Name = "btnBuscarPlaca";
            this.btnBuscarPlaca.Size = new System.Drawing.Size(100, 34);
            this.btnBuscarPlaca.TabIndex = 2;
            this.btnBuscarPlaca.Text = "Buscar";
            this.btnBuscarPlaca.UseVisualStyleBackColor = true;
            this.btnBuscarPlaca.Click += new System.EventHandler(this.btnBuscarPlaca_Click);
            // 
            // txtPlaca2
            // 
            this.txtPlaca2.Location = new System.Drawing.Point(265, 59);
            this.txtPlaca2.Name = "txtPlaca2";
            this.txtPlaca2.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca2.TabIndex = 1;
            this.txtPlaca2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Buscar Placa";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-248, -55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1342, 606);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.btnEliminar11);
            this.Name = "frmMensualidad";
            this.Text = "Mensualidad";
            this.Load += new System.EventHandler(this.frmMensualidad_Load);
            this.tabCliente.ResumeLayout(false);
            this.gbxcliente.ResumeLayout(false);
            this.gpAutomovil.ResumeLayout(false);
            this.gpAutomovil.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbPagos.ResumeLayout(false);
            this.tbPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button btnEliminar11;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.GroupBox gbxcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.TabPage tbPagos;
        private System.Windows.Forms.GroupBox gpAutomovil;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtPlaca3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarPlaca;
        private System.Windows.Forms.TextBox txtPlaca2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPagar;
    }
}
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
            this.lblDocumento = new System.Windows.Forms.Label();
            this.btnAtras22 = new System.Windows.Forms.Button();
            this.txtBuscar22 = new System.Windows.Forms.TextBox();
            this.btnBuscar22 = new System.Windows.Forms.Button();
            this.btnEliminar22 = new System.Windows.Forms.Button();
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.btnModificar22 = new System.Windows.Forms.Button();
            this.gbxcliente = new System.Windows.Forms.GroupBox();
            this.cmbTarifa22 = new System.Windows.Forms.ComboBox();
            this.cbxSi22 = new System.Windows.Forms.CheckBox();
            this.cmbempleado22 = new System.Windows.Forms.ComboBox();
            this.cmbAutomovil22 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTipoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrada22 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre11 = new System.Windows.Forms.TextBox();
            this.txtSalida22 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguarda22 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
            this.gbxcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(218, 275);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(34, 13);
            this.lblDocumento.TabIndex = 22;
            this.lblDocumento.Text = "Placa";
            // 
            // btnAtras22
            // 
            this.btnAtras22.Location = new System.Drawing.Point(923, 162);
            this.btnAtras22.Name = "btnAtras22";
            this.btnAtras22.Size = new System.Drawing.Size(75, 23);
            this.btnAtras22.TabIndex = 28;
            this.btnAtras22.Text = "Atras";
            this.btnAtras22.UseVisualStyleBackColor = true;
            // 
            // txtBuscar22
            // 
            this.txtBuscar22.Location = new System.Drawing.Point(337, 275);
            this.txtBuscar22.Name = "txtBuscar22";
            this.txtBuscar22.Size = new System.Drawing.Size(204, 20);
            this.txtBuscar22.TabIndex = 23;
            // 
            // btnBuscar22
            // 
            this.btnBuscar22.Location = new System.Drawing.Point(590, 273);
            this.btnBuscar22.Name = "btnBuscar22";
            this.btnBuscar22.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar22.TabIndex = 27;
            this.btnBuscar22.Text = "buscar";
            this.btnBuscar22.UseVisualStyleBackColor = true;
            // 
            // btnEliminar22
            // 
            this.btnEliminar22.Location = new System.Drawing.Point(923, 124);
            this.btnEliminar22.Name = "btnEliminar22";
            this.btnEliminar22.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar22.TabIndex = 26;
            this.btnEliminar22.Text = "Eliminar";
            this.btnEliminar22.UseVisualStyleBackColor = true;
            this.btnEliminar22.Click += new System.EventHandler(this.btnEliminar22_Click);
            // 
            // dgvServicio
            // 
            this.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicio.Location = new System.Drawing.Point(125, 301);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.Size = new System.Drawing.Size(680, 247);
            this.dgvServicio.TabIndex = 25;
            this.dgvServicio.DoubleClick += new System.EventHandler(this.dgvServicio_DoubleClick);
            // 
            // btnModificar22
            // 
            this.btnModificar22.Location = new System.Drawing.Point(923, 82);
            this.btnModificar22.Name = "btnModificar22";
            this.btnModificar22.Size = new System.Drawing.Size(75, 23);
            this.btnModificar22.TabIndex = 21;
            this.btnModificar22.Text = "Modificar";
            this.btnModificar22.UseVisualStyleBackColor = true;
            this.btnModificar22.Click += new System.EventHandler(this.btnModificar22_Click);
            // 
            // gbxcliente
            // 
            this.gbxcliente.Controls.Add(this.cmbTarifa22);
            this.gbxcliente.Controls.Add(this.cbxSi22);
            this.gbxcliente.Controls.Add(this.cmbempleado22);
            this.gbxcliente.Controls.Add(this.cmbAutomovil22);
            this.gbxcliente.Controls.Add(this.label9);
            this.gbxcliente.Controls.Add(this.label8);
            this.gbxcliente.Controls.Add(this.txtTipoa);
            this.gbxcliente.Controls.Add(this.label6);
            this.gbxcliente.Controls.Add(this.label1);
            this.gbxcliente.Controls.Add(this.txtEntrada22);
            this.gbxcliente.Controls.Add(this.label5);
            this.gbxcliente.Controls.Add(this.label2);
            this.gbxcliente.Controls.Add(this.txtnombre11);
            this.gbxcliente.Controls.Add(this.txtSalida22);
            this.gbxcliente.Controls.Add(this.label4);
            this.gbxcliente.Controls.Add(this.label3);
            this.gbxcliente.Location = new System.Drawing.Point(18, 20);
            this.gbxcliente.Name = "gbxcliente";
            this.gbxcliente.Size = new System.Drawing.Size(858, 225);
            this.gbxcliente.TabIndex = 24;
            this.gbxcliente.TabStop = false;
            // 
            // cmbTarifa22
            // 
            this.cmbTarifa22.FormattingEnabled = true;
            this.cmbTarifa22.Location = new System.Drawing.Point(609, 142);
            this.cmbTarifa22.Name = "cmbTarifa22";
            this.cmbTarifa22.Size = new System.Drawing.Size(204, 21);
            this.cmbTarifa22.TabIndex = 20;
            // 
            // cbxSi22
            // 
            this.cbxSi22.AutoSize = true;
            this.cbxSi22.Checked = true;
            this.cbxSi22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSi22.Location = new System.Drawing.Point(609, 178);
            this.cbxSi22.Name = "cbxSi22";
            this.cbxSi22.Size = new System.Drawing.Size(35, 17);
            this.cbxSi22.TabIndex = 18;
            this.cbxSi22.Text = "Si";
            this.cbxSi22.UseVisualStyleBackColor = true;
            // 
            // cmbempleado22
            // 
            this.cmbempleado22.FormattingEnabled = true;
            this.cmbempleado22.Location = new System.Drawing.Point(608, 68);
            this.cmbempleado22.Name = "cmbempleado22";
            this.cmbempleado22.Size = new System.Drawing.Size(204, 21);
            this.cmbempleado22.TabIndex = 17;
            this.cmbempleado22.SelectedIndexChanged += new System.EventHandler(this.cmbempleado22_SelectedIndexChanged);
            // 
            // cmbAutomovil22
            // 
            this.cmbAutomovil22.FormattingEnabled = true;
            this.cmbAutomovil22.Location = new System.Drawing.Point(148, 147);
            this.cmbAutomovil22.Name = "cmbAutomovil22";
            this.cmbAutomovil22.Size = new System.Drawing.Size(204, 21);
            this.cmbAutomovil22.TabIndex = 16;
            this.cmbAutomovil22.SelectedIndexChanged += new System.EventHandler(this.cmbAutomovil22_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombres del  Empleados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Automovil";
            // 
            // txtTipoa
            // 
            this.txtTipoa.Location = new System.Drawing.Point(148, 184);
            this.txtTipoa.Name = "txtTipoa";
            this.txtTipoa.Size = new System.Drawing.Size(204, 20);
            this.txtTipoa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Otro Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha-Hora de entrada";
            // 
            // txtEntrada22
            // 
            this.txtEntrada22.Location = new System.Drawing.Point(148, 71);
            this.txtEntrada22.Name = "txtEntrada22";
            this.txtEntrada22.Size = new System.Drawing.Size(204, 20);
            this.txtEntrada22.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tarifa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha-Hora de Salida";
            // 
            // txtnombre11
            // 
            this.txtnombre11.Location = new System.Drawing.Point(608, 106);
            this.txtnombre11.Name = "txtnombre11";
            this.txtnombre11.Size = new System.Drawing.Size(204, 20);
            this.txtnombre11.TabIndex = 8;
            // 
            // txtSalida22
            // 
            this.txtSalida22.Location = new System.Drawing.Point(148, 111);
            this.txtSalida22.Name = "txtSalida22";
            this.txtSalida22.Size = new System.Drawing.Size(204, 20);
            this.txtSalida22.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Documento del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // btnguarda22
            // 
            this.btnguarda22.Location = new System.Drawing.Point(923, 46);
            this.btnguarda22.Name = "btnguarda22";
            this.btnguarda22.Size = new System.Drawing.Size(75, 23);
            this.btnguarda22.TabIndex = 20;
            this.btnguarda22.Text = "Registrar";
            this.btnguarda22.UseVisualStyleBackColor = true;
            this.btnguarda22.Click += new System.EventHandler(this.btnguarda22_Click);
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 565);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.btnAtras22);
            this.Controls.Add(this.txtBuscar22);
            this.Controls.Add(this.btnBuscar22);
            this.Controls.Add(this.btnEliminar22);
            this.Controls.Add(this.dgvServicio);
            this.Controls.Add(this.btnModificar22);
            this.Controls.Add(this.gbxcliente);
            this.Controls.Add(this.btnguarda22);
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
        private System.Windows.Forms.CheckBox cbxSi22;
        private System.Windows.Forms.ComboBox cmbempleado22;
        private System.Windows.Forms.ComboBox cmbAutomovil22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTipoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntrada22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre11;
        private System.Windows.Forms.TextBox txtSalida22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguarda22;
    }
}
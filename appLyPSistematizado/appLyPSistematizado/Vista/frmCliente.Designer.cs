namespace appLyPSistematizado.Vista
{
    partial class frmCliente
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
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnEliminar11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocumento11 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.gbxcliente = new System.Windows.Forms.GroupBox();
            this.btnModificar11 = new System.Windows.Forms.Button();
            this.btnguarda11 = new System.Windows.Forms.Button();
            this.txtFecha11 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirec11 = new System.Windows.Forms.TextBox();
            this.txtNom11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelf11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoc11 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbxcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServicio
            // 
            this.btnServicio.Location = new System.Drawing.Point(777, 406);
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
            this.btnEliminar11.Click += new System.EventHandler(this.btnEliminar11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Documento";
            // 
            // txtDocumento11
            // 
            this.txtDocumento11.Location = new System.Drawing.Point(583, 44);
            this.txtDocumento11.Name = "txtDocumento11";
            this.txtDocumento11.Size = new System.Drawing.Size(204, 20);
            this.txtDocumento11.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(834, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(427, 86);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(631, 300);
            this.dgvCliente.TabIndex = 20;
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // gbxcliente
            // 
            this.gbxcliente.Controls.Add(this.label1);
            this.gbxcliente.Controls.Add(this.txtDoc11);
            this.gbxcliente.Controls.Add(this.btnModificar11);
            this.gbxcliente.Controls.Add(this.btnguarda11);
            this.gbxcliente.Controls.Add(this.txtFecha11);
            this.gbxcliente.Controls.Add(this.label5);
            this.gbxcliente.Controls.Add(this.label2);
            this.gbxcliente.Controls.Add(this.txtDirec11);
            this.gbxcliente.Controls.Add(this.txtNom11);
            this.gbxcliente.Controls.Add(this.label4);
            this.gbxcliente.Controls.Add(this.label3);
            this.gbxcliente.Controls.Add(this.txtTelf11);
            this.gbxcliente.Location = new System.Drawing.Point(34, 31);
            this.gbxcliente.Name = "gbxcliente";
            this.gbxcliente.Size = new System.Drawing.Size(358, 398);
            this.gbxcliente.TabIndex = 19;
            this.gbxcliente.TabStop = false;
            this.gbxcliente.Text = "Registro de Cliente";
            // 
            // btnModificar11
            // 
            this.btnModificar11.Location = new System.Drawing.Point(171, 297);
            this.btnModificar11.Name = "btnModificar11";
            this.btnModificar11.Size = new System.Drawing.Size(75, 23);
            this.btnModificar11.TabIndex = 11;
            this.btnModificar11.Text = "Modificar";
            this.btnModificar11.UseVisualStyleBackColor = true;
            this.btnModificar11.Click += new System.EventHandler(this.btnModificar11_Click);
            // 
            // btnguarda11
            // 
            this.btnguarda11.Location = new System.Drawing.Point(65, 297);
            this.btnguarda11.Name = "btnguarda11";
            this.btnguarda11.Size = new System.Drawing.Size(75, 23);
            this.btnguarda11.TabIndex = 0;
            this.btnguarda11.Text = "Registrar";
            this.btnguarda11.UseVisualStyleBackColor = true;
            this.btnguarda11.Click += new System.EventHandler(this.btnguarda11_Click);
            // 
            // txtFecha11
            // 
            this.txtFecha11.Location = new System.Drawing.Point(148, 223);
            this.txtFecha11.Name = "txtFecha11";
            this.txtFecha11.Size = new System.Drawing.Size(204, 20);
            this.txtFecha11.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre y Apellidos";
            // 
            // txtDirec11
            // 
            this.txtDirec11.Location = new System.Drawing.Point(148, 186);
            this.txtDirec11.Name = "txtDirec11";
            this.txtDirec11.Size = new System.Drawing.Size(204, 20);
            this.txtDirec11.TabIndex = 8;
            this.txtDirec11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirec11_KeyPress);
            // 
            // txtNom11
            // 
            this.txtNom11.Location = new System.Drawing.Point(148, 73);
            this.txtNom11.Name = "txtNom11";
            this.txtNom11.Size = new System.Drawing.Size(204, 20);
            this.txtNom11.TabIndex = 4;
            this.txtNom11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom11_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // txtTelf11
            // 
            this.txtTelf11.Location = new System.Drawing.Point(148, 147);
            this.txtTelf11.Name = "txtTelf11";
            this.txtTelf11.Size = new System.Drawing.Size(204, 20);
            this.txtTelf11.TabIndex = 6;
            this.txtTelf11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelf11_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Documento";
            // 
            // txtDoc11
            // 
            this.txtDoc11.Location = new System.Drawing.Point(148, 111);
            this.txtDoc11.Name = "txtDoc11";
            this.txtDoc11.Size = new System.Drawing.Size(204, 20);
            this.txtDoc11.TabIndex = 13;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.btnEliminar11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDocumento11);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.gbxcliente);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbxcliente.ResumeLayout(false);
            this.gbxcliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button btnEliminar11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocumento11;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox gbxcliente;
        private System.Windows.Forms.Button btnModificar11;
        private System.Windows.Forms.Button btnguarda11;
        private System.Windows.Forms.TextBox txtFecha11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirec11;
        private System.Windows.Forms.TextBox txtNom11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelf11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoc11;
    }
}
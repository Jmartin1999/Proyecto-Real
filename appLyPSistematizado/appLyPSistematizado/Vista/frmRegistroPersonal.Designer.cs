namespace appLyPSistematizado.Vista
{
    partial class frmRegistroPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroPersonal));
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.btnListarPersonal = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmbRol.Location = new System.Drawing.Point(114, 281);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(147, 21);
            this.cmbRol.TabIndex = 39;
            this.cmbRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRol_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Rol";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(161, 168);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 35;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(161, 128);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 33;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Direccion";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(161, 92);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 31;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre y Apellido";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(161, 51);
            this.txtDocumento.MaxLength = 15;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 29;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Documento";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(161, 238);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 27;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(161, 205);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 26;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(49, 386);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(138, 52);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Correo Electronico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Registro Personal";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(308, 386);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(156, 52);
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(610, 386);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 52);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(328, 48);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.Size = new System.Drawing.Size(413, 265);
            this.dgvPersonal.TabIndex = 42;
            // 
            // btnListarPersonal
            // 
            this.btnListarPersonal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPersonal.Location = new System.Drawing.Point(428, 319);
            this.btnListarPersonal.Name = "btnListarPersonal";
            this.btnListarPersonal.Size = new System.Drawing.Size(197, 38);
            this.btnListarPersonal.TabIndex = 43;
            this.btnListarPersonal.Text = "Listar Personal";
            this.btnListarPersonal.UseVisualStyleBackColor = true;
            this.btnListarPersonal.Click += new System.EventHandler(this.btnListarPersonal_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-271, -78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1342, 606);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // frmRegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarPersonal);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmRegistroPersonal";
            this.Text = "frmRegistroPersonal";
            this.Load += new System.EventHandler(this.frmRegistroPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnListarPersonal;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
namespace appLyPSistematizado
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.chkContraseña = new System.Windows.Forms.CheckBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lnlContraseña = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Electronico ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(381, 185);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(381, 239);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(116, 22);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "BIENVENIDOS";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(357, 401);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(131, 29);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar Sesion ";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // chkContraseña
            // 
            this.chkContraseña.AutoSize = true;
            this.chkContraseña.Location = new System.Drawing.Point(514, 241);
            this.chkContraseña.Name = "chkContraseña";
            this.chkContraseña.Size = new System.Drawing.Size(107, 19);
            this.chkContraseña.TabIndex = 8;
            this.chkContraseña.Text = "Ver Contraseña";
            this.chkContraseña.UseVisualStyleBackColor = true;
            this.chkContraseña.CheckedChanged += new System.EventHandler(this.chkContraseña_CheckedChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Jefe"});
            this.cmbRol.Location = new System.Drawing.Point(381, 295);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 23);
            this.cmbRol.TabIndex = 9;
            this.cmbRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRol_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rol";
            // 
            // lnlContraseña
            // 
            this.lnlContraseña.AutoSize = true;
            this.lnlContraseña.Location = new System.Drawing.Point(354, 356);
            this.lnlContraseña.Name = "lnlContraseña";
            this.lnlContraseña.Size = new System.Drawing.Size(130, 15);
            this.lnlContraseña.TabIndex = 12;
            this.lnlContraseña.TabStop = true;
            this.lnlContraseña.Text = "Olvido Su Contraseña?";
            this.lnlContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlContraseña_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 520);
            this.Controls.Add(this.lnlContraseña);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.chkContraseña);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.CheckBox chkContraseña;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnlContraseña;
    }
}


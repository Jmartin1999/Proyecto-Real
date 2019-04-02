namespace appLyPSistematizado.Vista
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbProceso = new System.Windows.Forms.PictureBox();
            this.pbRegistro = new System.Windows.Forms.PictureBox();
            this.pbTipo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo";
            // 
            // pbProceso
            // 
            this.pbProceso.Image = ((System.Drawing.Image)(resources.GetObject("pbProceso.Image")));
            this.pbProceso.Location = new System.Drawing.Point(43, 168);
            this.pbProceso.Name = "pbProceso";
            this.pbProceso.Size = new System.Drawing.Size(207, 158);
            this.pbProceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProceso.TabIndex = 2;
            this.pbProceso.TabStop = false;
            this.pbProceso.Click += new System.EventHandler(this.pbProceso_Click);
            // 
            // pbRegistro
            // 
            this.pbRegistro.Image = ((System.Drawing.Image)(resources.GetObject("pbRegistro.Image")));
            this.pbRegistro.Location = new System.Drawing.Point(293, 339);
            this.pbRegistro.Name = "pbRegistro";
            this.pbRegistro.Size = new System.Drawing.Size(206, 145);
            this.pbRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegistro.TabIndex = 3;
            this.pbRegistro.TabStop = false;
            this.pbRegistro.Click += new System.EventHandler(this.pbRegistro_Click);
            // 
            // pbTipo
            // 
            this.pbTipo.Image = ((System.Drawing.Image)(resources.GetObject("pbTipo.Image")));
            this.pbTipo.Location = new System.Drawing.Point(525, 154);
            this.pbTipo.Name = "pbTipo";
            this.pbTipo.Size = new System.Drawing.Size(187, 158);
            this.pbTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTipo.TabIndex = 4;
            this.pbTipo.TabStop = false;
            this.pbTipo.Click += new System.EventHandler(this.pbTipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proceso Vehicular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Registro Personal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipos y Tarifas Vehiculares";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbTipo);
            this.Controls.Add(this.pbRegistro);
            this.Controls.Add(this.pbProceso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbProceso;
        private System.Windows.Forms.PictureBox pbRegistro;
        private System.Windows.Forms.PictureBox pbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
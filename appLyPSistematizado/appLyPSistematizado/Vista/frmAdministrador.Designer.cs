namespace appLyPSistematizado.Vista
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.pbMensualidad = new System.Windows.Forms.PictureBox();
            this.pbLavado = new System.Windows.Forms.PictureBox();
            this.pbProceso = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLavado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMensualidad
            // 
            this.pbMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("pbMensualidad.Image")));
            this.pbMensualidad.Location = new System.Drawing.Point(596, 150);
            this.pbMensualidad.Name = "pbMensualidad";
            this.pbMensualidad.Size = new System.Drawing.Size(176, 138);
            this.pbMensualidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensualidad.TabIndex = 13;
            this.pbMensualidad.TabStop = false;
            this.pbMensualidad.Click += new System.EventHandler(this.pbMensualidad_Click);
            // 
            // pbLavado
            // 
            this.pbLavado.Image = ((System.Drawing.Image)(resources.GetObject("pbLavado.Image")));
            this.pbLavado.Location = new System.Drawing.Point(308, 150);
            this.pbLavado.Name = "pbLavado";
            this.pbLavado.Size = new System.Drawing.Size(176, 138);
            this.pbLavado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLavado.TabIndex = 12;
            this.pbLavado.TabStop = false;
            // 
            // pbProceso
            // 
            this.pbProceso.Image = ((System.Drawing.Image)(resources.GetObject("pbProceso.Image")));
            this.pbProceso.Location = new System.Drawing.Point(36, 150);
            this.pbProceso.Name = "pbProceso";
            this.pbProceso.Size = new System.Drawing.Size(176, 138);
            this.pbProceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProceso.TabIndex = 11;
            this.pbProceso.TabStop = false;
            this.pbProceso.Click += new System.EventHandler(this.pbProceso_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-271, -78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1342, 606);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "MENSUALIDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "LAVADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "PARQUEO";
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbMensualidad);
            this.Controls.Add(this.pbLavado);
            this.Controls.Add(this.pbProceso);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.pbMensualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLavado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMensualidad;
        private System.Windows.Forms.PictureBox pbLavado;
        private System.Windows.Forms.PictureBox pbProceso;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}
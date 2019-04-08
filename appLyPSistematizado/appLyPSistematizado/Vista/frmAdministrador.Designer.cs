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
            ((System.ComponentModel.ISupportInitialize)(this.pbMensualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLavado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).BeginInit();
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
            // 
            // pbLavado
            // 
            this.pbLavado.Image = ((System.Drawing.Image)(resources.GetObject("pbLavado.Image")));
            this.pbLavado.Location = new System.Drawing.Point(316, 150);
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
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMensualidad);
            this.Controls.Add(this.pbLavado);
            this.Controls.Add(this.pbProceso);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.pbMensualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLavado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMensualidad;
        private System.Windows.Forms.PictureBox pbLavado;
        private System.Windows.Forms.PictureBox pbProceso;
    }
}
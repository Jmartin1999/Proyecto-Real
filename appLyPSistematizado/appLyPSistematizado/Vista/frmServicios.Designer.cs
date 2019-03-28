namespace appLyPSistematizado.Vista
{
    partial class frmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicios));
            this.pbParqueo = new System.Windows.Forms.PictureBox();
            this.pbLavado = new System.Windows.Forms.PictureBox();
            this.pbMensualidad = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbParqueo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLavado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensualidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pbParqueo
            // 
            this.pbParqueo.Image = ((System.Drawing.Image)(resources.GetObject("pbParqueo.Image")));
            this.pbParqueo.Location = new System.Drawing.Point(29, 135);
            this.pbParqueo.Name = "pbParqueo";
            this.pbParqueo.Size = new System.Drawing.Size(171, 127);
            this.pbParqueo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbParqueo.TabIndex = 0;
            this.pbParqueo.TabStop = false;
            this.pbParqueo.Click += new System.EventHandler(this.pbParqueo_Click);
            // 
            // pbLavado
            // 
            this.pbLavado.Image = ((System.Drawing.Image)(resources.GetObject("pbLavado.Image")));
            this.pbLavado.Location = new System.Drawing.Point(279, 135);
            this.pbLavado.Name = "pbLavado";
            this.pbLavado.Size = new System.Drawing.Size(193, 128);
            this.pbLavado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLavado.TabIndex = 1;
            this.pbLavado.TabStop = false;
            this.pbLavado.Click += new System.EventHandler(this.pbLavado_Click);
            // 
            // pbMensualidad
            // 
            this.pbMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("pbMensualidad.Image")));
            this.pbMensualidad.Location = new System.Drawing.Point(558, 135);
            this.pbMensualidad.Name = "pbMensualidad";
            this.pbMensualidad.Size = new System.Drawing.Size(188, 133);
            this.pbMensualidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensualidad.TabIndex = 2;
            this.pbMensualidad.TabStop = false;
            this.pbMensualidad.Click += new System.EventHandler(this.pbMensualidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servicios ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parqueo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lavado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensualidad";
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMensualidad);
            this.Controls.Add(this.pbLavado);
            this.Controls.Add(this.pbParqueo);
            this.Name = "frmServicios";
            this.Text = "SERVICIOS";
            ((System.ComponentModel.ISupportInitialize)(this.pbParqueo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLavado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensualidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbParqueo;
        private System.Windows.Forms.PictureBox pbLavado;
        private System.Windows.Forms.PictureBox pbMensualidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
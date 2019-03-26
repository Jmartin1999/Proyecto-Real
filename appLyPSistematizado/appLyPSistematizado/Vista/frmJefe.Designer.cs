namespace appLyPSistematizado.Vista
{
    partial class frmJefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJefe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbProceso = new System.Windows.Forms.PictureBox();
            this.pbRegistro = new System.Windows.Forms.PictureBox();
            this.pbTipo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // frmJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbTipo);
            this.Controls.Add(this.pbRegistro);
            this.Controls.Add(this.pbProceso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJefe";
            this.Text = "frmJefe";
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
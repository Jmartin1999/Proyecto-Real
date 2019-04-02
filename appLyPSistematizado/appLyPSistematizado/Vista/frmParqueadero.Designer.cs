namespace appLyPSistematizado.Vista
{
    partial class frmParqueadero
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbt = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPlaca2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvAutomovil = new System.Windows.Forms.DataGridView();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.chbsalida = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEntrada22 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalida22 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTarifaParqueo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTiempotrans = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomovil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(681, 401);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 32);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(204, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 30);
            this.textBox1.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cupo";
            // 
            // cmbt
            // 
            this.cmbt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbt.FormattingEnabled = true;
            this.cmbt.Items.AddRange(new object[] {
            "CARRO",
            "MOTO ",
            "BICICLETA",
            "OTROS"});
            this.cmbt.Location = new System.Drawing.Point(205, 157);
            this.cmbt.Name = "cmbt";
            this.cmbt.Size = new System.Drawing.Size(278, 31);
            this.cmbt.TabIndex = 45;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(478, 403);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 30);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtPlaca2
            // 
            this.txtPlaca2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca2.Location = new System.Drawing.Point(23, 23);
            this.txtPlaca2.Name = "txtPlaca2";
            this.txtPlaca2.Size = new System.Drawing.Size(161, 30);
            this.txtPlaca2.TabIndex = 42;
            this.txtPlaca2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Digite la placa";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(323, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 32);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvAutomovil
            // 
            this.dgvAutomovil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomovil.Location = new System.Drawing.Point(234, 475);
            this.dgvAutomovil.Name = "dgvAutomovil";
            this.dgvAutomovil.Size = new System.Drawing.Size(728, 150);
            this.dgvAutomovil.TabIndex = 39;
            this.dgvAutomovil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutomovil_CellContentClick);
            this.dgvAutomovil.DoubleClick += new System.EventHandler(this.dgvAutomovil_DoubleClick);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(205, 282);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(278, 79);
            this.txtObservaciones.TabIndex = 38;
            this.txtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservaciones_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(205, 200);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(278, 30);
            this.txtMarca.TabIndex = 37;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(205, 116);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(278, 30);
            this.txtPlaca.TabIndex = 36;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Placa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tipo";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(254, 403);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(104, 31);
            this.btnRegistro.TabIndex = 28;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "Tipo De Servicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "10";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "BUENO",
            "MALO"});
            this.cmbEstado.Location = new System.Drawing.Point(205, 239);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(278, 31);
            this.cmbEstado.TabIndex = 51;
            // 
            // chbsalida
            // 
            this.chbsalida.AutoSize = true;
            this.chbsalida.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbsalida.Location = new System.Drawing.Point(791, 64);
            this.chbsalida.Name = "chbsalida";
            this.chbsalida.Size = new System.Drawing.Size(15, 14);
            this.chbsalida.TabIndex = 56;
            this.chbsalida.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(614, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 23);
            this.label11.TabIndex = 52;
            this.label11.Text = "Fecha-Hora de entrada";
            // 
            // txtEntrada22
            // 
            this.txtEntrada22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada22.Location = new System.Drawing.Point(809, 16);
            this.txtEntrada22.Name = "txtEntrada22";
            this.txtEntrada22.Size = new System.Drawing.Size(204, 30);
            this.txtEntrada22.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(617, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 23);
            this.label12.TabIndex = 54;
            this.label12.Text = "Fecha-Hora de Salida";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtSalida22
            // 
            this.txtSalida22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida22.Location = new System.Drawing.Point(812, 52);
            this.txtSalida22.Name = "txtSalida22";
            this.txtSalida22.Size = new System.Drawing.Size(201, 30);
            this.txtSalida22.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.chbsalida);
            this.groupBox1.Controls.Add(this.txtPlaca2);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEntrada22);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRegistro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSalida22);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmbt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(50, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 440);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTarifaParqueo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTiempotrans);
            this.groupBox2.Location = new System.Drawing.Point(652, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 177);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(78, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 23);
            this.label14.TabIndex = 60;
            this.label14.Text = "Tarida por hora";
            // 
            // txtTarifaParqueo
            // 
            this.txtTarifaParqueo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifaParqueo.Location = new System.Drawing.Point(59, 118);
            this.txtTarifaParqueo.Name = "txtTarifaParqueo";
            this.txtTarifaParqueo.Size = new System.Drawing.Size(204, 30);
            this.txtTarifaParqueo.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(78, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 23);
            this.label13.TabIndex = 58;
            this.label13.Text = "Tiempo transcurido";
            // 
            // txtTiempotrans
            // 
            this.txtTiempotrans.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempotrans.Location = new System.Drawing.Point(59, 49);
            this.txtTiempotrans.Name = "txtTiempotrans";
            this.txtTiempotrans.Size = new System.Drawing.Size(204, 30);
            this.txtTiempotrans.TabIndex = 59;
            // 
            // frmParqueadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAutomovil);
            this.Name = "frmParqueadero";
            this.Text = "Parqueo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomovil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbt;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtPlaca2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvAutomovil;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox chbsalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEntrada22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSalida22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTarifaParqueo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTiempotrans;
    }
}
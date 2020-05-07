namespace VentaDeRevistasMontecarlo
{
    partial class f_ventaDeRevistas
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
            this.gb_opciones = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_limSup = new System.Windows.Forms.MaskedTextBox();
            this.txt_limInf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cant_sim = new System.Windows.Forms.MaskedTextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.grid_simulacion = new System.Windows.Forms.DataGridView();
            this.gb_opciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_simulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_opciones
            // 
            this.gb_opciones.BackColor = System.Drawing.Color.RoyalBlue;
            this.gb_opciones.Controls.Add(this.groupBox2);
            this.gb_opciones.Controls.Add(this.groupBox1);
            this.gb_opciones.Controls.Add(this.btn_generar);
            this.gb_opciones.Location = new System.Drawing.Point(2, 1);
            this.gb_opciones.Name = "gb_opciones";
            this.gb_opciones.Size = new System.Drawing.Size(1183, 155);
            this.gb_opciones.TabIndex = 0;
            this.gb_opciones.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_limSup);
            this.groupBox2.Controls.Add(this.txt_limInf);
            this.groupBox2.Location = new System.Drawing.Point(158, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limites a mostrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lim Superior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lim Inferior";
            // 
            // txt_limSup
            // 
            this.txt_limSup.Location = new System.Drawing.Point(88, 67);
            this.txt_limSup.Mask = "999999";
            this.txt_limSup.Name = "txt_limSup";
            this.txt_limSup.Size = new System.Drawing.Size(100, 20);
            this.txt_limSup.TabIndex = 1;
            this.txt_limSup.ValidatingType = typeof(int);
            // 
            // txt_limInf
            // 
            this.txt_limInf.Location = new System.Drawing.Point(88, 30);
            this.txt_limInf.Mask = "999999";
            this.txt_limInf.Name = "txt_limInf";
            this.txt_limInf.Size = new System.Drawing.Size(100, 20);
            this.txt_limInf.TabIndex = 0;
            this.txt_limInf.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cant_sim);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de visitas a simular";
            // 
            // txt_cant_sim
            // 
            this.txt_cant_sim.Location = new System.Drawing.Point(15, 33);
            this.txt_cant_sim.Name = "txt_cant_sim";
            this.txt_cant_sim.Size = new System.Drawing.Size(107, 20);
            this.txt_cant_sim.TabIndex = 1;
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(394, 19);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(104, 51);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // grid_simulacion
            // 
            this.grid_simulacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grid_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_simulacion.Location = new System.Drawing.Point(2, 191);
            this.grid_simulacion.Name = "grid_simulacion";
            this.grid_simulacion.Size = new System.Drawing.Size(1183, 281);
            this.grid_simulacion.TabIndex = 1;
            // 
            // f_ventaDeRevistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1183, 512);
            this.Controls.Add(this.grid_simulacion);
            this.Controls.Add(this.gb_opciones);
            this.Name = "f_ventaDeRevistas";
            this.Text = "Venta de revistas";
            this.Load += new System.EventHandler(this.F_ventaDeRevistas_Load);
            this.gb_opciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_simulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_opciones;
        private System.Windows.Forms.DataGridView grid_simulacion;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_cant_sim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_limSup;
        private System.Windows.Forms.MaskedTextBox txt_limInf;
    }
}


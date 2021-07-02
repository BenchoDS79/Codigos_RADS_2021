namespace RubenDuron
{
    partial class FORMULARIO2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Producto = new System.Windows.Forms.TextBox();
            this.textBox2Cantidad = new System.Windows.Forms.TextBox();
            this.textBox3Precio = new System.Windows.Forms.TextBox();
            this.button1Agregar = new System.Windows.Forms.Button();
            this.button2Calcular = new System.Windows.Forms.Button();
            this.button3Limpiar = new System.Windows.Forms.Button();
            this.button4Salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4Total = new System.Windows.Forms.TextBox();
            this.textBox5Descuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6TotalP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(15, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "cantidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "CALCULO DE DESCUENTO SOBRE COMPRA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Precio";
            // 
            // textBox1Producto
            // 
            this.textBox1Producto.Location = new System.Drawing.Point(96, 42);
            this.textBox1Producto.Name = "textBox1Producto";
            this.textBox1Producto.Size = new System.Drawing.Size(167, 20);
            this.textBox1Producto.TabIndex = 18;
            // 
            // textBox2Cantidad
            // 
            this.textBox2Cantidad.Location = new System.Drawing.Point(96, 67);
            this.textBox2Cantidad.Name = "textBox2Cantidad";
            this.textBox2Cantidad.Size = new System.Drawing.Size(100, 20);
            this.textBox2Cantidad.TabIndex = 19;
            // 
            // textBox3Precio
            // 
            this.textBox3Precio.Location = new System.Drawing.Point(96, 91);
            this.textBox3Precio.Name = "textBox3Precio";
            this.textBox3Precio.Size = new System.Drawing.Size(100, 20);
            this.textBox3Precio.TabIndex = 20;
            // 
            // button1Agregar
            // 
            this.button1Agregar.Location = new System.Drawing.Point(287, 42);
            this.button1Agregar.Name = "button1Agregar";
            this.button1Agregar.Size = new System.Drawing.Size(117, 23);
            this.button1Agregar.TabIndex = 21;
            this.button1Agregar.Text = "Agregar Producto";
            this.button1Agregar.UseVisualStyleBackColor = true;
            this.button1Agregar.Click += new System.EventHandler(this.button1Agregar_Click);
            // 
            // button2Calcular
            // 
            this.button2Calcular.Location = new System.Drawing.Point(287, 75);
            this.button2Calcular.Name = "button2Calcular";
            this.button2Calcular.Size = new System.Drawing.Size(117, 23);
            this.button2Calcular.TabIndex = 22;
            this.button2Calcular.Text = "Calcular Descuento";
            this.button2Calcular.UseVisualStyleBackColor = true;
            this.button2Calcular.Click += new System.EventHandler(this.button2Calcular_Click);
            // 
            // button3Limpiar
            // 
            this.button3Limpiar.Location = new System.Drawing.Point(380, 272);
            this.button3Limpiar.Name = "button3Limpiar";
            this.button3Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button3Limpiar.TabIndex = 23;
            this.button3Limpiar.Text = "Limpiar";
            this.button3Limpiar.UseVisualStyleBackColor = true;
            this.button3Limpiar.Click += new System.EventHandler(this.button3Limpiar_Click);
            // 
            // button4Salir
            // 
            this.button4Salir.Location = new System.Drawing.Point(378, 302);
            this.button4Salir.Name = "button4Salir";
            this.button4Salir.Size = new System.Drawing.Size(75, 23);
            this.button4Salir.TabIndex = 24;
            this.button4Salir.Text = "Salir";
            this.button4Salir.UseVisualStyleBackColor = true;
            this.button4Salir.Click += new System.EventHandler(this.button4Salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Compra Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Descuento ";
            // 
            // textBox4Total
            // 
            this.textBox4Total.Enabled = false;
            this.textBox4Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4Total.Location = new System.Drawing.Point(20, 298);
            this.textBox4Total.Name = "textBox4Total";
            this.textBox4Total.Size = new System.Drawing.Size(100, 27);
            this.textBox4Total.TabIndex = 27;
            this.textBox4Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5Descuento
            // 
            this.textBox5Descuento.Enabled = false;
            this.textBox5Descuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5Descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox5Descuento.Location = new System.Drawing.Point(139, 298);
            this.textBox5Descuento.Name = "textBox5Descuento";
            this.textBox5Descuento.Size = new System.Drawing.Size(100, 27);
            this.textBox5Descuento.TabIndex = 28;
            this.textBox5Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total a Pagar";
            // 
            // textBox6TotalP
            // 
            this.textBox6TotalP.Enabled = false;
            this.textBox6TotalP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6TotalP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox6TotalP.Location = new System.Drawing.Point(258, 298);
            this.textBox6TotalP.Name = "textBox6TotalP";
            this.textBox6TotalP.Size = new System.Drawing.Size(100, 27);
            this.textBox6TotalP.TabIndex = 30;
            this.textBox6TotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FORMULARIO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 339);
            this.Controls.Add(this.textBox6TotalP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5Descuento);
            this.Controls.Add(this.textBox4Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4Salir);
            this.Controls.Add(this.button3Limpiar);
            this.Controls.Add(this.button2Calcular);
            this.Controls.Add(this.button1Agregar);
            this.Controls.Add(this.textBox3Precio);
            this.Controls.Add(this.textBox2Cantidad);
            this.Controls.Add(this.textBox1Producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FORMULARIO2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Producto;
        private System.Windows.Forms.TextBox textBox2Cantidad;
        private System.Windows.Forms.TextBox textBox3Precio;
        private System.Windows.Forms.Button button1Agregar;
        private System.Windows.Forms.Button button2Calcular;
        private System.Windows.Forms.Button button3Limpiar;
        private System.Windows.Forms.Button button4Salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4Total;
        private System.Windows.Forms.TextBox textBox5Descuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6TotalP;
    }
}
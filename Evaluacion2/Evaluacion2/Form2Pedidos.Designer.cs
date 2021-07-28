namespace Evaluacion2
{
    partial class Form2Pedidos
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
            this.button1Salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1Tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.textBox2Direccion = new System.Windows.Forms.TextBox();
            this.textBox3Medicamento = new System.Windows.Forms.TextBox();
            this.textBox4Cantidad = new System.Windows.Forms.TextBox();
            this.comboBox2Presentacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5Precio = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6Total = new System.Windows.Forms.TextBox();
            this.button2Confirmar = new System.Windows.Forms.Button();
            this.button3Otro = new System.Windows.Forms.Button();
            this.button4Nuevo = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Salir
            // 
            this.button1Salir.Location = new System.Drawing.Point(769, 379);
            this.button1Salir.Name = "button1Salir";
            this.button1Salir.Size = new System.Drawing.Size(75, 23);
            this.button1Salir.TabIndex = 0;
            this.button1Salir.Text = "SALIR";
            this.button1Salir.UseVisualStyleBackColor = true;
            this.button1Salir.Click += new System.EventHandler(this.button1Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(10, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 207);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox1Tipo
            // 
            this.comboBox1Tipo.FormattingEnabled = true;
            this.comboBox1Tipo.Items.AddRange(new object[] {
            "",
            "Analgésicos",
            "Antiácidos",
            "Antialérgicos",
            "Antidiarreicos",
            "Antibióticos",
            "Antifúngicos",
            "Antivirales",
            "Antiparasitarios",
            "Antiinflamatorios",
            "Antidepresivos",
            "Antipiréticos",
            "Antitusivos",
            "Laxantes",
            "Mucolíticos"});
            this.comboBox1Tipo.Location = new System.Drawing.Point(108, 88);
            this.comboBox1Tipo.Name = "comboBox1Tipo";
            this.comboBox1Tipo.Size = new System.Drawing.Size(125, 21);
            this.comboBox1Tipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Presentacion";
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Location = new System.Drawing.Point(122, 12);
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.Size = new System.Drawing.Size(180, 20);
            this.textBox1Nombre.TabIndex = 7;
            // 
            // textBox2Direccion
            // 
            this.textBox2Direccion.Location = new System.Drawing.Point(443, 15);
            this.textBox2Direccion.Name = "textBox2Direccion";
            this.textBox2Direccion.Size = new System.Drawing.Size(180, 20);
            this.textBox2Direccion.TabIndex = 8;
            // 
            // textBox3Medicamento
            // 
            this.textBox3Medicamento.Location = new System.Drawing.Point(108, 58);
            this.textBox3Medicamento.Name = "textBox3Medicamento";
            this.textBox3Medicamento.Size = new System.Drawing.Size(125, 20);
            this.textBox3Medicamento.TabIndex = 9;
            // 
            // textBox4Cantidad
            // 
            this.textBox4Cantidad.Location = new System.Drawing.Point(323, 58);
            this.textBox4Cantidad.Name = "textBox4Cantidad";
            this.textBox4Cantidad.Size = new System.Drawing.Size(125, 20);
            this.textBox4Cantidad.TabIndex = 10;
            // 
            // comboBox2Presentacion
            // 
            this.comboBox2Presentacion.FormattingEnabled = true;
            this.comboBox2Presentacion.Items.AddRange(new object[] {
            "",
            "Polvos",
            "Granulados",
            "Comprimidos",
            "Cápsulas",
            "Jarabes",
            "Suspensiones",
            "Emulsiones",
            "Inyectables"});
            this.comboBox2Presentacion.Location = new System.Drawing.Point(108, 115);
            this.comboBox2Presentacion.Name = "comboBox2Presentacion";
            this.comboBox2Presentacion.Size = new System.Drawing.Size(125, 21);
            this.comboBox2Presentacion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo Medicamento";
            // 
            // textBox5Precio
            // 
            this.textBox5Precio.Location = new System.Drawing.Point(323, 87);
            this.textBox5Precio.Name = "textBox5Precio";
            this.textBox5Precio.Size = new System.Drawing.Size(125, 20);
            this.textBox5Precio.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dirección";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Medicamento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Presentacion";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Precio";
            this.Column7.Name = "Column7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total a Pagar";
            // 
            // textBox6Total
            // 
            this.textBox6Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6Total.Location = new System.Drawing.Point(156, 380);
            this.textBox6Total.Name = "textBox6Total";
            this.textBox6Total.Size = new System.Drawing.Size(202, 22);
            this.textBox6Total.TabIndex = 17;
            // 
            // button2Confirmar
            // 
            this.button2Confirmar.Location = new System.Drawing.Point(707, 9);
            this.button2Confirmar.Name = "button2Confirmar";
            this.button2Confirmar.Size = new System.Drawing.Size(125, 23);
            this.button2Confirmar.TabIndex = 18;
            this.button2Confirmar.Text = "Confirmar";
            this.button2Confirmar.UseVisualStyleBackColor = true;
            this.button2Confirmar.Click += new System.EventHandler(this.button2Confirmar_Click);
            // 
            // button3Otro
            // 
            this.button3Otro.Location = new System.Drawing.Point(707, 55);
            this.button3Otro.Name = "button3Otro";
            this.button3Otro.Size = new System.Drawing.Size(125, 23);
            this.button3Otro.TabIndex = 19;
            this.button3Otro.Text = "Otro Pedido";
            this.button3Otro.UseVisualStyleBackColor = true;
            this.button3Otro.Click += new System.EventHandler(this.button3Otro_Click);
            // 
            // button4Nuevo
            // 
            this.button4Nuevo.Location = new System.Drawing.Point(707, 108);
            this.button4Nuevo.Name = "button4Nuevo";
            this.button4Nuevo.Size = new System.Drawing.Size(125, 23);
            this.button4Nuevo.TabIndex = 20;
            this.button4Nuevo.Text = "Nuevo Pedido";
            this.button4Nuevo.UseVisualStyleBackColor = true;
            this.button4Nuevo.Click += new System.EventHandler(this.button4Nuevo_Click);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            // 
            // Form2Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 420);
            this.ControlBox = false;
            this.Controls.Add(this.button4Nuevo);
            this.Controls.Add(this.button3Otro);
            this.Controls.Add(this.button2Confirmar);
            this.Controls.Add(this.textBox6Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5Precio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2Presentacion);
            this.Controls.Add(this.textBox4Cantidad);
            this.Controls.Add(this.textBox3Medicamento);
            this.Controls.Add(this.textBox2Direccion);
            this.Controls.Add(this.textBox1Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1Tipo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1Salir);
            this.Name = "Form2Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEDIDOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox comboBox1Tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1Nombre;
        private System.Windows.Forms.TextBox textBox2Direccion;
        private System.Windows.Forms.TextBox textBox3Medicamento;
        private System.Windows.Forms.TextBox textBox4Cantidad;
        private System.Windows.Forms.ComboBox comboBox2Presentacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5Precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6Total;
        private System.Windows.Forms.Button button2Confirmar;
        private System.Windows.Forms.Button button3Otro;
        private System.Windows.Forms.Button button4Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
namespace Evaluacion1
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.VentastextBox1 = new System.Windows.Forms.TextBox();
            this.AñostextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Verificarbutton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EdadtextBox4 = new System.Windows.Forms.TextBox();
            this.SalariotextBox3 = new System.Windows.Forms.TextBox();
            this.AvisotextBox5 = new System.Windows.Forms.TextBox();
            this.Limpiarbutton2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // VentastextBox1
            // 
            this.VentastextBox1.Location = new System.Drawing.Point(154, 82);
            this.VentastextBox1.Name = "VentastextBox1";
            this.VentastextBox1.Size = new System.Drawing.Size(100, 20);
            this.VentastextBox1.TabIndex = 1;
            // 
            // AñostextBox2
            // 
            this.AñostextBox2.Location = new System.Drawing.Point(154, 119);
            this.AñostextBox2.Name = "AñostextBox2";
            this.AñostextBox2.Size = new System.Drawing.Size(100, 20);
            this.AñostextBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Ventas Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Años de Antigüedad";
            // 
            // Verificarbutton1
            // 
            this.Verificarbutton1.Location = new System.Drawing.Point(278, 82);
            this.Verificarbutton1.Name = "Verificarbutton1";
            this.Verificarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Verificarbutton1.TabIndex = 6;
            this.Verificarbutton1.Text = "Verificar";
            this.Verificarbutton1.UseVisualStyleBackColor = true;
            this.Verificarbutton1.Click += new System.EventHandler(this.Verificarbutton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datos del Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvisotextBox5);
            this.groupBox1.Controls.Add(this.SalariotextBox3);
            this.groupBox1.Controls.Add(this.EdadtextBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(29, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nuevo Salario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EdadtextBox4
            // 
            this.EdadtextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.EdadtextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EdadtextBox4.Enabled = false;
            this.EdadtextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadtextBox4.Location = new System.Drawing.Point(69, 53);
            this.EdadtextBox4.Name = "EdadtextBox4";
            this.EdadtextBox4.Size = new System.Drawing.Size(42, 15);
            this.EdadtextBox4.TabIndex = 2;
            // 
            // SalariotextBox3
            // 
            this.SalariotextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.SalariotextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalariotextBox3.Enabled = false;
            this.SalariotextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalariotextBox3.Location = new System.Drawing.Point(134, 92);
            this.SalariotextBox3.Name = "SalariotextBox3";
            this.SalariotextBox3.Size = new System.Drawing.Size(100, 15);
            this.SalariotextBox3.TabIndex = 3;
            // 
            // AvisotextBox5
            // 
            this.AvisotextBox5.BackColor = System.Drawing.SystemColors.Control;
            this.AvisotextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AvisotextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisotextBox5.Location = new System.Drawing.Point(26, 16);
            this.AvisotextBox5.Name = "AvisotextBox5";
            this.AvisotextBox5.Size = new System.Drawing.Size(278, 15);
            this.AvisotextBox5.TabIndex = 4;
            // 
            // Limpiarbutton2
            // 
            this.Limpiarbutton2.Location = new System.Drawing.Point(278, 121);
            this.Limpiarbutton2.Name = "Limpiarbutton2";
            this.Limpiarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbutton2.TabIndex = 9;
            this.Limpiarbutton2.Text = "Limpiar";
            this.Limpiarbutton2.UseVisualStyleBackColor = true;
            this.Limpiarbutton2.Click += new System.EventHandler(this.Limpiarbutton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 289);
            this.Controls.Add(this.Limpiarbutton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Verificarbutton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AñostextBox2);
            this.Controls.Add(this.VentastextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox VentastextBox1;
        private System.Windows.Forms.TextBox AñostextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Verificarbutton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SalariotextBox3;
        private System.Windows.Forms.TextBox EdadtextBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AvisotextBox5;
        private System.Windows.Forms.Button Limpiarbutton2;
    }
}


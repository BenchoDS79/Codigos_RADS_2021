namespace Ejercicio4_CS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.textBox2Edad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1Lista = new System.Windows.Forms.ComboBox();
            this.button1Agregar = new System.Windows.Forms.Button();
            this.button2Asc = new System.Windows.Forms.Button();
            this.button3Des = new System.Windows.Forms.Button();
            this.button4Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Nombre.Location = new System.Drawing.Point(110, 49);
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.Size = new System.Drawing.Size(116, 22);
            this.textBox1Nombre.TabIndex = 2;
            // 
            // textBox2Edad
            // 
            this.textBox2Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Edad.Location = new System.Drawing.Point(110, 87);
            this.textBox2Edad.Name = "textBox2Edad";
            this.textBox2Edad.Size = new System.Drawing.Size(116, 22);
            this.textBox2Edad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese sus Datos";
            // 
            // comboBox1Lista
            // 
            this.comboBox1Lista.FormattingEnabled = true;
            this.comboBox1Lista.Location = new System.Drawing.Point(283, 49);
            this.comboBox1Lista.Name = "comboBox1Lista";
            this.comboBox1Lista.Size = new System.Drawing.Size(199, 21);
            this.comboBox1Lista.TabIndex = 5;
            // 
            // button1Agregar
            // 
            this.button1Agregar.Location = new System.Drawing.Point(22, 141);
            this.button1Agregar.Name = "button1Agregar";
            this.button1Agregar.Size = new System.Drawing.Size(88, 36);
            this.button1Agregar.TabIndex = 6;
            this.button1Agregar.Text = "AGREGAR";
            this.button1Agregar.UseVisualStyleBackColor = true;
            this.button1Agregar.Click += new System.EventHandler(this.button1Agregar_Click);
            // 
            // button2Asc
            // 
            this.button2Asc.Location = new System.Drawing.Point(283, 141);
            this.button2Asc.Name = "button2Asc";
            this.button2Asc.Size = new System.Drawing.Size(94, 36);
            this.button2Asc.TabIndex = 7;
            this.button2Asc.Text = "Orden Ascendente";
            this.button2Asc.UseVisualStyleBackColor = true;
            this.button2Asc.Click += new System.EventHandler(this.button2Asc_Click);
            // 
            // button3Des
            // 
            this.button3Des.Location = new System.Drawing.Point(388, 141);
            this.button3Des.Name = "button3Des";
            this.button3Des.Size = new System.Drawing.Size(94, 36);
            this.button3Des.TabIndex = 8;
            this.button3Des.Text = "Orden Descendente";
            this.button3Des.UseVisualStyleBackColor = true;
            // 
            // button4Limpiar
            // 
            this.button4Limpiar.Location = new System.Drawing.Point(132, 141);
            this.button4Limpiar.Name = "button4Limpiar";
            this.button4Limpiar.Size = new System.Drawing.Size(94, 36);
            this.button4Limpiar.TabIndex = 9;
            this.button4Limpiar.Text = "LIMPIAR";
            this.button4Limpiar.UseVisualStyleBackColor = true;
            this.button4Limpiar.Click += new System.EventHandler(this.button4Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 203);
            this.Controls.Add(this.button4Limpiar);
            this.Controls.Add(this.button3Des);
            this.Controls.Add(this.button2Asc);
            this.Controls.Add(this.button1Agregar);
            this.Controls.Add(this.comboBox1Lista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2Edad);
            this.Controls.Add(this.textBox1Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Nombre;
        private System.Windows.Forms.TextBox textBox2Edad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1Lista;
        private System.Windows.Forms.Button button1Agregar;
        private System.Windows.Forms.Button button2Asc;
        private System.Windows.Forms.Button button3Des;
        private System.Windows.Forms.Button button4Limpiar;
    }
}


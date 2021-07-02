namespace Ejercicio_1_CS
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
            this.Comprobarbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.Limpiarbutton1 = new System.Windows.Forms.Button();
            this.ResultadotextBox1 = new System.Windows.Forms.TextBox();
            this.NumeroPrimotextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Comprobarbutton1
            // 
            this.Comprobarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comprobarbutton1.Location = new System.Drawing.Point(20, 166);
            this.Comprobarbutton1.Name = "Comprobarbutton1";
            this.Comprobarbutton1.Size = new System.Drawing.Size(110, 30);
            this.Comprobarbutton1.TabIndex = 0;
            this.Comprobarbutton1.Text = "Comprobar";
            this.Comprobarbutton1.UseVisualStyleBackColor = true;
            this.Comprobarbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Determinar si el numero es Par, Impar y Primo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese un Numero Entero";
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Numero1textBox1.Location = new System.Drawing.Point(242, 76);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(110, 26);
            this.Numero1textBox1.TabIndex = 3;
            // 
            // Limpiarbutton1
            // 
            this.Limpiarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbutton1.Location = new System.Drawing.Point(234, 166);
            this.Limpiarbutton1.Name = "Limpiarbutton1";
            this.Limpiarbutton1.Size = new System.Drawing.Size(110, 30);
            this.Limpiarbutton1.TabIndex = 4;
            this.Limpiarbutton1.Text = "Limpiar";
            this.Limpiarbutton1.UseVisualStyleBackColor = true;
            this.Limpiarbutton1.Click += new System.EventHandler(this.Limpiarbutton1_Click);
            // 
            // ResultadotextBox1
            // 
            this.ResultadotextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultadotextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultadotextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadotextBox1.Location = new System.Drawing.Point(58, 117);
            this.ResultadotextBox1.Multiline = true;
            this.ResultadotextBox1.Name = "ResultadotextBox1";
            this.ResultadotextBox1.Size = new System.Drawing.Size(174, 33);
            this.ResultadotextBox1.TabIndex = 5;
            // 
            // NumeroPrimotextBox1
            // 
            this.NumeroPrimotextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NumeroPrimotextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumeroPrimotextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroPrimotextBox1.Location = new System.Drawing.Point(234, 117);
            this.NumeroPrimotextBox1.Multiline = true;
            this.NumeroPrimotextBox1.Name = "NumeroPrimotextBox1";
            this.NumeroPrimotextBox1.Size = new System.Drawing.Size(90, 33);
            this.NumeroPrimotextBox1.TabIndex = 6;
            this.NumeroPrimotextBox1.TextChanged += new System.EventHandler(this.NumeroPrimotextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 214);
            this.Controls.Add(this.NumeroPrimotextBox1);
            this.Controls.Add(this.ResultadotextBox1);
            this.Controls.Add(this.Limpiarbutton1);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comprobarbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comprobarbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.Button Limpiarbutton1;
        private System.Windows.Forms.TextBox ResultadotextBox1;
        private System.Windows.Forms.TextBox NumeroPrimotextBox1;
    }
}


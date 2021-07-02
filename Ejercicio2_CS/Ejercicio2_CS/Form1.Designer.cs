namespace Ejercicio2_CS
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
            this.VentatextBox1 = new System.Windows.Forms.TextBox();
            this.Calculobutton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BonotextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Limpiarbutton2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SumatextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta promedio del empleado";
            // 
            // VentatextBox1
            // 
            this.VentatextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentatextBox1.Location = new System.Drawing.Point(225, 49);
            this.VentatextBox1.Name = "VentatextBox1";
            this.VentatextBox1.Size = new System.Drawing.Size(100, 22);
            this.VentatextBox1.TabIndex = 1;
            // 
            // Calculobutton1
            // 
            this.Calculobutton1.Location = new System.Drawing.Point(359, 45);
            this.Calculobutton1.Name = "Calculobutton1";
            this.Calculobutton1.Size = new System.Drawing.Size(107, 30);
            this.Calculobutton1.TabIndex = 2;
            this.Calculobutton1.Text = "Calcular Bono";
            this.Calculobutton1.UseVisualStyleBackColor = true;
            this.Calculobutton1.Click += new System.EventHandler(this.Calculobutton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bono";
            // 
            // BonotextBox2
            // 
            this.BonotextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonotextBox2.Location = new System.Drawing.Point(225, 96);
            this.BonotextBox2.Name = "BonotextBox2";
            this.BonotextBox2.ReadOnly = true;
            this.BonotextBox2.Size = new System.Drawing.Size(100, 22);
            this.BonotextBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CALCULO DE BONO ";
            // 
            // Limpiarbutton2
            // 
            this.Limpiarbutton2.Location = new System.Drawing.Point(359, 99);
            this.Limpiarbutton2.Name = "Limpiarbutton2";
            this.Limpiarbutton2.Size = new System.Drawing.Size(107, 30);
            this.Limpiarbutton2.TabIndex = 6;
            this.Limpiarbutton2.Text = "Limpiar";
            this.Limpiarbutton2.UseVisualStyleBackColor = true;
            this.Limpiarbutton2.Click += new System.EventHandler(this.Limpiarbutton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Venta mas Bono";
            // 
            // SumatextBox3
            // 
            this.SumatextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumatextBox3.Location = new System.Drawing.Point(225, 147);
            this.SumatextBox3.Name = "SumatextBox3";
            this.SumatextBox3.ReadOnly = true;
            this.SumatextBox3.Size = new System.Drawing.Size(100, 22);
            this.SumatextBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 193);
            this.Controls.Add(this.SumatextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Limpiarbutton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BonotextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calculobutton1);
            this.Controls.Add(this.VentatextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VentatextBox1;
        private System.Windows.Forms.Button Calculobutton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BonotextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Limpiarbutton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SumatextBox3;
    }
}


namespace RubenDuron
{
    partial class FORMULARIO1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1Capital = new System.Windows.Forms.TextBox();
            this.textBox2Tasa = new System.Windows.Forms.TextBox();
            this.textBox3Periodos = new System.Windows.Forms.TextBox();
            this.textBox4Intereses = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Salir
            // 
            this.button1Salir.Location = new System.Drawing.Point(420, 296);
            this.button1Salir.Name = "button1Salir";
            this.button1Salir.Size = new System.Drawing.Size(76, 25);
            this.button1Salir.TabIndex = 0;
            this.button1Salir.Text = "SALIR";
            this.button1Salir.UseVisualStyleBackColor = true;
            this.button1Salir.Click += new System.EventHandler(this.button1Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Periodos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Intereses Ganados";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(317, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(179, 228);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1Capital
            // 
            this.textBox1Capital.Location = new System.Drawing.Point(97, 64);
            this.textBox1Capital.Name = "textBox1Capital";
            this.textBox1Capital.Size = new System.Drawing.Size(100, 20);
            this.textBox1Capital.TabIndex = 7;
            // 
            // textBox2Tasa
            // 
            this.textBox2Tasa.Enabled = false;
            this.textBox2Tasa.Location = new System.Drawing.Point(97, 109);
            this.textBox2Tasa.Name = "textBox2Tasa";
            this.textBox2Tasa.Size = new System.Drawing.Size(100, 20);
            this.textBox2Tasa.TabIndex = 8;
            this.textBox2Tasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3Periodos
            // 
            this.textBox3Periodos.Location = new System.Drawing.Point(97, 154);
            this.textBox3Periodos.Name = "textBox3Periodos";
            this.textBox3Periodos.Size = new System.Drawing.Size(100, 20);
            this.textBox3Periodos.TabIndex = 9;
            // 
            // textBox4Intereses
            // 
            this.textBox4Intereses.Location = new System.Drawing.Point(175, 258);
            this.textBox4Intereses.Name = "textBox4Intereses";
            this.textBox4Intereses.Size = new System.Drawing.Size(100, 20);
            this.textBox4Intereses.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "CALCULO DE INTERES MENSUAL";
            // 
            // FORMULARIO1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 333);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4Intereses);
            this.Controls.Add(this.textBox3Periodos);
            this.Controls.Add(this.textBox2Tasa);
            this.Controls.Add(this.textBox1Capital);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Salir);
            this.Name = "FORMULARIO1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1Capital;
        private System.Windows.Forms.TextBox textBox2Tasa;
        private System.Windows.Forms.TextBox textBox3Periodos;
        private System.Windows.Forms.TextBox textBox4Intereses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}
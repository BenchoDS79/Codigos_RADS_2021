namespace Evaluacion2
{
    partial class Form1Ingreso
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
            this.label3 = new System.Windows.Forms.Label();
            this.UsuariotextBox1 = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox2 = new System.Windows.Forms.TextBox();
            this.Ingresarbutton1 = new System.Windows.Forms.Button();
            this.Salirbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(60, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña";
            // 
            // UsuariotextBox1
            // 
            this.UsuariotextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.UsuariotextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariotextBox1.Location = new System.Drawing.Point(27, 19);
            this.UsuariotextBox1.Name = "UsuariotextBox1";
            this.UsuariotextBox1.Size = new System.Drawing.Size(159, 26);
            this.UsuariotextBox1.TabIndex = 2;
            // 
            // ContraseñatextBox2
            // 
            this.ContraseñatextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.ContraseñatextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñatextBox2.Location = new System.Drawing.Point(27, 82);
            this.ContraseñatextBox2.Name = "ContraseñatextBox2";
            this.ContraseñatextBox2.Size = new System.Drawing.Size(159, 26);
            this.ContraseñatextBox2.TabIndex = 3;
            // 
            // Ingresarbutton1
            // 
            this.Ingresarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresarbutton1.Location = new System.Drawing.Point(12, 161);
            this.Ingresarbutton1.Name = "Ingresarbutton1";
            this.Ingresarbutton1.Size = new System.Drawing.Size(81, 28);
            this.Ingresarbutton1.TabIndex = 4;
            this.Ingresarbutton1.Text = "Ingresar";
            this.Ingresarbutton1.UseVisualStyleBackColor = true;
            this.Ingresarbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salirbutton2
            // 
            this.Salirbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton2.Location = new System.Drawing.Point(119, 161);
            this.Salirbutton2.Name = "Salirbutton2";
            this.Salirbutton2.Size = new System.Drawing.Size(81, 28);
            this.Salirbutton2.TabIndex = 5;
            this.Salirbutton2.Text = "Salir";
            this.Salirbutton2.UseVisualStyleBackColor = true;
            this.Salirbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(216, 214);
            this.ControlBox = false;
            this.Controls.Add(this.Salirbutton2);
            this.Controls.Add(this.Ingresarbutton1);
            this.Controls.Add(this.ContraseñatextBox2);
            this.Controls.Add(this.UsuariotextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1Ingreso_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuariotextBox1;
        private System.Windows.Forms.TextBox ContraseñatextBox2;
        private System.Windows.Forms.Button Ingresarbutton1;
        private System.Windows.Forms.Button Salirbutton2;
    }
}
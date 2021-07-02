namespace RubenDuron
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
            this.button1Salir = new System.Windows.Forms.Button();
            this.label1F1 = new System.Windows.Forms.Label();
            this.label2F2 = new System.Windows.Forms.Label();
            this.label3F3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Salir
            // 
            this.button1Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Salir.Location = new System.Drawing.Point(82, 203);
            this.button1Salir.Name = "button1Salir";
            this.button1Salir.Size = new System.Drawing.Size(96, 34);
            this.button1Salir.TabIndex = 0;
            this.button1Salir.Text = "SALIR";
            this.button1Salir.UseVisualStyleBackColor = true;
            this.button1Salir.Click += new System.EventHandler(this.button1Salir_Click);
            // 
            // label1F1
            // 
            this.label1F1.AutoSize = true;
            this.label1F1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1F1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1F1.Location = new System.Drawing.Point(62, 45);
            this.label1F1.Name = "label1F1";
            this.label1F1.Size = new System.Drawing.Size(142, 20);
            this.label1F1.TabIndex = 1;
            this.label1F1.Text = "FORMULARIO 1";
            this.label1F1.Click += new System.EventHandler(this.label1F1_Click);
            // 
            // label2F2
            // 
            this.label2F2.AutoSize = true;
            this.label2F2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2F2.Location = new System.Drawing.Point(62, 99);
            this.label2F2.Name = "label2F2";
            this.label2F2.Size = new System.Drawing.Size(142, 20);
            this.label2F2.TabIndex = 2;
            this.label2F2.Text = "FORMULARIO 2";
            this.label2F2.Click += new System.EventHandler(this.label2F2_Click);
            // 
            // label3F3
            // 
            this.label3F3.AutoSize = true;
            this.label3F3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3F3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3F3.Location = new System.Drawing.Point(62, 153);
            this.label3F3.Name = "label3F3";
            this.label3F3.Size = new System.Drawing.Size(142, 20);
            this.label3F3.TabIndex = 3;
            this.label3F3.Text = "FORMULARIO 3";
            this.label3F3.Click += new System.EventHandler(this.label3F3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 261);
            this.Controls.Add(this.label3F3);
            this.Controls.Add(this.label2F2);
            this.Controls.Add(this.label1F1);
            this.Controls.Add(this.button1Salir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Salir;
        private System.Windows.Forms.Label label1F1;
        private System.Windows.Forms.Label label2F2;
        private System.Windows.Forms.Label label3F3;
    }
}


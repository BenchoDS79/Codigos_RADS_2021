namespace RubenDuron
{
    partial class FORMULARIO3
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
            this.button1Mostrar = new System.Windows.Forms.Button();
            this.button2Salir = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1Mostrar
            // 
            this.button1Mostrar.Location = new System.Drawing.Point(23, 247);
            this.button1Mostrar.Name = "button1Mostrar";
            this.button1Mostrar.Size = new System.Drawing.Size(88, 31);
            this.button1Mostrar.TabIndex = 0;
            this.button1Mostrar.Text = "MOSTRAR";
            this.button1Mostrar.UseVisualStyleBackColor = true;
            this.button1Mostrar.Click += new System.EventHandler(this.button1Mostrar_Click);
            // 
            // button2Salir
            // 
            this.button2Salir.Location = new System.Drawing.Point(353, 247);
            this.button2Salir.Name = "button2Salir";
            this.button2Salir.Size = new System.Drawing.Size(88, 31);
            this.button2Salir.TabIndex = 1;
            this.button2Salir.Text = "SALIR";
            this.button2Salir.UseVisualStyleBackColor = true;
            this.button2Salir.Click += new System.EventHandler(this.button2Salir_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(14, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 223);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // FORMULARIO3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 293);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2Salir);
            this.Controls.Add(this.button1Mostrar);
            this.Name = "FORMULARIO3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1Mostrar;
        private System.Windows.Forms.Button button2Salir;
        private System.Windows.Forms.ListView listView1;
    }
}
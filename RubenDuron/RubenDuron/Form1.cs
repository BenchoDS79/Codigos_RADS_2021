using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubenDuron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();  
            
        }

        private void label1F1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FORMULARIO1 frm = new FORMULARIO1();
            frm.Show();
            
        }

        private void label2F2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORMULARIO2 frm = new FORMULARIO2();
            frm.Show();
        }

        private void label3F3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORMULARIO3 frm = new FORMULARIO3();
            frm.Show();
        }
    }
}

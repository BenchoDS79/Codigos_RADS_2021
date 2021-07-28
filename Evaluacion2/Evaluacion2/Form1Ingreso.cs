using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form1Ingreso : Form
    {
        public Form1Ingreso()
        {
            InitializeComponent();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Usuario = "rduron";
            String contraseña = "1979antonio";

            if (UsuariotextBox1.Text == "")
            {
                MessageBox.Show("Ingrese el Usuario"); 
                UsuariotextBox1.Focus();
                return;                        
            }

            if (ContraseñatextBox2.Text == "")
            {
                MessageBox.Show("Ingrese su Contraseña");
                ContraseñatextBox2.Focus();
                return;
            }

            else if (UsuariotextBox1.Text != Usuario && ContraseñatextBox2.Text != contraseña)
            {
                MessageBox.Show("Datos Incorrectos");
                UsuariotextBox1.Clear();
                ContraseñatextBox2.Clear();  
            }

            else if (UsuariotextBox1.Text == Usuario && ContraseñatextBox2.Text == contraseña)
            {
                MessageBox.Show("Binvenido al Sistema");
                                    
                this.Close();
            }
        }


        private void Form1Ingreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            


        }
    }
}

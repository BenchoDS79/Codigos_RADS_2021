using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(Numero1textBox1.Text);
            bool resultado = numeroPar(numero);
            if (resultado == true)
            {
                ResultadotextBox1.Text = "El numero Ingresado es Par"; 
            }
            else
            {
                ResultadotextBox1.Text = "El numero Ingresado es Impar";
            }

            var n = int.Parse(Numero1textBox1.Text);
            int i = 0;
            int c = 0; 
            bool resultado2 = numeroprimo(n, i , c);
            if (resultado == true)
            {
                NumeroPrimotextBox1.Text = "y no es Primo";
            }
            else
            {
                NumeroPrimotextBox1.Text = "y es Primo";
            }



        }


        private void Limpiarbutton1_Click(object sender, EventArgs e)
        {
            Numero1textBox1.Clear();
            NumeroPrimotextBox1.Clear();
            ResultadotextBox1.Clear(); 
        }

        private bool numeroPar(int valor)
        {

            if (valor % 2 == 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }

          }

        private bool numeroprimo(int n, int i, int c)
        {
            c = 0;

            n = int.Parse(Numero1textBox1.Text);

            for (i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    c++;
                }
            }

            if (c == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
       }

        private void ResultadotextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumeroPrimotextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

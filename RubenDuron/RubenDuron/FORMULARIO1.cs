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
    public partial class FORMULARIO1 : Form
    {
        public FORMULARIO1()
        {
            InitializeComponent();
            textBox2Tasa.Text = "1.5%";
        }

        private void button1Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Enero--------");
            lista.Add("Febrero------");
            lista.Add("Marzo--------");
            lista.Add("Abril-----------");
            lista.Add("Mayo---------");
            lista.Add("Junio----------");
            lista.Add("Julio-----------");
            lista.Add("Agosto-------");
            lista.Add("Septiembre-");
            lista.Add("Octubre------");
            lista.Add("Noviembre---");
            lista.Add("Diciembre----");

            Double capital = 0;
            double interes = 0.015;
            double capint = 0;
            double Aint = 0;
            double Tint = 0;
            double suma = 0;
            int periodos = 0;
            int i = 0;
            int y = 0;

            capital = Convert.ToDouble(textBox1Capital.Text);
                         
            periodos = Convert.ToInt32(textBox3Periodos.Text);


            for (i = 0; i < periodos; i++)
            {
                y = i;

                Aint = capital * interes;

                Tint = Aint * 1;

                capint = capital + Tint;

                capital = 0;

                capital = capint;

                suma = suma + Tint;

                textBox4Intereses.Text = suma.ToString("C");  

                listView1.Items.Add(lista[y] + "> " + Tint.ToString("C"));

            }

             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1Capital.Clear();
            textBox3Periodos.Clear();
            textBox4Intereses.Clear();

            listView1.Clear();  

        }
    }
}

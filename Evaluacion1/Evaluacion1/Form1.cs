using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime factual = DateTime.Today;
            int edad = factual.Year - dateTimePicker1.Value.Year;
                        
        }

        private void Verificarbutton1_Click(object sender, EventArgs e)
        {
            if (VentastextBox1.Text == "" || AñostextBox2.Text == "")
            {
                MessageBox.Show("Datos Erroneos");  
            }
            else
            { 
            int ventaprom = int.Parse(VentastextBox1.Text);
            int años = int.Parse(AñostextBox2.Text);
            double calculo = 0;
            double suma = 0;

            DateTime factual = DateTime.Today;
            int edad = factual.Year - dateTimePicker1.Value.Year;

                if (ventaprom > 10000 && años >=10 && edad >=30)
                {
                    AvisotextBox5.Text = "SI APLICA AL AUMENTO DEL 5%";
                    calculo = ventaprom * 0.05;
                    suma = calculo + ventaprom;
                    EdadtextBox4.Text = edad.ToString();
                    SalariotextBox3.Text = suma.ToString("C");
                 }
                else
                {
                    AvisotextBox5.Text = "NO APLICA AL AUMENTO DEL 5%";
                    EdadtextBox4.Text = edad.ToString();
                    SalariotextBox3.Text = ventaprom.ToString("C");
                } 
            }
        }

        private void Limpiarbutton2_Click(object sender, EventArgs e)
        {
            VentastextBox1.Clear();
            AñostextBox2.Clear();
            EdadtextBox4.Clear();
            SalariotextBox3.Clear();
            AvisotextBox5.Clear(); 
            dateTimePicker1.Value = DateTime.Now;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

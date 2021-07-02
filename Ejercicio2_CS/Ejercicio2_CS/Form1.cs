using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiarbutton2_Click(object sender, EventArgs e)
        {
            VentatextBox1.Clear();
            BonotextBox2.Clear();
            SumatextBox3.Clear(); 

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Calculobutton1_Click(object sender, EventArgs e)
        {
            if (VentatextBox1.Text == "")
            {
                BonotextBox2.Text = "ERROR";
                SumatextBox3.Text = "ERROR";
            }
            else
            {
                Double venta = 0;
                Double bono = 0;
                Double suma = 0;

                venta = Convert.ToDouble(VentatextBox1.Text); 

                if (venta > 5000)
                {
                    bono = (venta * 0.05);
                }
                else if (venta <= 5000 && venta > 3000)
                {
                    bono = (venta * 0.03);
                }
                else if (venta <= 3000 && venta > 1000)
                {
                    bono = (venta * 0.02);
                }
                else if (venta <= 1000)
                {
                    bono = (venta * 0);
                }

                suma = venta + bono;

                BonotextBox2.Text = bono.ToString("C");
                
                SumatextBox3.Text = suma.ToString("C");  
            }
          }
        }
    }


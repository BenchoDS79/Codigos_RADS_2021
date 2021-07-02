using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Agregar_Click(object sender, EventArgs e)
        {
            string[] nombre = new string[1];
            int[] edad = new int[1];
            int i = 0;

            for (i = 0; i < nombre.Length; i++)
            {
                nombre[i] = textBox1Nombre.Text;
                edad[i] = Int32.Parse(textBox2Edad.Text);  

                comboBox1Lista.Items.Add(nombre[i] + " " + Convert.ToString(edad[i]));

                textBox1Nombre.Clear();
                textBox2Edad.Clear();

            }

        }

        private void button4Limpiar_Click(object sender, EventArgs e)
        {
            textBox1Nombre.Clear();
            textBox2Edad.Clear();
            comboBox1Lista.Items.Clear(); 
        }

        private void button2Asc_Click(object sender, EventArgs e)
        {
            comboBox1Lista.DataSource. 
    }
}

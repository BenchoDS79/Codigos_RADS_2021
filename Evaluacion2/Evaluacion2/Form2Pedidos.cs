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
    public partial class Form2Pedidos : Form
    {
        public Form2Pedidos()
        {
            InitializeComponent();
        }

        private void button1Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult Confirmar = MessageBox.Show("¿Desea confirmar su pedido?", "Confirmacion", MessageBoxButtons.YesNo);

            if (Confirmar == DialogResult.Yes)
            {
                double cantidad = Convert.ToDouble(textBox4Cantidad.Text);
                double precio = Convert.ToDouble(textBox5Precio.Text);
                double total = cantidad * precio;
                double suma = 0;


                dataGridView1.Rows.Add(textBox1Nombre.Text, textBox2Direccion.Text, textBox3Medicamento.Text, comboBox1Tipo.Text, comboBox2Presentacion.Text, cantidad, precio, total);

                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    suma += Convert.ToDouble(Row.Cells["Column8"].Value);
                }

                 textBox6Total.Text = suma.ToString("C");

            }

            else if (Confirmar == DialogResult.No)
            {
                textBox1Nombre.Clear();
                textBox2Direccion.Clear();
                textBox3Medicamento.Clear();
                comboBox1Tipo.Text = "";
                comboBox2Presentacion.Text = "";
                textBox4Cantidad.Clear();
                textBox5Precio.Clear();

            }
        }

        private void button3Otro_Click(object sender, EventArgs e)
        {
            textBox1Nombre.Clear();
            textBox2Direccion.Clear();
            textBox3Medicamento.Clear();
            comboBox1Tipo.Text = "";
            comboBox2Presentacion.Text = "";
            textBox4Cantidad.Clear();
            textBox5Precio.Clear();
        }

        private void button4Nuevo_Click(object sender, EventArgs e)
        {
            textBox1Nombre.Clear();
            textBox2Direccion.Clear();
            textBox3Medicamento.Clear();
            comboBox1Tipo.Text = "";
            comboBox2Presentacion.Text = "";
            textBox4Cantidad.Clear();
            textBox5Precio.Clear();
            textBox6Total.Clear(); 


            dataGridView1.Columns.Clear();   
        }
    }
}

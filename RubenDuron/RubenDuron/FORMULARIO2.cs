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
    public partial class FORMULARIO2 : Form
    {
        double precio = 0;
        double cantidad = 0;
        double total = 0;
        double suma = 0;
        double porcent = 0.15;
        double desc = 0;
        double totp = 0;

        public FORMULARIO2()
        {
            InitializeComponent();
        }

        private void button3Limpiar_Click(object sender, EventArgs e)
        {
            textBox1Producto.Clear(); 
            textBox2Cantidad.Clear();
            textBox3Precio.Clear();
            textBox4Total.Clear();
            textBox5Descuento.Clear();
            textBox6TotalP.Clear();  
            dataGridView1.Rows.Clear();
        }

        private void button4Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1Agregar_Click(object sender, EventArgs e)
        {
            suma = 0;
            textBox4Total.Clear();
             
            cantidad = Convert.ToDouble(textBox2Cantidad.Text);
            precio = Convert.ToDouble(textBox3Precio.Text);
            total = cantidad * precio;
            
            dataGridView1.Rows.Add(textBox1Producto.Text, cantidad, precio, total);
            textBox1Producto.Clear();
            textBox2Cantidad.Clear();
            textBox3Precio.Clear();

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                suma += Convert.ToDouble(Row.Cells["Column4"].Value);
            }

            textBox4Total.Text = suma.ToString("C");   

        }

        private async void button2Calcular_Click(object sender, EventArgs e)
        {
            Double valor = await CalculoAsync();
            textBox5Descuento.Text = valor.ToString("C");

            totp = suma - desc;
            textBox6TotalP.Text = totp.ToString("C");  
                 
        }


        private Task<Double> CalculoAsync()
        {
            return Task.Run(() =>
            {
                desc = suma * porcent;
                return desc;
            });  
        }
    }
}

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
    public partial class FORMULARIO3 : Form
    {
        public FORMULARIO3()
        {
            InitializeComponent();
        }

        private void button1Mostrar_Click(object sender, EventArgs e)
        {
            int num = 0;
            int i = 0;

            for (i = 0; i < 100; i++)
            {
                num = i+1;

                if (num % 3 == 0 && num % 5 == 0)
                {
                    listView1.Items.Add("ruben duron");
                }

                else if (num % 3 == 0)
                {
                    listView1.Items.Add("ruben");
                }

                else if (num % 5 == 0)
                {
                    listView1.Items.Add("duron");
                }

                else if (num % 3 != 0 && num % 5 != 0)
                {
                    listView1.Items.Add(num.ToString());
                }
                
           }
        }

        private void button2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }


}



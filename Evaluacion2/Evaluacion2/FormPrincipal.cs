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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            pedidosToolStripMenuItem.Enabled = false; 
        }

        Form1Ingreso IngresoForm; 
        private void logingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IngresoForm == null)
            {
                IngresoForm = new Form1Ingreso();
                IngresoForm.MdiParent = this;
                IngresoForm.FormClosed += IngresoForm_FormClosed;  
                IngresoForm.Show(); 
            }
            else
            {
                IngresoForm.Activate(); 
            }
        }

        private void IngresoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IngresoForm = null;
            pedidosToolStripMenuItem.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Desea salir del Sistema?", "Confirmacion", MessageBoxButtons.YesNo);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (salir == DialogResult.No)
            {

            }

          
        }

        Form2Pedidos PedidosForm;
        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (PedidosForm == null)
            {
                PedidosForm = new Form2Pedidos();
                PedidosForm.MdiParent = this;
                PedidosForm.FormClosed += PedidosForm_FormClosed;
                PedidosForm.Show();
            }
            else
            {
                PedidosForm.Activate();
            }
        }

        private void PedidosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PedidosForm = null;
        }
    }
    }


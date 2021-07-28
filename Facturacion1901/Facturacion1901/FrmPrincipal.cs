using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Facturacion1901
{
    public partial class FrmPrincipal : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        FrmUsuarios FUsuarios;
        FrmProductos FProductos;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (FUsuarios == null)
            {
                FUsuarios = new FrmUsuarios();
                FUsuarios.MdiParent = this;
                FUsuarios.FormClosed += FUsuarios_FormClosed;
                FUsuarios.Show(); 
            }

            else
            {
                FUsuarios.Activate();  
            }
        }

        private void FUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            FUsuarios = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (FProductos == null)
            {
                FProductos = new FrmProductos();
                FProductos.MdiParent = this;
                FProductos.FormClosed += FProductos_FormClosed;
                FProductos.Show(); 
            }
            else
            {
                FProductos.Activate();
            }
        }

        private void FProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FProductos = null;
        }
    }
}

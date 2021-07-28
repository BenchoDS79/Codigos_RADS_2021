using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Facturacion1901
{
    public partial class LoginForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
           if (UsuarioTextBox.Text == "")
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese el Usuario");
                UsuarioTextBox.Focus();
                return;   
            }

            errorProvider1.SetError(UsuarioTextBox, "");

            if (ContraseñaTextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese la Contraseña");
                ContraseñaTextBox.Focus();
                return;
            }

            errorProvider1.SetError(ContraseñaTextBox, "");

            //CONECTAR A LA BASE DE DATOS

            string cadena = "Data Source=AFICOT\\RUBENDS; Initial Catalog=FACTURACION1901; Integrated Security=True";
            //SqlConnection _Conexion = new SqlConnection(cadena);
            //_Conexion.Open();
            //MessageBox.Show("Conexion realizada");
            //_Conexion.Close();

            bool esUsuarioValido = false;

            using (SqlConnection _Conexion = new SqlConnection(cadena))
            {
                _Conexion.Open();

                string consulta = "SELECT 1 FROM USUARIOS WHERE CODIGO = '" + UsuarioTextBox.Text + "' AND CLAVE = '" + ContraseñaTextBox.Text + "';";

                using (SqlCommand comando = new SqlCommand(consulta, _Conexion))
                {
                    esUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                }

            }

            if (esUsuarioValido)
            {
                FrmPrincipal Formulario = new FrmPrincipal();
                this.Hide();
                Formulario.Show();
            }

            else
            {
                MessageBox.Show("Usuario o Contraseña Invalidas"); 
            }
            
            
        }
    }
}

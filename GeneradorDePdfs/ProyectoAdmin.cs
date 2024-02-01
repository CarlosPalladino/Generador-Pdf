using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDeDatos;
using CLases;
namespace GeneradorDePdfs
{
    public partial class ProyectoAdmin : Form
    {
        public ProyectoAdmin()
        {
            InitializeComponent();
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            LectorDeAdmin metodo = new LectorDeAdmin();
            try
            {
                Admin user = new Admin();

                user.Nombre = txtNombre.Text;
                user.Contrasena = txtContrasena.Text;
                if (metodo.Ingesar(user))
                {
                    Principal principal = new Principal();
                    principal.ShowDialog();


                }
                else
                    MessageBox.Show("llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

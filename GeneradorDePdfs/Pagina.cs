using FirebaseSharp.Portable;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using System.Data;
using System.Diagnostics.Metrics;
using AccesoDeDatos;
using CLases;
namespace GeneradorDePdfs
{
    public partial class Principal : Form
    {

        private List<Productos> lista;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void BtnIngrsar_Click(object sender, EventArgs e)
        {

        }


        public void Cargar()
        {
            LectorDeProductos lector = new LectorDeProductos();

            try
            {
                lista = lector.listar();
                dgvVista.DataSource = lista;
                if (lista.Count > 0)
                {
                    CargarImagen(lista[0].Imagen);
                }
                OcultarColumnas();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void OcultarColumnas()
        {
            dgvVista.Columns[""].Visible = false;

        }

        public void CargarImagen(string imagen)
        {
            try
            {
                PicImagen.Load(imagen);
            }
            catch (Exception)
            {

                PicImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");

            }
        }






    }
}

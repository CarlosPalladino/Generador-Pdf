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

        private List<Productos> listaProductos;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void dgvVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void BtnIngrsar_Click(object sender, EventArgs e)
        {
            ProyectoAdmin admin = new ProyectoAdmin();

            admin.ShowDialog();
        }


        public void Cargar()
        {
            LectorDeProductos lector = new LectorDeProductos();

            try
            {
                listaProductos = lector.listar();
                dgvVista.DataSource = listaProductos;
                if (listaProductos.Count > 0)
                {
                    CargarImagen(listaProductos[0].Imagen);
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
            dgvVista.Columns["Id"].Visible = false;
            //if()
            //dgvVista.Columns[""].Visible = true;


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

        private void dgvVista_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void LblFiltro_Click(object sender, EventArgs e)
        {
            List<Productos> lista = new List<Productos>;
            string filtro = txtFiltro.Text;

            if (filtro.Length > 2)
            {
                lista = listaProductos.Where(p => p.Nombre.ToUpper().Contains(filtro.ToUpper())).ToList();
            }
            dgvVista.DataSource = null;
            dgvVista.DataSource = lista;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

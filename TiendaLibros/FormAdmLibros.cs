using Entidades;
using Negocios;
using System.Data;

namespace TiendaLibros
{
    public partial class FormAdmLibros : Form
    {
        public FormAdmLibros()
        {
            InitializeComponent();
            dgvLibros.ColumnCount = 6;
            dgvLibros.Columns[0].HeaderText = "Código";
            dgvLibros.Columns[1].HeaderText = "Título";
            dgvLibros.Columns[2].HeaderText = "Autor";
            dgvLibros.Columns[3].HeaderText = "Género";
            dgvLibros.Columns[4].HeaderText = "Precio";
            dgvLibros.Columns[5].HeaderText = "Cantidad en Stock";
            dgvLibros.Columns[0].Width = 60;
            dgvLibros.Columns[1].Width = 200;
            dgvLibros.Columns[2].Width = 100;
            dgvLibros.Columns[3].Width = 100;
            dgvLibros.Columns[4].Width = 100;
            dgvLibros.Columns[5].Width = 60;
            LlenarDGV();
        }

        public Libro objEntLibro = new Libro();

        public NegLibros objNegLibro = new NegLibros();

        private void LlenarDGV()
        {
            dgvLibros.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegLibro.listadoLibros("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(), etc..
                    dgvLibros.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
                lblMensaje.Text = "No hay libros cargados en el sistema";
        }

        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            objEntLibro.CodLibro = int.Parse(txtCodLibro.Text);
            objEntLibro.Titulo = txtTitulo.Text;
            objEntLibro.Autor = txtAutor.Text;
            objEntLibro.Genero = txtGenero.Text;
            objEntLibro.Precio = decimal.Parse(txtPrecio.Text);
            objEntLibro.CantidadStock = int.Parse(txtStock.Text);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Obj();
            nGrabados = objNegLibro.abmLibros("Alta", objEntLibro); //invoco a la capa de negocio
            if (nGrabados == -1)
            {
                lblMensaje.Text = " No pudo añadir el libro en el sistema";
            }
            else
            {
                lblMensaje.Text = " Se agregó con éxito a Libros.";
                LlenarDGV();
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtCodLibro.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtGenero.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntLibro.CodLibro = Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value);
            ds = objNegLibro.listadoLibros(objEntLibro.CodLibro.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btAgregar.Visible = false;
                lblMensaje.Text = string.Empty;
            }
        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodLibro.Text = ds.Tables[0].Rows[0]["CodLibro"].ToString();
            txtTitulo.Text = ds.Tables[0].Rows[0]["Titulo"].ToString();
            txtAutor.Text = ds.Tables[0].Rows[0]["Autor"].ToString();
            txtGenero.Text = ds.Tables[0].Rows[0]["Género"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
            txtStock.Text = ds.Tables[0].Rows[0]["Cantidad en Stock"].ToString();
            txtCodLibro.Enabled = false;
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
        }
    }
}
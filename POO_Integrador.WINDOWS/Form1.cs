using POO_Integrador.DATOS;
using POO_Integrador.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Integrador.WINDOWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();     
        }

        private List<Libro> lista;
  

        private int cantidadDeRegistros;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cantidadDeRegistros = RepositorioLibros.GetInstancia().GetCantidad();
            if (cantidadDeRegistros>0)
            {
                lista = RepositorioLibros.GetInstancia().GetLista();
                MostrarDatosEnGrilla();
                ActualizarContadorRegistros();
            }
        }

        private void RecargarGrilla()
        {
            lista = RepositorioLibros.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var libro in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, libro);
                AgregarFila(r);
            }
        }

        private void SetearFila(DataGridViewRow r, Libro libro)
        {
            r.Cells[ColNombre.Index].Value = libro.NombreLibro;
            r.Cells[ColEditorial.Index].Value = libro.Editorial;
            r.Cells[ColTema.Index].Value = libro.Tema;
            r.Cells[ColPaginas.Index].Value = libro.Paginas;
            r.Cells[ColISBN.Index].Value = libro.Isbn;
            r.Cells[ColAutor.Index].Value = libro.Autor;

            r.Tag = libro;
        }
            
        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NuevoToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmLibrosEdit frm = new FrmLibrosEdit() { Text = "Agregar nuevo libro" };
            DialogResult dr = frm.ShowDialog(this);

            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Libro libro = frm.GetLibro();
            if (RepositorioLibros.GetInstancia().Existe(libro))
            {
                MessageBox.Show("El libro ya existe");
                return;
            }

            RepositorioLibros.GetInstancia().Agregar(libro);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, libro);
            AgregarFila(r);
            ActualizarContadorRegistros();
            MessageBox.Show("Registro Agregado");

        }

        private void ActualizarContadorRegistros()
        {
     
            CantidadRegistrosLabel.Text = RepositorioLibros.GetInstancia().GetCantidad().ToString();
        }

        private void SalirToolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void BorrarToolStripButton2_Click(object sender, EventArgs e)
        {
            if(DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Libro libro = (Libro)r.Tag;

            const string mensaje = "¿Desea borrar el registro seleccionado?";
            const string caption = "Cerrar";
            DialogResult dr = MessageBox.Show(mensaje, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (dr==DialogResult.Yes)

            {
                RepositorioLibros.GetInstancia().Remover(libro);
                DatosDataGridView.Rows.Remove(r);
                MessageBox.Show("Registro Borrado");
                ActualizarContadorRegistros();
            }
        }

        private void EditarToolStripButton3_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];           
            Libro libro = (Libro)r.Tag;
            Libro libroCopia = (Libro)libro.Clone();
            FrmLibrosEdit frm = new FrmLibrosEdit() {Text= "Editar Libro" };
            frm.SetLibro(libroCopia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            libroCopia = frm.GetLibro();
            if (RepositorioLibros.GetInstancia().Existe(libroCopia))
            {
                MessageBox.Show("El libro ya existe");
                return;
            }

            RepositorioLibros.GetInstancia().Editar(libro, libroCopia);
            SetearFila(r, libroCopia);
            MessageBox.Show("Se modificó el registro");


        }


        private void ActualizarToolStripButton5_Click(object sender, EventArgs e)
        {
            ActualizarContadorRegistros();
            lista = RepositorioLibros.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
        }

        
    }
}

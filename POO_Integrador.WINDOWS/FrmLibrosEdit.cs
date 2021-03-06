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
    public partial class FrmLibrosEdit : Form
    {
        public FrmLibrosEdit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (libro!=null)
            {
                LibroTextBox.Text = libro.NombreLibro;
                EditorialComboBox.SelectedItem = libro.Editorial;
                TemaComboBox.SelectedItem = libro.Tema;
                IsbnTextBox.Text = Convert.ToString(libro.Isbn);
                PaginasTextBox.Text = Convert.ToString(libro.Paginas);
                AutorTextBox.Text = Convert.ToString(libro.Autor);
            }

        }

        private void FrmLibrosEdit_Load(object sender, EventArgs e)
        {
            CargarDatosCombos(ref TemaComboBox, ref EditorialComboBox);
        }

        private void CargarDatosCombos(ref ComboBox temaComboBox, ref ComboBox editorialComboBox)
        {
            editorialComboBox.DataSource = Enum.GetValues(typeof(ENTIDADES.Editorial));
            temaComboBox.DataSource = Enum.GetValues(typeof(ENTIDADES.Tema));
        }

        private Libro libro;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (libro == null)
                    libro = new Libro();
            }

            libro.NombreLibro = LibroTextBox.Text;
            libro.Editorial = (Editorial)EditorialComboBox.SelectedItem;
            libro.Tema = (Tema)TemaComboBox.SelectedItem;
            libro.Isbn = (Convert.ToInt32 (IsbnTextBox.Text));
            libro.Paginas = (Convert.ToInt32(PaginasTextBox.Text));
            libro.Autor = AutorTextBox.Text;

            DialogResult = DialogResult.OK;
        }

        public Libro GetLibro()
        {
            return libro; 
        }

        private bool ValidarDatos()
        {
            return true;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void SetLibro(Libro libroCopia)
        {
            libro = libroCopia;
        }

        private void LibroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

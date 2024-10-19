using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioProyecto
{
    public partial class frm_altaLibros : Form
    {
        public frm_altaLibros()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_idAltaLib_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_idAltaLib_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardarAltaAut_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("Por favor ingrese datos validos!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DOLibros libro = new DOLibros();

            libro.idLibro = Convert.ToInt32(txt_idAltaLib.Text);
            libro.idAutor = Convert.ToInt32(txt_idAutorAltaLib.Text);
            libro.Titulo = txt_tituloAltaLib.Text;
            libro.Genero = txt_generoAltaLib.Text;
            libro.Anio_Publicacion = Convert.ToInt32(txt_aniopubAltaLib.Text);
            libro.Volumen = Convert.ToInt32(txt_volAltaLib.Text);
            libro.Capitulo = Convert.ToInt32(txt_capAltaLib.Text);
            libro.Editorial = txt_editAltaLib.Text;

            int idLibro = BLLibros.InsertOrUpdateLibros(libro);
            if (idLibro > 0)
            {
                MessageBox.Show("Libro dado de alta con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show("Hubo un error, por favor intente más tarde", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarDatos()
        {

            if (string.IsNullOrWhiteSpace(txt_idAltaLib.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_idAutorAltaLib.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_tituloAltaLib.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_generoAltaLib.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_aniopubAltaLib.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_volAltaLib.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_capAltaLib.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_editAltaLib.Text))
            {
                return false;
            }
            else

                return true;
        }

        private void LimpiarCampos()
        {
            txt_idAltaLib.Text = "";
            txt_idAutorAltaLib.Text = "";
            txt_tituloAltaLib.Text = "";
            txt_generoAltaLib.Text = "";
            txt_aniopubAltaLib.Text = "";
            txt_volAltaLib.Text = "";
            txt_capAltaLib.Text = "";
            txt_editAltaLib.Text = "";
        }

        private void frm_altaLibros_Load(object sender, EventArgs e)
        {

        }
    }
}

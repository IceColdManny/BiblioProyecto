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
    public partial class frm_altaAut : Form
    {
        public frm_altaAut()
        {
            InitializeComponent();
        }

        private void btn_guardarAltaAut_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("Por favor ingrese datos validos!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DOAutores autor = new DOAutores();

            autor.idAutor = Convert.ToInt32(txt_idAltaAut.Text);
            autor.Nombre = txt_nombreAltaAut.Text;
            autor.Apellido = txt_apellidoAltaAut.Text;
            autor.Nacionalidad = txt_nacionAltaAut.Text;



            int idAutor = BLAutores.InsertOrUpdateAutores(autor);
            if (idAutor > 0)
            {
                MessageBox.Show("Autor dado de alta con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Hubo un error, por favor intente más tarde", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarDatos()
        {

            if (string.IsNullOrWhiteSpace(txt_idAltaAut.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_nombreAltaAut.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_apellidoAltaAut.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_nacionAltaAut.Text))
            {
                return false;
            }
            else

                return true;
        }

        private void LimpiarCampos()
        {
            txt_idAltaAut.Text = "";
            txt_nombreAltaAut.Text = "";
            txt_apellidoAltaAut.Text = "";
            txt_nacionAltaAut.Text = ""; // Reinicia el combo box de estado
        }


        private void txt_idAltaAut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_altaAut_Load(object sender, EventArgs e)
        {

        }
    }
}

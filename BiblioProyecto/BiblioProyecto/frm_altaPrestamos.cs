using BusinessLogic;
using Database;
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
    public partial class frm_altaPrestamos : Form
    {
        public frm_altaPrestamos()
        {
            InitializeComponent();
        }

        private void frm_altaPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardarAltaPres_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("Por favor ingrese datos validos!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DOPrestamos prestamo = new DOPrestamos();

            prestamo.idLibro = Convert.ToInt32(txt_idLibroAltaPres.Text);
            prestamo.idPrestamo = Convert.ToInt32(txt_idAltaPres.Text);
            prestamo.FechaPrestamo = DateTime.Now;
            prestamo.FechaDevolucion = DateTime.Now.AddDays(30);
            prestamo.NombreUsuario = txt_nombreAltaPres.Text;
            prestamo.Telefono = (int)Convert.ToInt64(txt_telAltaPres.Text);
            prestamo.Correo = txt_corAltaPres.Text;
            prestamo.Direccion = txt_dirAltaPres.Text;
            prestamo.PrestamoDevuelto = false;



            int idPrestamo = BLPrestamos.InsertOrUpdatePrestamos(prestamo);
            if (idPrestamo > 0)
            {
                MessageBox.Show("Prestamo dado de alta con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show("Hubo un error", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool validarDatos()
        {

            if (string.IsNullOrWhiteSpace(txt_idLibroAltaPres.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_idAltaPres.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_nombreAltaPres.Text))
            {
                return false;
            }
            else
            if (string.IsNullOrWhiteSpace(txt_telAltaPres.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_corAltaPres.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_dirAltaPres.Text))
            {
                return false;
            }
            else

                return true;
        }

        private void LimpiarCampos()
        {
            txt_idLibroAltaPres.Text = "";
            txt_idAltaPres.Text = "";
            txt_nombreAltaPres.Text = "";
            txt_telAltaPres.Text = "";
            txt_corAltaPres.Text = "";
            txt_dirAltaPres.Text = "";
        }
    }
}

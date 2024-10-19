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
    public partial class frm_prestamoDevuelto : Form
    {
        public frm_prestamoDevuelto()
        {
            InitializeComponent();
        }

        private void btn_guardarDevPres_Click(object sender, EventArgs e)
        {
            int idPrestamo = Convert.ToInt32(txt_idDevPres.Text);
            bool PrestamoDevuelto = true;  // Cambiado de false a true

            if (!BLPrestamos.MarcarDevuelto(idPrestamo, PrestamoDevuelto))
            {
                MessageBox.Show("Hubo un error", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Libro devuelto con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpia los campos después de eliminar el municipio
            }
        }


        private void LimpiarCampos()
        {
            txt_idDevPres.Text = "";
        }
    }
}

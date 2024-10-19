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
    public partial class frm_bajaPrestamos : Form
    {
        public frm_bajaPrestamos()
        {
            InitializeComponent();
        }

        private void btn_guardarBajaPres_Click(object sender, EventArgs e)
        {
            int idPrestamo = Convert.ToInt32(txt_idBajaPres.Text);

            if (!BLPrestamos.DeletePrestamo(idPrestamo))
            {
                MessageBox.Show("Hubo un error, es posible que el libro esté enlazado a un prestamo y no se puede proceder", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Prestamo eliminado con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpia los campos después de eliminar el municipio
            }
        }

        private void LimpiarCampos()
        {
            txt_idBajaPres.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace DataInterface
{
    public partial class frm_bajaLibros : Form
    {
        public frm_bajaLibros()
        {
            InitializeComponent();
        }

        private void frm_bajaLibros_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardarBajaLib_Click(object sender, EventArgs e)
        {
            int idLibro = Convert.ToInt32(txt_idBajaLib.Text);

            if (!BLLibros.DeleteLibro(idLibro))
            {
                MessageBox.Show("Hubo un error, es posible que el libro esté enlazado a un prestamo y no se puede proceder", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Libro eliminado con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpia los campos después de eliminar el municipio
            }
        }

        private void LimpiarCampos()
        {
            txt_idBajaLib.Text = "";
        }
    }
}

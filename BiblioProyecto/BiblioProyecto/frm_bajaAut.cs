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
    public partial class frm_bajaAut : Form
    {
        public frm_bajaAut()
        {
            InitializeComponent();
        }

        private void frm_bajaAut_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardarAltaAut_Click(object sender, EventArgs e)
        {
            int idAutor = Convert.ToInt32(txt_idBajaAut.Text);

            if (!BLAutores.DeleteAutor(idAutor))
            {
                MessageBox.Show("Hubo un error, es posible que el autor esté enlazado a un libro y no se puede proceder", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Autor eliminado con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpia los campos después de eliminar el municipio
            }


        }

        private void LimpiarCampos()
        {
            txt_idBajaAut.Text = "";
        }
    }
}

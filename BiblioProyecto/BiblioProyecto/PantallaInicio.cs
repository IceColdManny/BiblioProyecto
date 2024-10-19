using DataInterface;
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
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bIBLIOTECAPRDataSet3.LIBROS' Puede moverla o quitarla según sea necesario.
            this.lIBROSTableAdapter.Fill(this.bIBLIOTECAPRDataSet3.LIBROS);
            // TODO: esta línea de código carga datos en la tabla 'bIBLIOTECAPRDataSet2.AUTORES' Puede moverla o quitarla según sea necesario.
            this.aUTORESTableAdapter.Fill(this.bIBLIOTECAPRDataSet2.AUTORES);
            // TODO: esta línea de código carga datos en la tabla 'bIBLIOTECAPRDataSet.PRESTAMOS' Puede moverla o quitarla según sea necesario.
            this.pRESTAMOSTableAdapter.Fill(this.bIBLIOTECAPRDataSet.PRESTAMOS);

        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_altaAut frmAltaAut = new frm_altaAut();

            frmAltaAut.ShowDialog();
        }

        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_bajaAut frmBajaAut = new frm_bajaAut();

            frmBajaAut.ShowDialog();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_altaLibros frmAltaLib = new frm_altaLibros();

            frmAltaLib.ShowDialog();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_bajaLibros frmBajaLib = new frm_bajaLibros();

            frmBajaLib.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_altaPrestamos frmaltaPres = new frm_altaPrestamos();

            frmaltaPres.ShowDialog();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_bajaPrestamos frmbajaPres = new frm_bajaPrestamos();

            frmbajaPres.ShowDialog();
        }

        private void marcarPrestamoDevueltoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_prestamoDevuelto frmPresDev = new frm_prestamoDevuelto();

            frmPresDev.ShowDialog();
        }

        private void miembrosDelEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_portada frmportada = new frm_portada();

            frmportada.ShowDialog();
        }
    }
}

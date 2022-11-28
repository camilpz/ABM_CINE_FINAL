using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABM_CINE_FINAL.Presentacion;

namespace ABM_CINE_FINAL.Presentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaFuncion A_Funcion = new FrmAltaFuncion();
            A_Funcion.ShowDialog();
        }

        private void películaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAltaBajaPelicula f_ab_pelicula = new FrmAltaBajaPelicula();
            f_ab_pelicula.ShowDialog();
        }
    }
}

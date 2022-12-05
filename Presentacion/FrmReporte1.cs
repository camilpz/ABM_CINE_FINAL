using ABM_CINE_FINAL.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM_CINE_FINAL.Presentacion
{
    public partial class FrmReporte1 : Form
    {
        public FrmReporte1()
        {
            InitializeComponent();
        }

        private void FrmReporte1_Load(object sender, EventArgs e)
        {
            HelperDAO.ObtenerInstancia().ConsultaReporte("");
        }
    }
}

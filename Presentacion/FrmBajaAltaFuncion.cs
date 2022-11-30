using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABM_CINE_FINAL.Datos;

namespace ABM_CINE_FINAL.Presentacion
{
    public partial class FrmBajaAltaFuncion : Form
    {
        public FrmBajaAltaFuncion()
        {
            InitializeComponent();
        }

        private void FrmBajaAltaFuncion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        public void CargarGrilla(int eleccion)
        {
            DataTable tabla = new DataTable();
            tabla = HelperDAO.ObtenerInstancia().ObtenerFunciones(eleccion);
            foreach (DataRow fila in tabla.Rows)
            {
                dgvFunciones.Rows.Add(new object[] { fila["ID"], fila["Pelicula"], fila["Idioma"], fila["NroSala"], fila["Fecha"], fila["Horario"] });
            }
        }
        public void Inicializar()
        {
            rbtAlta.Checked = false;
            rbtBaja.Checked = false;
        }
        public void Elegir()
        {
            if (rbtAlta.Checked)
            {
                CargarGrilla(1);
            }
            else if (rbtBaja.Checked)
            {
                CargarGrilla(2);
            }
        }
        private void rbtAlta_CheckedChanged(object sender, EventArgs e)
        {
            dgvFunciones.Rows.Clear();
            Elegir();
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvFunciones.CurrentCell.ColumnIndex == 6)
            {
                if (rbtAlta.Checked)
                {
                    if (HelperDAO.ObtenerInstancia().CambiarEstadoFuncion(Convert.ToInt32(dgvFunciones.CurrentRow.Cells["colID"].Value), 1)){
                        dgvFunciones.Rows.RemoveAt(dgvFunciones.CurrentRow.Index);
                        MessageBox.Show("Se ha dado de baja exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                if (rbtBaja.Checked)
                {
                    if(HelperDAO.ObtenerInstancia().CambiarEstadoFuncion(Convert.ToInt32(dgvFunciones.CurrentRow.Cells["colID"].Value), 2))
                    {
                        dgvFunciones.Rows.RemoveAt(dgvFunciones.CurrentRow.Index);
                        MessageBox.Show("Se ha dado de alta exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
            }
        }

        private void rbtBaja_CheckedChanged(object sender, EventArgs e)
        {
            dgvFunciones.Rows.Clear();
            Elegir();
        }
    }
}

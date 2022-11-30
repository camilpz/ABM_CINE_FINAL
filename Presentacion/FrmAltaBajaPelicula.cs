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
    public partial class FrmAltaBajaPelicula : Form
    {
        public FrmAltaBajaPelicula()
        {
            InitializeComponent();
        }

        private void FrmAltaBajaPelicula_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        public void Inicializar()
        {
            rbtActiva.Checked = false;
            rbtInactiva.Checked = false;
        }
        public void CargarGrilla(string peli, int elec)
        {
            DataTable tabla = new DataTable();
            tabla = HelperDAO.ObtenerInstancia().ObtenerPeliculasNombreEstado(peli, elec);
            foreach (DataRow fila in tabla.Rows)
            {
                dgvPeliculas.Rows.Add(new object[] { fila["ID"], fila["Pelicula"], fila["Clasificacion"], fila["Duracion"] });
            }
        }
        public void Elegir()
        {
            if (!txtNombre.Text.Equals(string.Empty))
            {
                if (rbtActiva.Checked)
                {
                    CargarGrilla(txtNombre.Text, 2);
                }
                if (rbtInactiva.Checked)
                {
                    CargarGrilla(txtNombre.Text, 1);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de una película");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvPeliculas.Rows.Clear();
            Elegir();
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPeliculas.CurrentCell.ColumnIndex == 4)
            {
                if (rbtActiva.Checked)
                {
                    if (HelperDAO.ObtenerInstancia().CambiarEstadoPelicula(Convert.ToInt32(dgvPeliculas.CurrentRow.Cells["colId"].Value), 1))
                    {
                        MessageBox.Show("Se ha dado de baja con éxito");
                        dgvPeliculas.Rows.RemoveAt(dgvPeliculas.CurrentRow.Index);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                if (rbtInactiva.Checked)
                {
                    if (HelperDAO.ObtenerInstancia().CambiarEstadoPelicula(Convert.ToInt32(dgvPeliculas.CurrentRow.Cells["colId"].Value), 2))
                    {
                        MessageBox.Show("Se ha dado de alta con éxito");
                        dgvPeliculas.Rows.RemoveAt(dgvPeliculas.CurrentRow.Index);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                
            }
        }
    }
}

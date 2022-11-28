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
using ABM_CINE_FINAL.Dominio;

namespace ABM_CINE_FINAL.Presentacion
{
    public partial class FrmAltaFuncion : Form
    {
        Funcion funcion;
        public FrmAltaFuncion()
        {
            InitializeComponent();
        }

        private void FrmAltaFuncion_Load(object sender, EventArgs e)
        { 
            CargarCombos(cboPeliculas, HelperDAO.ObtenerInstancia().ObtenerPeliculasActivas());
        }
        public void CargarCombos(ComboBox cbo, DataTable tabla)
        {
            cbo.DataSource = tabla;
            cbo.ValueMember = tabla.Columns[0].ColumnName;
            cbo.DisplayMember = tabla.Columns[1].ColumnName;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        public void Limpiar()
        {
            cboPeliculas.SelectedIndex = -1;
            cboIdiomas.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
            cboHorarios.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
        }
        public bool Verificar()
        {
            bool valido = true;
            if (cboPeliculas.SelectedValue.Equals(-1))
            {
                valido = false;

            }
            else if (cboIdiomas.SelectedValue.Equals(-1))
            {
                valido = false;
            }
            else if (cboHorarios.SelectedValue.Equals(-1))
            {
                valido = false;
            }
            else if (cboSala.SelectedValue.Equals(-1))
            {
                valido = false;

            }
            else if (dtpFecha.Value < DateTime.Now)
            {
                valido = false;
                MessageBox.Show("No puede crear una función para un día pasado");
            }
            return valido;
        }

        private void cboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPeliculas.SelectedIndex != -1)
            {
                DataRowView fila = (DataRowView)cboPeliculas.SelectedItem;
                int id = Convert.ToInt32(fila["ID"]);
                string nombre = fila["Pelicula"].ToString();

                CargarCombos(cboIdiomas, HelperDAO.ObtenerInstancia().ObtenerIdiomasPeliculas(id));
            }
            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFecha.Value < DateTime.Today)
            {
                MessageBox.Show("Debe elegir la fecha a partir de hoy");
            }
            else
            {
                DateTime fecha = dtpFecha.Value;
                CargarCombos(cboSala, HelperDAO.ObtenerInstancia().ObtenerSalasDesocupadas(fecha));
            }
            
        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSala.SelectedIndex != -1)
            {
                DataRowView fila = (DataRowView)cboSala.SelectedItem;
                int nro_sala = Convert.ToInt32(fila["ID"]);

                CargarCombos(cboHorarios, HelperDAO.ObtenerInstancia().ObtenerHorariosDisponibles(nro_sala));
            }
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                funcion = new Funcion();
                funcion.Id_peli_idio = Convert.ToInt32(cboIdiomas.SelectedValue);
                funcion.Sala.Id = Convert.ToInt32(cboSala.SelectedValue);
                funcion.Fecha = dtpFecha.Value;
                funcion.Horario.Id = Convert.ToInt32(cboHorarios.SelectedValue);

                if (HelperDAO.ObtenerInstancia().AltaFuncion(funcion))
                {
                    MessageBox.Show("Se ha creado con éxito");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            

        }
    }
}

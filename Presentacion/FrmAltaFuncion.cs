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
using ABM_CINE_FINAL.Servicios;

namespace ABM_CINE_FINAL.Presentacion
{
    public partial class FrmAltaFuncion : Form
    {
        Servicio servicio = new Servicio();
        public FrmAltaFuncion()
        {
            InitializeComponent();
        }

        private void FrmAltaFuncion_Load(object sender, EventArgs e)
        {
            Limpiar();
            Inicializar(false);
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
        public void Inicializar(bool x)
        {
            cboIdiomas.Enabled = x;
            cboHorarios.Enabled = x;
            cboSala.Enabled = x;
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
                DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
                int id_peli = Convert.ToInt32(peli[0]);
                cboIdiomas.Enabled = true;
                CargarCombos(cboIdiomas, HelperDAO.ObtenerInstancia().ObtenerIdiomasPeliculas(id_peli));
            }
            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFecha.Value < DateTime.Today)
            {
                MessageBox.Show("Debe elegir la fecha a partir de hoy");
                dtpFecha.Value = DateTime.Today;
            }
            else
            {
                DateTime fecha = dtpFecha.Value;
                cboSala.Enabled = true;
                CargarCombos(cboSala, HelperDAO.ObtenerInstancia().ObtenerSalasDesocupadas(fecha));
            }
            
        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSala.SelectedIndex != -1)
            {
                DataRowView sala = (DataRowView)cboSala.SelectedItem;
                int nro_sala = Convert.ToInt32(sala[0]);
                cboHorarios.Enabled = true;
                CargarCombos(cboHorarios, HelperDAO.ObtenerInstancia().ObtenerHorariosDisponibles(nro_sala));
            }   
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                DataRowView hora = (DataRowView)cboHorarios.SelectedItem;
                int id_horario = Convert.ToInt32(hora[0]);

				DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
				int id_peli = Convert.ToInt32(peli[0]);

                DataRowView idio = (DataRowView)cboIdiomas.SelectedItem;
                int id_idioma = Convert.ToInt32(idio[0]);

				DataRowView sala = (DataRowView)cboSala.SelectedItem;
				int nro_sala = Convert.ToInt32(sala[0]);

                DateTime fecha = dtpFecha.Value;

                int id_pxi = servicio.ObtenerIDPXI(id_peli, id_idioma);
				Funcion funcion = new Funcion();
                funcion.Id_peli_idio = id_pxi;
                Sala sal = new Sala();
                sal.Id = nro_sala;
                funcion.Sala = sal;
                funcion.Fecha = fecha;
                Horario hor = new Horario();
                hor.Id = id_horario;
                funcion.Horario = hor;

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
		private void cboIdiomas_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCine.Factory;
using LibreriaCine.Clases;

namespace ABM_CINE_FINAL.Presentacion
{
	public partial class FrmEditarFuncion : Form
	{
		Servicio servicio = new Servicio();
		List<Funcion> Lfunciones = new List<Funcion>();
		public FrmEditarFuncion()
		{
			InitializeComponent();
		}

		private void FrmEditarFuncion_Load(object sender, EventArgs e)
		{
			CargarGrilla(CargarTabla());
			CargarCombo(cboHorario, 7);
			CargarCombo(cboSala, 8);
			Inicializar(false);
		}
		public void Limpiar()
		{
			cboHorario.SelectedIndex = -1;
			cboSala.SelectedIndex = -1;
			dtpFecha.Value = DateTime.Today;
		}
		public void Inicializar(bool x)
		{
			cboHorario.Enabled = x;
			cboSala.Enabled = x;
			dtpFecha.Enabled = x;
		}
		public bool Verificar()
		{
			bool valido = true;
			//if(cboHorario.SelectedIndex == -1)
			//{
			//	valido = false;
			//	MessageBox.Show("Debe seleccionar un horario");
			//}
			//else if(cboSala.SelectedIndex ==-1)
			//{
			//	valido = false;
			//	MessageBox.Show("Debe seleccionar una sala");
			//}
			if(!cboHorario.Enabled && !cboSala.Enabled && !dtpFecha.Enabled)
			{
				valido = false;
				MessageBox.Show("Debe seleccionar una función");
			}
			return valido;
		}
		public DataTable CargarTabla()
		{
			DataTable tabla = new DataTable();
			tabla = servicio.ObtenerFuncionesEditar();
			return tabla;
		}
		public void CargarGrilla(DataTable tabla)
		{
			
			foreach (DataRow fila in tabla.Rows)
			{
				int id_fun = Convert.ToInt32(fila["ID"]);
				
				Pelicula pelicula= new Pelicula();
				pelicula.Nombre = fila["Pelicula"].ToString();
				DateTime fecha = Convert.ToDateTime(fila["Fecha"]);
				Idioma idioma = new Idioma();
				idioma.Id = Convert.ToInt32(fila["ID_Idioma"]);
				idioma.Nombre = fila["Idioma"].ToString();
				Sala sala = new Sala();
				sala.Id = Convert.ToInt32(fila["NroSala"]);
				Horario horario = new Horario();
				horario.Id = Convert.ToInt32(fila["ID_Horario"]);
				horario.Hora = fila["Horario"].ToString();

				Funcion funcion = new Funcion(id_fun, pelicula,sala, fecha, horario, idioma);
				Lfunciones.Add(funcion);
				dgvFunciones.Rows.Add(new object[] { fila["ID"], fila["Pelicula"], fila["Idioma"], fila["Horario"] });
			}
		}
		public void CargarCombo(ComboBox cbo, int nro_tabla)
		{
			DataTable tabla = new DataTable();
			tabla = servicio.ObtenerTablasAux(nro_tabla);
			cbo.DataSource = tabla;
			cbo.ValueMember = tabla.Columns[0].ColumnName;
			cbo.DisplayMember= tabla.Columns[1].ColumnName;
			cbo.DropDownStyle = ComboBoxStyle.DropDownList;
			cbo.SelectedIndex = -1;
		}

		private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Inicializar(true);
			int indice = dgvFunciones.CurrentRow.Index;
			cboHorario.SelectedValue = Lfunciones[indice].Horario.Id;
			cboSala.SelectedValue = Lfunciones[indice].Sala.Id;
			dtpFecha.Value = Lfunciones[indice].Fecha;
		}

		private void btnGuardarCambios_Click(object sender, EventArgs e)
		{
			if (Verificar())
			{
				int indice = dgvFunciones.CurrentRow.Index;
				Lfunciones[indice].Horario.Id = Convert.ToInt32(cboHorario.SelectedValue);
				Lfunciones[indice].Sala.Id = Convert.ToInt32(cboSala.SelectedValue);
				Lfunciones[indice].Fecha = dtpFecha.Value;

				if (servicio.EditarFuncion(Lfunciones[indice]))
				{
					MessageBox.Show("La función se modificó exitosamente");
					//Lfunciones.Clear();
					//dgvFunciones.Rows.Clear();
					//CargarGrilla(CargarTabla());
					DataRowView filacbo = (DataRowView)cboHorario.SelectedItem;
					dgvFunciones.CurrentRow.Cells["colHorario"].Value = filacbo["horario"];
					Limpiar();
					Inicializar(false);
				}
				else
				{
					MessageBox.Show("Ha ocurrido un error");
				}
			}
		}
	}
}

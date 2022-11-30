using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABM_CINE_FINAL.Servicios;

namespace ABM_CINE_FINAL.Presentacion
{
	public partial class FrmEditarFuncion : Form
	{
		Servicio servicio = new Servicio();
		public FrmEditarFuncion()
		{
			InitializeComponent();
		}

		private void FrmEditarFuncion_Load(object sender, EventArgs e)
		{
			CargarGrilla();
			CargarCombo(cboHorario, 7);
			CargarCombo(cboSala, 8);
		}
		public void CargarGrilla()
		{
			DataTable tabla = new DataTable();
			tabla = servicio.ObtenerFuncionesEditar();
			foreach (DataRow fila in tabla.Rows)
			{
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
	}
}

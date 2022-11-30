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
using ABM_CINE_FINAL.Dominio;

namespace ABM_CINE_FINAL.Presentacion
{
	public partial class FrmAltaComprobante : Form
	{
		List<Detalle> Ldetalles; //Pasar la lista desde el form de butacas
		Servicio servicio = new Servicio();
		public FrmAltaComprobante()
		{
			InitializeComponent();
		}

		private void FrmAltaComprobante_Load(object sender, EventArgs e)
		{
			CargarCombos(cboFormasPago, 1);
			CargarCombos(cboDescuentos, 5);
			CargarCombos(cboExtras, 9);
		}

		public void CargarCombos(ComboBox combo, int nro_tabla) //ver valor en el SP
		{
			DataTable table = new DataTable();
			table = servicio.ObtenerTablasAux(nro_tabla);
			combo.DataSource = table;
			combo.ValueMember = table.Columns[0].ColumnName;
			combo.DisplayMember = table.Columns[1].ColumnName;
			combo.DropDownStyle = ComboBoxStyle.DropDownList;
			combo.SelectedIndex = -1;
		}
		public void CargarGrilla()
		{
			foreach (Detalle det in Ldetalles)
			{
				dgvDetalles.Rows.Add(new object[] { det.Funcion.Pelicula, det.Sala.Id, det.Sala.LisButacas.Count(), det.CalcularTotal()});
			}
		}
		//public double CalcularTotal()
		//{
		//	double total = 0;

		//	foreach (Detalle det in Ldetalles)
		//	{
		//		total += det.CalcularTotal();
		//	}
		//	if (cboDescuentos.SelectedIndex == -1)
		//	{
		//		return total;
		//	}
		//	else
		//	{
		//		if(cboDescuentos.SelectedIndex == 1)
		//		{
		//			//hacer 2x1
		//		}
		//		else if(cboDescuentos.SelectedIndex == 2)
		//		{
		//			double resultado = 0;
		//			int cantidad = l
		//		}
		//	}
		//}
		private void cboDescuentos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

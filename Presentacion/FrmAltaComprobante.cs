using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using LibreriaCine.Clases;
using LibreriaCine.Factory;

namespace ABM_CINE_FINAL.Presentacion
{
	public partial class FrmAltaComprobante : Form
	{
		public List<Detalle> Ldetalles; //Pasar la lista desde el form de butacas
		Servicio servicio = new Servicio();
		public FrmAltaComprobante()
		{
			InitializeComponent();
		}

		//METODOS
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
		
		public int UltimoComprobante()
		{
			return servicio.ObtenerUltimoComprobante();
		}
		
		public void CargarGrilla()
		{
			foreach (Detalle det in Ldetalles)
			{
				dgvDetalles.Rows.Add(new object[] { det.Funcion.Pelicula.Nombre, det.Funcion.Sala.Id, det.Funcion.Sala.LisButacas.Count(), det.CalcularTotal()});
			}
		}
		
		public double TotalSimple()
		{
			double total = 0;
			foreach (Detalle det in Ldetalles)
			{
				total += det.CalcularTotal();
			}
			return total;
		}
		
		public double CalcularTotal()
		{

			double total = 0;
			if (cboDescuentos.SelectedIndex == -1)       //SIN DESCUENTO
			{
				foreach (Detalle det in Ldetalles)
				{
					total += det.CalcularTotal();
				}
			}
			else if (cboDescuentos.SelectedIndex == 0 || cboDescuentos.SelectedIndex == 1
				|| cboDescuentos.SelectedIndex == 5 || cboDescuentos.SelectedIndex == 7)
			{
				foreach (Detalle det in Ldetalles)     //2x1
				{
					int cant = 0;
					cant = det.Funcion.Sala.LisButacas.Count;
					if (cant % 2 == 0)
					{
						total += det.CalcularTotal() /2;
					}
					else
					{
						//MessageBox.Show("No se puede aplicar el descuento, las entradas no son pares");
						total += det.CalcularTotal();
					}
				}
			}
			else if (cboDescuentos.SelectedIndex == 2)       //50%
			{
				double resul;
				foreach (Detalle det in Ldetalles) //1 detalle tiene 1 sala con su precio y la cantidad de entradas
				{
					total += det.CalcularTotal();

				}
				resul = (total * 50) / 100;
				total = total - resul;
			}
			else if (cboDescuentos.SelectedIndex == 3 || cboDescuentos.SelectedIndex == 4 || cboDescuentos.SelectedIndex == 6)
			{
				double resul;
				foreach (Detalle det in Ldetalles)         //20%
				{
					total += det.CalcularTotal();

				}
				resul = (total * 20) / 100;
				total = total - resul;
			}
			return total;
		}
		
		public bool Verificar()
		{
			bool valido = true;
			if (cboFormasPago.SelectedIndex.Equals(-1))
			{
				valido = false;
				MessageBox.Show("Debe seleccionar una forma de pago");
			}
			else if (txtCliente.Text.Equals(string.Empty))
			{
				valido = false;
				MessageBox.Show("Debe ingresar el nombre del cliente");
			}
			return valido;
		}

		//METODOS WEB API


		//EVENTOS
		private void FrmAltaComprobante_Load(object sender, EventArgs e)
		{
			lblComprobanteNro.Text = $"Comprobante Nro: {UltimoComprobante()}";
			CargarCombos(cboFormasPago, 1);
			CargarCombos(cboDescuentos, 5);
			//CargarCombos(cboExtras, 9);
			CargarGrilla();
			lblSubtotal.Text = $"Subtotal $: {TotalSimple()}";
			lblTotal.Text = $"Total $: {CalcularTotal()}";
		}

		private void cboDescuentos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboDescuentos.SelectedIndex != -1)
			{
				lblTotal.Text = $"Total: $ {CalcularTotal()}";
			}
			
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (Verificar())
			{
				DataRowView forma_pago = (DataRowView)cboFormasPago.SelectedItem;
				int id_for_pago = Convert.ToInt32(forma_pago[0]);

				int id_promo;
				if (cboDescuentos.SelectedIndex.Equals(-1))
				{
					id_promo = 0;
				}
				else
				{
					DataRowView promo = (DataRowView)cboDescuentos.SelectedItem;
					id_promo = Convert.ToInt32(promo[0]);
				}
				string cliente = txtCliente.Text;
				DateTime fecha = dtpFecha.Value;
				List<Detalle> Ldet = new List<Detalle>();
				foreach (Detalle detalle in Ldetalles)
				{
					Ldet.Add(detalle);
				}
				//Comprobante comprobante = new Comprobante(id_for_pago, cliente, fecha, Ldet); //???
				Comprobante comprobante = new Comprobante();
				comprobante.Id_forma_pago = id_for_pago;
				comprobante.Cliente = cliente;
				comprobante.Fecha = fecha;
				comprobante.LisDetalles = Ldet;
				if (servicio.AltaComprobante(comprobante))
				{
					MessageBox.Show("Se ha realizado la venta");
				}
				else
				{
					MessageBox.Show("Ha ocurrido un error");
				}
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgvDetalles.CurrentCell.ColumnIndex == 4)
			{
				Ldetalles.RemoveAt(dgvDetalles.CurrentRow.Index);
				dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
				lblTotal.Text = $"Total: $ {CalcularTotal()}";
				lblSubtotal.Text = $"Subtotal: $ {TotalSimple()}";
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCine.Clases;
using LibreriaCine.Factory;

namespace ABM_CINE_FINAL.Presentacion
{
	public partial class FrmElegirButacas : Form
	{
		List<Image> Limagenes = new List<Image>() { Properties.Resources.ButacaIcono64, Properties.Resources.ButacaDisponible64, Properties.Resources.ButacaOcupada64 };
		List<Funcion> LFunciones= new List<Funcion>();//sacar
		List<Detalle> LDetalles = new List<Detalle>();
		Servicio servicio= new Servicio();
		List<Butaca> LButacas = new List<Butaca>();
		List<Butaca> LReserva = new List<Butaca>();
		public FrmElegirButacas()
		{
			InitializeComponent();
		}

		private void A1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void FrmElegirButacas_Load(object sender, EventArgs e)
		{
			CargarCombo(cboPeliculas, servicio.ObtenerFuncionesPeliculas());
			Inicializar();
		}
		public void CargarCombo(ComboBox cbo, DataTable tabla)
		{
			cbo.DataSource= tabla;
			cbo.DisplayMember = tabla.Columns[1].ColumnName;
			cbo.ValueMember = tabla.Columns[0].ColumnName;
			cbo.DropDownStyle = ComboBoxStyle.DropDownList; 
			cbo.SelectedIndex = -1;
		}
		public void CargarLista(int id_funcion)
		{
			DataTable tabla = new DataTable();
			tabla = servicio.ObtenerAsientosOcupadosFuncion(id_funcion);
			foreach (DataRow fila in tabla.Rows)
			{
				Butaca butaca = new Butaca();
				butaca.Id = Convert.ToInt32(fila["ID"]);
				butaca.Nombre = fila["Nombre"].ToString(); 
				butaca.Estado = Convert.ToInt32(fila["Id_Estado"]);

				LButacas.Add(butaca);
			}
		}
		public void Inicializar()
		{
			cboIdiomas.Enabled = false;
			cboHorarios.Enabled = false;
			cboSala.Enabled = false;
			cboFechas.Enabled = false;
			
		}
		public void CargarButacas()
		{
			foreach (Butaca butaca in LButacas)
			{
				foreach (CheckBox boton in panelButacas.Controls.OfType<CheckBox>())
				{
					if(Convert.ToInt32(boton.Tag) == butaca.Id) //&& butaca.Id == 2
					{
						
						boton.Image = Limagenes[2];
						boton.Enabled = false;
					}
				}
			}
		}
		private void AgregarButaca(Butaca butaca) 
		{
			LReserva.Add(butaca);
		}
		private void EliminarButacas(Butaca butaca) 
		{
			for (int i = 0; i < LReserva.Count(); i++)
			{
				if (LReserva[i].Id == butaca.Id)
				{
					LReserva.RemoveAt(i);
				}
			}
		}
		private void cboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboPeliculas.SelectedIndex != -1)
			{
				DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
				int id = Convert.ToInt32(peli["ID"]);
				CargarCombo(cboIdiomas, servicio.ObtenerFuncionesIdiomas(id));
				cboIdiomas.Enabled = true;
			}
		}
		private void cboIdiomas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboIdiomas.SelectedIndex != -1)
			{
				DataRowView idioma = (DataRowView)cboIdiomas.SelectedItem;
				int id_idi = Convert.ToInt32(idioma["ID"]);
				DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
				int id = Convert.ToInt32(peli["ID"]);
				CargarCombo(cboSala, servicio.ObtenerFuncionesSalas(id, id_idi));
				cboSala.Enabled = true;
			}
		}
		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
		}
		
		private void cboFechas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboFechas.SelectedIndex != -1)
			{
				DataRowView fecha = (DataRowView)cboFechas.SelectedItem;
				DateTime fec = Convert.ToDateTime(fecha["Fecha"]);
				DataRowView sala = (DataRowView)cboSala.SelectedItem;
				int id_sala = Convert.ToInt32(sala["ID"]);
				DataRowView idioma = (DataRowView)cboIdiomas.SelectedItem;
				int id_idi = Convert.ToInt32(idioma["ID"]);
				DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
				int id = Convert.ToInt32(peli["ID"]);
				CargarCombo(cboHorarios, servicio.ObtenerFuncionesHorario(id, id_idi, id_sala, fec));
				cboHorarios.Enabled= true;
			}
		}

		private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboSala.SelectedIndex != -1)
			{
				DataRowView sala = (DataRowView)cboSala.SelectedItem;
				int id_sala = Convert.ToInt32(sala["ID"]);
				DataRowView idioma = (DataRowView)cboIdiomas.SelectedItem;
				int id_idi = Convert.ToInt32(idioma["ID"]);
				DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
				int id = Convert.ToInt32(peli["ID"]);

				CargarCombo(cboFechas, servicio.ObtenerFuncionesFecha(id, id_idi, id_sala));
				cboFechas.Enabled = true;
			}
		}
		public bool Verificar()
		{
			bool valido = true;
			if(cboPeliculas.SelectedIndex.Equals(-1))
			{
				valido = false;
				MessageBox.Show("Debe seleccionar una película");
			}
			else if (cboIdiomas.SelectedIndex.Equals(-1))
			{
				valido = false;
				MessageBox.Show("Debe seleccionar un idioma");
			}
			else if (cboSala.SelectedIndex.Equals(-1))
			{
				valido = false;
				MessageBox.Show("Debe seleccionar una sala");
			}
			else if (cboFechas.SelectedIndex.Equals(-1))
			{
				valido = false;
				MessageBox.Show("Debe seleccionar una fecha");
			}
			else if (cboHorarios.SelectedIndex.Equals(-1))
			{
				valido = false;
				MessageBox.Show("Debe seleccionar un horario");
			}
			
			return valido;
		}
		private void btnContinuar_Click(object sender, EventArgs e)
		{
			if (LDetalles.Count > 0)
			{
				FrmAltaComprobante f_a_comprobante = new FrmAltaComprobante();
				f_a_comprobante.Ldetalles = LDetalles; //PASAR LA LISTA DE DETALLES
				f_a_comprobante.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Debe seleccionar al menos una función");
			}
		}

		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			if (Verificar())
			{
				panelButacas.Enabled = true;
				DataRowView hora = (DataRowView)cboHorarios.SelectedItem;
				int id_horario = Convert.ToInt32(hora["ID"]);
				DataRowView fecha = (DataRowView)cboFechas.SelectedItem;
				DateTime fec = Convert.ToDateTime(fecha["Fecha"]);
				DataRowView sala = (DataRowView)cboSala.SelectedItem;
				int id_sala = Convert.ToInt32(sala["ID"]);
				DataRowView idioma = (DataRowView)cboIdiomas.SelectedItem;
				int id_idi = Convert.ToInt32(idioma["ID"]);
				DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
				int id = Convert.ToInt32(peli["ID"]);

				int id_funcion = 0;
				id_funcion = servicio.ObtenerFuncionID(id, id_idi, id_sala, id_horario, fec);

				CargarLista(id_funcion);
				CargarButacas();
			}
		}

		private void Click_Butaca(object sender, EventArgs e)
		{
			CheckBox boton = sender as CheckBox;
			Butaca butaca = new Butaca();
			butaca.Id = Convert.ToInt32(boton.Tag);

			if (boton.Checked)
			{
				boton.Image = Limagenes[1];
				AgregarButaca(butaca);
				lblCantButacas.Text = $"Cantidad de butacas seleccionadas: {CantidadButacas()}";
			}
			
			else
			{
				boton.Image = Limagenes[0];
				EliminarButacas(butaca);
				lblCantButacas.Text = $"Cantidad de butacas seleccionadas: {CantidadButacas()}";
			}
		}
		private void Limpiar_Butacas()
		{
			LButacas.Clear();
			LReserva.Clear();
			foreach (CheckBox cb in panelButacas.Controls.OfType<CheckBox>())
			{
				cb.Image = Limagenes[0];
				cb.Checked = false;
			}
			panelButacas.Enabled = false;
		}
		public string CantidadFunciones()
		{
			string funciones = "";
			foreach (Detalle det in LDetalles)
			{
				funciones += " " + det.Funcion.Pelicula.Nombre + "-";
			}
			return funciones;
		}
		public int CantidadButacas()
		{
			return LReserva.Count;
		}
		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (LReserva.Count > 0)
			{
				DataRowView hora = (DataRowView)cboHorarios.SelectedItem;
				int id_horario = Convert.ToInt32(hora["ID"]);
				DataRowView fecha = (DataRowView)cboFechas.SelectedItem;
				DateTime fec = Convert.ToDateTime(fecha["Fecha"]);
				DataRowView sala = (DataRowView)cboSala.SelectedItem;
				int id_sala = Convert.ToInt32(sala["ID"]);
				double precio = Convert.ToDouble(sala["Precio"]);
				DataRowView idioma = (DataRowView)cboIdiomas.SelectedItem;
				int id_idi = Convert.ToInt32(idioma["ID"]);
				DataRowView peli = (DataRowView)cboPeliculas.SelectedItem;
				int id = Convert.ToInt32(peli["ID"]);
				string nom = peli["Pelicula"].ToString();


				Pelicula pelicula = new Pelicula();

				int id_fun = servicio.ObtenerFuncionID(id, id_idi, id_sala, id_horario, fec);
				pelicula.Nombre = nom;
				List<Butaca> lbut = new List<Butaca>();

				foreach (Butaca b in LReserva)
				{
					lbut.Add(b);
				}
				Sala sal = new Sala(id_sala, precio, lbut);

				Funcion funcion = new Funcion(id_fun, pelicula, sal);
				Detalle detalle = new Detalle();
				detalle.Funcion = funcion;
				LDetalles.Add(detalle);

				Limpiar_Butacas();
				lblCantButacas.Text = $"Cantidad de butacas seleccionadas: {CantidadButacas()}";
				Inicializar();
				CargarCombo(cboPeliculas, servicio.ObtenerFuncionesPeliculas());

				lblCantFunciones.Text = $"Funciones seleccionadas: {CantidadFunciones()}";
			}
			else
			{
				MessageBox.Show("Debe seleccionar al menos una butaca");
			}
		}
	}
}

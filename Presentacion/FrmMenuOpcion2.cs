using ABM_CINE_FINAL.Formularios;
using ABMCine.Formularios;
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
	public partial class FrmMenuOpcion2 : Form
	{
		public FrmMenuOpcion2()
		{
			InitializeComponent();
			PersonalizarDisenio();
		}

		private void FrmMenuOpcion2_Load(object sender, EventArgs e)
		{
			btnSalirFActual.Enabled = false;
		}
		public void PersonalizarDisenio()
		{
			panelSubmenuNuevo.Visible = false;
			panelSubmenuEditar.Visible = false;
			panelSubmenuBaja.Visible = false;
			panelSubmenuReportes.Visible = false;
		}
		public void OcultarSubmenu()
		{
			if(panelSubmenuNuevo.Visible == true)
			{
				panelSubmenuNuevo.Visible = false;
			}
			if(panelSubmenuEditar.Visible == true)
			{
				panelSubmenuEditar.Visible = false;
			}
			if(panelSubmenuBaja.Visible == true)
			{
				panelSubmenuBaja.Visible = false;
			}
			if(panelSubmenuReportes.Visible == true)
			{
				panelSubmenuReportes.Visible = false;
			}
		}
		public void MostrarSubmenu(Panel submenu)
		{
			if(submenu.Visible == false)
			{
				OcultarSubmenu();
				submenu.Visible = true;
			}
			else
			{
				submenu.Visible = false;
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelSubmenuNuevo);
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelSubmenuEditar);
		}

		private void btnComprobante_Click(object sender, EventArgs e)
		{
			//llamar a butacas, despues ir a la creación del comprobante
			AbrirFormularios(new FrmElegirButacas());
			OcultarSubmenu();
		}

		private void btnFuncion_Click(object sender, EventArgs e)
		{
			//FrmAltaFuncion f_a_funcion = new FrmAltaFuncion();
			//f_a_funcion.ShowDialog();
			AbrirFormularios(new FrmAltaFuncion());
			OcultarSubmenu();
		}

		private Form FormularioActivo = null;
		public void AbrirFormularios(Form formularioHijo)
		{
			if (FormularioActivo != null)
			{
				FormularioActivo.Close();
			}
			FormularioActivo = formularioHijo;
			formularioHijo.TopLevel = false;
			formularioHijo.FormBorderStyle = FormBorderStyle.None;
			formularioHijo.Dock = DockStyle.Fill;
			//agregar al panel
			panelContenedor.Controls.Add(formularioHijo);
			panelContenedor.Tag = formularioHijo;
			formularioHijo.BringToFront();
			formularioHijo.Show();
			btnSalirFActual.Enabled = true;
		}

		private void btnPelícula_Click(object sender, EventArgs e)
		{
			AbrirFormularios(new FrmAltaPelicula());
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			//CERRAR EL LOGIN????
			
		}

		private void btnAcciones_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelSubmenuBaja);
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelSubmenuReportes);
		}

		private void btnBajaFuncion_Click(object sender, EventArgs e)
		{
			AbrirFormularios(new FrmBajaAltaFuncion());
		}

		private void btnBajaPelicula_Click(object sender, EventArgs e)
		{
			AbrirFormularios(new FrmAltaBajaPelicula());
		}

		private void btnSalirFActual_Click(object sender, EventArgs e)
		{
			if(FormularioActivo != null)
			{
				FormularioActivo.Close();
				btnSalirFActual.Enabled = false;
			}
			
		}

		private void btnBajaComprobante_Click(object sender, EventArgs e)
		{
			AbrirFormularios(new FrmBajaComprobante());
		}

		private void bntEditarFuncion_Click(object sender, EventArgs e)
		{
			AbrirFormularios(new FrmEditarFuncion());
		}
	}
}

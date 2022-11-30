using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABM_CINE_FINAL.Dominio;
using ABM_CINE_FINAL.Datos;
using ABM_CINE_FINAL.Presentacion;
using System.Windows.Controls;

namespace ABM_CINE_FINAL
{
    public partial class FrmLogin : Form
    {
        Cliente cli;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
			txtPassword.UseSystemPasswordChar = true;
		}
        public bool VerificarCampos()
        {
			
			bool valido = true;
            if (txtDni.Text.Equals(string.Empty))
            {
                valido = false;
                MessageBox.Show("Debe ingresar su DNI");
                txtDni.Focus();
            }
            else if (txtPassword.Text.Equals(string.Empty))
            {
                valido = false;
                MessageBox.Show("Debe ingresar su contraseña");
                txtPassword.Focus();
            }
            return valido;
        }
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (VerificarCampos())
            //{
            //    int dni = Convert.ToInt32(txtDni.Text);
            //    string contra = txtPassword.Text;
            //    cli = new Cliente(dni, contra);

            //    if (HelperDAO.ObtenerInstancia().Login(cli))
            //    {
            //        FrmMenu menu = new FrmMenu();
            //        menu.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Datos incorrectos");
            //    }
            //}
            if(txtDni.Text.Equals("1234") && txtPassword.Text.Equals("1234"))
            {
                //FrmMenu menu = new FrmMenu();
                //menu.Show();
                //this.Hide();
                FrmMenuOpcion2 menu2 = new FrmMenuOpcion2();
                menu2.Show();
                this.Hide();
            }
        }

		private void cbxMostrarPass_CheckedChanged(object sender, EventArgs e)
		{
            if (cbxMostrarPass.Checked)
            {
                cbxMostrarPass.Image = Properties.Resources.OjoAbiertoIcono;
                txtPassword.UseSystemPasswordChar = false;  
            }
            else
            {
                cbxMostrarPass.Image = Properties.Resources.OjoCerradoIcono;
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
            this.Dispose();
		}
	}
}

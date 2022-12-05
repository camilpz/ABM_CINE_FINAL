﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABM_CINE_FINAL.Presentacion;
using System.Windows.Controls;
using LibreriaCine.Clases;
using ABM_CINE_FINAL.CliSingleton;
using Newtonsoft.Json;

namespace ABM_CINE_FINAL
{
    public partial class FrmLogin : Form
    {
        Cliente cli;
        public static FrmMenuOpcion2 menu2 = new FrmMenuOpcion2();
        public FrmLogin()
        {
            InitializeComponent();
        }

        //METODOS
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

        //METODOS API

        public async Task<Cliente> Cargar_Cliente(Cliente c)
        {
            string datosJson = JsonConvert.SerializeObject(c);
            string url = "";    //NECESITO QUE FUNCIONE EL WEB API PARA CONSEGUIR LAS URL
            var data = await ClienteSingleton.Nuevo().PostAsync(url, datosJson);
            
            return JsonConvert.DeserializeObject<Cliente>(data);
        }

        //EVENTOS
        private void FrmLogin_Load(object sender, EventArgs e)
        {
			txtPassword.UseSystemPasswordChar = true;
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
            
            
            if (txtDni.Text.Equals("1234") && txtPassword.Text.Equals("1234"))
            {
                
                menu2.Closed += (s, args) => this.Close();
                this.Hide();
                menu2.Show();
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

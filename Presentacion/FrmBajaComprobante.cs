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

namespace ABM_CINE_FINAL.Formularios
{
    public partial class FrmBajaComprobante : Form
    {
        Servicio servicio = new Servicio();
        public FrmBajaComprobante()
        {
            InitializeComponent();
        }

        private void FrmBajaComprobante_Load(object sender, EventArgs e)
        {

        }
        public void CargarGrilla(int dni)
        {
            DataTable tabla = new DataTable();
            tabla = servicio.FiltrarComprobanteDni(dni);

            foreach (DataRow fila in tabla.Rows)
            {
                dgvComprobantes.Rows.Add(new object[] { fila["ID"], fila["FormaPago"], fila["Cliente"], fila["Fecha"] });
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar un DNI válido");
                txtDni.Text = string.Empty;
            }
            //else if (System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text, "  ^ [0-9]")) //Verificar que solo sean nros???
            //{
            //    txtDni.Text = "";
            //}
            else
            {
                try //comprobar que solo ingresen nros
                {
					CargarGrilla(Convert.ToInt32(txtDni.Text));
				}
                catch
                {
                    MessageBox.Show("Debe ingresar sólo números");
                }
                
            }
        }

        private void dgvComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvComprobantes.CurrentCell.ColumnIndex == 4)
            { 
            
                if (servicio.BajaComprobante(Convert.ToInt32(dgvComprobantes.CurrentRow.Cells["colID"].Value)))
                {
                    dgvComprobantes.Rows.RemoveAt(dgvComprobantes.CurrentRow.Index);
                    MessageBox.Show("Se ha dado de baja con éxito");
                    
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

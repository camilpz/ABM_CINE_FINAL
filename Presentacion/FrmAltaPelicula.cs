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
using ABM_CINE_FINAL.Servicios;

namespace ABMCine.Formularios
{
    public partial class FrmAltaPelicula : Form
    {
        Pelicula peli= new Pelicula();
        Servicios servicio = new Servicios();
        
        public FrmAltaPelicula()
        {
            InitializeComponent();
        }

        private void FrmAltaPelicula_Load(object sender, EventArgs e)
        {
            CargarCombo(cboClasificacion, 4);
            CargarCombo(cboGeneros, 3);
            CargarCombo(cboIdiomas, 2);
        }
        public void CargarCombo(ComboBox cbo, int nro_tabla)
        {
            DataTable tabla = new DataTable();
            tabla = servicio.ObtenerTablasAux(nro_tabla);
            cbo.DataSource = tabla;
            cbo.DisplayMember = tabla.Columns[1].ColumnName;
            cbo.ValueMember = tabla.Columns[0].ColumnName;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Limpiar()
        {
            txtNombre.Text = String.Empty;
            txtDuracion.Text = String.Empty;
            cboClasificacion.SelectedIndex = -1;
            cboGeneros.SelectedIndex = -1;
            cboIdiomas.SelectedIndex = -1;
            dgvGeneros.Rows.Clear();
            dgvIdiomas.Rows.Clear();
        }
        public bool Existe(DataGridView dgv,int indice, string col)
        {
            bool existe = false;
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if(fila.Cells[col].Value.Equals(indice))
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }
        public bool ComprobarCampos()
        {
            bool valido = true;

            if (txtNombre.Text.Equals(string.Empty))
            {
                valido = false;
                MessageBox.Show("Debe ingresar un nombre");
                txtNombre.Focus();
            }
            else if (txtDuracion.Text.Equals(string.Empty)) //modificar
            {
                valido = false;
                MessageBox.Show("Debe ingresar una duración");
                txtDuracion.Focus();
            }
            else if (cboClasificacion.SelectedIndex == -1)
            {
                valido = false;
                MessageBox.Show("Debe seleccionar un clasificación");
                cboClasificacion.Focus();
            } 
            else if (dgvGeneros.Rows.Count == 0)
            {
                valido = false;
                MessageBox.Show("Debe elegir al menos 1 género");
            }
            else if(dgvIdiomas.Rows.Count == 0)
            {
                valido = false;
                MessageBox.Show("Debe elegir al menos 1 idioma");
            }
            return valido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos()) 
            {
                
                Clasificacion clas = new Clasificacion();
                peli.Nombre = txtNombre.Text;
                peli.Duracion = Convert.ToInt32(txtDuracion.Text);
                clas.Id = Convert.ToInt32(cboClasificacion.SelectedValue);
                peli.Clasificacion = clas;


                if (servicio.AltaPelicula(peli))
                {
                    MessageBox.Show("Se ha agregado la pelicula con éxito");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnAgregarGen_Click(object sender, EventArgs e)
        {
            if (cboGeneros.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un género");
                cboGeneros.Focus();
            }
            else
            {
                
                DataRowView fila = (DataRowView)cboGeneros.SelectedItem;
                if (!Existe(dgvGeneros, Convert.ToInt32(fila["id_genero"]), "colIDG"))
                {
                    Genero genero = new Genero();
                    genero.Id = Convert.ToInt32(fila["id_genero"]);
                    genero.Nombre = fila["genero"].ToString();

                    peli.AgregarGenero(genero);

                    dgvGeneros.Rows.Add(new object[] { genero.Id, genero.Nombre });
                }
                else
                {
                    MessageBox.Show("Ya ha seleccionado este género");
                }
                
            }
        }

        private void btnAgregarIdi_Click(object sender, EventArgs e)
        {
            if (cboIdiomas.SelectedIndex == -1)
            {
                
                MessageBox.Show("Debe seleccionar un idioma");
                cboIdiomas.Focus();
            }
            else
            {
                DataRowView fila = (DataRowView)cboIdiomas.SelectedItem;
                if (!Existe(dgvIdiomas, Convert.ToInt32(fila["id_idioma"]), "colID"))
                {
                    Idioma idi = new Idioma();
                    idi.Id = Convert.ToInt32(fila["id_idioma"]);
                    idi.Nombre = fila["idioma"].ToString();

                    peli.AgregarIdioma(idi);

                    dgvIdiomas.Rows.Add(new object[] { idi.Id, idi.Nombre });
                }
                else
                {
                    MessageBox.Show("Ya ha seleccionado este idioma");
                }
                
            }
        }

        private void dgvIdiomas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvIdiomas.CurrentCell.ColumnIndex == 2)
            {
                peli.QuitarIdioma(dgvIdiomas.CurrentRow.Index);
                dgvIdiomas.Rows.RemoveAt(dgvIdiomas.CurrentRow.Index);
                
            }
        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvGeneros.CurrentCell.ColumnIndex == 2)
            {
                peli.QuitarGenero(dgvGeneros.CurrentRow.Index);
                dgvGeneros.Rows.RemoveAt(dgvGeneros.CurrentRow.Index);
                
            }
        }
    }
}

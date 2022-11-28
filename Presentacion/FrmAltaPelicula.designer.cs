namespace ABMCine.Formularios
{
    partial class FrmAltaPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.cboIdiomas = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvIdiomas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.btnAgregarGen = new System.Windows.Forms.Button();
            this.btnAgregarIdi = new System.Windows.Forms.Button();
            this.colIDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccionesG = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(129, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(110, 143);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(86, 16);
            this.lblClasificacion.TabIndex = 1;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(137, 211);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(55, 16);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Género:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(137, 266);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(51, 16);
            this.lblIdioma.TabIndex = 3;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(33, 321);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(159, 16);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración (EN MINUTOS):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(233, 315);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(224, 22);
            this.txtDuracion.TabIndex = 6;
            this.txtDuracion.TextChanged += new System.EventHandler(this.txtDuracion_TextChanged);
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(233, 143);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(224, 24);
            this.cboClasificacion.TabIndex = 1;
            // 
            // cboGeneros
            // 
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(233, 211);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(224, 24);
            this.cboGeneros.TabIndex = 2;
            // 
            // cboIdiomas
            // 
            this.cboIdiomas.FormattingEnabled = true;
            this.cboIdiomas.Location = new System.Drawing.Point(233, 266);
            this.cboIdiomas.Name = "cboIdiomas";
            this.cboIdiomas.Size = new System.Drawing.Size(224, 24);
            this.cboIdiomas.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(293, 397);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(392, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvIdiomas
            // 
            this.dgvIdiomas.AllowUserToAddRows = false;
            this.dgvIdiomas.AllowUserToDeleteRows = false;
            this.dgvIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdiomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIdioma,
            this.colAcciones});
            this.dgvIdiomas.Location = new System.Drawing.Point(635, 68);
            this.dgvIdiomas.Name = "dgvIdiomas";
            this.dgvIdiomas.ReadOnly = true;
            this.dgvIdiomas.RowHeadersWidth = 51;
            this.dgvIdiomas.RowTemplate.Height = 24;
            this.dgvIdiomas.Size = new System.Drawing.Size(302, 150);
            this.dgvIdiomas.TabIndex = 13;
            this.dgvIdiomas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdiomas_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 125;
            // 
            // colIdioma
            // 
            this.colIdioma.HeaderText = "Idioma";
            this.colIdioma.MinimumWidth = 6;
            this.colIdioma.Name = "colIdioma";
            this.colIdioma.ReadOnly = true;
            this.colIdioma.Width = 125;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.MinimumWidth = 6;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Width = 125;
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.AllowUserToAddRows = false;
            this.dgvGeneros.AllowUserToDeleteRows = false;
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDG,
            this.colGenero,
            this.colAccionesG});
            this.dgvGeneros.Location = new System.Drawing.Point(635, 224);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.ReadOnly = true;
            this.dgvGeneros.RowHeadersWidth = 51;
            this.dgvGeneros.RowTemplate.Height = 24;
            this.dgvGeneros.Size = new System.Drawing.Size(302, 150);
            this.dgvGeneros.TabIndex = 14;
            this.dgvGeneros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneros_CellContentClick);
            // 
            // btnAgregarGen
            // 
            this.btnAgregarGen.Location = new System.Drawing.Point(477, 212);
            this.btnAgregarGen.Name = "btnAgregarGen";
            this.btnAgregarGen.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarGen.TabIndex = 3;
            this.btnAgregarGen.Text = "Agregar";
            this.btnAgregarGen.UseVisualStyleBackColor = true;
            this.btnAgregarGen.Click += new System.EventHandler(this.btnAgregarGen_Click);
            // 
            // btnAgregarIdi
            // 
            this.btnAgregarIdi.Location = new System.Drawing.Point(477, 267);
            this.btnAgregarIdi.Name = "btnAgregarIdi";
            this.btnAgregarIdi.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIdi.TabIndex = 5;
            this.btnAgregarIdi.Text = "Agregar";
            this.btnAgregarIdi.UseVisualStyleBackColor = true;
            this.btnAgregarIdi.Click += new System.EventHandler(this.btnAgregarIdi_Click);
            // 
            // colIDG
            // 
            this.colIDG.HeaderText = "ID";
            this.colIDG.MinimumWidth = 6;
            this.colIDG.Name = "colIDG";
            this.colIDG.ReadOnly = true;
            this.colIDG.Visible = false;
            this.colIDG.Width = 125;
            // 
            // colGenero
            // 
            this.colGenero.HeaderText = "Género";
            this.colGenero.MinimumWidth = 6;
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Width = 125;
            // 
            // colAccionesG
            // 
            this.colAccionesG.HeaderText = "Acciones";
            this.colAccionesG.MinimumWidth = 6;
            this.colAccionesG.Name = "colAccionesG";
            this.colAccionesG.ReadOnly = true;
            this.colAccionesG.Width = 125;
            // 
            // FrmAltaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.btnAgregarIdi);
            this.Controls.Add(this.btnAgregarGen);
            this.Controls.Add(this.dgvGeneros);
            this.Controls.Add(this.dgvIdiomas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboIdiomas);
            this.Controls.Add(this.cboGeneros);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAltaPelicula";
            this.Text = "FrmAltaPelicula";
            this.Load += new System.EventHandler(this.FrmAltaPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.ComboBox cboIdiomas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvIdiomas;
        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.Button btnAgregarGen;
        private System.Windows.Forms.Button btnAgregarIdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdioma;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewButtonColumn colAccionesG;
    }
}
namespace ABM_CINE_FINAL.Presentacion
{
    partial class FrmBajaAltaFuncion
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
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbtAlta = new System.Windows.Forms.RadioButton();
            this.rbtBaja = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPelicula,
            this.colIdioma,
            this.colSala,
            this.colFecha,
            this.colHorario,
            this.colAcciones});
            this.dgvFunciones.Location = new System.Drawing.Point(69, 101);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersWidth = 51;
            this.dgvFunciones.RowTemplate.Height = 24;
            this.dgvFunciones.Size = new System.Drawing.Size(780, 300);
            this.dgvFunciones.TabIndex = 0;
            this.dgvFunciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellContentClick);
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
            // colPelicula
            // 
            this.colPelicula.HeaderText = "Pelicula";
            this.colPelicula.MinimumWidth = 6;
            this.colPelicula.Name = "colPelicula";
            this.colPelicula.ReadOnly = true;
            this.colPelicula.Width = 125;
            // 
            // colIdioma
            // 
            this.colIdioma.HeaderText = "Idioma";
            this.colIdioma.MinimumWidth = 6;
            this.colIdioma.Name = "colIdioma";
            this.colIdioma.ReadOnly = true;
            this.colIdioma.Width = 125;
            // 
            // colSala
            // 
            this.colSala.HeaderText = "Sala";
            this.colSala.MinimumWidth = 6;
            this.colSala.Name = "colSala";
            this.colSala.ReadOnly = true;
            this.colSala.Width = 125;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 125;
            // 
            // colHorario
            // 
            this.colHorario.HeaderText = "Horario";
            this.colHorario.MinimumWidth = 6;
            this.colHorario.Name = "colHorario";
            this.colHorario.ReadOnly = true;
            this.colHorario.Width = 125;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.MinimumWidth = 6;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Width = 125;
            // 
            // rbtAlta
            // 
            this.rbtAlta.AutoSize = true;
            this.rbtAlta.Location = new System.Drawing.Point(156, 47);
            this.rbtAlta.Name = "rbtAlta";
            this.rbtAlta.Size = new System.Drawing.Size(51, 20);
            this.rbtAlta.TabIndex = 1;
            this.rbtAlta.TabStop = true;
            this.rbtAlta.Text = "Alta";
            this.rbtAlta.UseVisualStyleBackColor = true;
            this.rbtAlta.CheckedChanged += new System.EventHandler(this.rbtAlta_CheckedChanged);
            // 
            // rbtBaja
            // 
            this.rbtBaja.AutoSize = true;
            this.rbtBaja.Location = new System.Drawing.Point(238, 47);
            this.rbtBaja.Name = "rbtBaja";
            this.rbtBaja.Size = new System.Drawing.Size(56, 20);
            this.rbtBaja.TabIndex = 2;
            this.rbtBaja.TabStop = true;
            this.rbtBaja.Text = "Baja";
            this.rbtBaja.UseVisualStyleBackColor = true;
            this.rbtBaja.CheckedChanged += new System.EventHandler(this.rbtBaja_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(66, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado:";
            // 
            // FrmBajaAltaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.rbtBaja);
            this.Controls.Add(this.rbtAlta);
            this.Controls.Add(this.dgvFunciones);
            this.Name = "FrmBajaAltaFuncion";
            this.Text = "FrmBajaAltaFuncion";
            this.Load += new System.EventHandler(this.FrmBajaAltaFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorario;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.RadioButton rbtAlta;
        private System.Windows.Forms.RadioButton rbtBaja;
        private System.Windows.Forms.Label lblEstado;
    }
}
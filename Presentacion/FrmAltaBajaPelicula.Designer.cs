namespace ABM_CINE_FINAL.Presentacion
{
    partial class FrmAltaBajaPelicula
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
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.lblFiltrar = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.rbtActiva = new System.Windows.Forms.RadioButton();
			this.rbtInactiva = new System.Windows.Forms.RadioButton();
			this.dgvPeliculas = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnFiltrar.FlatAppearance.BorderSize = 0;
			this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnFiltrar.Location = new System.Drawing.Point(683, 81);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(79, 27);
			this.btnFiltrar.TabIndex = 0;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = false;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// lblFiltrar
			// 
			this.lblFiltrar.AutoSize = true;
			this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblFiltrar.Location = new System.Drawing.Point(162, 81);
			this.lblFiltrar.Name = "lblFiltrar";
			this.lblFiltrar.Size = new System.Drawing.Size(151, 20);
			this.lblFiltrar.TabIndex = 1;
			this.lblFiltrar.Text = "Filtrar por Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(336, 79);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(309, 22);
			this.txtNombre.TabIndex = 2;
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEstado.Location = new System.Drawing.Point(247, 131);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(66, 20);
			this.lblEstado.TabIndex = 3;
			this.lblEstado.Text = "Estado:";
			// 
			// rbtActiva
			// 
			this.rbtActiva.AutoSize = true;
			this.rbtActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtActiva.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.rbtActiva.Location = new System.Drawing.Point(336, 127);
			this.rbtActiva.Name = "rbtActiva";
			this.rbtActiva.Size = new System.Drawing.Size(76, 24);
			this.rbtActiva.TabIndex = 4;
			this.rbtActiva.TabStop = true;
			this.rbtActiva.Text = "Activa";
			this.rbtActiva.UseVisualStyleBackColor = true;
			// 
			// rbtInactiva
			// 
			this.rbtInactiva.AutoSize = true;
			this.rbtInactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtInactiva.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.rbtInactiva.Location = new System.Drawing.Point(422, 127);
			this.rbtInactiva.Name = "rbtInactiva";
			this.rbtInactiva.Size = new System.Drawing.Size(87, 24);
			this.rbtInactiva.TabIndex = 5;
			this.rbtInactiva.TabStop = true;
			this.rbtInactiva.Text = "Inactiva";
			this.rbtInactiva.UseVisualStyleBackColor = true;
			// 
			// dgvPeliculas
			// 
			this.dgvPeliculas.AllowUserToAddRows = false;
			this.dgvPeliculas.AllowUserToDeleteRows = false;
			this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colPelicula,
            this.colClasificacion,
            this.colDuracion,
            this.colAcciones});
			this.dgvPeliculas.Location = new System.Drawing.Point(105, 188);
			this.dgvPeliculas.Name = "dgvPeliculas";
			this.dgvPeliculas.ReadOnly = true;
			this.dgvPeliculas.RowHeadersWidth = 51;
			this.dgvPeliculas.RowTemplate.Height = 24;
			this.dgvPeliculas.Size = new System.Drawing.Size(733, 267);
			this.dgvPeliculas.TabIndex = 6;
			this.dgvPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellContentClick);
			// 
			// colId
			// 
			this.colId.HeaderText = "ID";
			this.colId.MinimumWidth = 6;
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			this.colId.Visible = false;
			this.colId.Width = 125;
			// 
			// colPelicula
			// 
			this.colPelicula.HeaderText = "Pelicula";
			this.colPelicula.MinimumWidth = 6;
			this.colPelicula.Name = "colPelicula";
			this.colPelicula.ReadOnly = true;
			this.colPelicula.Width = 125;
			// 
			// colClasificacion
			// 
			this.colClasificacion.HeaderText = "Clasificación";
			this.colClasificacion.MinimumWidth = 6;
			this.colClasificacion.Name = "colClasificacion";
			this.colClasificacion.ReadOnly = true;
			this.colClasificacion.Width = 125;
			// 
			// colDuracion
			// 
			this.colDuracion.HeaderText = "Duración";
			this.colDuracion.MinimumWidth = 6;
			this.colDuracion.Name = "colDuracion";
			this.colDuracion.ReadOnly = true;
			this.colDuracion.Width = 125;
			// 
			// colAcciones
			// 
			this.colAcciones.HeaderText = "Acciones";
			this.colAcciones.MinimumWidth = 6;
			this.colAcciones.Name = "colAcciones";
			this.colAcciones.ReadOnly = true;
			this.colAcciones.Width = 125;
			// 
			// FrmAltaBajaPelicula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(929, 537);
			this.Controls.Add(this.dgvPeliculas);
			this.Controls.Add(this.rbtInactiva);
			this.Controls.Add(this.rbtActiva);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblFiltrar);
			this.Controls.Add(this.btnFiltrar);
			this.Name = "FrmAltaBajaPelicula";
			this.Text = "FrmAltaBajaPelicula";
			this.Load += new System.EventHandler(this.FrmAltaBajaPelicula_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rbtActiva;
        private System.Windows.Forms.RadioButton rbtInactiva;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}
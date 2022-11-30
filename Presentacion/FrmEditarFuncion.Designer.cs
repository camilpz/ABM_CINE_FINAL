namespace ABM_CINE_FINAL.Presentacion
{
	partial class FrmEditarFuncion
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
			this.colHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cboSala = new System.Windows.Forms.ComboBox();
			this.cboHorario = new System.Windows.Forms.ComboBox();
			this.lblSala = new System.Windows.Forms.Label();
			this.lblHorario = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.btnGuardarCambios = new System.Windows.Forms.Button();
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
            this.colHorario});
			this.dgvFunciones.Location = new System.Drawing.Point(83, 208);
			this.dgvFunciones.Name = "dgvFunciones";
			this.dgvFunciones.ReadOnly = true;
			this.dgvFunciones.RowHeadersWidth = 51;
			this.dgvFunciones.RowTemplate.Height = 24;
			this.dgvFunciones.Size = new System.Drawing.Size(766, 281);
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
			this.colPelicula.HeaderText = "Película";
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
			// colHorario
			// 
			this.colHorario.HeaderText = "Horario";
			this.colHorario.MinimumWidth = 6;
			this.colHorario.Name = "colHorario";
			this.colHorario.ReadOnly = true;
			this.colHorario.Width = 125;
			// 
			// cboSala
			// 
			this.cboSala.FormattingEnabled = true;
			this.cboSala.Location = new System.Drawing.Point(202, 93);
			this.cboSala.Name = "cboSala";
			this.cboSala.Size = new System.Drawing.Size(300, 24);
			this.cboSala.TabIndex = 1;
			// 
			// cboHorario
			// 
			this.cboHorario.FormattingEnabled = true;
			this.cboHorario.Location = new System.Drawing.Point(202, 143);
			this.cboHorario.Name = "cboHorario";
			this.cboHorario.Size = new System.Drawing.Size(300, 24);
			this.cboHorario.TabIndex = 2;
			// 
			// lblSala
			// 
			this.lblSala.AutoSize = true;
			this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSala.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblSala.Location = new System.Drawing.Point(120, 101);
			this.lblSala.Name = "lblSala";
			this.lblSala.Size = new System.Drawing.Size(47, 20);
			this.lblSala.TabIndex = 3;
			this.lblSala.Text = "Sala:";
			// 
			// lblHorario
			// 
			this.lblHorario.AutoSize = true;
			this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblHorario.Location = new System.Drawing.Point(103, 151);
			this.lblHorario.Name = "lblHorario";
			this.lblHorario.Size = new System.Drawing.Size(70, 20);
			this.lblHorario.TabIndex = 4;
			this.lblHorario.Text = "Horario:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblFecha.Location = new System.Drawing.Point(549, 97);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(60, 20);
			this.lblFecha.TabIndex = 5;
			this.lblFecha.Text = "Fecha:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(626, 95);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 22);
			this.dtpFecha.TabIndex = 6;
			// 
			// btnGuardarCambios
			// 
			this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
			this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnGuardarCambios.Location = new System.Drawing.Point(718, 521);
			this.btnGuardarCambios.Name = "btnGuardarCambios";
			this.btnGuardarCambios.Size = new System.Drawing.Size(131, 29);
			this.btnGuardarCambios.TabIndex = 7;
			this.btnGuardarCambios.Text = "Guardar Cambios";
			this.btnGuardarCambios.UseVisualStyleBackColor = false;
			this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
			// 
			// FrmEditarFuncion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(929, 589);
			this.Controls.Add(this.btnGuardarCambios);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblHorario);
			this.Controls.Add(this.lblSala);
			this.Controls.Add(this.cboHorario);
			this.Controls.Add(this.cboSala);
			this.Controls.Add(this.dgvFunciones);
			this.Name = "FrmEditarFuncion";
			this.Text = "FrmEditarFuncion";
			this.Load += new System.EventHandler(this.FrmEditarFuncion_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFunciones;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPelicula;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdioma;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHorario;
		private System.Windows.Forms.ComboBox cboSala;
		private System.Windows.Forms.ComboBox cboHorario;
		private System.Windows.Forms.Label lblSala;
		private System.Windows.Forms.Label lblHorario;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button btnGuardarCambios;
	}
}
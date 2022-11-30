﻿namespace ABM_CINE_FINAL.Presentacion
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
			this.cboSala = new System.Windows.Forms.ComboBox();
			this.cboHorario = new System.Windows.Forms.ComboBox();
			this.lblSala = new System.Windows.Forms.Label();
			this.lblHorario = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.dgvFunciones.Location = new System.Drawing.Point(97, 242);
			this.dgvFunciones.Name = "dgvFunciones";
			this.dgvFunciones.ReadOnly = true;
			this.dgvFunciones.RowHeadersWidth = 51;
			this.dgvFunciones.RowTemplate.Height = 24;
			this.dgvFunciones.Size = new System.Drawing.Size(599, 281);
			this.dgvFunciones.TabIndex = 0;
			// 
			// cboSala
			// 
			this.cboSala.FormattingEnabled = true;
			this.cboSala.Location = new System.Drawing.Point(223, 74);
			this.cboSala.Name = "cboSala";
			this.cboSala.Size = new System.Drawing.Size(300, 24);
			this.cboSala.TabIndex = 1;
			// 
			// cboHorario
			// 
			this.cboHorario.FormattingEnabled = true;
			this.cboHorario.Location = new System.Drawing.Point(223, 124);
			this.cboHorario.Name = "cboHorario";
			this.cboHorario.Size = new System.Drawing.Size(300, 24);
			this.cboHorario.TabIndex = 2;
			// 
			// lblSala
			// 
			this.lblSala.AutoSize = true;
			this.lblSala.Location = new System.Drawing.Point(141, 82);
			this.lblSala.Name = "lblSala";
			this.lblSala.Size = new System.Drawing.Size(38, 16);
			this.lblSala.TabIndex = 3;
			this.lblSala.Text = "Sala:";
			// 
			// lblHorario
			// 
			this.lblHorario.AutoSize = true;
			this.lblHorario.Location = new System.Drawing.Point(124, 132);
			this.lblHorario.Name = "lblHorario";
			this.lblHorario.Size = new System.Drawing.Size(55, 16);
			this.lblHorario.TabIndex = 4;
			this.lblHorario.Text = "Horario:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(131, 181);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(48, 16);
			this.lblFecha.TabIndex = 5;
			this.lblFecha.Text = "Fecha:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(223, 175);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 22);
			this.dtpFecha.TabIndex = 6;
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
			// FrmEditarFuncion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 589);
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
	}
}
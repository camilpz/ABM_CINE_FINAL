namespace ABM_CINE_FINAL.Formularios
{
	partial class FrmBajaComprobante
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
			this.dgvComprobantes = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.btnFiltrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvComprobantes
			// 
			this.dgvComprobantes.AllowUserToAddRows = false;
			this.dgvComprobantes.AllowUserToDeleteRows = false;
			this.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFormaPago,
            this.colCliente,
            this.colFecha,
            this.colAcciones});
			this.dgvComprobantes.Location = new System.Drawing.Point(63, 97);
			this.dgvComprobantes.Name = "dgvComprobantes";
			this.dgvComprobantes.ReadOnly = true;
			this.dgvComprobantes.RowHeadersWidth = 51;
			this.dgvComprobantes.RowTemplate.Height = 24;
			this.dgvComprobantes.Size = new System.Drawing.Size(652, 296);
			this.dgvComprobantes.TabIndex = 0;
			this.dgvComprobantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobantes_CellContentClick);
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
			// colFormaPago
			// 
			this.colFormaPago.HeaderText = "Forma de Pago";
			this.colFormaPago.MinimumWidth = 6;
			this.colFormaPago.Name = "colFormaPago";
			this.colFormaPago.ReadOnly = true;
			this.colFormaPago.Width = 125;
			// 
			// colCliente
			// 
			this.colCliente.HeaderText = "Cliente";
			this.colCliente.MinimumWidth = 6;
			this.colCliente.Name = "colCliente";
			this.colCliente.ReadOnly = true;
			this.colCliente.Width = 125;
			// 
			// colFecha
			// 
			this.colFecha.HeaderText = "Fecha";
			this.colFecha.MinimumWidth = 6;
			this.colFecha.Name = "colFecha";
			this.colFecha.ReadOnly = true;
			this.colFecha.Width = 125;
			// 
			// colAcciones
			// 
			this.colAcciones.HeaderText = "Acciones";
			this.colAcciones.MinimumWidth = 6;
			this.colAcciones.Name = "colAcciones";
			this.colAcciones.ReadOnly = true;
			this.colAcciones.Text = "Dar de Baja";
			this.colAcciones.UseColumnTextForButtonValue = true;
			this.colAcciones.Width = 125;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnAceptar.Location = new System.Drawing.Point(625, 425);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(90, 34);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(108, 49);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(212, 22);
			this.txtDni.TabIndex = 2;
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltro.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblFiltro.Location = new System.Drawing.Point(60, 52);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(43, 20);
			this.lblFiltro.TabIndex = 3;
			this.lblFiltro.Text = "DNI:";
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnFiltrar.FlatAppearance.BorderSize = 0;
			this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnFiltrar.Location = new System.Drawing.Point(360, 44);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(103, 28);
			this.btnFiltrar.TabIndex = 4;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = false;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// FrmBajaComprobante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(805, 487);
			this.Controls.Add(this.btnFiltrar);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.dgvComprobantes);
			this.Name = "FrmBajaComprobante";
			this.Text = "FrmBajaComprobante";
			this.Load += new System.EventHandler(this.FrmBajaComprobante_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvComprobantes;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFormaPago;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
		private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
	}
}
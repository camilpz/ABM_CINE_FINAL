namespace ABM_CINE_FINAL.Presentacion
{
	partial class FrmAltaComprobante
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
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.dgvDetalles = new System.Windows.Forms.DataGridView();
			this.colFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCantAsientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblFormaPago = new System.Windows.Forms.Label();
			this.cboFormasPago = new System.Windows.Forms.ComboBox();
			this.cboDescuentos = new System.Windows.Forms.ComboBox();
			this.lblComprobanteNro = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(115, 116);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(48, 16);
			this.lblFecha.TabIndex = 2;
			this.lblFecha.Text = "Fecha:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Enabled = false;
			this.dtpFecha.Location = new System.Drawing.Point(185, 119);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(224, 22);
			this.dtpFecha.TabIndex = 3;
			// 
			// dgvDetalles
			// 
			this.dgvDetalles.AllowUserToAddRows = false;
			this.dgvDetalles.AllowUserToDeleteRows = false;
			this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFuncion,
            this.colSala,
            this.colCantAsientos,
            this.colSubtotal,
            this.colAcciones});
			this.dgvDetalles.Location = new System.Drawing.Point(56, 208);
			this.dgvDetalles.Name = "dgvDetalles";
			this.dgvDetalles.ReadOnly = true;
			this.dgvDetalles.RowHeadersWidth = 51;
			this.dgvDetalles.RowTemplate.Height = 24;
			this.dgvDetalles.Size = new System.Drawing.Size(831, 260);
			this.dgvDetalles.TabIndex = 5;
			this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
			// 
			// colFuncion
			// 
			this.colFuncion.HeaderText = "Función";
			this.colFuncion.MinimumWidth = 6;
			this.colFuncion.Name = "colFuncion";
			this.colFuncion.ReadOnly = true;
			this.colFuncion.Width = 125;
			// 
			// colSala
			// 
			this.colSala.HeaderText = "Sala";
			this.colSala.MinimumWidth = 6;
			this.colSala.Name = "colSala";
			this.colSala.ReadOnly = true;
			this.colSala.Width = 125;
			// 
			// colCantAsientos
			// 
			this.colCantAsientos.HeaderText = "Cantidad de Asientos";
			this.colCantAsientos.MinimumWidth = 6;
			this.colCantAsientos.Name = "colCantAsientos";
			this.colCantAsientos.ReadOnly = true;
			this.colCantAsientos.Width = 125;
			// 
			// colSubtotal
			// 
			this.colSubtotal.HeaderText = "Subtotal";
			this.colSubtotal.MinimumWidth = 6;
			this.colSubtotal.Name = "colSubtotal";
			this.colSubtotal.ReadOnly = true;
			this.colSubtotal.Width = 125;
			// 
			// colAcciones
			// 
			this.colAcciones.HeaderText = "Acciones";
			this.colAcciones.MinimumWidth = 6;
			this.colAcciones.Name = "colAcciones";
			this.colAcciones.ReadOnly = true;
			this.colAcciones.Width = 125;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblTotal.Location = new System.Drawing.Point(727, 533);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(63, 20);
			this.lblTotal.TabIndex = 10;
			this.lblTotal.Text = "Total: $";
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnAceptar.Location = new System.Drawing.Point(344, 531);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(106, 33);
			this.btnAceptar.TabIndex = 11;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnCancelar.Location = new System.Drawing.Point(465, 533);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(106, 33);
			this.btnCancelar.TabIndex = 12;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// lblFormaPago
			// 
			this.lblFormaPago.AutoSize = true;
			this.lblFormaPago.Location = new System.Drawing.Point(59, 158);
			this.lblFormaPago.Name = "lblFormaPago";
			this.lblFormaPago.Size = new System.Drawing.Size(104, 16);
			this.lblFormaPago.TabIndex = 13;
			this.lblFormaPago.Text = "Forma de Pago:";
			// 
			// cboFormasPago
			// 
			this.cboFormasPago.FormattingEnabled = true;
			this.cboFormasPago.Location = new System.Drawing.Point(185, 158);
			this.cboFormasPago.Name = "cboFormasPago";
			this.cboFormasPago.Size = new System.Drawing.Size(222, 24);
			this.cboFormasPago.TabIndex = 14;
			// 
			// cboDescuentos
			// 
			this.cboDescuentos.FormattingEnabled = true;
			this.cboDescuentos.Location = new System.Drawing.Point(568, 71);
			this.cboDescuentos.Name = "cboDescuentos";
			this.cboDescuentos.Size = new System.Drawing.Size(188, 24);
			this.cboDescuentos.TabIndex = 15;
			this.cboDescuentos.SelectedIndexChanged += new System.EventHandler(this.cboDescuentos_SelectedIndexChanged);
			// 
			// lblComprobanteNro
			// 
			this.lblComprobanteNro.AutoSize = true;
			this.lblComprobanteNro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComprobanteNro.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblComprobanteNro.Location = new System.Drawing.Point(138, 28);
			this.lblComprobanteNro.Name = "lblComprobanteNro";
			this.lblComprobanteNro.Size = new System.Drawing.Size(199, 27);
			this.lblComprobanteNro.TabIndex = 0;
			this.lblComprobanteNro.Text = "Comprobante Nro: ";
			this.lblComprobanteNro.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label2.Location = new System.Drawing.Point(115, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fecha:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label4.Location = new System.Drawing.Point(53, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Forma de Pago:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label5.Location = new System.Drawing.Point(461, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "Descuento:";
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(185, 73);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(221, 22);
			this.txtCliente.TabIndex = 17;
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblCliente.Location = new System.Drawing.Point(112, 75);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(64, 20);
			this.lblCliente.TabIndex = 18;
			this.lblCliente.Text = "Cliente:";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblSubtotal.Location = new System.Drawing.Point(702, 494);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(88, 20);
			this.lblSubtotal.TabIndex = 19;
			this.lblSubtotal.Text = "Subtotal: $";
			// 
			// FrmAltaComprobante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(929, 609);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboDescuentos);
			this.Controls.Add(this.cboFormasPago);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblFormaPago);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.dgvDetalles);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblComprobanteNro);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAltaComprobante";
			this.Text = "FrmAltaComprobante";
			this.Load += new System.EventHandler(this.FrmAltaComprobante_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.DataGridView dgvDetalles;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblFormaPago;
		private System.Windows.Forms.ComboBox cboFormasPago;
		private System.Windows.Forms.ComboBox cboDescuentos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFuncion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSala;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCantAsientos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
		private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
		private System.Windows.Forms.Label lblComprobanteNro;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblSubtotal;
	}
}
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
			this.cboExtras = new System.Windows.Forms.ComboBox();
			this.lblAlimentos = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblFormaPago = new System.Windows.Forms.Label();
			this.cboFormasPago = new System.Windows.Forms.ComboBox();
			this.cboDescuentos = new System.Windows.Forms.ComboBox();
			this.lblDescuentos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(153, 132);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(48, 16);
			this.lblFecha.TabIndex = 2;
			this.lblFecha.Text = "Fecha:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(223, 135);
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
			this.dgvDetalles.Location = new System.Drawing.Point(107, 233);
			this.dgvDetalles.Name = "dgvDetalles";
			this.dgvDetalles.ReadOnly = true;
			this.dgvDetalles.RowHeadersWidth = 51;
			this.dgvDetalles.RowTemplate.Height = 24;
			this.dgvDetalles.Size = new System.Drawing.Size(675, 270);
			this.dgvDetalles.TabIndex = 5;
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
			// cboExtras
			// 
			this.cboExtras.FormattingEnabled = true;
			this.cboExtras.Location = new System.Drawing.Point(223, 182);
			this.cboExtras.Name = "cboExtras";
			this.cboExtras.Size = new System.Drawing.Size(224, 24);
			this.cboExtras.TabIndex = 6;
			// 
			// lblAlimentos
			// 
			this.lblAlimentos.AutoSize = true;
			this.lblAlimentos.Location = new System.Drawing.Point(132, 182);
			this.lblAlimentos.Name = "lblAlimentos";
			this.lblAlimentos.Size = new System.Drawing.Size(69, 16);
			this.lblAlimentos.TabIndex = 7;
			this.lblAlimentos.Text = "Alimentos:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnAgregar.Location = new System.Drawing.Point(598, 184);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(87, 29);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			// 
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(476, 184);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(106, 22);
			this.nudCantidad.TabIndex = 9;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblTotal.Location = new System.Drawing.Point(546, 539);
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
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnAceptar.Location = new System.Drawing.Point(277, 536);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(87, 29);
			this.btnAceptar.TabIndex = 11;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnCancelar.Location = new System.Drawing.Point(370, 536);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(87, 29);
			this.btnCancelar.TabIndex = 12;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// lblFormaPago
			// 
			this.lblFormaPago.AutoSize = true;
			this.lblFormaPago.Location = new System.Drawing.Point(97, 84);
			this.lblFormaPago.Name = "lblFormaPago";
			this.lblFormaPago.Size = new System.Drawing.Size(104, 16);
			this.lblFormaPago.TabIndex = 13;
			this.lblFormaPago.Text = "Forma de Pago:";
			// 
			// cboFormasPago
			// 
			this.cboFormasPago.FormattingEnabled = true;
			this.cboFormasPago.Location = new System.Drawing.Point(223, 84);
			this.cboFormasPago.Name = "cboFormasPago";
			this.cboFormasPago.Size = new System.Drawing.Size(222, 24);
			this.cboFormasPago.TabIndex = 14;
			// 
			// cboDescuentos
			// 
			this.cboDescuentos.FormattingEnabled = true;
			this.cboDescuentos.Location = new System.Drawing.Point(594, 84);
			this.cboDescuentos.Name = "cboDescuentos";
			this.cboDescuentos.Size = new System.Drawing.Size(188, 24);
			this.cboDescuentos.TabIndex = 15;
			this.cboDescuentos.SelectedIndexChanged += new System.EventHandler(this.cboDescuentos_SelectedIndexChanged);
			// 
			// lblDescuentos
			// 
			this.lblDescuentos.AutoSize = true;
			this.lblDescuentos.Location = new System.Drawing.Point(497, 84);
			this.lblDescuentos.Name = "lblDescuentos";
			this.lblDescuentos.Size = new System.Drawing.Size(75, 16);
			this.lblDescuentos.TabIndex = 16;
			this.lblDescuentos.Text = "Descuento:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label1.Location = new System.Drawing.Point(153, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Comprobante Nro: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label2.Location = new System.Drawing.Point(153, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fecha:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Location = new System.Drawing.Point(132, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Alimentos:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label4.Location = new System.Drawing.Point(97, 84);
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
			this.label5.Location = new System.Drawing.Point(497, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "Descuento:";
			// 
			// FrmAltaComprobante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(929, 609);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblDescuentos);
			this.Controls.Add(this.cboDescuentos);
			this.Controls.Add(this.cboFormasPago);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblFormaPago);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.nudCantidad);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblAlimentos);
			this.Controls.Add(this.cboExtras);
			this.Controls.Add(this.dgvDetalles);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label1);
			this.Name = "FrmAltaComprobante";
			this.Text = "FrmAltaComprobante";
			this.Load += new System.EventHandler(this.FrmAltaComprobante_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.DataGridView dgvDetalles;
		private System.Windows.Forms.ComboBox cboExtras;
		private System.Windows.Forms.Label lblAlimentos;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblFormaPago;
		private System.Windows.Forms.ComboBox cboFormasPago;
		private System.Windows.Forms.ComboBox cboDescuentos;
		private System.Windows.Forms.Label lblDescuentos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFuncion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSala;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCantAsientos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
		private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}
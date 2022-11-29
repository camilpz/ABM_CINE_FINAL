namespace ABM_CINE_FINAL.Presentacion
{
    partial class FrmMenu
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
			this.panelMenuLateral = new System.Windows.Forms.Integration.ElementHost();
			this.panelLogoCine = new System.Windows.Forms.Panel();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.panelSubmenuNuevo = new System.Windows.Forms.Panel();
			this.btnComprobante = new System.Windows.Forms.Button();
			this.btnFuncion = new System.Windows.Forms.Button();
			this.btnPelícula = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.panelSubmenuEditar = new System.Windows.Forms.Panel();
			this.bntEditarFuncion = new System.Windows.Forms.Button();
			this.btnReportes = new System.Windows.Forms.Button();
			this.panelSubmenuNuevo.SuspendLayout();
			this.panelSubmenuEditar.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenuLateral
			// 
			this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelMenuLateral.Location = new System.Drawing.Point(243, 0);
			this.panelMenuLateral.Name = "panelMenuLateral";
			this.panelMenuLateral.Size = new System.Drawing.Size(861, 656);
			this.panelMenuLateral.TabIndex = 0;
			this.panelMenuLateral.Text = "elementHost1";
			this.panelMenuLateral.Child = null;
			// 
			// panelLogoCine
			// 
			this.panelLogoCine.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogoCine.Location = new System.Drawing.Point(0, 0);
			this.panelLogoCine.Name = "panelLogoCine";
			this.panelLogoCine.Size = new System.Drawing.Size(243, 184);
			this.panelLogoCine.TabIndex = 1;
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNuevo.FlatAppearance.BorderSize = 0;
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnNuevo.Location = new System.Drawing.Point(0, 184);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnNuevo.Size = new System.Drawing.Size(243, 45);
			this.btnNuevo.TabIndex = 2;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.UseVisualStyleBackColor = false;
			// 
			// panelSubmenuNuevo
			// 
			this.panelSubmenuNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(79)))));
			this.panelSubmenuNuevo.Controls.Add(this.btnPelícula);
			this.panelSubmenuNuevo.Controls.Add(this.btnFuncion);
			this.panelSubmenuNuevo.Controls.Add(this.btnComprobante);
			this.panelSubmenuNuevo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSubmenuNuevo.Location = new System.Drawing.Point(0, 229);
			this.panelSubmenuNuevo.Name = "panelSubmenuNuevo";
			this.panelSubmenuNuevo.Size = new System.Drawing.Size(243, 129);
			this.panelSubmenuNuevo.TabIndex = 3;
			// 
			// btnComprobante
			// 
			this.btnComprobante.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnComprobante.FlatAppearance.BorderSize = 0;
			this.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnComprobante.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnComprobante.Location = new System.Drawing.Point(0, 0);
			this.btnComprobante.Name = "btnComprobante";
			this.btnComprobante.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnComprobante.Size = new System.Drawing.Size(243, 40);
			this.btnComprobante.TabIndex = 0;
			this.btnComprobante.Text = "Comprobante";
			this.btnComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnComprobante.UseVisualStyleBackColor = true;
			// 
			// btnFuncion
			// 
			this.btnFuncion.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFuncion.FlatAppearance.BorderSize = 0;
			this.btnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFuncion.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnFuncion.Location = new System.Drawing.Point(0, 40);
			this.btnFuncion.Name = "btnFuncion";
			this.btnFuncion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnFuncion.Size = new System.Drawing.Size(243, 40);
			this.btnFuncion.TabIndex = 1;
			this.btnFuncion.Text = "Función";
			this.btnFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFuncion.UseVisualStyleBackColor = true;
			// 
			// btnPelícula
			// 
			this.btnPelícula.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPelícula.FlatAppearance.BorderSize = 0;
			this.btnPelícula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPelícula.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnPelícula.Location = new System.Drawing.Point(0, 80);
			this.btnPelícula.Name = "btnPelícula";
			this.btnPelícula.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnPelícula.Size = new System.Drawing.Size(243, 40);
			this.btnPelícula.TabIndex = 2;
			this.btnPelícula.Text = "Película";
			this.btnPelícula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPelícula.UseVisualStyleBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnEditar.Location = new System.Drawing.Point(0, 358);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnEditar.Size = new System.Drawing.Size(243, 45);
			this.btnEditar.TabIndex = 4;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.UseVisualStyleBackColor = false;
			// 
			// panelSubmenuEditar
			// 
			this.panelSubmenuEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(79)))));
			this.panelSubmenuEditar.Controls.Add(this.bntEditarFuncion);
			this.panelSubmenuEditar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSubmenuEditar.Location = new System.Drawing.Point(0, 403);
			this.panelSubmenuEditar.Name = "panelSubmenuEditar";
			this.panelSubmenuEditar.Size = new System.Drawing.Size(243, 52);
			this.panelSubmenuEditar.TabIndex = 5;
			// 
			// bntEditarFuncion
			// 
			this.bntEditarFuncion.Dock = System.Windows.Forms.DockStyle.Top;
			this.bntEditarFuncion.FlatAppearance.BorderSize = 0;
			this.bntEditarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntEditarFuncion.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bntEditarFuncion.Location = new System.Drawing.Point(0, 0);
			this.bntEditarFuncion.Name = "bntEditarFuncion";
			this.bntEditarFuncion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.bntEditarFuncion.Size = new System.Drawing.Size(243, 40);
			this.bntEditarFuncion.TabIndex = 0;
			this.bntEditarFuncion.Text = "Función";
			this.bntEditarFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntEditarFuncion.UseVisualStyleBackColor = true;
			// 
			// btnReportes
			// 
			this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReportes.FlatAppearance.BorderSize = 0;
			this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnReportes.Location = new System.Drawing.Point(0, 455);
			this.btnReportes.Name = "btnReportes";
			this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnReportes.Size = new System.Drawing.Size(243, 45);
			this.btnReportes.TabIndex = 6;
			this.btnReportes.Text = "Reportes";
			this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReportes.UseVisualStyleBackColor = false;
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1104, 656);
			this.Controls.Add(this.btnReportes);
			this.Controls.Add(this.panelSubmenuEditar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.panelSubmenuNuevo);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.panelLogoCine);
			this.Controls.Add(this.panelMenuLateral);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmMenu";
			this.Text = "FrmMenu";
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.panelSubmenuNuevo.ResumeLayout(false);
			this.panelSubmenuEditar.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Integration.ElementHost panelMenuLateral;
		private System.Windows.Forms.Panel panelLogoCine;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Panel panelSubmenuNuevo;
		private System.Windows.Forms.Button btnPelícula;
		private System.Windows.Forms.Button btnFuncion;
		private System.Windows.Forms.Button btnComprobante;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Panel panelSubmenuEditar;
		private System.Windows.Forms.Button bntEditarFuncion;
		private System.Windows.Forms.Button btnReportes;
	}
}
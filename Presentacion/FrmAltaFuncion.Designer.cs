namespace ABM_CINE_FINAL.Presentacion
{
    partial class FrmAltaFuncion
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
			this.lblPelicula = new System.Windows.Forms.Label();
			this.lblIdiomas = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblHorarios = new System.Windows.Forms.Label();
			this.cboPeliculas = new System.Windows.Forms.ComboBox();
			this.cboIdiomas = new System.Windows.Forms.ComboBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cboHorarios = new System.Windows.Forms.ComboBox();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblSalas = new System.Windows.Forms.Label();
			this.cboSala = new System.Windows.Forms.ComboBox();
			this.lblNuevaFuncion = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPelicula
			// 
			this.lblPelicula.AutoSize = true;
			this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPelicula.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblPelicula.Location = new System.Drawing.Point(115, 118);
			this.lblPelicula.Name = "lblPelicula";
			this.lblPelicula.Size = new System.Drawing.Size(73, 20);
			this.lblPelicula.TabIndex = 0;
			this.lblPelicula.Text = "Película:";
			// 
			// lblIdiomas
			// 
			this.lblIdiomas.AutoSize = true;
			this.lblIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdiomas.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblIdiomas.Location = new System.Drawing.Point(121, 183);
			this.lblIdiomas.Name = "lblIdiomas";
			this.lblIdiomas.Size = new System.Drawing.Size(72, 20);
			this.lblIdiomas.TabIndex = 1;
			this.lblIdiomas.Text = "Idiomas:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblFecha.Location = new System.Drawing.Point(128, 251);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(60, 20);
			this.lblFecha.TabIndex = 2;
			this.lblFecha.Text = "Fecha:";
			// 
			// lblHorarios
			// 
			this.lblHorarios.AutoSize = true;
			this.lblHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHorarios.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblHorarios.Location = new System.Drawing.Point(114, 384);
			this.lblHorarios.Name = "lblHorarios";
			this.lblHorarios.Size = new System.Drawing.Size(79, 20);
			this.lblHorarios.TabIndex = 3;
			this.lblHorarios.Text = "Horarios:";
			// 
			// cboPeliculas
			// 
			this.cboPeliculas.FormattingEnabled = true;
			this.cboPeliculas.Location = new System.Drawing.Point(206, 118);
			this.cboPeliculas.Name = "cboPeliculas";
			this.cboPeliculas.Size = new System.Drawing.Size(329, 24);
			this.cboPeliculas.TabIndex = 4;
			this.cboPeliculas.SelectedIndexChanged += new System.EventHandler(this.cboPeliculas_SelectedIndexChanged);
			// 
			// cboIdiomas
			// 
			this.cboIdiomas.FormattingEnabled = true;
			this.cboIdiomas.Location = new System.Drawing.Point(206, 183);
			this.cboIdiomas.Name = "cboIdiomas";
			this.cboIdiomas.Size = new System.Drawing.Size(200, 24);
			this.cboIdiomas.TabIndex = 5;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(206, 251);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 22);
			this.dtpFecha.TabIndex = 6;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
			// 
			// cboHorarios
			// 
			this.cboHorarios.FormattingEnabled = true;
			this.cboHorarios.Location = new System.Drawing.Point(206, 384);
			this.cboHorarios.Name = "cboHorarios";
			this.cboHorarios.Size = new System.Drawing.Size(200, 24);
			this.cboHorarios.TabIndex = 7;
			// 
			// btnCrear
			// 
			this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnCrear.Location = new System.Drawing.Point(327, 507);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(98, 40);
			this.btnCrear.TabIndex = 9;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnCancelar.Location = new System.Drawing.Point(453, 507);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(101, 38);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// lblSalas
			// 
			this.lblSalas.AutoSize = true;
			this.lblSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSalas.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblSalas.Location = new System.Drawing.Point(138, 328);
			this.lblSalas.Name = "lblSalas";
			this.lblSalas.Size = new System.Drawing.Size(47, 20);
			this.lblSalas.TabIndex = 11;
			this.lblSalas.Text = "Sala:";
			// 
			// cboSala
			// 
			this.cboSala.FormattingEnabled = true;
			this.cboSala.Location = new System.Drawing.Point(206, 320);
			this.cboSala.Name = "cboSala";
			this.cboSala.Size = new System.Drawing.Size(200, 24);
			this.cboSala.TabIndex = 12;
			this.cboSala.SelectedIndexChanged += new System.EventHandler(this.cboSala_SelectedIndexChanged);
			// 
			// lblNuevaFuncion
			// 
			this.lblNuevaFuncion.AutoSize = true;
			this.lblNuevaFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNuevaFuncion.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblNuevaFuncion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblNuevaFuncion.Location = new System.Drawing.Point(92, 53);
			this.lblNuevaFuncion.Name = "lblNuevaFuncion";
			this.lblNuevaFuncion.Size = new System.Drawing.Size(187, 29);
			this.lblNuevaFuncion.TabIndex = 16;
			this.lblNuevaFuncion.Text = "Nueva Función";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.button1.Location = new System.Drawing.Point(327, 506);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 40);
			this.button1.TabIndex = 9;
			this.button1.Text = "Crear";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.button2.Location = new System.Drawing.Point(453, 506);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 38);
			this.button2.TabIndex = 10;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// FrmAltaFuncion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(929, 589);
			this.Controls.Add(this.lblNuevaFuncion);
			this.Controls.Add(this.cboSala);
			this.Controls.Add(this.lblSalas);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.cboHorarios);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.cboIdiomas);
			this.Controls.Add(this.cboPeliculas);
			this.Controls.Add(this.lblHorarios);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblIdiomas);
			this.Controls.Add(this.lblPelicula);
			this.Name = "FrmAltaFuncion";
			this.Text = "FrmAltaFuncion";
			this.Load += new System.EventHandler(this.FrmAltaFuncion_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.ComboBox cboIdiomas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboHorarios;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.ComboBox cboSala;
		private System.Windows.Forms.Label lblNuevaFuncion;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}
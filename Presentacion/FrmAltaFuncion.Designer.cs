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
			this.lblFuncion = new System.Windows.Forms.Label();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblSalas = new System.Windows.Forms.Label();
			this.cboSala = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblPelicula
			// 
			this.lblPelicula.AutoSize = true;
			this.lblPelicula.Location = new System.Drawing.Point(135, 114);
			this.lblPelicula.Name = "lblPelicula";
			this.lblPelicula.Size = new System.Drawing.Size(58, 16);
			this.lblPelicula.TabIndex = 0;
			this.lblPelicula.Text = "Película:";
			// 
			// lblIdiomas
			// 
			this.lblIdiomas.AutoSize = true;
			this.lblIdiomas.Location = new System.Drawing.Point(128, 183);
			this.lblIdiomas.Name = "lblIdiomas";
			this.lblIdiomas.Size = new System.Drawing.Size(58, 16);
			this.lblIdiomas.TabIndex = 1;
			this.lblIdiomas.Text = "Idiomas:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(138, 244);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(48, 16);
			this.lblFecha.TabIndex = 2;
			this.lblFecha.Text = "Fecha:";
			// 
			// lblHorarios
			// 
			this.lblHorarios.AutoSize = true;
			this.lblHorarios.Location = new System.Drawing.Point(124, 357);
			this.lblHorarios.Name = "lblHorarios";
			this.lblHorarios.Size = new System.Drawing.Size(62, 16);
			this.lblHorarios.TabIndex = 3;
			this.lblHorarios.Text = "Horarios:";
			// 
			// cboPeliculas
			// 
			this.cboPeliculas.FormattingEnabled = true;
			this.cboPeliculas.Location = new System.Drawing.Point(216, 114);
			this.cboPeliculas.Name = "cboPeliculas";
			this.cboPeliculas.Size = new System.Drawing.Size(329, 24);
			this.cboPeliculas.TabIndex = 4;
			this.cboPeliculas.SelectedIndexChanged += new System.EventHandler(this.cboPeliculas_SelectedIndexChanged);
			// 
			// cboIdiomas
			// 
			this.cboIdiomas.FormattingEnabled = true;
			this.cboIdiomas.Location = new System.Drawing.Point(216, 183);
			this.cboIdiomas.Name = "cboIdiomas";
			this.cboIdiomas.Size = new System.Drawing.Size(200, 24);
			this.cboIdiomas.TabIndex = 5;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(216, 244);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 22);
			this.dtpFecha.TabIndex = 6;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
			// 
			// cboHorarios
			// 
			this.cboHorarios.FormattingEnabled = true;
			this.cboHorarios.Location = new System.Drawing.Point(216, 357);
			this.cboHorarios.Name = "cboHorarios";
			this.cboHorarios.Size = new System.Drawing.Size(200, 24);
			this.cboHorarios.TabIndex = 7;
			// 
			// lblFuncion
			// 
			this.lblFuncion.AutoSize = true;
			this.lblFuncion.Location = new System.Drawing.Point(289, 57);
			this.lblFuncion.Name = "lblFuncion";
			this.lblFuncion.Size = new System.Drawing.Size(67, 16);
			this.lblFuncion.TabIndex = 8;
			this.lblFuncion.Text = "FUNCIÓN";
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(236, 428);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 23);
			this.btnCrear.TabIndex = 9;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(341, 428);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// lblSalas
			// 
			this.lblSalas.AutoSize = true;
			this.lblSalas.Location = new System.Drawing.Point(148, 308);
			this.lblSalas.Name = "lblSalas";
			this.lblSalas.Size = new System.Drawing.Size(38, 16);
			this.lblSalas.TabIndex = 11;
			this.lblSalas.Text = "Sala:";
			// 
			// cboSala
			// 
			this.cboSala.FormattingEnabled = true;
			this.cboSala.Location = new System.Drawing.Point(216, 300);
			this.cboSala.Name = "cboSala";
			this.cboSala.Size = new System.Drawing.Size(200, 24);
			this.cboSala.TabIndex = 12;
			this.cboSala.SelectedIndexChanged += new System.EventHandler(this.cboSala_SelectedIndexChanged);
			// 
			// FrmAltaFuncion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 506);
			this.Controls.Add(this.cboSala);
			this.Controls.Add(this.lblSalas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.lblFuncion);
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
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.ComboBox cboSala;
    }
}
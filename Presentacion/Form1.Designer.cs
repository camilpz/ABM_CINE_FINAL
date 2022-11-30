namespace ABM_CINE_FINAL
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.lblDni = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cbxMostrarPass = new System.Windows.Forms.CheckBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDni.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblDni.Location = new System.Drawing.Point(140, 258);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(38, 20);
			this.lblDni.TabIndex = 1;
			this.lblDni.Text = "DNI";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblPassword.Location = new System.Drawing.Point(140, 331);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(95, 20);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Contraseña";
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(144, 281);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(289, 22);
			this.txtDni.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(144, 354);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(289, 22);
			this.txtPassword.TabIndex = 4;
			// 
			// cbxMostrarPass
			// 
			this.cbxMostrarPass.Appearance = System.Windows.Forms.Appearance.Button;
			this.cbxMostrarPass.AutoSize = true;
			this.cbxMostrarPass.FlatAppearance.BorderSize = 0;
			this.cbxMostrarPass.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.cbxMostrarPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.cbxMostrarPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.cbxMostrarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxMostrarPass.Image = global::ABM_CINE_FINAL.Properties.Resources.OjoAbiertoIcono;
			this.cbxMostrarPass.Location = new System.Drawing.Point(451, 349);
			this.cbxMostrarPass.Name = "cbxMostrarPass";
			this.cbxMostrarPass.Size = new System.Drawing.Size(32, 32);
			this.cbxMostrarPass.TabIndex = 5;
			this.cbxMostrarPass.UseVisualStyleBackColor = true;
			this.cbxMostrarPass.CheckedChanged += new System.EventHandler(this.cbxMostrarPass_CheckedChanged);
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnIngresar.Location = new System.Drawing.Point(187, 420);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(93, 30);
			this.btnIngresar.TabIndex = 6;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(36)))));
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnSalir.Location = new System.Drawing.Point(297, 420);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(93, 30);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(224, 52);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(146, 137);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(584, 512);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.cbxMostrarPass);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblDni);
			this.Name = "FrmLogin";
			this.Text = "Iniciar Sesión";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxMostrarPass;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}


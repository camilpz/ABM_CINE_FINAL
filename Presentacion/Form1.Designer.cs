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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblDni = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cbxMostrarPass = new System.Windows.Forms.CheckBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblTitulo.Location = new System.Drawing.Point(99, 45);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(151, 16);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "INGRESE SUS DATOS:";
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblDni.Location = new System.Drawing.Point(120, 137);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(33, 16);
			this.lblDni.TabIndex = 1;
			this.lblDni.Text = "DNI:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblPassword.Location = new System.Drawing.Point(74, 194);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(79, 16);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Contraseña:";
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(180, 131);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(289, 22);
			this.txtDni.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(180, 194);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(289, 22);
			this.txtPassword.TabIndex = 4;
			// 
			// cbxMostrarPass
			// 
			this.cbxMostrarPass.AutoSize = true;
			this.cbxMostrarPass.Location = new System.Drawing.Point(490, 199);
			this.cbxMostrarPass.Name = "cbxMostrarPass";
			this.cbxMostrarPass.Size = new System.Drawing.Size(18, 17);
			this.cbxMostrarPass.TabIndex = 5;
			this.cbxMostrarPass.UseVisualStyleBackColor = true;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(212, 298);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(75, 23);
			this.btnIngresar.TabIndex = 6;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(318, 297);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(613, 380);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.cbxMostrarPass);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblDni);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FrmLogin";
			this.Text = "Iniciar Sesión";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxMostrarPass;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
    }
}


namespace Evaluacion2NuevaNET
{
    partial class VntLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VntLogin));
            this._lblLogin = new System.Windows.Forms.Label();
            this._lblCajero = new System.Windows.Forms.Label();
            this._lblPass = new System.Windows.Forms.Label();
            this._txbCajero = new System.Windows.Forms.TextBox();
            this._txbPass = new System.Windows.Forms.TextBox();
            this._btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblLogin
            // 
            this._lblLogin.AutoSize = true;
            this._lblLogin.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLogin.Location = new System.Drawing.Point(248, 44);
            this._lblLogin.Name = "_lblLogin";
            this._lblLogin.Size = new System.Drawing.Size(93, 32);
            this._lblLogin.TabIndex = 0;
            this._lblLogin.Text = "Login";
            // 
            // _lblCajero
            // 
            this._lblCajero.AutoSize = true;
            this._lblCajero.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCajero.Location = new System.Drawing.Point(158, 131);
            this._lblCajero.Name = "_lblCajero";
            this._lblCajero.Size = new System.Drawing.Size(71, 22);
            this._lblCajero.TabIndex = 1;
            this._lblCajero.Text = "Cajero";
            // 
            // _lblPass
            // 
            this._lblPass.AutoSize = true;
            this._lblPass.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPass.Location = new System.Drawing.Point(158, 169);
            this._lblPass.Name = "_lblPass";
            this._lblPass.Size = new System.Drawing.Size(117, 22);
            this._lblPass.TabIndex = 2;
            this._lblPass.Text = "Contraseña";
            // 
            // _txbCajero
            // 
            this._txbCajero.Location = new System.Drawing.Point(320, 131);
            this._txbCajero.Name = "_txbCajero";
            this._txbCajero.Size = new System.Drawing.Size(129, 20);
            this._txbCajero.TabIndex = 3;
            // 
            // _txbPass
            // 
            this._txbPass.Location = new System.Drawing.Point(320, 169);
            this._txbPass.Name = "_txbPass";
            this._txbPass.PasswordChar = '*';
            this._txbPass.Size = new System.Drawing.Size(129, 20);
            this._txbPass.TabIndex = 4;
            // 
            // _btnIngresar
            // 
            this._btnIngresar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnIngresar.Location = new System.Drawing.Point(226, 227);
            this._btnIngresar.Name = "_btnIngresar";
            this._btnIngresar.Size = new System.Drawing.Size(138, 40);
            this._btnIngresar.TabIndex = 5;
            this._btnIngresar.Text = "Ingresar";
            this._btnIngresar.UseVisualStyleBackColor = true;
            this._btnIngresar.Click += new System.EventHandler(this._btnIngresar_Click);
            // 
            // VntLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(604, 311);
            this.Controls.Add(this._btnIngresar);
            this.Controls.Add(this._txbPass);
            this.Controls.Add(this._txbCajero);
            this.Controls.Add(this._lblPass);
            this.Controls.Add(this._lblCajero);
            this.Controls.Add(this._lblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(620, 350);
            this.MinimumSize = new System.Drawing.Size(620, 350);
            this.Name = "VntLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblLogin;
        private System.Windows.Forms.Label _lblCajero;
        private System.Windows.Forms.Label _lblPass;
        private System.Windows.Forms.TextBox _txbCajero;
        private System.Windows.Forms.TextBox _txbPass;
        private System.Windows.Forms.Button _btnIngresar;
    }
}


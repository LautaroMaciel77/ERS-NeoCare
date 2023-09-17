namespace ERS_NeoCare.Design
{
    partial class Login
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.iconButtonIniciar = new FontAwesome.Sharp.IconButton();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.textBoxPass);
            this.panelLogin.Controls.Add(this.textBoxUser);
            this.panelLogin.Controls.Add(this.labelContraseña);
            this.panelLogin.Controls.Add(this.labelUser);
            this.panelLogin.Controls.Add(this.iconButtonIniciar);
            this.panelLogin.Location = new System.Drawing.Point(97, 33);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(381, 261);
            this.panelLogin.TabIndex = 0;
            // 
            // iconButtonIniciar
            // 
            this.iconButtonIniciar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonIniciar.IconColor = System.Drawing.Color.Black;
            this.iconButtonIniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonIniciar.Location = new System.Drawing.Point(72, 201);
            this.iconButtonIniciar.Name = "iconButtonIniciar";
            this.iconButtonIniciar.Size = new System.Drawing.Size(219, 39);
            this.iconButtonIniciar.TabIndex = 0;
            this.iconButtonIniciar.Text = "Iniciar secion";
            this.iconButtonIniciar.UseVisualStyleBackColor = true;
            this.iconButtonIniciar.Click += new System.EventHandler(this.iconButtonIniciar_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(72, 58);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(72, 131);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 2;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(155, 58);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(136, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(155, 131);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(136, 20);
            this.textBoxPass.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 352);
            this.Controls.Add(this.panelLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUser;
        private FontAwesome.Sharp.IconButton iconButtonIniciar;
    }
}
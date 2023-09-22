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
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.iconButtonIniciar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(67)))), ((int)(((byte)(91)))));
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxPass);
            this.panelLogin.Controls.Add(this.textBoxUser);
            this.panelLogin.Controls.Add(this.labelContraseña);
            this.panelLogin.Controls.Add(this.labelUser);
            this.panelLogin.Controls.Add(this.iconButtonIniciar);
            this.panelLogin.Location = new System.Drawing.Point(70, 87);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(356, 311);
            this.panelLogin.TabIndex = 0;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(75, 160);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(219, 23);
            this.textBoxPass.TabIndex = 4;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(75, 89);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(219, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.White;
            this.labelContraseña.Location = new System.Drawing.Point(75, 141);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(84, 17);
            this.labelContraseña.TabIndex = 2;
            this.labelContraseña.Text = "Contraseña";
            this.labelContraseña.Click += new System.EventHandler(this.labelContraseña_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(75, 70);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(54, 17);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuario";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // iconButtonIniciar
            // 
            this.iconButtonIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButtonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonIniciar.FlatAppearance.BorderSize = 0;
            this.iconButtonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonIniciar.ForeColor = System.Drawing.Color.White;
            this.iconButtonIniciar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonIniciar.IconColor = System.Drawing.Color.Black;
            this.iconButtonIniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonIniciar.Location = new System.Drawing.Point(75, 223);
            this.iconButtonIniciar.Name = "iconButtonIniciar";
            this.iconButtonIniciar.Size = new System.Drawing.Size(219, 41);
            this.iconButtonIniciar.TabIndex = 0;
            this.iconButtonIniciar.Text = "Iniciar sesion";
            this.iconButtonIniciar.UseVisualStyleBackColor = false;
            this.iconButtonIniciar.Click += new System.EventHandler(this.iconButtonIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.pictureBoxLogo.BackgroundImage = global::ERS_NeoCare.Properties.Resources.logo_NeoCare2;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(167, 59);
            this.pictureBoxLogo.TabIndex = 18;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(497, 462);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUser;
        private FontAwesome.Sharp.IconButton iconButtonIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
namespace ERS_NeoCare.Design.Medico
{
    partial class MenuMedicoPacientes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconClose = new FontAwesome.Sharp.IconButton();
            this.iconTurno = new FontAwesome.Sharp.IconButton();
            this.iconVer = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconClose
            // 
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconClose.IconColor = System.Drawing.Color.Black;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.Location = new System.Drawing.Point(141, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(75, 23);
            this.iconClose.TabIndex = 21;
            this.iconClose.Text = "cerrar";
            this.iconClose.UseVisualStyleBackColor = true;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // iconTurno
            // 
            this.iconTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconTurno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            this.iconTurno.FlatAppearance.BorderSize = 0;
            this.iconTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.iconTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTurno.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTurno.ForeColor = System.Drawing.Color.Transparent;
            this.iconTurno.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconTurno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.iconTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTurno.IconSize = 35;
            this.iconTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconTurno.Location = new System.Drawing.Point(0, 26);
            this.iconTurno.Margin = new System.Windows.Forms.Padding(0);
            this.iconTurno.Name = "iconTurno";
            this.iconTurno.Size = new System.Drawing.Size(216, 40);
            this.iconTurno.TabIndex = 22;
            this.iconTurno.Text = "agregar Turno";
            this.iconTurno.UseVisualStyleBackColor = false;
            this.iconTurno.Click += new System.EventHandler(this.iconTurno_Click);
            // 
            // iconVer
            // 
            this.iconVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconVer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            this.iconVer.FlatAppearance.BorderSize = 0;
            this.iconVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.iconVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconVer.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconVer.ForeColor = System.Drawing.Color.Transparent;
            this.iconVer.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconVer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.iconVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVer.IconSize = 35;
            this.iconVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconVer.Location = new System.Drawing.Point(0, 66);
            this.iconVer.Margin = new System.Windows.Forms.Padding(0);
            this.iconVer.Name = "iconVer";
            this.iconVer.Size = new System.Drawing.Size(216, 40);
            this.iconVer.TabIndex = 19;
            this.iconVer.Text = "ver paciente";
            this.iconVer.UseVisualStyleBackColor = false;
            this.iconVer.Click += new System.EventHandler(this.iconVer_Click);
            // 
            // MenuMedicoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.iconTurno);
            this.Controls.Add(this.iconVer);
            this.Name = "MenuMedicoPacientes";
            this.Size = new System.Drawing.Size(215, 106);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconTurno;
        private FontAwesome.Sharp.IconButton iconClose;
        private FontAwesome.Sharp.IconButton iconVer;
    }
}

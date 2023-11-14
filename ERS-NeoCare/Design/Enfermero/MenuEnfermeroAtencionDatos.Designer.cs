namespace ERS_NeoCare.Design
{
    partial class MenuEnfermeroAtencionDatos
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
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.btn_atender = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(67)))), ((int)(((byte)(44)))));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 12;
            this.iconButtonClose.Location = new System.Drawing.Point(225, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(32, 23);
            this.iconButtonClose.TabIndex = 34;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // btn_atender
            // 
            this.btn_atender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_atender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.btn_atender.FlatAppearance.BorderSize = 0;
            this.btn_atender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.btn_atender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atender.ForeColor = System.Drawing.Color.Transparent;
            this.btn_atender.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btn_atender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.btn_atender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_atender.IconSize = 35;
            this.btn_atender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atender.Location = new System.Drawing.Point(22, 55);
            this.btn_atender.Margin = new System.Windows.Forms.Padding(0);
            this.btn_atender.Name = "btn_atender";
            this.btn_atender.Size = new System.Drawing.Size(216, 40);
            this.btn_atender.TabIndex = 35;
            this.btn_atender.Text = "Ver atenciones";
            this.btn_atender.UseVisualStyleBackColor = false;
            this.btn_atender.Click += new System.EventHandler(this.btn_atender_Click);
            // 
            // MenuEnfermeroAtencionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.btn_atender);
            this.Controls.Add(this.iconButtonClose);
            this.Name = "MenuEnfermeroAtencionDatos";
            this.Size = new System.Drawing.Size(260, 150);
            this.Load += new System.EventHandler(this.menuPaciente_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton btn_atender;
    }
}

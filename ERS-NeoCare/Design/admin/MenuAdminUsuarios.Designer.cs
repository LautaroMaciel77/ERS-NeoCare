﻿namespace ERS_NeoCare.Design.Medico
{
    partial class MenuAdminUsuarios
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
            this.iconTurno = new FontAwesome.Sharp.IconButton();
            this.iconVer = new FontAwesome.Sharp.IconButton();
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
            this.iconButtonClose.TabIndex = 33;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // iconTurno
            // 
            this.iconTurno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.iconTurno.FlatAppearance.BorderSize = 0;
            this.iconTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.iconTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTurno.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTurno.ForeColor = System.Drawing.Color.Transparent;
            this.iconTurno.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconTurno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.iconTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTurno.IconSize = 35;
            this.iconTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconTurno.Location = new System.Drawing.Point(26, 36);
            this.iconTurno.Margin = new System.Windows.Forms.Padding(0);
            this.iconTurno.Name = "iconTurno";
            this.iconTurno.Size = new System.Drawing.Size(216, 40);
            this.iconTurno.TabIndex = 22;
            this.iconTurno.Text = "Editar";
            this.iconTurno.UseVisualStyleBackColor = false;
            this.iconTurno.Click += new System.EventHandler(this.iconTurno_Click);
            // 
            // iconVer
            // 
            this.iconVer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.iconVer.FlatAppearance.BorderSize = 0;
            this.iconVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.iconVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconVer.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconVer.ForeColor = System.Drawing.Color.Transparent;
            this.iconVer.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.iconVer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.iconVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVer.IconSize = 35;
            this.iconVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconVer.Location = new System.Drawing.Point(26, 76);
            this.iconVer.Margin = new System.Windows.Forms.Padding(0);
            this.iconVer.Name = "iconVer";
            this.iconVer.Size = new System.Drawing.Size(216, 40);
            this.iconVer.TabIndex = 19;
            this.iconVer.Text = "Dar de baja";
            this.iconVer.UseVisualStyleBackColor = false;
            this.iconVer.Click += new System.EventHandler(this.iconVer_Click);
            // 
            // MenuAdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.iconButtonClose);
            this.Controls.Add(this.iconTurno);
            this.Controls.Add(this.iconVer);
            this.Name = "MenuAdminUsuarios";
            this.Size = new System.Drawing.Size(260, 150);
            this.Load += new System.EventHandler(this.MenuAdminUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconTurno;
        private FontAwesome.Sharp.IconButton iconVer;
        private FontAwesome.Sharp.IconButton iconButtonClose;
    }
}

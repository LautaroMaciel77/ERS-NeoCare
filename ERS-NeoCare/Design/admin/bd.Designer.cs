namespace ERS_NeoCare.Design
{
    partial class bd
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
            this.iconButtonCrearCopia = new FontAwesome.Sharp.IconButton();
            this.iconButtonRestaurar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButtonCrearCopia
            // 
            this.iconButtonCrearCopia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.iconButtonCrearCopia.FlatAppearance.BorderSize = 0;
            this.iconButtonCrearCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCrearCopia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCrearCopia.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButtonCrearCopia.IconColor = System.Drawing.Color.Black;
            this.iconButtonCrearCopia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCrearCopia.IconSize = 40;
            this.iconButtonCrearCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCrearCopia.Location = new System.Drawing.Point(396, 225);
            this.iconButtonCrearCopia.Name = "iconButtonCrearCopia";
            this.iconButtonCrearCopia.Size = new System.Drawing.Size(434, 60);
            this.iconButtonCrearCopia.TabIndex = 2;
            this.iconButtonCrearCopia.Text = "Crear copia de seguridad de datos";
            this.iconButtonCrearCopia.UseVisualStyleBackColor = false;
            this.iconButtonCrearCopia.Click += new System.EventHandler(this.iconButtonCrearCopia_Click);
            // 
            // iconButtonRestaurar
            // 
            this.iconButtonRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(128)))));
            this.iconButtonRestaurar.FlatAppearance.BorderSize = 0;
            this.iconButtonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRestaurar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRestaurar.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButtonRestaurar.IconColor = System.Drawing.Color.Black;
            this.iconButtonRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRestaurar.IconSize = 40;
            this.iconButtonRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRestaurar.Location = new System.Drawing.Point(396, 334);
            this.iconButtonRestaurar.Name = "iconButtonRestaurar";
            this.iconButtonRestaurar.Size = new System.Drawing.Size(434, 60);
            this.iconButtonRestaurar.TabIndex = 3;
            this.iconButtonRestaurar.Text = "Restaurar una copia de seguridad de datos";
            this.iconButtonRestaurar.UseVisualStyleBackColor = false;
            this.iconButtonRestaurar.Click += new System.EventHandler(this.iconButtonRestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema";
            // 
            // bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonRestaurar);
            this.Controls.Add(this.iconButtonCrearCopia);
            this.Name = "bd";
            this.Size = new System.Drawing.Size(1196, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonCrearCopia;
        private FontAwesome.Sharp.IconButton iconButtonRestaurar;
        private System.Windows.Forms.Label label1;
    }
}

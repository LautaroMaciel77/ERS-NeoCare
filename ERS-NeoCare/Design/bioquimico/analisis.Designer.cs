namespace ERS_NeoCare.Design.administrativo
{
    partial class analisis
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
            this.iconButtonCargar = new FontAwesome.Sharp.IconButton();
            this.listViewResultados = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.LabelResultados = new System.Windows.Forms.Label();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iconButtonCargar
            // 
            this.iconButtonCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButtonCargar.FlatAppearance.BorderSize = 0;
            this.iconButtonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCargar.ForeColor = System.Drawing.Color.White;
            this.iconButtonCargar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButtonCargar.IconColor = System.Drawing.Color.White;
            this.iconButtonCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCargar.IconSize = 20;
            this.iconButtonCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCargar.Location = new System.Drawing.Point(814, 412);
            this.iconButtonCargar.Name = "iconButtonCargar";
            this.iconButtonCargar.Size = new System.Drawing.Size(75, 32);
            this.iconButtonCargar.TabIndex = 35;
            this.iconButtonCargar.Text = "Cargar";
            this.iconButtonCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCargar.UseVisualStyleBackColor = false;
            // 
            // listViewResultados
            // 
            this.listViewResultados.HideSelection = false;
            this.listViewResultados.Location = new System.Drawing.Point(444, 302);
            this.listViewResultados.Name = "listViewResultados";
            this.listViewResultados.Size = new System.Drawing.Size(445, 104);
            this.listViewResultados.TabIndex = 34;
            this.listViewResultados.UseCompatibleStateImageBehavior = false;
            this.listViewResultados.SelectedIndexChanged += new System.EventHandler(this.listViewResultados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Analisis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(465, 490);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(151, 40);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // LabelResultados
            // 
            this.LabelResultados.AutoSize = true;
            this.LabelResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultados.Location = new System.Drawing.Point(270, 302);
            this.LabelResultados.Name = "LabelResultados";
            this.LabelResultados.Size = new System.Drawing.Size(76, 16);
            this.LabelResultados.TabIndex = 21;
            this.LabelResultados.Text = "Resultados";
            this.LabelResultados.Click += new System.EventHandler(this.LabelDomicilio_Click);
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(270, 134);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(99, 16);
            this.labelObservaciones.TabIndex = 20;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(444, 134);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(445, 104);
            this.textBoxObservaciones.TabIndex = 36;
            // 
            // analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.iconButtonCargar);
            this.Controls.Add(this.listViewResultados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelObservaciones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.LabelResultados);
            this.Name = "analisis";
            this.Size = new System.Drawing.Size(1127, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label LabelResultados;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonCargar;
        private System.Windows.Forms.ListView listViewResultados;
        private System.Windows.Forms.TextBox textBoxObservaciones;
    }
}

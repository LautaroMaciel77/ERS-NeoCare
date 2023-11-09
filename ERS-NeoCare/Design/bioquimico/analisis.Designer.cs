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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.LabelResultados = new System.Windows.Forms.Label();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelIndicaciones = new System.Windows.Forms.Panel();
            this.listViewArchivos = new System.Windows.Forms.ListView();
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
            this.iconButtonCargar.Location = new System.Drawing.Point(699, 364);
            this.iconButtonCargar.Name = "iconButtonCargar";
            this.iconButtonCargar.Size = new System.Drawing.Size(75, 32);
            this.iconButtonCargar.TabIndex = 35;
            this.iconButtonCargar.Text = "Cargar";
            this.iconButtonCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCargar.UseVisualStyleBackColor = false;
            this.iconButtonCargar.Click += new System.EventHandler(this.iconButtonCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Analisis";
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
            this.LabelResultados.Location = new System.Drawing.Point(326, 278);
            this.LabelResultados.Name = "LabelResultados";
            this.LabelResultados.Size = new System.Drawing.Size(69, 16);
            this.LabelResultados.TabIndex = 21;
            this.LabelResultados.Text = "Resultado";
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(326, 141);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(162, 16);
            this.labelObservaciones.TabIndex = 20;
            this.labelObservaciones.Text = "Observaciones (opcional)";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(329, 160);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(445, 104);
            this.textBoxObservaciones.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tipo de analisis";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox1.Location = new System.Drawing.Point(329, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // panelIndicaciones
            // 
            this.panelIndicaciones.Location = new System.Drawing.Point(37, 51);
            this.panelIndicaciones.Name = "panelIndicaciones";
            this.panelIndicaciones.Size = new System.Drawing.Size(283, 317);
            this.panelIndicaciones.TabIndex = 39;
            // 
            // listViewArchivos
            // 
            this.listViewArchivos.HideSelection = false;
            this.listViewArchivos.Location = new System.Drawing.Point(325, 296);
            this.listViewArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewArchivos.Name = "listViewArchivos";
            this.listViewArchivos.Size = new System.Drawing.Size(449, 64);
            this.listViewArchivos.TabIndex = 40;
            this.listViewArchivos.UseCompatibleStateImageBehavior = false;
            // 
            // analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewArchivos);
            this.Controls.Add(this.panelIndicaciones);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.iconButtonCargar);
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
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelIndicaciones;
        private System.Windows.Forms.ListView listViewArchivos;
    }
}

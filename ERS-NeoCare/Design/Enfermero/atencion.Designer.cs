namespace ERS_NeoCare.Design.administrativo
{
    partial class atencion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.textBoxIndicaciones = new System.Windows.Forms.TextBox();
            this.labelIndicaciones = new System.Windows.Forms.Label();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Resumen de Atencion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(697, 618);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(167, 28);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(456, 348);
            this.labelObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(121, 20);
            this.labelObservaciones.TabIndex = 20;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // textBoxIndicaciones
            // 
            this.textBoxIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndicaciones.Location = new System.Drawing.Point(460, 190);
            this.textBoxIndicaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIndicaciones.Multiline = true;
            this.textBoxIndicaciones.Name = "textBoxIndicaciones";
            this.textBoxIndicaciones.Size = new System.Drawing.Size(592, 127);
            this.textBoxIndicaciones.TabIndex = 35;
            this.textBoxIndicaciones.TextChanged += new System.EventHandler(this.textBoxIndicaciones_TextChanged);
            // 
            // labelIndicaciones
            // 
            this.labelIndicaciones.AutoSize = true;
            this.labelIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicaciones.Location = new System.Drawing.Point(456, 166);
            this.labelIndicaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIndicaciones.Name = "labelIndicaciones";
            this.labelIndicaciones.Size = new System.Drawing.Size(102, 20);
            this.labelIndicaciones.TabIndex = 34;
            this.labelIndicaciones.Text = "Indicaciones";
            // 
            // textObservaciones
            // 
            this.textObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObservaciones.Location = new System.Drawing.Point(460, 372);
            this.textObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(592, 127);
            this.textObservaciones.TabIndex = 36;
            // 
            // atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textObservaciones);
            this.Controls.Add(this.textBoxIndicaciones);
            this.Controls.Add(this.labelIndicaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelObservaciones);
            this.Controls.Add(this.btnRegistrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "atencion";
            this.Size = new System.Drawing.Size(1503, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIndicaciones;
        private System.Windows.Forms.Label labelIndicaciones;
        private System.Windows.Forms.TextBox textObservaciones;
    }
}

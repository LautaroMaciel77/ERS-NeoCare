namespace ERS_NeoCare.Design.administrativo
{
    partial class evaluacion
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
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.textBoxIndicaciones = new System.Windows.Forms.TextBox();
            this.labelSintomas = new System.Windows.Forms.Label();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.labelIndicaciones = new System.Windows.Forms.Label();
            this.textBoxIndicacionesPaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Evaluacion Medica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(342, 354);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(99, 16);
            this.labelObservaciones.TabIndex = 20;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // textBoxIndicaciones
            // 
            this.textBoxIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndicaciones.Location = new System.Drawing.Point(345, 77);
            this.textBoxIndicaciones.Multiline = true;
            this.textBoxIndicaciones.Name = "textBoxIndicaciones";
            this.textBoxIndicaciones.Size = new System.Drawing.Size(445, 104);
            this.textBoxIndicaciones.TabIndex = 35;
            this.textBoxIndicaciones.TextChanged += new System.EventHandler(this.textBoxIndicaciones_TextChanged);
            // 
            // labelSintomas
            // 
            this.labelSintomas.AutoSize = true;
            this.labelSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSintomas.Location = new System.Drawing.Point(342, 58);
            this.labelSintomas.Name = "labelSintomas";
            this.labelSintomas.Size = new System.Drawing.Size(128, 16);
            this.labelSintomas.TabIndex = 34;
            this.labelSintomas.Text = "Sintomas (Opcional)";
            // 
            // textObservaciones
            // 
            this.textObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObservaciones.Location = new System.Drawing.Point(345, 373);
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(445, 104);
            this.textObservaciones.TabIndex = 36;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(483, 520);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(151, 40);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // labelIndicaciones
            // 
            this.labelIndicaciones.AutoSize = true;
            this.labelIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicaciones.Location = new System.Drawing.Point(342, 207);
            this.labelIndicaciones.Name = "labelIndicaciones";
            this.labelIndicaciones.Size = new System.Drawing.Size(217, 16);
            this.labelIndicaciones.TabIndex = 37;
            this.labelIndicaciones.Text = "Indicaciones al paciente (Opcional)";
            // 
            // textBoxIndicacionesPaciente
            // 
            this.textBoxIndicacionesPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndicacionesPaciente.Location = new System.Drawing.Point(345, 226);
            this.textBoxIndicacionesPaciente.Multiline = true;
            this.textBoxIndicacionesPaciente.Name = "textBoxIndicacionesPaciente";
            this.textBoxIndicacionesPaciente.Size = new System.Drawing.Size(445, 104);
            this.textBoxIndicacionesPaciente.TabIndex = 38;
            // 
            // evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxIndicacionesPaciente);
            this.Controls.Add(this.labelIndicaciones);
            this.Controls.Add(this.textObservaciones);
            this.Controls.Add(this.textBoxIndicaciones);
            this.Controls.Add(this.labelSintomas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelObservaciones);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "evaluacion";
            this.Size = new System.Drawing.Size(1127, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIndicaciones;
        private System.Windows.Forms.Label labelSintomas;
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label labelIndicaciones;
        private System.Windows.Forms.TextBox textBoxIndicacionesPaciente;
    }
}

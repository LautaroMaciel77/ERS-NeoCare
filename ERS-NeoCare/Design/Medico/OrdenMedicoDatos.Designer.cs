namespace ERS_NeoCare.Design
{
    partial class OrdenMedicoDatos
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
            this.labelIndicaciones = new System.Windows.Forms.Label();
            this.labelUrgencia = new System.Windows.Forms.Label();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.textBoxIndicaciones = new System.Windows.Forms.TextBox();
            this.labelTipoOrden = new System.Windows.Forms.Label();
            this.labelOrden = new System.Windows.Forms.Label();
            this.labelPacienteEvaluacion = new System.Windows.Forms.Label();
            this.labelFechaEvaluacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIndicaciones
            // 
            this.labelIndicaciones.AutoSize = true;
            this.labelIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicaciones.Location = new System.Drawing.Point(373, 307);
            this.labelIndicaciones.Name = "labelIndicaciones";
            this.labelIndicaciones.Size = new System.Drawing.Size(98, 20);
            this.labelIndicaciones.TabIndex = 0;
            this.labelIndicaciones.Text = "Indicaciones";
            // 
            // labelUrgencia
            // 
            this.labelUrgencia.AutoSize = true;
            this.labelUrgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrgencia.Location = new System.Drawing.Point(373, 245);
            this.labelUrgencia.Name = "labelUrgencia";
            this.labelUrgencia.Size = new System.Drawing.Size(73, 20);
            this.labelUrgencia.TabIndex = 1;
            this.labelUrgencia.Text = "Urgencia";
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSi.Location = new System.Drawing.Point(377, 268);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(41, 24);
            this.radioButtonSi.TabIndex = 2;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.Location = new System.Drawing.Point(420, 268);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(47, 24);
            this.radioButtonNo.TabIndex = 3;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // textBoxIndicaciones
            // 
            this.textBoxIndicaciones.Enabled = false;
            this.textBoxIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndicaciones.Location = new System.Drawing.Point(377, 330);
            this.textBoxIndicaciones.Multiline = true;
            this.textBoxIndicaciones.Name = "textBoxIndicaciones";
            this.textBoxIndicaciones.Size = new System.Drawing.Size(445, 163);
            this.textBoxIndicaciones.TabIndex = 36;
            // 
            // labelTipoOrden
            // 
            this.labelTipoOrden.AutoSize = true;
            this.labelTipoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoOrden.Location = new System.Drawing.Point(373, 180);
            this.labelTipoOrden.Name = "labelTipoOrden";
            this.labelTipoOrden.Size = new System.Drawing.Size(106, 20);
            this.labelTipoOrden.TabIndex = 37;
            this.labelTipoOrden.Text = "Tipo de orden";
            // 
            // labelOrden
            // 
            this.labelOrden.AutoSize = true;
            this.labelOrden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrden.Location = new System.Drawing.Point(526, 34);
            this.labelOrden.Name = "labelOrden";
            this.labelOrden.Size = new System.Drawing.Size(170, 25);
            this.labelOrden.TabIndex = 40;
            this.labelOrden.Text = "Orden (Pedido)";
            // 
            // labelPacienteEvaluacion
            // 
            this.labelPacienteEvaluacion.AutoSize = true;
            this.labelPacienteEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacienteEvaluacion.Location = new System.Drawing.Point(455, 131);
            this.labelPacienteEvaluacion.Name = "labelPacienteEvaluacion";
            this.labelPacienteEvaluacion.Size = new System.Drawing.Size(121, 20);
            this.labelPacienteEvaluacion.TabIndex = 46;
            this.labelPacienteEvaluacion.Text = "label paciente";
            // 
            // labelFechaEvaluacion
            // 
            this.labelFechaEvaluacion.AutoSize = true;
            this.labelFechaEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaEvaluacion.Location = new System.Drawing.Point(437, 89);
            this.labelFechaEvaluacion.Name = "labelFechaEvaluacion";
            this.labelFechaEvaluacion.Size = new System.Drawing.Size(97, 20);
            this.labelFechaEvaluacion.TabIndex = 45;
            this.labelFechaEvaluacion.Text = "label fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha:";
            // 
            // OrdenMedicoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPacienteEvaluacion);
            this.Controls.Add(this.labelFechaEvaluacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOrden);
            this.Controls.Add(this.labelTipoOrden);
            this.Controls.Add(this.textBoxIndicaciones);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonSi);
            this.Controls.Add(this.labelUrgencia);
            this.Controls.Add(this.labelIndicaciones);
            this.Name = "OrdenMedicoDatos";
            this.Size = new System.Drawing.Size(1196, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIndicaciones;
        private System.Windows.Forms.Label labelUrgencia;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.TextBox textBoxIndicaciones;
        private System.Windows.Forms.Label labelTipoOrden;
        private System.Windows.Forms.Label labelOrden;
        private System.Windows.Forms.Label labelPacienteEvaluacion;
        private System.Windows.Forms.Label labelFechaEvaluacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

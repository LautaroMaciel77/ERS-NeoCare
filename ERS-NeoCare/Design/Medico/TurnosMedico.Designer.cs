namespace ERS_NeoCare.Design
{
    partial class TurnosMedico
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRegistrarOrden = new System.Windows.Forms.Button();
            this.labelOrden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIndicaciones
            // 
            this.labelIndicaciones.AutoSize = true;
            this.labelIndicaciones.Location = new System.Drawing.Point(322, 227);
            this.labelIndicaciones.Name = "labelIndicaciones";
            this.labelIndicaciones.Size = new System.Drawing.Size(67, 13);
            this.labelIndicaciones.TabIndex = 0;
            this.labelIndicaciones.Text = "Indicaciones";
            // 
            // labelUrgencia
            // 
            this.labelUrgencia.AutoSize = true;
            this.labelUrgencia.Location = new System.Drawing.Point(325, 166);
            this.labelUrgencia.Name = "labelUrgencia";
            this.labelUrgencia.Size = new System.Drawing.Size(50, 13);
            this.labelUrgencia.TabIndex = 1;
            this.labelUrgencia.Text = "Urgencia";
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(328, 191);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSi.TabIndex = 2;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(368, 191);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 3;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // textBoxIndicaciones
            // 
            this.textBoxIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndicaciones.Location = new System.Drawing.Point(325, 253);
            this.textBoxIndicaciones.Multiline = true;
            this.textBoxIndicaciones.Name = "textBoxIndicaciones";
            this.textBoxIndicaciones.Size = new System.Drawing.Size(445, 163);
            this.textBoxIndicaciones.TabIndex = 36;
            // 
            // labelTipoOrden
            // 
            this.labelTipoOrden.AutoSize = true;
            this.labelTipoOrden.Location = new System.Drawing.Point(322, 115);
            this.labelTipoOrden.Name = "labelTipoOrden";
            this.labelTipoOrden.Size = new System.Drawing.Size(73, 13);
            this.labelTipoOrden.TabIndex = 37;
            this.labelTipoOrden.Text = "Tipo de orden";
            this.labelTipoOrden.Click += new System.EventHandler(this.labelTipoOrden_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // btnRegistrarOrden
            // 
            this.btnRegistrarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnRegistrarOrden.FlatAppearance.BorderSize = 0;
            this.btnRegistrarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarOrden.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarOrden.Location = new System.Drawing.Point(510, 539);
            this.btnRegistrarOrden.Name = "btnRegistrarOrden";
            this.btnRegistrarOrden.Size = new System.Drawing.Size(151, 40);
            this.btnRegistrarOrden.TabIndex = 39;
            this.btnRegistrarOrden.Text = "Registrar";
            this.btnRegistrarOrden.UseCompatibleTextRendering = true;
            this.btnRegistrarOrden.UseVisualStyleBackColor = false;
            // 
            // labelOrden
            // 
            this.labelOrden.AutoSize = true;
            this.labelOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrden.Location = new System.Drawing.Point(507, 42);
            this.labelOrden.Name = "labelOrden";
            this.labelOrden.Size = new System.Drawing.Size(123, 18);
            this.labelOrden.TabIndex = 40;
            this.labelOrden.Text = "Orden (Pedido)";
            // 
            // TurnosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelOrden);
            this.Controls.Add(this.btnRegistrarOrden);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTipoOrden);
            this.Controls.Add(this.textBoxIndicaciones);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonSi);
            this.Controls.Add(this.labelUrgencia);
            this.Controls.Add(this.labelIndicaciones);
            this.Name = "TurnosMedico";
            this.Size = new System.Drawing.Size(1196, 768);
            this.Load += new System.EventHandler(this.TurnosMedico_Load);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRegistrarOrden;
        private System.Windows.Forms.Label labelOrden;
    }
}

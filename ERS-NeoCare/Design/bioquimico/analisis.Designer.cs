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
            this.listViewArchivos = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrdenIndicaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelFechaOrden = new System.Windows.Forms.Label();
            this.labelPacienteDniOrden = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMedicoMatriculaOrden = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMedicoNombreOrden = new System.Windows.Forms.Label();
            this.labelPacienteNombreOrden = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButtonCargar
            // 
            this.iconButtonCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButtonCargar.FlatAppearance.BorderSize = 0;
            this.iconButtonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCargar.ForeColor = System.Drawing.Color.White;
            this.iconButtonCargar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButtonCargar.IconColor = System.Drawing.Color.White;
            this.iconButtonCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCargar.IconSize = 20;
            this.iconButtonCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCargar.Location = new System.Drawing.Point(980, 393);
            this.iconButtonCargar.Name = "iconButtonCargar";
            this.iconButtonCargar.Size = new System.Drawing.Size(106, 32);
            this.iconButtonCargar.TabIndex = 35;
            this.iconButtonCargar.Text = "Cargar";
            this.iconButtonCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCargar.UseVisualStyleBackColor = false;
            this.iconButtonCargar.Click += new System.EventHandler(this.iconButtonCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(816, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Analisis";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(511, 521);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(151, 40);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar analisis";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // LabelResultados
            // 
            this.LabelResultados.AutoSize = true;
            this.LabelResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultados.Location = new System.Drawing.Point(638, 307);
            this.LabelResultados.Name = "LabelResultados";
            this.LabelResultados.Size = new System.Drawing.Size(82, 20);
            this.LabelResultados.TabIndex = 21;
            this.LabelResultados.Text = "Resultado";
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(638, 170);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(187, 20);
            this.labelObservaciones.TabIndex = 20;
            this.labelObservaciones.Text = "Observaciones (opcional)";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(641, 189);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(445, 104);
            this.textBoxObservaciones.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tipo de analisis";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox1.Location = new System.Drawing.Point(641, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 28);
            this.comboBox1.TabIndex = 38;
            // 
            // listViewArchivos
            // 
            this.listViewArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewArchivos.HideSelection = false;
            this.listViewArchivos.Location = new System.Drawing.Point(637, 325);
            this.listViewArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewArchivos.Name = "listViewArchivos";
            this.listViewArchivos.Size = new System.Drawing.Size(449, 64);
            this.listViewArchivos.TabIndex = 40;
            this.listViewArchivos.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Orden de analisis";
            // 
            // textBoxOrdenIndicaciones
            // 
            this.textBoxOrdenIndicaciones.Enabled = false;
            this.textBoxOrdenIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrdenIndicaciones.Location = new System.Drawing.Point(51, 243);
            this.textBoxOrdenIndicaciones.Multiline = true;
            this.textBoxOrdenIndicaciones.Name = "textBoxOrdenIndicaciones";
            this.textBoxOrdenIndicaciones.Size = new System.Drawing.Size(445, 146);
            this.textBoxOrdenIndicaciones.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Indicaciones";
            // 
            // labelFechaOrden
            // 
            this.labelFechaOrden.AutoSize = true;
            this.labelFechaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaOrden.Location = new System.Drawing.Point(111, 77);
            this.labelFechaOrden.Name = "labelFechaOrden";
            this.labelFechaOrden.Size = new System.Drawing.Size(57, 20);
            this.labelFechaOrden.TabIndex = 47;
            this.labelFechaOrden.Text = "label8";
            // 
            // labelPacienteDniOrden
            // 
            this.labelPacienteDniOrden.AutoSize = true;
            this.labelPacienteDniOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacienteDniOrden.Location = new System.Drawing.Point(88, 132);
            this.labelPacienteDniOrden.Name = "labelPacienteDniOrden";
            this.labelPacienteDniOrden.Size = new System.Drawing.Size(57, 20);
            this.labelPacienteDniOrden.TabIndex = 70;
            this.labelPacienteDniOrden.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "DNI:";
            // 
            // labelMedicoMatriculaOrden
            // 
            this.labelMedicoMatriculaOrden.AutoSize = true;
            this.labelMedicoMatriculaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicoMatriculaOrden.Location = new System.Drawing.Point(89, 182);
            this.labelMedicoMatriculaOrden.Name = "labelMedicoMatriculaOrden";
            this.labelMedicoMatriculaOrden.Size = new System.Drawing.Size(57, 20);
            this.labelMedicoMatriculaOrden.TabIndex = 68;
            this.labelMedicoMatriculaOrden.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "MP:";
            // 
            // labelMedicoNombreOrden
            // 
            this.labelMedicoNombreOrden.AutoSize = true;
            this.labelMedicoNombreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicoNombreOrden.Location = new System.Drawing.Point(117, 162);
            this.labelMedicoNombreOrden.Name = "labelMedicoNombreOrden";
            this.labelMedicoNombreOrden.Size = new System.Drawing.Size(57, 20);
            this.labelMedicoNombreOrden.TabIndex = 66;
            this.labelMedicoNombreOrden.Text = "label8";
            // 
            // labelPacienteNombreOrden
            // 
            this.labelPacienteNombreOrden.AutoSize = true;
            this.labelPacienteNombreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacienteNombreOrden.Location = new System.Drawing.Point(117, 112);
            this.labelPacienteNombreOrden.Name = "labelPacienteNombreOrden";
            this.labelPacienteNombreOrden.Size = new System.Drawing.Size(57, 20);
            this.labelPacienteNombreOrden.TabIndex = 65;
            this.labelPacienteNombreOrden.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Paciente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Medico:";
            // 
            // analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPacienteDniOrden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelMedicoMatriculaOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMedicoNombreOrden);
            this.Controls.Add(this.labelPacienteNombreOrden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelFechaOrden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOrdenIndicaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewArchivos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.iconButtonCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelObservaciones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.LabelResultados);
            this.Name = "analisis";
            this.Size = new System.Drawing.Size(1196, 768);
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
        private System.Windows.Forms.ListView listViewArchivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrdenIndicaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelFechaOrden;
        private System.Windows.Forms.Label labelPacienteDniOrden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMedicoMatriculaOrden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMedicoNombreOrden;
        private System.Windows.Forms.Label labelPacienteNombreOrden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

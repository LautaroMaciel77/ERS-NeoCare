namespace ERS_NeoCare.Design.administrativo
{
    partial class agregar_paciente
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
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelObra = new System.Windows.Forms.Label();
            this.LabelDomicilio = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textObra = new System.Windows.Forms.TextBox();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(483, 120);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(73, 20);
            this.labelApellido.TabIndex = 16;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(483, 169);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 20);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(483, 218);
            this.labelDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(51, 20);
            this.labelDni.TabIndex = 18;
            this.labelDni.Text = "D.N.I:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(483, 267);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(164, 20);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "Fecha de nacimiento";
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObra.Location = new System.Drawing.Point(483, 317);
            this.labelObra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(121, 25);
            this.labelObra.TabIndex = 20;
            this.labelObra.Text = "Obra Social";
            // 
            // LabelDomicilio
            // 
            this.LabelDomicilio.AutoSize = true;
            this.LabelDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDomicilio.Location = new System.Drawing.Point(483, 366);
            this.LabelDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDomicilio.Name = "LabelDomicilio";
            this.LabelDomicilio.Size = new System.Drawing.Size(79, 20);
            this.LabelDomicilio.TabIndex = 21;
            this.LabelDomicilio.Text = "Domicilio";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(483, 413);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(46, 20);
            this.labelSexo.TabIndex = 22;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Click += new System.EventHandler(this.labelSexo_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(715, 260);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 26);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(715, 116);
            this.textApellido.Margin = new System.Windows.Forms.Padding(4);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(313, 26);
            this.textApellido.TabIndex = 24;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellido_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(715, 165);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(313, 26);
            this.textNombre.TabIndex = 25;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(715, 211);
            this.textDni.Margin = new System.Windows.Forms.Padding(4);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(313, 26);
            this.textDni.TabIndex = 26;
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textObra
            // 
            this.textObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObra.Location = new System.Drawing.Point(715, 313);
            this.textObra.Margin = new System.Windows.Forms.Padding(4);
            this.textObra.Name = "textObra";
            this.textObra.Size = new System.Drawing.Size(313, 26);
            this.textObra.TabIndex = 27;
            this.textObra.TextChanged += new System.EventHandler(this.textObra_TextChanged);
            this.textObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textObra_KeyPress);
            // 
            // textDomicilio
            // 
            this.textDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDomicilio.Location = new System.Drawing.Point(715, 363);
            this.textDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(313, 26);
            this.textDomicilio.TabIndex = 28;
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHombre.Location = new System.Drawing.Point(715, 413);
            this.radioHombre.Margin = new System.Windows.Forms.Padding(4);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(86, 24);
            this.radioHombre.TabIndex = 29;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            this.radioHombre.CheckedChanged += new System.EventHandler(this.radioHombre_CheckedChanged);
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMujer.Location = new System.Drawing.Point(860, 413);
            this.radioMujer.Margin = new System.Windows.Forms.Padding(4);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(72, 24);
            this.radioMujer.TabIndex = 22;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            this.radioMujer.CheckedChanged += new System.EventHandler(this.radioMujer_CheckedChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(631, 495);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(231, 43);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Paciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // agregar_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.radioMujer);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.radioHombre);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textObra);
            this.Controls.Add(this.labelObra);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.LabelDomicilio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "agregar_paciente";
            this.Size = new System.Drawing.Size(1503, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelObra;
        private System.Windows.Forms.Label LabelDomicilio;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textObra;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
    }
}

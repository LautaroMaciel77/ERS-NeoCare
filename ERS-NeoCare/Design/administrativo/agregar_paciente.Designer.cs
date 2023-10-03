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
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelApellido
            // 
<<<<<<< HEAD
            this.panelAgregarPaciente.Controls.Add(this.label1);
            this.panelAgregarPaciente.Controls.Add(this.iconButtonClose);
            this.panelAgregarPaciente.Controls.Add(this.btnRegistrar);
            this.panelAgregarPaciente.Controls.Add(this.radioMujer);
            this.panelAgregarPaciente.Controls.Add(this.radioHombre);
            this.panelAgregarPaciente.Controls.Add(this.textDomicilio);
            this.panelAgregarPaciente.Controls.Add(this.textObra);
            this.panelAgregarPaciente.Controls.Add(this.textDni);
            this.panelAgregarPaciente.Controls.Add(this.textNombre);
            this.panelAgregarPaciente.Controls.Add(this.textApellido);
            this.panelAgregarPaciente.Controls.Add(this.dateTimePicker1);
            this.panelAgregarPaciente.Controls.Add(this.labelSexo);
            this.panelAgregarPaciente.Controls.Add(this.LabelDomicilio);
            this.panelAgregarPaciente.Controls.Add(this.labelObra);
            this.panelAgregarPaciente.Controls.Add(this.labelFecha);
            this.panelAgregarPaciente.Controls.Add(this.labelDni);
            this.panelAgregarPaciente.Controls.Add(this.labelNombre);
            this.panelAgregarPaciente.Controls.Add(this.labelApellido);
            this.panelAgregarPaciente.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarPaciente.Name = "panelAgregarPaciente";
            this.panelAgregarPaciente.Size = new System.Drawing.Size(478, 415);
            this.panelAgregarPaciente.TabIndex = 17;
           // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Paciente";
          
=======
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(349, 179);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 17);
            this.labelApellido.TabIndex = 16;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(349, 219);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 17);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(349, 259);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(43, 17);
            this.labelDni.TabIndex = 18;
            this.labelDni.Text = "D.N.I:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(349, 299);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(146, 17);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "Fecha de nacimiento";
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObra.Location = new System.Drawing.Point(349, 339);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(79, 17);
            this.labelObra.TabIndex = 20;
            this.labelObra.Text = "ObraSocial";
            // 
            // LabelDomicilio
            // 
            this.LabelDomicilio.AutoSize = true;
            this.LabelDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDomicilio.Location = new System.Drawing.Point(349, 379);
            this.LabelDomicilio.Name = "LabelDomicilio";
            this.LabelDomicilio.Size = new System.Drawing.Size(69, 17);
            this.LabelDomicilio.TabIndex = 21;
            this.LabelDomicilio.Text = "Domicilio";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(355, 419);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(37, 17);
            this.labelSexo.TabIndex = 22;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Click += new System.EventHandler(this.labelSexo_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(523, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 23);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(523, 176);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(236, 23);
            this.textApellido.TabIndex = 24;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(523, 216);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(236, 23);
            this.textNombre.TabIndex = 25;
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(523, 253);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(236, 23);
            this.textDni.TabIndex = 26;
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textObra
            // 
            this.textObra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObra.Location = new System.Drawing.Point(523, 336);
            this.textObra.Name = "textObra";
            this.textObra.Size = new System.Drawing.Size(236, 23);
            this.textObra.TabIndex = 27;
            this.textObra.TextChanged += new System.EventHandler(this.textObra_TextChanged);
            this.textObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textObra_KeyPress);
            // 
            // textDomicilio
            // 
            this.textDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDomicilio.Location = new System.Drawing.Point(523, 376);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(236, 23);
            this.textDomicilio.TabIndex = 28;
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHombre.Location = new System.Drawing.Point(523, 417);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(77, 21);
            this.radioHombre.TabIndex = 29;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            this.radioHombre.CheckedChanged += new System.EventHandler(this.radioHombre_CheckedChanged);
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMujer.Location = new System.Drawing.Point(632, 417);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(62, 21);
            this.radioMujer.TabIndex = 22;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            this.radioMujer.CheckedChanged += new System.EventHandler(this.radioMujer_CheckedChanged);
>>>>>>> 1c2bf2b3d594a4329ecccc02652adfc0cde058ff
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(499, 469);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 23);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
<<<<<<< HEAD
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMujer.Location = new System.Drawing.Point(315, 319);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(62, 21);
            this.radioMujer.TabIndex = 22;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            this.radioMujer.CheckedChanged += new System.EventHandler(this.radioMujer_CheckedChanged);
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHombre.Location = new System.Drawing.Point(206, 319);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(77, 21);
            this.radioHombre.TabIndex = 29;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            this.radioHombre.CheckedChanged += new System.EventHandler(this.radioHombre_CheckedChanged);
            // 
            // textDomicilio
            // 
            this.textDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDomicilio.Location = new System.Drawing.Point(206, 278);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(236, 23);
            this.textDomicilio.TabIndex = 28;
            // 
            // textObra
            // 
            this.textObra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObra.Location = new System.Drawing.Point(206, 238);
            this.textObra.Name = "textObra";
            this.textObra.Size = new System.Drawing.Size(236, 23);
            this.textObra.TabIndex = 27;
         
            this.textObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textObra_KeyPress);
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(206, 155);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(236, 23);
            this.textDni.TabIndex = 26;
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(206, 118);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(236, 23);
            this.textNombre.TabIndex = 25;
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(206, 78);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(236, 23);
            this.textApellido.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 23);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(38, 321);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(37, 17);
            this.labelSexo.TabIndex = 22;
            this.labelSexo.Text = "Sexo";
    
            // 
            // LabelDomicilio
            // 
            this.LabelDomicilio.AutoSize = true;
            this.LabelDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDomicilio.Location = new System.Drawing.Point(32, 281);
            this.LabelDomicilio.Name = "LabelDomicilio";
            this.LabelDomicilio.Size = new System.Drawing.Size(69, 17);
            this.LabelDomicilio.TabIndex = 21;
            this.LabelDomicilio.Text = "Domicilio";
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObra.Location = new System.Drawing.Point(32, 241);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(79, 17);
            this.labelObra.TabIndex = 20;
            this.labelObra.Text = "ObraSocial";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(32, 201);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(146, 17);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "Fecha de nacimiento";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(32, 161);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(43, 17);
            this.labelDni.TabIndex = 18;
            this.labelDni.Text = "D.N.I:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(32, 121);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 17);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(32, 81);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 17);
            this.labelApellido.TabIndex = 16;
            this.labelApellido.Text = "Apellido:";
            // 
=======
>>>>>>> 1c2bf2b3d594a4329ecccc02652adfc0cde058ff
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButtonClose.IconColor = System.Drawing.Color.Black;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 24;
            this.iconButtonClose.Location = new System.Drawing.Point(3, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(52, 41);
            this.iconButtonClose.TabIndex = 32;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Paciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // agregar_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonClose);
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
            this.Name = "agregar_paciente";
            this.Size = new System.Drawing.Size(1127, 609);
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
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.Label label1;
    }
}

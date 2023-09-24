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
            this.panelAgregarPaciente = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.textObra = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelSexo = new System.Windows.Forms.Label();
            this.LabelDomicilio = new System.Windows.Forms.Label();
            this.labelObra = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.panelAgregarPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgregarPaciente
            // 
            this.panelAgregarPaciente.Controls.Add(this.buttonClose);
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
            this.panelAgregarPaciente.Size = new System.Drawing.Size(454, 341);
            this.panelAgregarPaciente.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(295, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(139, 23);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "buttoncerrar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(142, 267);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 23);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(257, 209);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(50, 17);
            this.radioMujer.TabIndex = 22;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            this.radioMujer.CheckedChanged += new System.EventHandler(this.radioMujer_CheckedChanged);
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Location = new System.Drawing.Point(152, 209);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(60, 17);
            this.radioHombre.TabIndex = 29;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            this.radioHombre.CheckedChanged += new System.EventHandler(this.radioHombre_CheckedChanged);
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(152, 177);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(100, 20);
            this.textDomicilio.TabIndex = 28;
            // 
            // textObra
            // 
            this.textObra.Location = new System.Drawing.Point(152, 147);
            this.textObra.Name = "textObra";
            this.textObra.Size = new System.Drawing.Size(100, 20);
            this.textObra.TabIndex = 27;
            this.textObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textObra_KeyPress);
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(152, 94);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(100, 20);
            this.textDni.TabIndex = 26;
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(152, 68);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 25;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(152, 33);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(43, 209);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 22;
            this.labelSexo.Text = "Sexo";
            // 
            // LabelDomicilio
            // 
            this.LabelDomicilio.AutoSize = true;
            this.LabelDomicilio.Location = new System.Drawing.Point(43, 177);
            this.LabelDomicilio.Name = "LabelDomicilio";
            this.LabelDomicilio.Size = new System.Drawing.Size(49, 13);
            this.LabelDomicilio.TabIndex = 21;
            this.LabelDomicilio.Text = "Domicilio";
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Location = new System.Drawing.Point(43, 150);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(59, 13);
            this.labelObra.TabIndex = 20;
            this.labelObra.Text = "ObraSocial";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(43, 126);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(93, 13);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "Fecha Nacimiento";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(43, 97);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(35, 13);
            this.labelDni.TabIndex = 18;
            this.labelDni.Text = "D.N.I:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(43, 64);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(43, 36);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 16;
            this.labelApellido.Text = "Apellido";
            // 
            // agregar_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAgregarPaciente);
            this.Name = "agregar_paciente";
            this.Size = new System.Drawing.Size(449, 339);
            this.panelAgregarPaciente.ResumeLayout(false);
            this.panelAgregarPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregarPaciente;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.TextBox textObra;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label LabelDomicilio;
        private System.Windows.Forms.Label labelObra;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
    }
}

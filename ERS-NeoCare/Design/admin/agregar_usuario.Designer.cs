namespace ERS_NeoCare.Design.administrativo
{
    partial class agregar_usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelProfesion = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.panelAgregarPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgregarPaciente
            // 
            this.panelAgregarPaciente.Controls.Add(this.textContraseña);
            this.panelAgregarPaciente.Controls.Add(this.textUsuario);
            this.panelAgregarPaciente.Controls.Add(this.labelContraseña);
            this.panelAgregarPaciente.Controls.Add(this.labelUsuario);
            this.panelAgregarPaciente.Controls.Add(this.labelProfesion);
            this.panelAgregarPaciente.Controls.Add(this.comboBox1);
            this.panelAgregarPaciente.Controls.Add(this.label1);
            this.panelAgregarPaciente.Controls.Add(this.iconButtonClose);
            this.panelAgregarPaciente.Controls.Add(this.btnRegistrar);
            this.panelAgregarPaciente.Controls.Add(this.textMatricula);
            this.panelAgregarPaciente.Controls.Add(this.textDni);
            this.panelAgregarPaciente.Controls.Add(this.textNombre);
            this.panelAgregarPaciente.Controls.Add(this.textApellido);
            this.panelAgregarPaciente.Controls.Add(this.labelMatricula);
            this.panelAgregarPaciente.Controls.Add(this.labelDni);
            this.panelAgregarPaciente.Controls.Add(this.labelNombre);
            this.panelAgregarPaciente.Controls.Add(this.labelApellido);
            this.panelAgregarPaciente.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarPaciente.Name = "panelAgregarPaciente";
            this.panelAgregarPaciente.Size = new System.Drawing.Size(478, 415);
            this.panelAgregarPaciente.TabIndex = 17;
            this.panelAgregarPaciente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAgregarPaciente_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(67)))), ((int)(((byte)(44)))));
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 12;
            this.iconButtonClose.Location = new System.Drawing.Point(443, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(32, 23);
            this.iconButtonClose.TabIndex = 32;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(182, 371);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 23);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(212, 228);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(236, 23);
            this.textDni.TabIndex = 26;
            this.textDni.TextChanged += new System.EventHandler(this.textDni_TextChanged);
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(212, 188);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(236, 23);
            this.textNombre.TabIndex = 25;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(212, 148);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(236, 23);
            this.textApellido.TabIndex = 24;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(58, 231);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(43, 17);
            this.labelDni.TabIndex = 18;
            this.labelDni.Text = "D.N.I:";
            this.labelDni.Click += new System.EventHandler(this.labelDni_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(58, 191);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 17);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(58, 151);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 17);
            this.labelApellido.TabIndex = 16;
            this.labelApellido.Text = "Apellido:";
            this.labelApellido.Click += new System.EventHandler(this.labelApellido_Click);
            // 
            // textMatricula
            // 
            this.textMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatricula.Location = new System.Drawing.Point(212, 268);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(236, 23);
            this.textMatricula.TabIndex = 27;
            this.textMatricula.TextChanged += new System.EventHandler(this.textObra_TextChanged);
            this.textMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textObra_KeyPress);
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(58, 271);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(72, 17);
            this.labelMatricula.TabIndex = 20;
            this.labelMatricula.Text = "Matricula:";
            this.labelMatricula.Click += new System.EventHandler(this.labelMatricula_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Medico",
            "Enfermero",
            "Bioquimico",
            "Administrativo"});
            this.comboBox1.Location = new System.Drawing.Point(212, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelProfesion
            // 
            this.labelProfesion.AutoSize = true;
            this.labelProfesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfesion.Location = new System.Drawing.Point(58, 309);
            this.labelProfesion.Name = "labelProfesion";
            this.labelProfesion.Size = new System.Drawing.Size(66, 17);
            this.labelProfesion.TabIndex = 36;
            this.labelProfesion.Text = "Profesion";
            this.labelProfesion.Click += new System.EventHandler(this.labelProfesion_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(61, 71);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(58, 17);
            this.labelUsuario.TabIndex = 37;
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(61, 111);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(88, 17);
            this.labelContraseña.TabIndex = 38;
            this.labelContraseña.Text = "Contraseña:";
            this.labelContraseña.Click += new System.EventHandler(this.labelContraseña_Click);
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(212, 68);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(236, 23);
            this.textUsuario.TabIndex = 39;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.Location = new System.Drawing.Point(212, 108);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(236, 23);
            this.textContraseña.TabIndex = 40;
            this.textContraseña.TextChanged += new System.EventHandler(this.textContraseña_TextChanged);
            // 
            // agregar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAgregarPaciente);
            this.Name = "agregar_usuario";
            this.Size = new System.Drawing.Size(478, 415);
            this.panelAgregarPaciente.ResumeLayout(false);
            this.panelAgregarPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregarPaciente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelProfesion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
    }
}

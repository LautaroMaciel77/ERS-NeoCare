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
            this.components = new System.ComponentModel.Container();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelProfesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new FontAwesome.Sharp.IconButton();
            this.ComboxProfesion = new System.Windows.Forms.ComboBox();
            this.dBNeoCareDataSet = new ERS_NeoCare.DBNeoCareDataSet();
            this.dBNeoCareDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalsaludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_saludTableAdapter = new ERS_NeoCare.DBNeoCareDataSetTableAdapters.personal_saludTableAdapter();
            this.personalsaludBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBNeoCareDataSet6 = new ERS_NeoCare.DBNeoCareDataSet6();
            this.profesionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionTableAdapter = new ERS_NeoCare.DBNeoCareDataSet6TableAdapters.profesionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.Location = new System.Drawing.Point(517, 382);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(236, 26);
            this.textContraseña.TabIndex = 40;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(358, 385);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(96, 20);
            this.labelContraseña.TabIndex = 38;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // labelProfesion
            // 
            this.labelProfesion.AutoSize = true;
            this.labelProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfesion.Location = new System.Drawing.Point(358, 299);
            this.labelProfesion.Name = "labelProfesion";
            this.labelProfesion.Size = new System.Drawing.Size(76, 20);
            this.labelProfesion.TabIndex = 36;
            this.labelProfesion.Text = "Profesion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Usuario";
            // 
            // textMatricula
            // 
            this.textMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatricula.Location = new System.Drawing.Point(517, 338);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(236, 26);
            this.textMatricula.TabIndex = 27;
            this.textMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textObra_KeyPress);
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(517, 215);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(236, 26);
            this.textDni.TabIndex = 26;
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(517, 175);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(236, 26);
            this.textNombre.TabIndex = 25;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(517, 258);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(236, 26);
            this.textApellido.TabIndex = 24;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellido_KeyPress);
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(358, 341);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(77, 20);
            this.labelMatricula.TabIndex = 20;
            this.labelMatricula.Text = "Matricula:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(358, 218);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(49, 20);
            this.labelDni.TabIndex = 18;
            this.labelDni.Text = "D.N.I:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(358, 178);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(358, 261);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(69, 20);
            this.labelApellido.TabIndex = 16;
            this.labelApellido.Text = "Apellido:";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegistrarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarUsuario.IconSize = 24;
            this.btnRegistrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(477, 473);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(167, 42);
            this.btnRegistrarUsuario.TabIndex = 42;
            this.btnRegistrarUsuario.Text = "Registrar usuario";
            this.btnRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // ComboxProfesion
            // 
            this.ComboxProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboxProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboxProfesion.FormattingEnabled = true;
            this.ComboxProfesion.Items.AddRange(new object[] {
            "administrativo",
            "enfermero",
            "medico",
            "bioquimico",
            "admin"});
            this.ComboxProfesion.Location = new System.Drawing.Point(517, 296);
            this.ComboxProfesion.Name = "ComboxProfesion";
            this.ComboxProfesion.Size = new System.Drawing.Size(236, 28);
            this.ComboxProfesion.TabIndex = 43;
            this.ComboxProfesion.SelectedIndexChanged += new System.EventHandler(this.ComboxProfesion_SelectedIndexChanged);
            // 
            // dBNeoCareDataSet
            // 
            this.dBNeoCareDataSet.DataSetName = "DBNeoCareDataSet";
            this.dBNeoCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBNeoCareDataSetBindingSource
            // 
            this.dBNeoCareDataSetBindingSource.DataSource = this.dBNeoCareDataSet;
            this.dBNeoCareDataSetBindingSource.Position = 0;
            // 
            // personalsaludBindingSource
            // 
            this.personalsaludBindingSource.DataMember = "personal_salud";
            this.personalsaludBindingSource.DataSource = this.dBNeoCareDataSetBindingSource;
            // 
            // personal_saludTableAdapter
            // 
            this.personal_saludTableAdapter.ClearBeforeFill = true;
            // 
            // personalsaludBindingSource1
            // 
            this.personalsaludBindingSource1.DataMember = "personal_salud";
            this.personalsaludBindingSource1.DataSource = this.dBNeoCareDataSetBindingSource;
            // 
            // dBNeoCareDataSet6
            // 
            this.dBNeoCareDataSet6.DataSetName = "DBNeoCareDataSet6";
            this.dBNeoCareDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesionBindingSource
            // 
            this.profesionBindingSource.DataMember = "profesion";
            this.profesionBindingSource.DataSource = this.dBNeoCareDataSet6;
            // 
            // profesionTableAdapter
            // 
            this.profesionTableAdapter.ClearBeforeFill = true;
            // 
            // agregar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboxProfesion);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelProfesion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textNombre);
            this.Name = "agregar_usuario";
            this.Size = new System.Drawing.Size(1127, 609);
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelProfesion;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private FontAwesome.Sharp.IconButton btnRegistrarUsuario;
        private System.Windows.Forms.ComboBox ComboxProfesion;
        private DBNeoCareDataSet dBNeoCareDataSet;
        private System.Windows.Forms.BindingSource dBNeoCareDataSetBindingSource;
        private System.Windows.Forms.BindingSource personalsaludBindingSource;
        private DBNeoCareDataSetTableAdapters.personal_saludTableAdapter personal_saludTableAdapter;
        private System.Windows.Forms.BindingSource personalsaludBindingSource1;
        private System.Windows.Forms.BindingSource profesionBindingSource;
        private DBNeoCareDataSet6 dBNeoCareDataSet6;
        private DBNeoCareDataSet6TableAdapters.profesionTableAdapter profesionTableAdapter;
    }
}

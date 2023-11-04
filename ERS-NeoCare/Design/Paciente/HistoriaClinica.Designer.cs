namespace ERS_NeoCare.Design.Paciente
{
    partial class HistoriaClinica
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listViewMedicamentos = new System.Windows.Forms.ListView();
            this.listViewFamiliares = new System.Windows.Forms.ListView();
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAlergias = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LHistoriaClinica = new System.Windows.Forms.Label();
            this.labelDatoNombre = new System.Windows.Forms.Label();
            this.labelDatoMatricula = new System.Windows.Forms.Label();
            this.labelDatoFechaInicio = new System.Windows.Forms.Label();
            this.btnEditFamiliares = new FontAwesome.Sharp.IconButton();
            this.btnEditMedicamentos = new FontAwesome.Sharp.IconButton();
            this.btnAlergias = new FontAwesome.Sharp.IconButton();
            this.listViewArchivos = new System.Windows.Forms.ListView();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btn_borrar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCargarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnBorrarArchivo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMedicamentos
            // 
            this.listViewMedicamentos.HideSelection = false;
            this.listViewMedicamentos.Location = new System.Drawing.Point(34, 326);
            this.listViewMedicamentos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewMedicamentos.Name = "listViewMedicamentos";
            this.listViewMedicamentos.Size = new System.Drawing.Size(629, 111);
            this.listViewMedicamentos.TabIndex = 27;
            this.listViewMedicamentos.UseCompatibleStateImageBehavior = false;
            this.listViewMedicamentos.View = System.Windows.Forms.View.List;
            // 
            // listViewFamiliares
            // 
            this.listViewFamiliares.HideSelection = false;
            this.listViewFamiliares.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewFamiliares.Location = new System.Drawing.Point(34, 185);
            this.listViewFamiliares.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFamiliares.Name = "listViewFamiliares";
            this.listViewFamiliares.Size = new System.Drawing.Size(629, 111);
            this.listViewFamiliares.TabIndex = 26;
            this.listViewFamiliares.UseCompatibleStateImageBehavior = false;
            this.listViewFamiliares.View = System.Windows.Forms.View.List;
            // 
            // listViewAlergias
            // 
            this.listViewAlergias.HideSelection = false;
            this.listViewAlergias.Location = new System.Drawing.Point(34, 466);
            this.listViewAlergias.Margin = new System.Windows.Forms.Padding(2);
            this.listViewAlergias.Name = "listViewAlergias";
            this.listViewAlergias.Size = new System.Drawing.Size(629, 111);
            this.listViewAlergias.TabIndex = 25;
            this.listViewAlergias.UseCompatibleStateImageBehavior = false;
            this.listViewAlergias.View = System.Windows.Forms.View.List;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 307);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Medicamentos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 588);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Estudios(archivos)";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(441, 48);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(111, 18);
            this.labelFecha.TabIndex = 22;
            this.labelFecha.Text = "Fecha de inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 447);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Alergias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Antecedentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Antecedentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Medico";
            // 
            // LHistoriaClinica
            // 
            this.LHistoriaClinica.AutoSize = true;
            this.LHistoriaClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistoriaClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.LHistoriaClinica.Location = new System.Drawing.Point(284, 15);
            this.LHistoriaClinica.Name = "LHistoriaClinica";
            this.LHistoriaClinica.Size = new System.Drawing.Size(129, 20);
            this.LHistoriaClinica.TabIndex = 15;
            this.LHistoriaClinica.Text = "Historia Clinica";
            // 
            // labelDatoNombre
            // 
            this.labelDatoNombre.AutoSize = true;
            this.labelDatoNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatoNombre.Location = new System.Drawing.Point(108, 75);
            this.labelDatoNombre.Name = "labelDatoNombre";
            this.labelDatoNombre.Size = new System.Drawing.Size(201, 16);
            this.labelDatoNombre.TabIndex = 29;
            this.labelDatoNombre.Text = "Nombre apellido concatenado";
            // 
            // labelDatoMatricula
            // 
            this.labelDatoMatricula.AutoSize = true;
            this.labelDatoMatricula.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatoMatricula.Location = new System.Drawing.Point(119, 103);
            this.labelDatoMatricula.Name = "labelDatoMatricula";
            this.labelDatoMatricula.Size = new System.Drawing.Size(67, 16);
            this.labelDatoMatricula.TabIndex = 30;
            this.labelDatoMatricula.Text = "Matricula";
            // 
            // labelDatoFechaInicio
            // 
            this.labelDatoFechaInicio.AutoSize = true;
            this.labelDatoFechaInicio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatoFechaInicio.Location = new System.Drawing.Point(571, 51);
            this.labelDatoFechaInicio.Name = "labelDatoFechaInicio";
            this.labelDatoFechaInicio.Size = new System.Drawing.Size(89, 16);
            this.labelDatoFechaInicio.TabIndex = 31;
            this.labelDatoFechaInicio.Text = "dd/mm/aaaa";
            // 
            // btnEditFamiliares
            // 
            this.btnEditFamiliares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnEditFamiliares.FlatAppearance.BorderSize = 0;
            this.btnEditFamiliares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.btnEditFamiliares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFamiliares.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditFamiliares.IconColor = System.Drawing.Color.White;
            this.btnEditFamiliares.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditFamiliares.IconSize = 12;
            this.btnEditFamiliares.Location = new System.Drawing.Point(152, 170);
            this.btnEditFamiliares.Name = "btnEditFamiliares";
            this.btnEditFamiliares.Size = new System.Drawing.Size(32, 14);
            this.btnEditFamiliares.TabIndex = 35;
            this.btnEditFamiliares.UseVisualStyleBackColor = false;
            this.btnEditFamiliares.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // btnEditMedicamentos
            // 
            this.btnEditMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnEditMedicamentos.FlatAppearance.BorderSize = 0;
            this.btnEditMedicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.btnEditMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMedicamentos.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditMedicamentos.IconColor = System.Drawing.Color.White;
            this.btnEditMedicamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditMedicamentos.IconSize = 12;
            this.btnEditMedicamentos.Location = new System.Drawing.Point(154, 311);
            this.btnEditMedicamentos.Name = "btnEditMedicamentos";
            this.btnEditMedicamentos.Size = new System.Drawing.Size(32, 14);
            this.btnEditMedicamentos.TabIndex = 36;
            this.btnEditMedicamentos.UseVisualStyleBackColor = false;
            this.btnEditMedicamentos.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAlergias
            // 
            this.btnAlergias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnAlergias.FlatAppearance.BorderSize = 0;
            this.btnAlergias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.btnAlergias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlergias.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAlergias.IconColor = System.Drawing.Color.White;
            this.btnAlergias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlergias.IconSize = 12;
            this.btnAlergias.Location = new System.Drawing.Point(103, 451);
            this.btnAlergias.Name = "btnAlergias";
            this.btnAlergias.Size = new System.Drawing.Size(32, 14);
            this.btnAlergias.TabIndex = 37;
            this.btnAlergias.UseVisualStyleBackColor = false;
            this.btnAlergias.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // listViewArchivos
            // 
            this.listViewArchivos.HideSelection = false;
            this.listViewArchivos.Location = new System.Drawing.Point(32, 623);
            this.listViewArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewArchivos.Name = "listViewArchivos";
            this.listViewArchivos.Size = new System.Drawing.Size(629, 111);
            this.listViewArchivos.TabIndex = 28;
            this.listViewArchivos.UseCompatibleStateImageBehavior = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 12;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(152, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 17);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btn_borrar);
            this.panel1.Controls.Add(this.btn_Editar);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.textBoxContenido);
            this.panel1.Location = new System.Drawing.Point(152, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 189);
            this.panel1.TabIndex = 40;
            // 
            // btnClose
            // 
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(212, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_borrar.IconColor = System.Drawing.Color.Black;
            this.btn_borrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_borrar.Location = new System.Drawing.Point(166, 147);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 41;
            this.btn_borrar.Text = "borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Editar.IconColor = System.Drawing.Color.Black;
            this.btn_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Editar.Location = new System.Drawing.Point(85, 147);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 42;
            this.btn_Editar.Text = "editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 12;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(84, 124);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(157, 17);
            this.iconButton2.TabIndex = 40;
            this.iconButton2.Text = "Guardar ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(14, 38);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(284, 80);
            this.textBoxContenido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tipo Sangre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBox1.Location = new System.Drawing.Point(525, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCargarArchivo.IconColor = System.Drawing.Color.White;
            this.btnCargarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarArchivo.IconSize = 12;
            this.btnCargarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarArchivo.Location = new System.Drawing.Point(168, 588);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(157, 30);
            this.btnCargarArchivo.TabIndex = 43;
            this.btnCargarArchivo.Text = "cargar archvio";
            this.btnCargarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnBorrarArchivo
            // 
            this.btnBorrarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnBorrarArchivo.FlatAppearance.BorderSize = 0;
            this.btnBorrarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.btnBorrarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarArchivo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnBorrarArchivo.IconColor = System.Drawing.Color.White;
            this.btnBorrarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrarArchivo.IconSize = 12;
            this.btnBorrarArchivo.Location = new System.Drawing.Point(331, 591);
            this.btnBorrarArchivo.Name = "btnBorrarArchivo";
            this.btnBorrarArchivo.Size = new System.Drawing.Size(32, 27);
            this.btnBorrarArchivo.TabIndex = 44;
            this.btnBorrarArchivo.UseVisualStyleBackColor = false;
            this.btnBorrarArchivo.Click += new System.EventHandler(this.btnBorrarArchivo_Click);
            // 
            // HistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.btnBorrarArchivo);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAlergias);
            this.Controls.Add(this.btnEditMedicamentos);
            this.Controls.Add(this.btnEditFamiliares);
            this.Controls.Add(this.labelDatoFechaInicio);
            this.Controls.Add(this.labelDatoMatricula);
            this.Controls.Add(this.labelDatoNombre);
            this.Controls.Add(this.listViewArchivos);
            this.Controls.Add(this.listViewMedicamentos);
            this.Controls.Add(this.listViewFamiliares);
            this.Controls.Add(this.listViewAlergias);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LHistoriaClinica);
            this.Name = "HistoriaClinica";
            this.Size = new System.Drawing.Size(458, 231);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewMedicamentos;
        private System.Windows.Forms.ListView listViewFamiliares;
        private System.Windows.Forms.ListView listViewAlergias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LHistoriaClinica;
        private System.Windows.Forms.Label labelDatoNombre;
        private System.Windows.Forms.Label labelDatoMatricula;
        private System.Windows.Forms.Label labelDatoFechaInicio;
        private FontAwesome.Sharp.IconButton btnEditFamiliares;
        private FontAwesome.Sharp.IconButton btnEditMedicamentos;
        private FontAwesome.Sharp.IconButton btnAlergias;
        private System.Windows.Forms.ListView listViewArchivos;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textBoxContenido;
        private FontAwesome.Sharp.IconButton btn_borrar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnCargarArchivo;
        private FontAwesome.Sharp.IconButton btnBorrarArchivo;
    }
}

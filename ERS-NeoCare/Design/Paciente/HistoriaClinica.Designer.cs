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
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonBorrar = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCargarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnBorrarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnVer = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonImprimir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMedicamentos
            // 
            this.listViewMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMedicamentos.HideSelection = false;
            this.listViewMedicamentos.Location = new System.Drawing.Point(145, 582);
            this.listViewMedicamentos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewMedicamentos.Name = "listViewMedicamentos";
            this.listViewMedicamentos.Size = new System.Drawing.Size(629, 150);
            this.listViewMedicamentos.TabIndex = 27;
            this.listViewMedicamentos.UseCompatibleStateImageBehavior = false;
            this.listViewMedicamentos.View = System.Windows.Forms.View.List;
            // 
            // listViewFamiliares
            // 
            this.listViewFamiliares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFamiliares.HideSelection = false;
            this.listViewFamiliares.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewFamiliares.Location = new System.Drawing.Point(145, 368);
            this.listViewFamiliares.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFamiliares.Name = "listViewFamiliares";
            this.listViewFamiliares.Size = new System.Drawing.Size(629, 150);
            this.listViewFamiliares.TabIndex = 26;
            this.listViewFamiliares.UseCompatibleStateImageBehavior = false;
            this.listViewFamiliares.View = System.Windows.Forms.View.List;
            // 
            // listViewAlergias
            // 
            this.listViewAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAlergias.HideSelection = false;
            this.listViewAlergias.Location = new System.Drawing.Point(145, 799);
            this.listViewAlergias.Margin = new System.Windows.Forms.Padding(2);
            this.listViewAlergias.Name = "listViewAlergias";
            this.listViewAlergias.Size = new System.Drawing.Size(629, 150);
            this.listViewAlergias.TabIndex = 25;
            this.listViewAlergias.UseCompatibleStateImageBehavior = false;
            this.listViewAlergias.View = System.Windows.Forms.View.List;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 551);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Medicamentos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 986);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Estudios(archivos)";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(551, 69);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(135, 20);
            this.labelFecha.TabIndex = 22;
            this.labelFecha.Text = "Fecha de inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 768);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Alergias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Antecedentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Antecedentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Medico";
            // 
            // LHistoriaClinica
            // 
            this.LHistoriaClinica.AutoSize = true;
            this.LHistoriaClinica.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistoriaClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.LHistoriaClinica.Location = new System.Drawing.Point(380, 19);
            this.LHistoriaClinica.Name = "LHistoriaClinica";
            this.LHistoriaClinica.Size = new System.Drawing.Size(149, 23);
            this.LHistoriaClinica.TabIndex = 15;
            this.LHistoriaClinica.Text = "Historia Clinica";
            // 
            // labelDatoNombre
            // 
            this.labelDatoNombre.AutoSize = true;
            this.labelDatoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatoNombre.Location = new System.Drawing.Point(215, 102);
            this.labelDatoNombre.Name = "labelDatoNombre";
            this.labelDatoNombre.Size = new System.Drawing.Size(220, 20);
            this.labelDatoNombre.TabIndex = 29;
            this.labelDatoNombre.Text = "Nombre apellido concatenado";
            // 
            // labelDatoMatricula
            // 
            this.labelDatoMatricula.AutoSize = true;
            this.labelDatoMatricula.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatoMatricula.Location = new System.Drawing.Point(229, 133);
            this.labelDatoMatricula.Name = "labelDatoMatricula";
            this.labelDatoMatricula.Size = new System.Drawing.Size(82, 18);
            this.labelDatoMatricula.TabIndex = 30;
            this.labelDatoMatricula.Text = "Matricula";
            // 
            // labelDatoFechaInicio
            // 
            this.labelDatoFechaInicio.AutoSize = true;
            this.labelDatoFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatoFechaInicio.Location = new System.Drawing.Point(691, 69);
            this.labelDatoFechaInicio.Name = "labelDatoFechaInicio";
            this.labelDatoFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.labelDatoFechaInicio.TabIndex = 31;
            this.labelDatoFechaInicio.Text = "dd/mm/aaaa";
            // 
            // btnEditFamiliares
            // 
            this.btnEditFamiliares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnEditFamiliares.FlatAppearance.BorderSize = 0;
            this.btnEditFamiliares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.btnEditFamiliares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFamiliares.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditFamiliares.IconColor = System.Drawing.Color.Black;
            this.btnEditFamiliares.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditFamiliares.IconSize = 16;
            this.btnEditFamiliares.Location = new System.Drawing.Point(742, 523);
            this.btnEditFamiliares.Name = "btnEditFamiliares";
            this.btnEditFamiliares.Size = new System.Drawing.Size(32, 22);
            this.btnEditFamiliares.TabIndex = 35;
            this.btnEditFamiliares.UseVisualStyleBackColor = false;
            this.btnEditFamiliares.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // btnEditMedicamentos
            // 
            this.btnEditMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnEditMedicamentos.FlatAppearance.BorderSize = 0;
            this.btnEditMedicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.btnEditMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMedicamentos.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditMedicamentos.IconColor = System.Drawing.Color.Black;
            this.btnEditMedicamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditMedicamentos.IconSize = 16;
            this.btnEditMedicamentos.Location = new System.Drawing.Point(742, 737);
            this.btnEditMedicamentos.Name = "btnEditMedicamentos";
            this.btnEditMedicamentos.Size = new System.Drawing.Size(32, 22);
            this.btnEditMedicamentos.TabIndex = 36;
            this.btnEditMedicamentos.UseVisualStyleBackColor = false;
            this.btnEditMedicamentos.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAlergias
            // 
            this.btnAlergias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnAlergias.FlatAppearance.BorderSize = 0;
            this.btnAlergias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.btnAlergias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlergias.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAlergias.IconColor = System.Drawing.Color.Black;
            this.btnAlergias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlergias.IconSize = 16;
            this.btnAlergias.Location = new System.Drawing.Point(742, 954);
            this.btnAlergias.Name = "btnAlergias";
            this.btnAlergias.Size = new System.Drawing.Size(32, 22);
            this.btnAlergias.TabIndex = 37;
            this.btnAlergias.UseVisualStyleBackColor = false;
            this.btnAlergias.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // listViewArchivos
            // 
            this.listViewArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewArchivos.HideSelection = false;
            this.listViewArchivos.Location = new System.Drawing.Point(145, 1020);
            this.listViewArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewArchivos.Name = "listViewArchivos";
            this.listViewArchivos.Size = new System.Drawing.Size(629, 150);
            this.listViewArchivos.TabIndex = 28;
            this.listViewArchivos.UseCompatibleStateImageBehavior = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(261, 1257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(341, 56);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar datos en Historia Clinica";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.iconButtonClose);
            this.panel1.Controls.Add(this.textBoxContenido);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(194, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 372);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(67)))), ((int)(((byte)(44)))));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 12;
            this.iconButtonClose.Location = new System.Drawing.Point(497, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(32, 23);
            this.iconButtonClose.TabIndex = 44;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click_1);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(20, 50);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(490, 265);
            this.textBoxContenido.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.iconButtonBorrar);
            this.panel2.Controls.Add(this.iconButtonEditar);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 340);
            this.panel2.TabIndex = 47;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // iconButtonBorrar
            // 
            this.iconButtonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButtonBorrar.FlatAppearance.BorderSize = 0;
            this.iconButtonBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.iconButtonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBorrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButtonBorrar.IconColor = System.Drawing.Color.Black;
            this.iconButtonBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBorrar.IconSize = 20;
            this.iconButtonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBorrar.Location = new System.Drawing.Point(309, 292);
            this.iconButtonBorrar.Name = "iconButtonBorrar";
            this.iconButtonBorrar.Size = new System.Drawing.Size(82, 28);
            this.iconButtonBorrar.TabIndex = 46;
            this.iconButtonBorrar.Text = "Borrar";
            this.iconButtonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBorrar.UseVisualStyleBackColor = false;
            this.iconButtonBorrar.Click += new System.EventHandler(this.iconButtonBorrar_Click);
            // 
            // iconButtonEditar
            // 
            this.iconButtonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButtonEditar.FlatAppearance.BorderSize = 0;
            this.iconButtonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.iconButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEditar.IconColor = System.Drawing.Color.Black;
            this.iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditar.IconSize = 20;
            this.iconButtonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEditar.Location = new System.Drawing.Point(219, 292);
            this.iconButtonEditar.Name = "iconButtonEditar";
            this.iconButtonEditar.Size = new System.Drawing.Size(84, 28);
            this.iconButtonEditar.TabIndex = 45;
            this.iconButtonEditar.Text = "Editar";
            this.iconButtonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEditar.UseVisualStyleBackColor = false;
            this.iconButtonEditar.Click += new System.EventHandler(this.iconButtonEditar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(397, 292);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(110, 28);
            this.iconButton2.TabIndex = 40;
            this.iconButton2.Text = "Guardar ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tipo Sangre";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBox1.Location = new System.Drawing.Point(264, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.Black;
            this.btnCargarArchivo.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnCargarArchivo.IconColor = System.Drawing.Color.Black;
            this.btnCargarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarArchivo.IconSize = 20;
            this.btnCargarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarArchivo.Location = new System.Drawing.Point(413, 1175);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(157, 27);
            this.btnCargarArchivo.TabIndex = 43;
            this.btnCargarArchivo.Text = "Cargar archivo";
            this.btnCargarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnBorrarArchivo
            // 
            this.btnBorrarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnBorrarArchivo.FlatAppearance.BorderSize = 0;
            this.btnBorrarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.btnBorrarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarArchivo.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarArchivo.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnBorrarArchivo.IconColor = System.Drawing.Color.Black;
            this.btnBorrarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrarArchivo.IconSize = 20;
            this.btnBorrarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarArchivo.Location = new System.Drawing.Point(576, 1175);
            this.btnBorrarArchivo.Name = "btnBorrarArchivo";
            this.btnBorrarArchivo.Size = new System.Drawing.Size(102, 27);
            this.btnBorrarArchivo.TabIndex = 44;
            this.btnBorrarArchivo.Text = "Borrar";
            this.btnBorrarArchivo.UseVisualStyleBackColor = false;
            this.btnBorrarArchivo.Click += new System.EventHandler(this.btnBorrarArchivo_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Black;
            this.btnVer.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnVer.IconColor = System.Drawing.Color.Black;
            this.btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVer.IconSize = 20;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(683, 1175);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(91, 27);
            this.btnVer.TabIndex = 45;
            this.btnVer.Text = "Abrir";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 1333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 33);
            this.label8.TabIndex = 46;
            this.label8.Text = " ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 247);
            this.panel3.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(250, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Historial actuaciones medicas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CEvento,
            this.CDatos,
            this.CAcciones});
            this.dataGridView1.Location = new System.Drawing.Point(27, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(765, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // CEvento
            // 
            this.CEvento.HeaderText = "Evento";
            this.CEvento.MinimumWidth = 6;
            this.CEvento.Name = "CEvento";
            this.CEvento.ReadOnly = true;
            // 
            // CDatos
            // 
            this.CDatos.HeaderText = "Fecha";
            this.CDatos.MinimumWidth = 6;
            this.CDatos.Name = "CDatos";
            this.CDatos.ReadOnly = true;
            // 
            // CAcciones
            // 
            this.CAcciones.HeaderText = "Acciones";
            this.CAcciones.MinimumWidth = 6;
            this.CAcciones.Name = "CAcciones";
            this.CAcciones.ReadOnly = true;
            // 
            // iconButtonImprimir
            // 
            this.iconButtonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconButtonImprimir.FlatAppearance.BorderSize = 0;
            this.iconButtonImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.iconButtonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButtonImprimir.IconColor = System.Drawing.Color.Black;
            this.iconButtonImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonImprimir.IconSize = 30;
            this.iconButtonImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonImprimir.Location = new System.Drawing.Point(663, 1257);
            this.iconButtonImprimir.Name = "iconButtonImprimir";
            this.iconButtonImprimir.Size = new System.Drawing.Size(111, 56);
            this.iconButtonImprimir.TabIndex = 48;
            this.iconButtonImprimir.Text = "Imprimir";
            this.iconButtonImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonImprimir.UseVisualStyleBackColor = false;
            this.iconButtonImprimir.Click += new System.EventHandler(this.iconButtonImprimir_Click);
            // 
            // HistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.iconButtonImprimir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVer);
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
            this.Size = new System.Drawing.Size(815, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnCargarArchivo;
        private FontAwesome.Sharp.IconButton btnBorrarArchivo;
        private FontAwesome.Sharp.IconButton btnVer;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonBorrar;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAcciones;
        private FontAwesome.Sharp.IconButton iconButtonImprimir;
    }
}

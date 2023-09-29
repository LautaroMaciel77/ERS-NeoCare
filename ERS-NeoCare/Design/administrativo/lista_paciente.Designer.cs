namespace ERS_NeoCare.Design
{
    partial class lista_paciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelMenuPaciente = new System.Windows.Forms.Panel();
            this.iconTurno = new FontAwesome.Sharp.IconButton();
            this.iconClose = new FontAwesome.Sharp.IconButton();
            this.iconVer = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DGVAdministrativo = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrasocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ERS_NeoCare.DatabaseDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.pacienteTableAdapter = new ERS_NeoCare.DatabaseDataSetTableAdapters.PacienteTableAdapter();
            this.panel.SuspendLayout();
            this.panelMenuPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.panelOpciones);
            this.panel.Controls.Add(this.panelMenuPaciente);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.DGVAdministrativo);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.btnAgregar);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(872, 549);
            this.panel.TabIndex = 0;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.Transparent;
            this.panelOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelOpciones.Location = new System.Drawing.Point(130, 184);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(541, 299);
            this.panelOpciones.TabIndex = 16;
            // 
            // panelMenuPaciente
            // 
            this.panelMenuPaciente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMenuPaciente.Controls.Add(this.iconTurno);
            this.panelMenuPaciente.Controls.Add(this.iconClose);
            this.panelMenuPaciente.Controls.Add(this.iconVer);
            this.panelMenuPaciente.Location = new System.Drawing.Point(297, 220);
            this.panelMenuPaciente.Name = "panelMenuPaciente";
            this.panelMenuPaciente.Size = new System.Drawing.Size(217, 129);
            this.panelMenuPaciente.TabIndex = 16;
            // 
            // iconTurno
            // 
            this.iconTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconTurno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            this.iconTurno.FlatAppearance.BorderSize = 0;
            this.iconTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.iconTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTurno.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTurno.ForeColor = System.Drawing.Color.Transparent;
            this.iconTurno.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconTurno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.iconTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTurno.IconSize = 35;
            this.iconTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconTurno.Location = new System.Drawing.Point(0, 76);
            this.iconTurno.Margin = new System.Windows.Forms.Padding(0);
            this.iconTurno.Name = "iconTurno";
            this.iconTurno.Size = new System.Drawing.Size(216, 40);
            this.iconTurno.TabIndex = 22;
            this.iconTurno.Text = "agregar Turno";
            this.iconTurno.UseVisualStyleBackColor = false;
            this.iconTurno.Click += new System.EventHandler(this.iconTurno_Click);
            // 
            // iconClose
            // 
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconClose.IconColor = System.Drawing.Color.Black;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.Location = new System.Drawing.Point(139, -1);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(75, 23);
            this.iconClose.TabIndex = 21;
            this.iconClose.Text = "cerrar";
            this.iconClose.UseVisualStyleBackColor = true;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click_1);
            // 
            // iconVer
            // 
            this.iconVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconVer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            this.iconVer.FlatAppearance.BorderSize = 0;
            this.iconVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))));
            this.iconVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconVer.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconVer.ForeColor = System.Drawing.Color.Transparent;
            this.iconVer.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconVer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.iconVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVer.IconSize = 35;
            this.iconVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconVer.Location = new System.Drawing.Point(1, 25);
            this.iconVer.Margin = new System.Windows.Forms.Padding(0);
            this.iconVer.Name = "iconVer";
            this.iconVer.Size = new System.Drawing.Size(216, 40);
            this.iconVer.TabIndex = 19;
            this.iconVer.Text = "ver paciente";
            this.iconVer.UseVisualStyleBackColor = false;
            this.iconVer.Click += new System.EventHandler(this.iconVer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Buscar";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(76, 81);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 27);
            this.textBox2.TabIndex = 13;
            // 
            // DGVAdministrativo
            // 
            this.DGVAdministrativo.AllowUserToAddRows = false;
            this.DGVAdministrativo.AllowUserToDeleteRows = false;
            this.DGVAdministrativo.AllowUserToResizeColumns = false;
            this.DGVAdministrativo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVAdministrativo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAdministrativo.AutoGenerateColumns = false;
            this.DGVAdministrativo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAdministrativo.BackgroundColor = System.Drawing.Color.White;
            this.DGVAdministrativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVAdministrativo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAdministrativo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVAdministrativo.ColumnHeadersHeight = 40;
            this.DGVAdministrativo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.obrasocialDataGridViewTextBoxColumn,
            this.CAcciones});
            this.DGVAdministrativo.DataSource = this.pacienteBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAdministrativo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAdministrativo.EnableHeadersVisualStyles = false;
            this.DGVAdministrativo.Location = new System.Drawing.Point(19, 125);
            this.DGVAdministrativo.Margin = new System.Windows.Forms.Padding(2);
            this.DGVAdministrativo.Name = "DGVAdministrativo";
            this.DGVAdministrativo.ReadOnly = true;
            this.DGVAdministrativo.RowHeadersVisible = false;
            this.DGVAdministrativo.RowHeadersWidth = 51;
            this.DGVAdministrativo.RowTemplate.Height = 40;
            this.DGVAdministrativo.Size = new System.Drawing.Size(751, 411);
            this.DGVAdministrativo.TabIndex = 10;
            this.DGVAdministrativo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAdministrativo_CellContentClick);
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.Frozen = true;
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Width = 96;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.Frozen = true;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 95;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Frozen = true;
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 96;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.Frozen = true;
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domicilioDataGridViewTextBoxColumn.Width = 96;
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Frozen = true;
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            this.fechanacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechanacimientoDataGridViewTextBoxColumn.Width = 95;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.Frozen = true;
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 96;
            // 
            // obrasocialDataGridViewTextBoxColumn
            // 
            this.obrasocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.obrasocialDataGridViewTextBoxColumn.DataPropertyName = "obra_social";
            this.obrasocialDataGridViewTextBoxColumn.Frozen = true;
            this.obrasocialDataGridViewTextBoxColumn.HeaderText = "obra_social";
            this.obrasocialDataGridViewTextBoxColumn.Name = "obrasocialDataGridViewTextBoxColumn";
            this.obrasocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.obrasocialDataGridViewTextBoxColumn.Width = 95;
            // 
            // CAcciones
            // 
            this.CAcciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CAcciones.Frozen = true;
            this.CAcciones.HeaderText = "Acciones";
            this.CAcciones.MinimumWidth = 6;
            this.CAcciones.Name = "CAcciones";
            this.CAcciones.ReadOnly = true;
            this.CAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAcciones.Text = ". . .";
            this.CAcciones.UseColumnTextForButtonValue = true;
            this.CAcciones.Width = 96;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 71);
            this.panel2.TabIndex = 14;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(34, 17);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 41);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pacientes";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(676, 81);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 40);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Nuevo Paciente";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // lista_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "lista_paciente";
            this.Size = new System.Drawing.Size(872, 549);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelMenuPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView DGVAdministrativo;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Panel panelMenuPaciente;
        private FontAwesome.Sharp.IconButton iconTurno;
        private FontAwesome.Sharp.IconButton iconClose;
        private FontAwesome.Sharp.IconButton iconVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrasocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CAcciones;
    }
}

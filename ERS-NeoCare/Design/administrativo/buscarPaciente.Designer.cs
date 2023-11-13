namespace ERS_NeoCare.Design.administrativo
{
    partial class buscarPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonClose2 = new FontAwesome.Sharp.IconButton();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.DGVABusqueda = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.personalsaludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNeoCareDataSet = new ERS_NeoCare.DBNeoCareDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.labelMedicoResultado = new System.Windows.Forms.Label();
            this.labelPacienteResultado = new System.Windows.Forms.Label();
            this.iconbtn_paciente = new FontAwesome.Sharp.IconButton();
            this.iconbtn_medico = new FontAwesome.Sharp.IconButton();
            this.personal_saludTableAdapter = new ERS_NeoCare.DBNeoCareDataSetTableAdapters.personal_saludTableAdapter();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconAgregar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVABusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconButtonClose2);
            this.panel1.Controls.Add(this.textBoxBusqueda);
            this.panel1.Controls.Add(this.DGVABusqueda);
            this.panel1.Location = new System.Drawing.Point(151, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 261);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar:";
            // 
            // iconButtonClose2
            // 
            this.iconButtonClose2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(67)))), ((int)(((byte)(44)))));
            this.iconButtonClose2.FlatAppearance.BorderSize = 0;
            this.iconButtonClose2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(149)))));
            this.iconButtonClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose2.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButtonClose2.IconColor = System.Drawing.Color.White;
            this.iconButtonClose2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose2.IconSize = 12;
            this.iconButtonClose2.Location = new System.Drawing.Point(515, 3);
            this.iconButtonClose2.Name = "iconButtonClose2";
            this.iconButtonClose2.Size = new System.Drawing.Size(32, 23);
            this.iconButtonClose2.TabIndex = 37;
            this.iconButtonClose2.UseVisualStyleBackColor = false;
            this.iconButtonClose2.Click += new System.EventHandler(this.iconButtonClose2_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.Location = new System.Drawing.Point(119, 14);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(265, 22);
            this.textBoxBusqueda.TabIndex = 18;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // DGVABusqueda
            // 
            this.DGVABusqueda.AllowUserToAddRows = false;
            this.DGVABusqueda.AllowUserToDeleteRows = false;
            this.DGVABusqueda.AllowUserToResizeColumns = false;
            this.DGVABusqueda.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVABusqueda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVABusqueda.AutoGenerateColumns = false;
            this.DGVABusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVABusqueda.BackgroundColor = System.Drawing.Color.White;
            this.DGVABusqueda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVABusqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVABusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVABusqueda.ColumnHeadersHeight = 40;
            this.DGVABusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombreDataGridViewTextBoxColumn,
            this.id,
            this.apellidoDataGridViewTextBoxColumn,
            this.Accion});
            this.DGVABusqueda.DataSource = this.personalsaludBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVABusqueda.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVABusqueda.EnableHeadersVisualStyles = false;
            this.DGVABusqueda.Location = new System.Drawing.Point(37, 42);
            this.DGVABusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.DGVABusqueda.Name = "DGVABusqueda";
            this.DGVABusqueda.ReadOnly = true;
            this.DGVABusqueda.RowHeadersVisible = false;
            this.DGVABusqueda.RowHeadersWidth = 51;
            this.DGVABusqueda.RowTemplate.Height = 40;
            this.DGVABusqueda.Size = new System.Drawing.Size(482, 192);
            this.DGVABusqueda.TabIndex = 16;
            this.DGVABusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVABusqueda_CellContentClick);
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // personalsaludBindingSource
            // 
            this.personalsaludBindingSource.DataMember = "personal_salud";
            this.personalsaludBindingSource.DataSource = this.dBNeoCareDataSet;
            // 
            // dBNeoCareDataSet
            // 
            this.dBNeoCareDataSet.DataSetName = "DBNeoCareDataSet";
            this.dBNeoCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medico:";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.labelPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaciente.Location = new System.Drawing.Point(191, 171);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(75, 20);
            this.labelPaciente.TabIndex = 2;
            this.labelPaciente.Text = "Paciente:";
            // 
            // labelMedicoResultado
            // 
            this.labelMedicoResultado.AutoSize = true;
            this.labelMedicoResultado.BackColor = System.Drawing.SystemColors.Control;
            this.labelMedicoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicoResultado.Location = new System.Drawing.Point(306, 120);
            this.labelMedicoResultado.Name = "labelMedicoResultado";
            this.labelMedicoResultado.Size = new System.Drawing.Size(57, 20);
            this.labelMedicoResultado.TabIndex = 3;
            this.labelMedicoResultado.Text = "label3";
            // 
            // labelPacienteResultado
            // 
            this.labelPacienteResultado.AutoSize = true;
            this.labelPacienteResultado.BackColor = System.Drawing.SystemColors.Control;
            this.labelPacienteResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacienteResultado.Location = new System.Drawing.Point(306, 172);
            this.labelPacienteResultado.Name = "labelPacienteResultado";
            this.labelPacienteResultado.Size = new System.Drawing.Size(57, 20);
            this.labelPacienteResultado.TabIndex = 4;
            this.labelPacienteResultado.Text = "label4";
            // 
            // iconbtn_paciente
            // 
            this.iconbtn_paciente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtn_paciente.IconColor = System.Drawing.Color.Black;
            this.iconbtn_paciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtn_paciente.Location = new System.Drawing.Point(420, 75);
            this.iconbtn_paciente.Name = "iconbtn_paciente";
            this.iconbtn_paciente.Size = new System.Drawing.Size(102, 23);
            this.iconbtn_paciente.TabIndex = 5;
            this.iconbtn_paciente.Text = "Buscar paciente";
            this.iconbtn_paciente.UseVisualStyleBackColor = true;
            this.iconbtn_paciente.Click += new System.EventHandler(this.iconbtn_paciente_Click);
            // 
            // iconbtn_medico
            // 
            this.iconbtn_medico.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtn_medico.IconColor = System.Drawing.Color.Black;
            this.iconbtn_medico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtn_medico.Location = new System.Drawing.Point(288, 75);
            this.iconbtn_medico.Name = "iconbtn_medico";
            this.iconbtn_medico.Size = new System.Drawing.Size(102, 23);
            this.iconbtn_medico.TabIndex = 6;
            this.iconbtn_medico.Text = "Buscar medico";
            this.iconbtn_medico.UseVisualStyleBackColor = true;
            this.iconbtn_medico.Click += new System.EventHandler(this.iconbtn_medico_Click);
            // 
            // personal_saludTableAdapter
            // 
            this.personal_saludTableAdapter.ClearBeforeFill = true;
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
            this.iconButtonClose.Location = new System.Drawing.Point(788, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(32, 23);
            this.iconButtonClose.TabIndex = 36;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.iconAgregar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.iconbtn_paciente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelPaciente);
            this.panel2.Controls.Add(this.labelMedicoResultado);
            this.panel2.Controls.Add(this.labelPacienteResultado);
            this.panel2.Controls.Add(this.iconbtn_medico);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 368);
            this.panel2.TabIndex = 37;
            // 
            // iconAgregar
            // 
            this.iconAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.iconAgregar.FlatAppearance.BorderSize = 0;
            this.iconAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAgregar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconAgregar.IconColor = System.Drawing.Color.Black;
            this.iconAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAgregar.IconSize = 24;
            this.iconAgregar.Location = new System.Drawing.Point(737, 304);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(43, 42);
            this.iconAgregar.TabIndex = 9;
            this.iconAgregar.UseVisualStyleBackColor = false;
            this.iconAgregar.Click += new System.EventHandler(this.iconAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cargar Medico y Paciente";
            // 
            // buscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.iconButtonClose);
            this.Controls.Add(this.panel2);
            this.Name = "buscarPaciente";
            this.Size = new System.Drawing.Size(823, 401);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVABusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Label labelMedicoResultado;
        private System.Windows.Forms.Label labelPacienteResultado;
        private FontAwesome.Sharp.IconButton iconbtn_paciente;
        private FontAwesome.Sharp.IconButton iconbtn_medico;
        private System.Windows.Forms.DataGridView DGVABusqueda;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.BindingSource personalsaludBindingSource;
        private DBNeoCareDataSet dBNeoCareDataSet;
        private DBNeoCareDataSetTableAdapters.personal_saludTableAdapter personal_saludTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private FontAwesome.Sharp.IconButton iconButtonClose2;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconAgregar;
        private System.Windows.Forms.Label label3;
    }
}

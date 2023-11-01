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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.btn_closePanel = new FontAwesome.Sharp.IconButton();
            this.DGVABusqueda = new System.Windows.Forms.DataGridView();
            this.personalsaludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNeoCareDataSet = new ERS_NeoCare.DBNeoCareDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.labelMedicoResultado = new System.Windows.Forms.Label();
            this.labelPacienteResultado = new System.Windows.Forms.Label();
            this.iconbtn_paciente = new FontAwesome.Sharp.IconButton();
            this.iconbtn_medico = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.personal_saludTableAdapter = new ERS_NeoCare.DBNeoCareDataSetTableAdapters.personal_saludTableAdapter();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVABusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxBusqueda);
            this.panel1.Controls.Add(this.btn_closePanel);
            this.panel1.Controls.Add(this.DGVABusqueda);
            this.panel1.Location = new System.Drawing.Point(108, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 253);
            this.panel1.TabIndex = 0;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(85, 17);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(381, 20);
            this.textBoxBusqueda.TabIndex = 18;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // btn_closePanel
            // 
            this.btn_closePanel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_closePanel.IconColor = System.Drawing.Color.Black;
            this.btn_closePanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_closePanel.Location = new System.Drawing.Point(472, 3);
            this.btn_closePanel.Name = "btn_closePanel";
            this.btn_closePanel.Size = new System.Drawing.Size(75, 23);
            this.btn_closePanel.TabIndex = 17;
            this.btn_closePanel.Text = "iconButton1";
            this.btn_closePanel.UseVisualStyleBackColor = true;
            this.btn_closePanel.Click += new System.EventHandler(this.btn_closePanel_Click);
            // 
            // DGVABusqueda
            // 
            this.DGVABusqueda.AllowUserToAddRows = false;
            this.DGVABusqueda.AllowUserToDeleteRows = false;
            this.DGVABusqueda.AllowUserToResizeColumns = false;
            this.DGVABusqueda.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVABusqueda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVABusqueda.AutoGenerateColumns = false;
            this.DGVABusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVABusqueda.BackgroundColor = System.Drawing.Color.White;
            this.DGVABusqueda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVABusqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVABusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVABusqueda.ColumnHeadersHeight = 40;
            this.DGVABusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombreDataGridViewTextBoxColumn,
            this.id,
            this.apellidoDataGridViewTextBoxColumn,
            this.Accion});
            this.DGVABusqueda.DataSource = this.personalsaludBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVABusqueda.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVABusqueda.EnableHeadersVisualStyles = false;
            this.DGVABusqueda.Location = new System.Drawing.Point(37, 42);
            this.DGVABusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.DGVABusqueda.Name = "DGVABusqueda";
            this.DGVABusqueda.ReadOnly = true;
            this.DGVABusqueda.RowHeadersVisible = false;
            this.DGVABusqueda.RowHeadersWidth = 51;
            this.DGVABusqueda.RowTemplate.Height = 40;
            this.DGVABusqueda.Size = new System.Drawing.Size(482, 211);
            this.DGVABusqueda.TabIndex = 16;
            this.DGVABusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVABusqueda_CellContentClick);
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
            this.label1.Location = new System.Drawing.Point(25, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medico";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(25, 179);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(49, 13);
            this.labelPaciente.TabIndex = 2;
            this.labelPaciente.Text = "Paciente";
            // 
            // labelMedicoResultado
            // 
            this.labelMedicoResultado.AutoSize = true;
            this.labelMedicoResultado.Location = new System.Drawing.Point(131, 179);
            this.labelMedicoResultado.Name = "labelMedicoResultado";
            this.labelMedicoResultado.Size = new System.Drawing.Size(35, 13);
            this.labelMedicoResultado.TabIndex = 3;
            this.labelMedicoResultado.Text = "label3";
            // 
            // labelPacienteResultado
            // 
            this.labelPacienteResultado.AutoSize = true;
            this.labelPacienteResultado.Location = new System.Drawing.Point(131, 117);
            this.labelPacienteResultado.Name = "labelPacienteResultado";
            this.labelPacienteResultado.Size = new System.Drawing.Size(35, 13);
            this.labelPacienteResultado.TabIndex = 4;
            this.labelPacienteResultado.Text = "label4";
            // 
            // iconbtn_paciente
            // 
            this.iconbtn_paciente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtn_paciente.IconColor = System.Drawing.Color.Black;
            this.iconbtn_paciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtn_paciente.Location = new System.Drawing.Point(306, 104);
            this.iconbtn_paciente.Name = "iconbtn_paciente";
            this.iconbtn_paciente.Size = new System.Drawing.Size(75, 23);
            this.iconbtn_paciente.TabIndex = 5;
            this.iconbtn_paciente.Text = "iconButton1";
            this.iconbtn_paciente.UseVisualStyleBackColor = true;
            this.iconbtn_paciente.Click += new System.EventHandler(this.iconbtn_paciente_Click);
            // 
            // iconbtn_medico
            // 
            this.iconbtn_medico.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtn_medico.IconColor = System.Drawing.Color.Black;
            this.iconbtn_medico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtn_medico.Location = new System.Drawing.Point(306, 179);
            this.iconbtn_medico.Name = "iconbtn_medico";
            this.iconbtn_medico.Size = new System.Drawing.Size(75, 23);
            this.iconbtn_medico.TabIndex = 6;
            this.iconbtn_medico.Text = "iconButton2";
            this.iconbtn_medico.UseVisualStyleBackColor = true;
            this.iconbtn_medico.Click += new System.EventHandler(this.iconbtn_medico_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(718, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // personal_saludTableAdapter
            // 
            this.personal_saludTableAdapter.ClearBeforeFill = true;
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
            // buscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconbtn_medico);
            this.Controls.Add(this.iconbtn_paciente);
            this.Controls.Add(this.labelPacienteResultado);
            this.Controls.Add(this.labelMedicoResultado);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.label1);
            this.Name = "buscarPaciente";
            this.Size = new System.Drawing.Size(823, 401);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVABusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsaludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private FontAwesome.Sharp.IconButton btn_closePanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.BindingSource personalsaludBindingSource;
        private DBNeoCareDataSet dBNeoCareDataSet;
        private DBNeoCareDataSetTableAdapters.personal_saludTableAdapter personal_saludTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}

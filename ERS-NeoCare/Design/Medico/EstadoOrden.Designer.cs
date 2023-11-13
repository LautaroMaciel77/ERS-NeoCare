namespace ERS_NeoCare.Design.Medico
{
    partial class EstadoOrden
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVAdministrativo = new System.Windows.Forms.DataGridView();
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNeoCareDataSet3 = new ERS_NeoCare.DBNeoCareDataSet3();
            this.ordenTableAdapter = new ERS_NeoCare.DBNeoCareDataSet3TableAdapters.ordenTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAdministrativo
            // 
            this.DGVAdministrativo.AllowUserToAddRows = false;
            this.DGVAdministrativo.AllowUserToDeleteRows = false;
            this.DGVAdministrativo.AllowUserToResizeColumns = false;
            this.DGVAdministrativo.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVAdministrativo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DGVAdministrativo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAdministrativo.BackgroundColor = System.Drawing.Color.White;
            this.DGVAdministrativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVAdministrativo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAdministrativo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DGVAdministrativo.ColumnHeadersHeight = 40;
            this.DGVAdministrativo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fecha_creacion,
            this.Medico,
            this.Paciente,
            this.dni_paciente,
            this.dni_medico,
            this.urgencia,
            this.estado,
            this.Accion});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAdministrativo.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGVAdministrativo.EnableHeadersVisualStyles = false;
            this.DGVAdministrativo.Location = new System.Drawing.Point(56, 76);
            this.DGVAdministrativo.Margin = new System.Windows.Forms.Padding(2);
            this.DGVAdministrativo.Name = "DGVAdministrativo";
            this.DGVAdministrativo.ReadOnly = true;
            this.DGVAdministrativo.RowHeadersVisible = false;
            this.DGVAdministrativo.RowHeadersWidth = 51;
            this.DGVAdministrativo.RowTemplate.Height = 40;
            this.DGVAdministrativo.Size = new System.Drawing.Size(972, 387);
            this.DGVAdministrativo.TabIndex = 11;
            this.DGVAdministrativo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAdministrativo_CellContentClick);
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataMember = "orden";
            this.ordenBindingSource.DataSource = this.dBNeoCareDataSet3;
            // 
            // dBNeoCareDataSet3
            // 
            this.dBNeoCareDataSet3.DataSetName = "DBNeoCareDataSet3";
            this.dBNeoCareDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "fecha creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "Medico";
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // dni_paciente
            // 
            this.dni_paciente.DataPropertyName = "dni_paciente";
            this.dni_paciente.HeaderText = "dni paciente";
            this.dni_paciente.Name = "dni_paciente";
            this.dni_paciente.ReadOnly = true;
            // 
            // dni_medico
            // 
            this.dni_medico.DataPropertyName = "dni_medico";
            this.dni_medico.HeaderText = "dni medico";
            this.dni_medico.Name = "dni_medico";
            this.dni_medico.ReadOnly = true;
            // 
            // urgencia
            // 
            this.urgencia.DataPropertyName = "urgencia";
            this.urgencia.HeaderText = "urgencia";
            this.urgencia.Name = "urgencia";
            this.urgencia.ReadOnly = true;
            this.urgencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.urgencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Acciones";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Atendido",
            "No Atendido",
            "Todos",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(429, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Urgente",
            "No Urgente",
            "Todos"});
            this.comboBox2.Location = new System.Drawing.Point(729, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(284, 28);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Estado Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(726, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo Urgencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Buscar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(109, 43);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 26);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EstadoOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DGVAdministrativo);
            this.Name = "EstadoOrden";
            this.Size = new System.Drawing.Size(1112, 482);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAdministrativo;

        private System.Windows.Forms.BindingSource ordenBindingSource;
        private DBNeoCareDataSet3 dBNeoCareDataSet3;
        private DBNeoCareDataSet3TableAdapters.ordenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_medico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
    }
}

namespace ERS_NeoCare.Design.administrativo
{
    partial class ListaTurnosAdministrativo
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
            this.DGVAdministrativo = new System.Windows.Forms.DataGridView();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNeoCareDataSet1 = new ERS_NeoCare.DBNeoCareDataSet1();
            this.turnoTableAdapter = new ERS_NeoCare.DBNeoCareDataSet1TableAdapters.TurnoTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedTimeRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasComentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTurnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.idDataGridViewTextBoxColumn,
            this.selectedDateDataGridViewTextBoxColumn,
            this.selectedTimeRangeDataGridViewTextBoxColumn,
            this.prioridadDataGridViewTextBoxColumn,
            this.notasComentariosDataGridViewTextBoxColumn,
            this.medicoidDataGridViewTextBoxColumn,
            this.pacienteidDataGridViewTextBoxColumn,
            this.estado,
            this.EstadoTurnoColumn});
            this.DGVAdministrativo.DataSource = this.turnoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAdministrativo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAdministrativo.EnableHeadersVisualStyles = false;
            this.DGVAdministrativo.Location = new System.Drawing.Point(35, 80);
            this.DGVAdministrativo.Margin = new System.Windows.Forms.Padding(2);
            this.DGVAdministrativo.Name = "DGVAdministrativo";
            this.DGVAdministrativo.ReadOnly = true;
            this.DGVAdministrativo.RowHeadersVisible = false;
            this.DGVAdministrativo.RowHeadersWidth = 51;
            this.DGVAdministrativo.RowTemplate.Height = 40;
            this.DGVAdministrativo.Size = new System.Drawing.Size(1127, 609);
            this.DGVAdministrativo.TabIndex = 11;
            this.DGVAdministrativo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAdministrativo_CellContentClick);
            this.DGVAdministrativo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVAdministrativo_CellFormatting);
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.dBNeoCareDataSet1;
            // 
            // dBNeoCareDataSet1
            // 
            this.dBNeoCareDataSet1.DataSetName = "DBNeoCareDataSet1";
            this.dBNeoCareDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Atendido",
            "No Atendido",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(817, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // selectedDateDataGridViewTextBoxColumn
            // 
            this.selectedDateDataGridViewTextBoxColumn.DataPropertyName = "selectedDate";
            this.selectedDateDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.selectedDateDataGridViewTextBoxColumn.Name = "selectedDateDataGridViewTextBoxColumn";
            this.selectedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectedTimeRangeDataGridViewTextBoxColumn
            // 
            this.selectedTimeRangeDataGridViewTextBoxColumn.DataPropertyName = "selectedTimeRange";
            this.selectedTimeRangeDataGridViewTextBoxColumn.HeaderText = "hora";
            this.selectedTimeRangeDataGridViewTextBoxColumn.Name = "selectedTimeRangeDataGridViewTextBoxColumn";
            this.selectedTimeRangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioridadDataGridViewTextBoxColumn
            // 
            this.prioridadDataGridViewTextBoxColumn.DataPropertyName = "prioridad";
            this.prioridadDataGridViewTextBoxColumn.HeaderText = "prioridad";
            this.prioridadDataGridViewTextBoxColumn.Name = "prioridadDataGridViewTextBoxColumn";
            this.prioridadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasComentariosDataGridViewTextBoxColumn
            // 
            this.notasComentariosDataGridViewTextBoxColumn.DataPropertyName = "notasComentarios";
            this.notasComentariosDataGridViewTextBoxColumn.HeaderText = "notasComentarios";
            this.notasComentariosDataGridViewTextBoxColumn.Name = "notasComentariosDataGridViewTextBoxColumn";
            this.notasComentariosDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasComentariosDataGridViewTextBoxColumn.Visible = false;
            // 
            // medicoidDataGridViewTextBoxColumn
            // 
            this.medicoidDataGridViewTextBoxColumn.DataPropertyName = "medico_id";
            this.medicoidDataGridViewTextBoxColumn.HeaderText = "medico_id";
            this.medicoidDataGridViewTextBoxColumn.Name = "medicoidDataGridViewTextBoxColumn";
            this.medicoidDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicoidDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacienteidDataGridViewTextBoxColumn
            // 
            this.pacienteidDataGridViewTextBoxColumn.DataPropertyName = "paciente_id";
            this.pacienteidDataGridViewTextBoxColumn.HeaderText = "paciente_id";
            this.pacienteidDataGridViewTextBoxColumn.Name = "pacienteidDataGridViewTextBoxColumn";
            this.pacienteidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacienteidDataGridViewTextBoxColumn.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // EstadoTurnoColumn
            // 
            this.EstadoTurnoColumn.HeaderText = "Estado";
            this.EstadoTurnoColumn.Name = "EstadoTurnoColumn";
            this.EstadoTurnoColumn.ReadOnly = true;
            // 
            // ListaTurnosAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DGVAdministrativo);
            this.Name = "ListaTurnosAdministrativo";
            this.Size = new System.Drawing.Size(1196, 768);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAdministrativo;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private DBNeoCareDataSet1 dBNeoCareDataSet1;
        private DBNeoCareDataSet1TableAdapters.TurnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedTimeRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasComentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTurnoColumn;
    }
}

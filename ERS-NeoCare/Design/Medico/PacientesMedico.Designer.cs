namespace ERS_NeoCare.Design
{
    partial class PacientesMedico
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
            this.panelPaciente = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DGVAdministrativo = new System.Windows.Forms.DataGridView();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ERS_NeoCare.DatabaseDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pacienteTableAdapter = new ERS_NeoCare.DatabaseDataSetTableAdapters.PacienteTableAdapter();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrasocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPaciente
            // 
            this.panelPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPaciente.AutoSize = true;
            this.panelPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.panelPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPaciente.Location = new System.Drawing.Point(465, 350);
            this.panelPaciente.Name = "panelPaciente";
            this.panelPaciente.Size = new System.Drawing.Size(260, 150);
            this.panelPaciente.TabIndex = 17;
            this.panelPaciente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpciones_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Buscar";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(90, 80);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVAdministrativo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVAdministrativo.AutoGenerateColumns = false;
            this.DGVAdministrativo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAdministrativo.BackgroundColor = System.Drawing.Color.White;
            this.DGVAdministrativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVAdministrativo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAdministrativo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAdministrativo.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVAdministrativo.EnableHeadersVisualStyles = false;
            this.DGVAdministrativo.Location = new System.Drawing.Point(34, 121);
            this.DGVAdministrativo.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.DGVAdministrativo.Name = "DGVAdministrativo";
            this.DGVAdministrativo.RowHeadersVisible = false;
            this.DGVAdministrativo.RowHeadersWidth = 51;
            this.DGVAdministrativo.RowTemplate.Height = 40;
            this.DGVAdministrativo.Size = new System.Drawing.Size(1127, 609);
            this.DGVAdministrativo.TabIndex = 10;
            this.DGVAdministrativo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAdministrativo_CellContentClick);
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
            this.panel2.Size = new System.Drawing.Size(1196, 71);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pacientes";
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // obrasocialDataGridViewTextBoxColumn
            // 
            this.obrasocialDataGridViewTextBoxColumn.DataPropertyName = "obra_social";
            this.obrasocialDataGridViewTextBoxColumn.HeaderText = "obra_social";
            this.obrasocialDataGridViewTextBoxColumn.Name = "obrasocialDataGridViewTextBoxColumn";
            // 
            // CAcciones
            // 
            this.CAcciones.HeaderText = "Acciones";
            this.CAcciones.MinimumWidth = 6;
            this.CAcciones.Name = "CAcciones";
            this.CAcciones.ReadOnly = true;
            this.CAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAcciones.Text = "menu";
            // 
            // PacientesMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DGVAdministrativo);
            this.Name = "PacientesMedico";
            this.Size = new System.Drawing.Size(1196, 768);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView DGVAdministrativo;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Panel panelPaciente;
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

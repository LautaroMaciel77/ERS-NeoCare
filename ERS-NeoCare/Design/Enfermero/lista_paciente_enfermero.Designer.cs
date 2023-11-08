﻿namespace ERS_NeoCare.Design
{
    partial class lista_paciente_enfermero
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DGVAdministrativo = new System.Windows.Forms.DataGridView();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new ERS_NeoCare.Database1DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pacienteTableAdapter = new ERS_NeoCare.Database1DataSetTableAdapters.PacienteTableAdapter();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.dBNeoCareDataSet4 = new ERS_NeoCare.DBNeoCareDataSet4();
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenTableAdapter = new ERS_NeoCare.DBNeoCareDataSet4TableAdapters.ordenTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Buscar";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(92, 81);
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
            this.id,
            this.fecha_creacion,
            this.urgencia,
            this.estado,
            this.Medico,
            this.Pacientes,
            this.dni_paciente,
            this.dni_medico,
            this.Acciones});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAdministrativo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAdministrativo.EnableHeadersVisualStyles = false;
            this.DGVAdministrativo.Location = new System.Drawing.Point(34, 121);
            this.DGVAdministrativo.Margin = new System.Windows.Forms.Padding(2);
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
            this.pacienteBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panelAgregar
            // 
            this.panelAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAgregar.AutoSize = true;
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.panelAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelAgregar.Location = new System.Drawing.Point(468, 309);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(260, 150);
            this.panelAgregar.TabIndex = 18;
            // 
            // dBNeoCareDataSet4
            // 
            this.dBNeoCareDataSet4.DataSetName = "DBNeoCareDataSet4";
            this.dBNeoCareDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataMember = "orden";
            this.ordenBindingSource.DataSource = this.dBNeoCareDataSet4;
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "fecha_creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            // 
            // urgencia
            // 
            this.urgencia.DataPropertyName = "urgencia";
            this.urgencia.HeaderText = "urgencia";
            this.urgencia.Name = "urgencia";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "Medico";
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            // 
            // Pacientes
            // 
            this.Pacientes.DataPropertyName = "Paciente";
            this.Pacientes.HeaderText = "Pacientes";
            this.Pacientes.Name = "Pacientes";
            // 
            // dni_paciente
            // 
            this.dni_paciente.DataPropertyName = "dni_paciente";
            this.dni_paciente.HeaderText = "dni_paciente";
            this.dni_paciente.Name = "dni_paciente";
            // 
            // dni_medico
            // 
            this.dni_medico.DataPropertyName = "dni_medico";
            this.dni_medico.HeaderText = "dni_medico";
            this.dni_medico.Name = "dni_medico";
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            // 
            // lista_paciente_enfermero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVAdministrativo);
            this.Name = "lista_paciente_enfermero";
            this.Size = new System.Drawing.Size(1196, 768);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdministrativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNeoCareDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView DGVAdministrativo;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private DBNeoCareDataSet4 dBNeoCareDataSet4;
        private DBNeoCareDataSet4TableAdapters.ordenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_medico;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}

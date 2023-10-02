namespace ERS_NeoCare.Design
{
    partial class TurnosMedico
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
            this.label2 = new System.Windows.Forms.Label();
            this.textboxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHora = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eleguir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.radioEnfermero = new System.Windows.Forms.RadioButton();
            this.radioBio = new System.Windows.Forms.RadioButton();
            this.labelEspecialista = new System.Windows.Forms.Label();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.iconAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHora)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // textboxDni
            // 
            this.textboxDni.Location = new System.Drawing.Point(725, 634);
            this.textboxDni.Name = "textboxDni";
            this.textboxDni.Size = new System.Drawing.Size(100, 20);
            this.textboxDni.TabIndex = 13;
            this.textboxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxDni_KeyPress);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(634, 637);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(85, 13);
            this.labelDni.TabIndex = 12;
            this.labelDni.Text = "Dni del Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // dataGridViewHora
            // 
            this.dataGridViewHora.AllowUserToAddRows = false;
            this.dataGridViewHora.AllowUserToDeleteRows = false;
            this.dataGridViewHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.disponible,
            this.Eleguir});
            this.dataGridViewHora.Location = new System.Drawing.Point(277, 555);
            this.dataGridViewHora.Name = "dataGridViewHora";
            this.dataGridViewHora.Size = new System.Drawing.Size(351, 150);
            this.dataGridViewHora.TabIndex = 10;
            this.dataGridViewHora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHora_CellContentClick);
            // 
            // hora
            // 
            this.hora.HeaderText = "hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // disponible
            // 
            this.disponible.HeaderText = "disponible";
            this.disponible.Name = "disponible";
            // 
            // Eleguir
            // 
            this.Eleguir.HeaderText = "Eleguir Hora";
            this.Eleguir.Name = "Eleguir";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(230, 63);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // radioEnfermero
            // 
            this.radioEnfermero.AutoSize = true;
            this.radioEnfermero.Location = new System.Drawing.Point(867, 633);
            this.radioEnfermero.Name = "radioEnfermero";
            this.radioEnfermero.Size = new System.Drawing.Size(73, 17);
            this.radioEnfermero.TabIndex = 18;
            this.radioEnfermero.TabStop = true;
            this.radioEnfermero.Text = "Enfermero";
            this.radioEnfermero.UseVisualStyleBackColor = true;
            this.radioEnfermero.CheckedChanged += new System.EventHandler(this.radioEnfermero_CheckedChanged);
            // 
            // radioBio
            // 
            this.radioBio.AutoSize = true;
            this.radioBio.Location = new System.Drawing.Point(867, 604);
            this.radioBio.Name = "radioBio";
            this.radioBio.Size = new System.Drawing.Size(76, 17);
            this.radioBio.TabIndex = 19;
            this.radioBio.TabStop = true;
            this.radioBio.Text = "Bioquimico";
            this.radioBio.UseVisualStyleBackColor = true;
            this.radioBio.CheckedChanged += new System.EventHandler(this.radioBio_CheckedChanged);
            // 
            // labelEspecialista
            // 
            this.labelEspecialista.AutoSize = true;
            this.labelEspecialista.Location = new System.Drawing.Point(867, 574);
            this.labelEspecialista.Name = "labelEspecialista";
            this.labelEspecialista.Size = new System.Drawing.Size(63, 13);
            this.labelEspecialista.TabIndex = 20;
            this.labelEspecialista.Text = "Especialista";
            // 
            // iconBuscar
            // 
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.Location = new System.Drawing.Point(745, 682);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(156, 23);
            this.iconBuscar.TabIndex = 16;
            this.iconBuscar.Text = "Buscar Turno";
            this.iconBuscar.UseVisualStyleBackColor = true;
            // 
            // iconAgregar
            // 
            this.iconAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconAgregar.IconColor = System.Drawing.Color.Black;
            this.iconAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAgregar.Location = new System.Drawing.Point(745, 711);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(156, 23);
            this.iconAgregar.TabIndex = 15;
            this.iconAgregar.Text = "Guardar Turno";
            this.iconAgregar.UseVisualStyleBackColor = true;
            this.iconAgregar.Click += new System.EventHandler(this.iconAgregar_Click);
            // 
            // TurnosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEspecialista);
            this.Controls.Add(this.radioBio);
            this.Controls.Add(this.radioEnfermero);
            this.Controls.Add(this.iconBuscar);
            this.Controls.Add(this.iconAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxDni);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHora);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "TurnosMedico";
            this.Size = new System.Drawing.Size(1196, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBuscar;
        private FontAwesome.Sharp.IconButton iconAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponible;
        private System.Windows.Forms.DataGridViewButtonColumn Eleguir;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton radioEnfermero;
        private System.Windows.Forms.RadioButton radioBio;
        private System.Windows.Forms.Label labelEspecialista;
    }
}

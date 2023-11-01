namespace ERS_NeoCare.Design.administrativo
{
    partial class turnoAdministrativo
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewHora = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eleguir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscarMedico = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.iconAgregar = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHora)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(112, 73);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
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
            this.dataGridViewHora.Location = new System.Drawing.Point(112, 570);
            this.dataGridViewHora.Name = "dataGridViewHora";
            this.dataGridViewHora.RowHeadersWidth = 51;
            this.dataGridViewHora.Size = new System.Drawing.Size(429, 150);
            this.dataGridViewHora.TabIndex = 1;
            this.dataGridViewHora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHora_CellContentClick);
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.MinimumWidth = 6;
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 125;
            // 
            // disponible
            // 
            this.disponible.HeaderText = "Disponible";
            this.disponible.MinimumWidth = 6;
            this.disponible.Name = "disponible";
            this.disponible.Width = 125;
            // 
            // Eleguir
            // 
            this.Eleguir.HeaderText = "Elegir Hora";
            this.Eleguir.MinimumWidth = 6;
            this.Eleguir.Name = "Eleguir";
            this.Eleguir.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cargar medico y paciente";
            // 
            // btn_buscarMedico
            // 
            this.btn_buscarMedico.Location = new System.Drawing.Point(777, 626);
            this.btn_buscarMedico.Name = "btn_buscarMedico";
            this.btn_buscarMedico.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarMedico.TabIndex = 12;
            this.btn_buscarMedico.Text = "button2";
            this.btn_buscarMedico.UseVisualStyleBackColor = true;
            this.btn_buscarMedico.Click += new System.EventHandler(this.btn_buscarMedico_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBuscar.AutoSize = true;
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.panelBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBuscar.Location = new System.Drawing.Point(184, 73);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(823, 401);
            this.panelBuscar.TabIndex = 22;
            // 
            // iconBuscar
            // 
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.Location = new System.Drawing.Point(647, 682);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(156, 23);
            this.iconBuscar.TabIndex = 8;
            this.iconBuscar.Text = "Buscar Turno";
            this.iconBuscar.UseVisualStyleBackColor = true;
            this.iconBuscar.Click += new System.EventHandler(this.iconBuscar_Click);
            // 
            // iconAgregar
            // 
            this.iconAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconAgregar.IconColor = System.Drawing.Color.Black;
            this.iconAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAgregar.Location = new System.Drawing.Point(647, 711);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(156, 23);
            this.iconAgregar.TabIndex = 7;
            this.iconAgregar.Text = "Guardar Turno";
            this.iconAgregar.UseVisualStyleBackColor = true;
            this.iconAgregar.Click += new System.EventHandler(this.iconAgregar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alta",
            "Normal",
            "Baja"});
            this.comboBox1.Location = new System.Drawing.Point(647, 655);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // turnoAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.btn_buscarMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconBuscar);
            this.Controls.Add(this.iconAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHora);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "turnoAdministrativo";
            this.Size = new System.Drawing.Size(1196, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridViewHora;
        private FontAwesome.Sharp.IconButton iconAgregar;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponible;
        private System.Windows.Forms.DataGridViewButtonColumn Eleguir;
        private System.Windows.Forms.Button btn_buscarMedico;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

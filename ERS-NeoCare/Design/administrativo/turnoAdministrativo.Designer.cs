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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewHora = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eleguir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelDni = new System.Windows.Forms.Label();
            this.textboxDni = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.iconAgregar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHora)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(191, 73);
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
            this.dataGridViewHora.Location = new System.Drawing.Point(287, 570);
            this.dataGridViewHora.Name = "dataGridViewHora";
            this.dataGridViewHora.Size = new System.Drawing.Size(351, 150);
            this.dataGridViewHora.TabIndex = 1;
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
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(644, 633);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(85, 13);
            this.labelDni.TabIndex = 3;
            this.labelDni.Text = "Dni del Paciente";
         
            // 
            // textboxDni
            // 
            this.textboxDni.Location = new System.Drawing.Point(735, 630);
            this.textboxDni.Name = "textboxDni";
            this.textboxDni.Size = new System.Drawing.Size(100, 20);
            this.textboxDni.TabIndex = 4;
            this.textboxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxDni_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // iconBuscar
            // 
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.Location = new System.Drawing.Point(679, 656);
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
            this.iconAgregar.Location = new System.Drawing.Point(679, 697);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(156, 23);
            this.iconAgregar.TabIndex = 7;
            this.iconAgregar.Text = "Guardar Turno";
            this.iconAgregar.UseVisualStyleBackColor = true;
            this.iconAgregar.Click += new System.EventHandler(this.iconAgregar_Click);
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
            // turnoAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconBuscar);
            this.Controls.Add(this.iconAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxDni);
            this.Controls.Add(this.labelDni);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponible;
        private System.Windows.Forms.DataGridViewButtonColumn Eleguir;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textboxDni;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private FontAwesome.Sharp.IconButton iconAgregar;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

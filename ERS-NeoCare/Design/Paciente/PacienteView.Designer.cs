namespace ERS_NeoCare.Design
{
    partial class PacienteView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelObra = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PBPaciente = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.LHistoriaClinica = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPaciente)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 247);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial actuaciones medicas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CEvento,
            this.CDatos,
            this.CAcciones});
            this.dataGridView1.Location = new System.Drawing.Point(44, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(801, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // CEvento
            // 
            this.CEvento.HeaderText = "Evento";
            this.CEvento.MinimumWidth = 6;
            this.CEvento.Name = "CEvento";
            this.CEvento.ReadOnly = true;
            // 
            // CDatos
            // 
            this.CDatos.HeaderText = "Fecha";
            this.CDatos.MinimumWidth = 6;
            this.CDatos.Name = "CDatos";
            this.CDatos.ReadOnly = true;
            // 
            // CAcciones
            // 
            this.CAcciones.HeaderText = "Acciones";
            this.CAcciones.MinimumWidth = 6;
            this.CAcciones.Name = "CAcciones";
            this.CAcciones.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 768);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelObra);
            this.panel5.Controls.Add(this.labelDni);
            this.panel5.Controls.Add(this.labelDomicilio);
            this.panel5.Controls.Add(this.labelFecha);
            this.panel5.Controls.Add(this.labelSexo);
            this.panel5.Controls.Add(this.labelApellido);
            this.panel5.Controls.Add(this.labelNombre);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 603);
            this.panel5.TabIndex = 1;
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObra.Location = new System.Drawing.Point(17, 184);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(91, 17);
            this.labelObra.TabIndex = 16;
            this.labelObra.Text = "Obra social:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(18, 210);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(40, 17);
            this.labelDni.TabIndex = 15;
            this.labelDni.Text = "DNI:";
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomicilio.Location = new System.Drawing.Point(18, 150);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(75, 17);
            this.labelDomicilio.TabIndex = 14;
            this.labelDomicilio.Text = "Domicilio:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(17, 122);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(156, 17);
            this.labelFecha.TabIndex = 13;
            this.labelFecha.Text = "Fecha de nacimiento:";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(18, 91);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(50, 17);
            this.labelSexo.TabIndex = 11;
            this.labelSexo.Text = "Sexo:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(18, 58);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(68, 17);
            this.labelApellido.TabIndex = 10;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(17, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(74, 17);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.PBPaciente);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 165);
            this.panel4.TabIndex = 0;
            // 
            // PBPaciente
            // 
            this.PBPaciente.BackgroundImage = global::ERS_NeoCare.Properties.Resources.user_background_icon;
            this.PBPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBPaciente.InitialImage = null;
            this.PBPaciente.Location = new System.Drawing.Point(89, 14);
            this.PBPaciente.Name = "PBPaciente";
            this.PBPaciente.Size = new System.Drawing.Size(120, 130);
            this.PBPaciente.TabIndex = 0;
            this.PBPaciente.TabStop = false;
            this.PBPaciente.Click += new System.EventHandler(this.PBPaciente_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.LHistoriaClinica);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(296, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 768);
            this.panel3.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(347, 350);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(245, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(245, 76);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Generar Historia clinica";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LHistoriaClinica
            // 
            this.LHistoriaClinica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LHistoriaClinica.AutoSize = true;
            this.LHistoriaClinica.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistoriaClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.LHistoriaClinica.Location = new System.Drawing.Point(307, 148);
            this.LHistoriaClinica.Name = "LHistoriaClinica";
            this.LHistoriaClinica.Size = new System.Drawing.Size(311, 18);
            this.LHistoriaClinica.TabIndex = 0;
            this.LHistoriaClinica.Text = "El paciente no tiene Historia Clinica";
            // 
            // PacienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PacienteView";
            this.Size = new System.Drawing.Size(1196, 768);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPaciente)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PBPaciente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAcciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LHistoriaClinica;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelObra;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}

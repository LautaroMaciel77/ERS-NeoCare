namespace ERS_NeoCare.Design
{
    partial class paciente
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
            this.labelNroA = new System.Windows.Forms.Label();
            this.LObraSocial = new System.Windows.Forms.Label();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.LDomicilio = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PBPaciente = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 247);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Size = new System.Drawing.Size(943, 171);
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
            this.panel2.Size = new System.Drawing.Size(296, 452);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelNroA);
            this.panel5.Controls.Add(this.LObraSocial);
            this.panel5.Controls.Add(this.LFechaNacimiento);
            this.panel5.Controls.Add(this.LDomicilio);
            this.panel5.Controls.Add(this.LNombre);
            this.panel5.Controls.Add(this.LSexo);
            this.panel5.Controls.Add(this.LApellido);
            this.panel5.Controls.Add(this.LDni);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 287);
            this.panel5.TabIndex = 1;
            // 
            // labelNroA
            // 
            this.labelNroA.AutoSize = true;
            this.labelNroA.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroA.Location = new System.Drawing.Point(16, 205);
            this.labelNroA.Name = "labelNroA";
            this.labelNroA.Size = new System.Drawing.Size(122, 17);
            this.labelNroA.TabIndex = 8;
            this.labelNroA.Text = "Numero afiliado:";
            // 
            // LObraSocial
            // 
            this.LObraSocial.AutoSize = true;
            this.LObraSocial.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LObraSocial.Location = new System.Drawing.Point(16, 177);
            this.LObraSocial.Name = "LObraSocial";
            this.LObraSocial.Size = new System.Drawing.Size(91, 17);
            this.LObraSocial.TabIndex = 7;
            this.LObraSocial.Text = "Obra social:";
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNacimiento.Location = new System.Drawing.Point(16, 94);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(156, 17);
            this.LFechaNacimiento.TabIndex = 6;
            this.LFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDomicilio.Location = new System.Drawing.Point(16, 150);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(75, 17);
            this.LDomicilio.TabIndex = 5;
            this.LDomicilio.Text = "Domicilio:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(16, 11);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(74, 17);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre: ";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.Location = new System.Drawing.Point(16, 122);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(50, 17);
            this.LSexo.TabIndex = 4;
            this.LSexo.Text = "Sexo:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(16, 39);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(68, 17);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido:";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(16, 67);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(40, 17);
            this.LDni.TabIndex = 3;
            this.LDni.Text = "DNI:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
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
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.listView4);
            this.panel3.Controls.Add(this.listView3);
            this.panel3.Controls.Add(this.listView2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.LHistoriaClinica);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(296, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 452);
            this.panel3.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(392, 334);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 111);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(44, 334);
            this.listView4.Margin = new System.Windows.Forms.Padding(2);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(301, 111);
            this.listView4.TabIndex = 13;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(44, 193);
            this.listView3.Margin = new System.Windows.Forms.Padding(2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(301, 111);
            this.listView3.TabIndex = 12;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(392, 193);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(301, 111);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 315);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Medicamentos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 315);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Estudios(archivos)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fecha de inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alergias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Familiares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antecedentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medico";
            // 
            // LHistoriaClinica
            // 
            this.LHistoriaClinica.AutoSize = true;
            this.LHistoriaClinica.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistoriaClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.LHistoriaClinica.Location = new System.Drawing.Point(294, 23);
            this.LHistoriaClinica.Name = "LHistoriaClinica";
            this.LHistoriaClinica.Size = new System.Drawing.Size(135, 18);
            this.LHistoriaClinica.TabIndex = 0;
            this.LHistoriaClinica.Text = "Historia Clinica";
            // 
            // paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "paciente";
            this.Size = new System.Drawing.Size(1011, 699);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LObraSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAcciones;
        private System.Windows.Forms.Label labelNroA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LHistoriaClinica;
    }
}

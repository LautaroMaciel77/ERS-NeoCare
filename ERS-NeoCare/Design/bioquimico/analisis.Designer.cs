namespace ERS_NeoCare.Design.administrativo
{
    partial class analisis
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
            this.panelAgregarPaciente = new System.Windows.Forms.Panel();
            this.iconButtonCargar = new FontAwesome.Sharp.IconButton();
            this.listViewResultados = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelResultados = new System.Windows.Forms.Label();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panelAgregarPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgregarPaciente
            // 
            this.panelAgregarPaciente.Controls.Add(this.iconButtonCargar);
            this.panelAgregarPaciente.Controls.Add(this.listViewResultados);
            this.panelAgregarPaciente.Controls.Add(this.label1);
            this.panelAgregarPaciente.Controls.Add(this.btnRegistrar);
            this.panelAgregarPaciente.Controls.Add(this.textObservaciones);
            this.panelAgregarPaciente.Controls.Add(this.dateTimePicker1);
            this.panelAgregarPaciente.Controls.Add(this.LabelResultados);
            this.panelAgregarPaciente.Controls.Add(this.labelObservaciones);
            this.panelAgregarPaciente.Controls.Add(this.labelFecha);
            this.panelAgregarPaciente.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarPaciente.Name = "panelAgregarPaciente";
            this.panelAgregarPaciente.Size = new System.Drawing.Size(478, 415);
            this.panelAgregarPaciente.TabIndex = 17;
            this.panelAgregarPaciente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAgregarPaciente_Paint);
            // 
            // iconButtonCargar
            // 
            this.iconButtonCargar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButtonCargar.IconColor = System.Drawing.Color.Black;
            this.iconButtonCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCargar.IconSize = 20;
            this.iconButtonCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCargar.Location = new System.Drawing.Point(371, 308);
            this.iconButtonCargar.Name = "iconButtonCargar";
            this.iconButtonCargar.Size = new System.Drawing.Size(75, 32);
            this.iconButtonCargar.TabIndex = 35;
            this.iconButtonCargar.Text = "Cargar";
            this.iconButtonCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCargar.UseVisualStyleBackColor = true;
            // 
            // listViewResultados
            // 
            this.listViewResultados.HideSelection = false;
            this.listViewResultados.Location = new System.Drawing.Point(210, 157);
            this.listViewResultados.Name = "listViewResultados";
            this.listViewResultados.Size = new System.Drawing.Size(236, 145);
            this.listViewResultados.TabIndex = 34;
            this.listViewResultados.UseCompatibleStateImageBehavior = false;
            this.listViewResultados.SelectedIndexChanged += new System.EventHandler(this.listViewResultados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Analisis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(184, 361);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 23);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // textObservaciones
            // 
            this.textObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObservaciones.Location = new System.Drawing.Point(210, 114);
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(236, 22);
            this.textObservaciones.TabIndex = 27;
            this.textObservaciones.TextChanged += new System.EventHandler(this.textObra_TextChanged);
            this.textObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textObra_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // LabelResultados
            // 
            this.LabelResultados.AutoSize = true;
            this.LabelResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultados.Location = new System.Drawing.Point(36, 157);
            this.LabelResultados.Name = "LabelResultados";
            this.LabelResultados.Size = new System.Drawing.Size(76, 16);
            this.LabelResultados.TabIndex = 21;
            this.LabelResultados.Text = "Resultados";
            this.LabelResultados.Click += new System.EventHandler(this.LabelDomicilio_Click);
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.Location = new System.Drawing.Point(36, 117);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(99, 16);
            this.labelObservaciones.TabIndex = 20;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(36, 77);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(48, 16);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "Fecha:";
            // 
            // analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAgregarPaciente);
            this.Name = "analisis";
            this.Size = new System.Drawing.Size(478, 415);
            this.panelAgregarPaciente.ResumeLayout(false);
            this.panelAgregarPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregarPaciente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabelResultados;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonCargar;
        private System.Windows.Forms.ListView listViewResultados;
    }
}

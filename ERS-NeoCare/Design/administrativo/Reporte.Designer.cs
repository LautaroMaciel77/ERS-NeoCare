namespace ERS_NeoCare.Design.administrativo
{
    partial class Reporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.chartTurnos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGenerarGrafico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(25, 69);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(461, 259);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(582, 69);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(263, 21);
            this.comboBoxFiltro.TabIndex = 1;
            // 
            // chartTurnos
            // 
            chartArea10.Name = "ChartArea1";
            this.chartTurnos.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartTurnos.Legends.Add(legend10);
            this.chartTurnos.Location = new System.Drawing.Point(582, 98);
            this.chartTurnos.Name = "chartTurnos";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartTurnos.Series.Add(series10);
            this.chartTurnos.Size = new System.Drawing.Size(506, 230);
            this.chartTurnos.TabIndex = 2;
            this.chartTurnos.Text = "chart2";
            // 
            // buttonGenerarGrafico
            // 
            this.buttonGenerarGrafico.Location = new System.Drawing.Point(870, 69);
            this.buttonGenerarGrafico.Name = "buttonGenerarGrafico";
            this.buttonGenerarGrafico.Size = new System.Drawing.Size(102, 23);
            this.buttonGenerarGrafico.TabIndex = 3;
            this.buttonGenerarGrafico.Text = "button1";
            this.buttonGenerarGrafico.UseVisualStyleBackColor = true;
            this.buttonGenerarGrafico.Click += new System.EventHandler(this.buttonGenerarGrafico_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(978, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTurnos);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxUsuarios);
            this.panel1.Location = new System.Drawing.Point(349, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 158);
            this.panel1.TabIndex = 5;
            // 
            // btnTurnos
            // 
            this.btnTurnos.Location = new System.Drawing.Point(68, 93);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(102, 23);
            this.btnTurnos.TabIndex = 6;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(3, 66);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(257, 21);
            this.comboBoxUsuarios.TabIndex = 2;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(870, 40);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(102, 23);
            this.btnAnalisis.TabIndex = 7;
            this.btnAnalisis.Text = "Analisis";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(582, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGenerarGrafico);
            this.Controls.Add(this.chartTurnos);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.chart1);
            this.Name = "Reporte";
            this.Size = new System.Drawing.Size(1123, 664);
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTurnos;
        private System.Windows.Forms.Button buttonGenerarGrafico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

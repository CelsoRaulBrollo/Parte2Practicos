namespace TP4
{
    partial class Formulario4
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.BFuncion = new System.Windows.Forms.Button();
            this.LBLista = new System.Windows.Forms.ListBox();
            this.TBHasta = new System.Windows.Forms.TextBox();
            this.TBDesde = new System.Windows.Forms.TextBox();
            this.LHasta = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.BTPares = new System.Windows.Forms.Button();
            this.BTImpares = new System.Windows.Forms.Button();
            this.BTPrimos = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Lista de Números";
            // 
            // BFuncion
            // 
            this.BFuncion.Location = new System.Drawing.Point(91, 137);
            this.BFuncion.Name = "BFuncion";
            this.BFuncion.Size = new System.Drawing.Size(103, 23);
            this.BFuncion.TabIndex = 40;
            this.BFuncion.Text = "Generar funcion";
            this.BFuncion.UseVisualStyleBackColor = true;
            this.BFuncion.Click += new System.EventHandler(this.BFuncion_Click);
            // 
            // LBLista
            // 
            this.LBLista.FormattingEnabled = true;
            this.LBLista.Location = new System.Drawing.Point(231, 51);
            this.LBLista.Name = "LBLista";
            this.LBLista.Size = new System.Drawing.Size(282, 277);
            this.LBLista.TabIndex = 39;
            this.LBLista.SelectedIndexChanged += new System.EventHandler(this.LBLista_SelectedIndexChanged);
            // 
            // TBHasta
            // 
            this.TBHasta.Location = new System.Drawing.Point(91, 99);
            this.TBHasta.Name = "TBHasta";
            this.TBHasta.Size = new System.Drawing.Size(100, 20);
            this.TBHasta.TabIndex = 42;
            // 
            // TBDesde
            // 
            this.TBDesde.Location = new System.Drawing.Point(91, 44);
            this.TBDesde.Name = "TBDesde";
            this.TBDesde.Size = new System.Drawing.Size(100, 20);
            this.TBDesde.TabIndex = 43;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(24, 102);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 36;
            this.LHasta.Text = "Hasta";
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(24, 51);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 35;
            this.LDesde.Text = "Desde";
            // 
            // BTPares
            // 
            this.BTPares.Location = new System.Drawing.Point(91, 189);
            this.BTPares.Name = "BTPares";
            this.BTPares.Size = new System.Drawing.Size(103, 23);
            this.BTPares.TabIndex = 45;
            this.BTPares.Text = "Numeros Pares";
            this.BTPares.UseVisualStyleBackColor = true;
            this.BTPares.Click += new System.EventHandler(this.BTPares_Click);
            // 
            // BTImpares
            // 
            this.BTImpares.Location = new System.Drawing.Point(91, 238);
            this.BTImpares.Name = "BTImpares";
            this.BTImpares.Size = new System.Drawing.Size(103, 23);
            this.BTImpares.TabIndex = 46;
            this.BTImpares.Text = "Numeros Impares";
            this.BTImpares.UseVisualStyleBackColor = true;
            this.BTImpares.Click += new System.EventHandler(this.BTImpares_Click);
            // 
            // BTPrimos
            // 
            this.BTPrimos.Location = new System.Drawing.Point(91, 288);
            this.BTPrimos.Name = "BTPrimos";
            this.BTPrimos.Size = new System.Drawing.Size(103, 23);
            this.BTPrimos.TabIndex = 47;
            this.BTPrimos.Text = "Numeros Primos";
            this.BTPrimos.UseVisualStyleBackColor = true;
            this.BTPrimos.Click += new System.EventHandler(this.BTPrimos_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            this.chart1.BorderlineColor = System.Drawing.Color.Gray;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(534, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Numeros";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(342, 277);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Formulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 355);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BTPrimos);
            this.Controls.Add(this.BTImpares);
            this.Controls.Add(this.BTPares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFuncion);
            this.Controls.Add(this.LBLista);
            this.Controls.Add(this.TBHasta);
            this.Controls.Add(this.TBDesde);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Name = "Formulario4";
            this.Text = "Formulario4";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BFuncion;
        private System.Windows.Forms.ListBox LBLista;
        private System.Windows.Forms.TextBox TBHasta;
        private System.Windows.Forms.TextBox TBDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Button BTPares;
        private System.Windows.Forms.Button BTImpares;
        private System.Windows.Forms.Button BTPrimos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


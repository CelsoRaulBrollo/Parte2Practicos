namespace TP4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BFuncion = new System.Windows.Forms.Button();
            this.LBLista = new System.Windows.Forms.ListBox();
            this.TBHasta = new System.Windows.Forms.TextBox();
            this.TBDesde = new System.Windows.Forms.TextBox();
            this.LHasta = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.BTPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Lista de Números";
            // 
            // BFuncion
            // 
            this.BFuncion.Location = new System.Drawing.Point(269, 89);
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
            this.LBLista.Location = new System.Drawing.Point(408, 89);
            this.LBLista.Name = "LBLista";
            this.LBLista.Size = new System.Drawing.Size(256, 212);
            this.LBLista.TabIndex = 39;
            this.LBLista.SelectedIndexChanged += new System.EventHandler(this.LBLista_SelectedIndexChanged);
            // 
            // TBHasta
            // 
            this.TBHasta.Location = new System.Drawing.Point(123, 140);
            this.TBHasta.Name = "TBHasta";
            this.TBHasta.Size = new System.Drawing.Size(100, 20);
            this.TBHasta.TabIndex = 42;
            // 
            // TBDesde
            // 
            this.TBDesde.Location = new System.Drawing.Point(123, 85);
            this.TBDesde.Name = "TBDesde";
            this.TBDesde.Size = new System.Drawing.Size(100, 20);
            this.TBDesde.TabIndex = 43;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(56, 143);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 36;
            this.LHasta.Text = "Hasta";
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(56, 92);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 35;
            this.LDesde.Text = "Desde";
            // 
            // BTPares
            // 
            this.BTPares.Location = new System.Drawing.Point(269, 137);
            this.BTPares.Name = "BTPares";
            this.BTPares.Size = new System.Drawing.Size(103, 23);
            this.BTPares.TabIndex = 45;
            this.BTPares.Text = "Numeros Pares";
            this.BTPares.UseVisualStyleBackColor = true;
            this.BTPares.Click += new System.EventHandler(this.BTPares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 341);
            this.Controls.Add(this.BTPares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFuncion);
            this.Controls.Add(this.LBLista);
            this.Controls.Add(this.TBHasta);
            this.Controls.Add(this.TBDesde);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


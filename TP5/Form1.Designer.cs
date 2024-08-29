namespace TP5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.RDBMujer = new System.Windows.Forms.RadioButton();
            this.RDBHombre = new System.Windows.Forms.RadioButton();
            this.BTFoto = new System.Windows.Forms.Button();
            this.TBFoto = new System.Windows.Forms.TextBox();
            this.TBSaldo = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.LBSaldo = new System.Windows.Forms.Label();
            this.LBSexo = new System.Windows.Forms.Label();
            this.LBFechaNac = new System.Windows.Forms.Label();
            this.LBApellido = new System.Windows.Forms.Label();
            this.LBNombre = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtgvCliente = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::TP5.Properties.Resources.Fondo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.BTAgregar);
            this.panel1.Controls.Add(this.RDBMujer);
            this.panel1.Controls.Add(this.RDBHombre);
            this.panel1.Controls.Add(this.BTFoto);
            this.panel1.Controls.Add(this.TBFoto);
            this.panel1.Controls.Add(this.TBSaldo);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.LBSaldo);
            this.panel1.Controls.Add(this.LBSexo);
            this.panel1.Controls.Add(this.LBFechaNac);
            this.panel1.Controls.Add(this.LBApellido);
            this.panel1.Controls.Add(this.LBNombre);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(69, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 347);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTAgregar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTAgregar.Image = global::TP5.Properties.Resources.Disco;
            this.BTAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTAgregar.Location = new System.Drawing.Point(205, 266);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTAgregar.Size = new System.Drawing.Size(106, 54);
            this.BTAgregar.TabIndex = 12;
            this.BTAgregar.Text = "Agregar    ";
            this.BTAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // RDBMujer
            // 
            this.RDBMujer.AutoSize = true;
            this.RDBMujer.BackColor = System.Drawing.Color.Transparent;
            this.RDBMujer.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBMujer.ForeColor = System.Drawing.SystemColors.Window;
            this.RDBMujer.Location = new System.Drawing.Point(228, 148);
            this.RDBMujer.Name = "RDBMujer";
            this.RDBMujer.Size = new System.Drawing.Size(63, 25);
            this.RDBMujer.TabIndex = 11;
            this.RDBMujer.TabStop = true;
            this.RDBMujer.Text = "Mujer";
            this.RDBMujer.UseVisualStyleBackColor = false;
            // 
            // RDBHombre
            // 
            this.RDBHombre.AutoSize = true;
            this.RDBHombre.BackColor = System.Drawing.Color.Transparent;
            this.RDBHombre.Checked = true;
            this.RDBHombre.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBHombre.ForeColor = System.Drawing.SystemColors.Window;
            this.RDBHombre.Location = new System.Drawing.Point(144, 148);
            this.RDBHombre.Name = "RDBHombre";
            this.RDBHombre.Size = new System.Drawing.Size(78, 25);
            this.RDBHombre.TabIndex = 10;
            this.RDBHombre.TabStop = true;
            this.RDBHombre.Text = "Hombre";
            this.RDBHombre.UseVisualStyleBackColor = false;
            // 
            // BTFoto
            // 
            this.BTFoto.Location = new System.Drawing.Point(38, 226);
            this.BTFoto.Name = "BTFoto";
            this.BTFoto.Size = new System.Drawing.Size(74, 21);
            this.BTFoto.TabIndex = 9;
            this.BTFoto.Text = "Foto";
            this.BTFoto.UseVisualStyleBackColor = true;
            this.BTFoto.Click += new System.EventHandler(this.BTFoto_Click);
            // 
            // TBFoto
            // 
            this.TBFoto.Location = new System.Drawing.Point(130, 227);
            this.TBFoto.Name = "TBFoto";
            this.TBFoto.Size = new System.Drawing.Size(268, 20);
            this.TBFoto.TabIndex = 8;
            // 
            // TBSaldo
            // 
            this.TBSaldo.Location = new System.Drawing.Point(130, 198);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.Size = new System.Drawing.Size(268, 20);
            this.TBSaldo.TabIndex = 7;
            this.TBSaldo.TextChanged += new System.EventHandler(this.TBSaldo_TextChanged);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(132, 64);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(268, 20);
            this.TBApellido.TabIndex = 6;
            // 
            // LBSaldo
            // 
            this.LBSaldo.AutoSize = true;
            this.LBSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LBSaldo.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSaldo.ForeColor = System.Drawing.SystemColors.Window;
            this.LBSaldo.Location = new System.Drawing.Point(32, 190);
            this.LBSaldo.Name = "LBSaldo";
            this.LBSaldo.Size = new System.Drawing.Size(78, 33);
            this.LBSaldo.TabIndex = 5;
            this.LBSaldo.Text = "Saldo:";
            // 
            // LBSexo
            // 
            this.LBSexo.AutoSize = true;
            this.LBSexo.BackColor = System.Drawing.Color.Transparent;
            this.LBSexo.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSexo.ForeColor = System.Drawing.SystemColors.Window;
            this.LBSexo.Location = new System.Drawing.Point(32, 148);
            this.LBSexo.Name = "LBSexo";
            this.LBSexo.Size = new System.Drawing.Size(70, 33);
            this.LBSexo.TabIndex = 4;
            this.LBSexo.Text = "Sexo:";
            // 
            // LBFechaNac
            // 
            this.LBFechaNac.AutoSize = true;
            this.LBFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.LBFechaNac.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFechaNac.ForeColor = System.Drawing.SystemColors.Window;
            this.LBFechaNac.Location = new System.Drawing.Point(34, 98);
            this.LBFechaNac.Name = "LBFechaNac";
            this.LBFechaNac.Size = new System.Drawing.Size(184, 33);
            this.LBFechaNac.TabIndex = 3;
            this.LBFechaNac.Text = "Fecha Nacimiento:";
            // 
            // LBApellido
            // 
            this.LBApellido.AutoSize = true;
            this.LBApellido.BackColor = System.Drawing.Color.Transparent;
            this.LBApellido.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.LBApellido.Location = new System.Drawing.Point(32, 56);
            this.LBApellido.Name = "LBApellido";
            this.LBApellido.Size = new System.Drawing.Size(98, 33);
            this.LBApellido.TabIndex = 2;
            this.LBApellido.Text = "Apellido:";
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.BackColor = System.Drawing.Color.Transparent;
            this.LBNombre.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.LBNombre.Location = new System.Drawing.Point(34, 14);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(92, 33);
            this.LBNombre.TabIndex = 1;
            this.LBNombre.Text = "Nombre:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(132, 22);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(268, 20);
            this.TBNombre.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BackgroundImage = global::TP5.Properties.Resources.avatar2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(552, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtgvCliente
            // 
            this.dtgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.FechaNacimiento,
            this.Sexo,
            this.Eliminar,
            this.Saldo,
            this.Foto,
            this.Ruta});
            this.dtgvCliente.Location = new System.Drawing.Point(12, 423);
            this.dtgvCliente.Name = "dtgvCliente";
            this.dtgvCliente.RowTemplate.Height = 50;
            this.dtgvCliente.Size = new System.Drawing.Size(977, 187);
            this.dtgvCliente.TabIndex = 3;
            this.dtgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCliente_CellContentClick_1);
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Foto.Width = 150;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP5.Properties.Resources.Cuadros_Negros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 622);
            this.Controls.Add(this.dtgvCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.RadioButton RDBMujer;
        private System.Windows.Forms.RadioButton RDBHombre;
        private System.Windows.Forms.Button BTFoto;
        private System.Windows.Forms.TextBox TBFoto;
        private System.Windows.Forms.TextBox TBSaldo;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label LBSaldo;
        private System.Windows.Forms.Label LBSexo;
        private System.Windows.Forms.Label LBFechaNac;
        private System.Windows.Forms.Label LBApellido;
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dtgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
    }
}


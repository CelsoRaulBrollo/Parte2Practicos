using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form1 : Form
    {

        private int n = 0;
        string imagePathCelda = null;
        string destinationFilePath = null;

        string ejecutablePath = Application.StartupPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void TBSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dtgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(rutaImagen);
                TBFoto.Text = rutaImagen;
            }
        }

        private void dtgvCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                string dato = (string)dtgvCliente.Rows[n].Cells[4].Value;
                string cliente = (string)dtgvCliente.Rows[n].Cells[0].Value + " " + (string)dtgvCliente.Rows[n].Cells[1].Value;
                if (!string.IsNullOrEmpty(dato) && e.ColumnIndex == 4)
                {
                    DialogResult ask = MessageBox.Show("Desea eliminar al Cliente: " + cliente, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (ask == DialogResult.Yes)
                    {
                        dtgvCliente.Rows.RemoveAt(n);
                        limpiar();
                    }

                }
                if (!string.IsNullOrEmpty(dato) && e.ColumnIndex != 4)
                {
                    TBApellido.Text = dtgvCliente.Rows[n].Cells[0].Value.ToString();
                    TBNombre.Text = dtgvCliente.Rows[n].Cells[1].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dtgvCliente.Rows[n].Cells[2].Value.ToString());
                    if (dtgvCliente.Rows[n].Cells[3].Value.ToString() == "Hombre") RDBHombre.Checked = true;
                    else RDBMujer.Checked = true;
                    TBSaldo.Text = dtgvCliente.Rows[n].Cells[5].Value.ToString();
                    pictureBox1.Image = Image.FromFile(dtgvCliente.Rows[n].Cells[7].Value.ToString());
                    TBFoto.Text = dtgvCliente.Rows[n].Cells[7].Value.ToString();
                }
            }
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBNombre.Text) || string.IsNullOrEmpty(TBApellido.Text) || string.IsNullOrEmpty(TBSaldo.Text) || string.IsNullOrEmpty(TBFoto.Text))
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsTexto(TBNombre.Text) || !EsTexto(TBApellido.Text))
            {
                MessageBox.Show("El nombre y apellido solo deben contener letras!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(TBSaldo.Text, out decimal saldo))
            {
                MessageBox.Show("El saldo debe ser un número válido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(TBFoto.Text) || !ImagenValida(TBFoto.Text))
            {
                MessageBox.Show("Debe seleccionar una imagen válida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;
            DateTime fechaMinima = DateTime.Today.AddYears(-18);
            if (fechaSeleccionada > fechaMinima)
            {
                MessageBox.Show("El usuario debe tener 18 años o más!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int n = dtgvCliente.Rows.Add();
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                dtgvCliente.Rows[n].Cells[0].Value = textInfo.ToTitleCase(TBApellido.Text.ToLower());
                dtgvCliente.Rows[n].Cells[1].Value = textInfo.ToTitleCase(TBNombre.Text.ToLower());
                dtgvCliente.Rows[n].Cells[2].Value = dateTimePicker1.Text;
                dtgvCliente.Rows[n].Cells[3].Value = RDBHombre.Checked ? "Hombre" : "Mujer";
                dtgvCliente.Rows[n].Cells[4].Value = "Eliminar";
                dtgvCliente.Rows[n].Cells[5].Value = saldo;

                if (saldo < 50)
                {
                    dtgvCliente.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                }

                string fotosPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos");

                if (!Directory.Exists(fotosPath))
                {
                    Directory.CreateDirectory(fotosPath);
                }

                string fileName = Path.GetFileName(TBFoto.Text);
                string destinationFilePath = Path.Combine(fotosPath, TBApellido.Text + TBNombre.Text + n + fileName);

                File.Copy(TBFoto.Text, destinationFilePath, true);

                Image imagen = Image.FromFile(destinationFilePath);
                dtgvCliente.Rows[n].Cells[6].Value = imagen;
                dtgvCliente.Rows[n].Cells[7].Value = destinationFilePath;

                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsTexto(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private bool ImagenValida(string filePath)
        {
            try
            {
                using (var img = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void limpiar()
        {
            TBNombre.Clear();
            TBApellido.Clear();
            dateTimePicker1.Value = DateTime.Now;
            RDBHombre.Checked = true;
            TBSaldo.Clear();
            TBFoto.Clear();
            pictureBox1.Image = TP5.Properties.Resources.avatar2;
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

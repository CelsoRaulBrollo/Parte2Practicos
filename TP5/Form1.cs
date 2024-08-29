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

        private void dtgvCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBNombre.Text) || string.IsNullOrEmpty(TBApellido.Text) || string.IsNullOrEmpty(TBSaldo.Text) || string.IsNullOrEmpty(TBFoto.Text))
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

                DateTime fechaMinima = DateTime.Today.AddYears(-18);
                if (fechaSeleccionada <= fechaMinima)
                {
                    int n = dtgvCliente.Rows.Add();
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                    dtgvCliente.Rows[n].Cells[0].Value = textInfo.ToTitleCase(TBApellido.Text.ToLower());
                    dtgvCliente.Rows[n].Cells[1].Value = textInfo.ToTitleCase(TBNombre.Text.ToLower());
                    dtgvCliente.Rows[n].Cells[2].Value = dateTimePicker1.Text;

                    if (RDBHombre.Checked) dtgvCliente.Rows[n].Cells[3].Value = "Hombre";
                    else dtgvCliente.Rows[n].Cells[3].Value = "Mujer";

                    dtgvCliente.Rows[n].Cells[4].Value = "Eliminar";

                    if (Decimal.Parse(TBSaldo.Text) < 50) dtgvCliente.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                    dtgvCliente.Rows[n].Cells[5].Value = Decimal.Parse(TBSaldo.Text);

                    try
                    {
                        string fotosPath = Path.Combine(ejecutablePath, "Fotos");

                        if (!Directory.Exists(fotosPath))
                        {
                            Directory.CreateDirectory(fotosPath);
                        }

                        string sourceFilePath = TBFoto.Text;

                        string fileName = Path.GetFileName(sourceFilePath);

                        destinationFilePath = Path.Combine(fotosPath, TBApellido.Text + TBNombre.Text + n + fileName);

                        File.Copy(sourceFilePath, destinationFilePath, true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Image imagen = Image.FromFile(destinationFilePath);
                    dtgvCliente.Rows[n].Cells[6].Value = imagen;

                    dtgvCliente.Rows[n].Cells[7].Value = destinationFilePath;

                    limpiar();
                    destinationFilePath = null;
                }
                else
                {
                    MessageBox.Show("El usuario debe tener 18 años o mas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
    }
}

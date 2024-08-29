using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        private Int16 desde;
        Int16 hasta;

        public Form1()
        {
            InitializeComponent();
        }

        private void LBLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BFuncion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBDesde.Text) || string.IsNullOrEmpty(TBHasta.Text))
            {
                MessageBox.Show("Debe ingresar números en ambos campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LBLista.Items.Clear();
                desde = Int16.Parse(TBDesde.Text);
                hasta = Int16.Parse(TBHasta.Text);
                while (desde <= hasta)
                {
                    LBLista.Items.Add(desde);
                    desde++;
                }
            }
        }
    }
}

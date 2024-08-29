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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace TP4
{
    public partial class Formulario4 : Form
    {
        private Int16 desde;
        Int16 hasta;

        string[] series = { "Pares", "Impares", "Primos", "Total" };
        int[] puntos = { };

        public Formulario4()
        {
            InitializeComponent();
            chart1.Titles.Add("Lista Números");
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

        private void BTPares_Click(object sender, EventArgs e)
        {
            if (LBLista.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chart1.Series["Numeros"].Points.Clear();
                LBLista.Items.Clear();
                desde = Int16.Parse(TBDesde.Text);
                hasta = Int16.Parse(TBHasta.Text);
                int total = 0;
                int par = 0;
                while (desde <= hasta)
                {

                    if (esPar(desde))
                    {
                        LBLista.Items.Add(desde);
                        par++;
                    }
                    desde++;
                    total++;
                }
                chart1.Series["Numeros"].Points.AddXY("Pares", par);
                chart1.Series["Numeros"].Points.AddXY("Total", total);
            }
        }

        public bool esPar(Int16 n)
        {
            return (n % 2 == 0);
        }

        private void BTImpares_Click(object sender, EventArgs e)
        {
            if (LBLista.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chart1.Series["Numeros"].Points.Clear();
                LBLista.Items.Clear();
                desde = Int16.Parse(TBDesde.Text);
                hasta = Int16.Parse(TBHasta.Text);
                int total = 0;
                int impar = 0;
                while (desde <= hasta)
                {
                    if (esImpar(desde))
                    {
                        LBLista.Items.Add(desde);
                        impar++;
                    }
                    desde++;
                    total++;
                }
                chart1.Series["Numeros"].Points.AddXY("Impares", impar);
                chart1.Series["Numeros"].Points.AddXY("Total", total);
            }
        }

        public bool esImpar(Int16 n)
        {
            return (n % 2 != 0);
        }

        private void BTPrimos_Click(object sender, EventArgs e)
        {
            if (LBLista.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chart1.Series["Numeros"].Points.Clear();
                LBLista.Items.Clear();
                desde = Int16.Parse(TBDesde.Text);
                hasta = Int16.Parse(TBHasta.Text);
                int total = 0;
                int primos = 0;
                while (desde <= hasta)
                {
                    if (esPrimo(desde))
                    {
                        LBLista.Items.Add(desde);
                        primos++;
                    }
                    desde++;
                    total++;
                }
                chart1.Series["Numeros"].Points.AddXY("Primos", primos);
                chart1.Series["Numeros"].Points.AddXY("Total", total);
            }
        }

        public bool esPrimo(Int16 n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

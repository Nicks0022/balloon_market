using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_balão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtTPagar.Clear();
            txtVTotal.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorProduto = decimal.Parse(txtProduto.Text);
            int quantidade = int.Parse(numericUpDown1.Text);

            // Calcule o valor total
            decimal valorTotal = valorProduto * quantidade;

            // Exiba o valor total no Label
            txtVTotal.Text = valorTotal.ToString("C2");

            rbdVista.Visible = true;
            rdbPrazo.Visible = true;

            if (rbdVista.Checked)
            {
                decimal valorComDesconto = valorTotal - (valorTotal * 0.1m);
                txtTPagar.Text = valorComDesconto.ToString();
            }

            else if (rdbPrazo.Checked)
            {
                decimal valorParcela = valorTotal / 3;
                txtTPagar.Text = valorParcela.ToString();
            }

        }

        private void rbdVista_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbdVista.Visible = false;
            rdbPrazo.Visible = false;
        }
    }

}

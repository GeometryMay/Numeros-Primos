using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPrimos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        private void btnMostrarPrimos_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear();

            if (int.TryParse(txtLimite.Text, out int limite) && limite >= 2)
            {
                for (int i = 2; i <= limite; i++)
                {
                    if (EsPrimo(i))
                        listBoxPrimos.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un límite válido mayor o igual a 2.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLimite.Text = "";
            listBoxPrimos.Items.Clear();
        }
    }
}

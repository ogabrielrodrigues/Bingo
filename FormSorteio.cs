using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoApp
{
    public partial class FormSorteio : Form
    {
        List<int> numerosDisponiveis = new List<int>();

        public FormSorteio()
        {
            InitializeComponent();

            for (int i = 1; i < 75; i++) {
                numerosDisponiveis.Add(i);
            }
        }

        void sortearNumero() {
            Random rnd = new Random();

            int numeroSorteado = rnd.Next(numerosDisponiveis.Count);

            numerosDisponiveis.RemoveAt(numeroSorteado);

            string letra = "";
            if (numerosDisponiveis[numeroSorteado] <= 15) {
                letra = "B";
            } else if (numerosDisponiveis[numeroSorteado] <= 30) {
                letra = "I";
            } else if (numerosDisponiveis[numeroSorteado] <= 45) {
                letra = "N";
            } else if (numerosDisponiveis[numeroSorteado] <= 60) {
                letra = "G";
            } else {
                letra = "O";
            }

            MessageBox.Show(letra + numerosDisponiveis[numeroSorteado].ToString());
        }

        private void btnSorteioSortear_Click(object sender, EventArgs e)
        {
            sortearNumero();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoApp
{
    public partial class FormHistorico : Form
    {
        string raiz;
        string caminho;

        public FormHistorico()
        {
            InitializeComponent();

            this.raiz = AppDomain.CurrentDomain.BaseDirectory;
            this.caminho = Path.Combine(raiz, "bingos");

            CarregarHistoricoBingo();
        }

        void CarregarHistoricoBingo()
        {
            if (!Directory.Exists(this.caminho)) {
               return;
            }

            IEnumerable<string> bingos = Directory.EnumerateFiles(this.caminho);
            if (bingos.Count() == 0) {
                lstHistorico.Items.Add("Sem bingos realizados.");
                return;
            }

            // Caso tenha chego até aqui, significa que possuem bingos
            foreach (string bingo in bingos)
            {
                lstHistorico.Items.Add(bingo);
            }
        }

        private void lstHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string conteudo = File.ReadAllText(lstHistorico.SelectedItem.ToString());
                txtHistoricoConteudo.Text = Regex.Replace(conteudo, "\n", "\r\n");
            }
            catch (Exception ex) {
                MessageBox.Show(
                    "Erro ao carregar o bingo\nERRO: " + ex.Message,
                    "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

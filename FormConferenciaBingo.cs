using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoApp
{
    public partial class FormConferenciaBingo : Form
    {
        DateTime momentoInicial, momentoFinal;

        List<int> numerosSorteados;
        string caminhoArquivo;

        public FormConferenciaBingo(string caminhoArquivo, DateTime momentoInicial, List<int> numerosSorteados)
        {
            InitializeComponent();

            this.caminhoArquivo = caminhoArquivo;
            this.momentoInicial = momentoInicial;
            this.numerosSorteados = numerosSorteados;
        }

        List<int> FormatarNumerosCartela()
        {
            List<int> numeros = new List<int>();

            string[] numerosTexto = txtConferenciaNumerosCartela.Text.Split(' ');

            foreach (string numero in numerosTexto)
            {
                if (!string.IsNullOrWhiteSpace(numero))
                {
                    numeros.Add(int.Parse(numero));
                }
            }

            return numeros;
        }

        private void btnConferenciaConferir_Click(object sender, EventArgs e)
        {
            List<int> numerosInformados = FormatarNumerosCartela();

            foreach (int informado in numerosInformados)
            {
                // Se retornar 0, é porque esse número não foi sorteado, ou não está presente
                // na cartela informada. Ou seja, COMEU BRONHA!
                if (this.numerosSorteados.Find(sorteado => sorteado == informado) == 0) {
                    MessageBox.Show(
                        "Atenção - Cartela Inválida",
                        "Você informou um número não sorteado! COMEU BRONHA!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    // Código Retry (4), é que algum número não foi sorteado
                    this.DialogResult = DialogResult.Retry;
                    return;
                }
            }

            // Código OK (1), é que deu certo e todos os número coincidem
            this.DialogResult = DialogResult.OK;

            this.momentoFinal = DateTime.Now;
            TimeSpan duracao = this.momentoFinal - this.momentoInicial;

            string listaDeSorteados = "";

            foreach (int sorteado in numerosSorteados)
            {
                listaDeSorteados += $"{sorteado.ToString().PadLeft(2, '0')}\n";
            }

            try
            {
                File.AppendAllText(caminhoArquivo, 
                    $"\n\nVENCEDOR: {txtConferenciaNome.Text}\nDATA TERMINO: {momentoFinal}\nDURAÇÃO: {duracao.ToString(@"hh\:mm\:ss")}"
                    + $"\n\nLISTA DE NÚMEROS SORTEADOS:\n\n{listaDeSorteados}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERRO",
                    "Houve um erro ao finalizar o bingo! Tente novamente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }
    }
}

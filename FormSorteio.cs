using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoApp
{
    public partial class FormSorteio : Form
    {
        string caminhoArquivo;
        DateTime momentoInicial;

        List<int> numeros;
        Random gerador;

        int indiceAtual;
        string ultimaLetra = "B";
        int ultimoSorteado = 0;

        List<int> numerosSorteados = new List<int>();

        public FormSorteio(string caminhoArquivo, DateTime momentoInicial)
        {
            InitializeComponent();
            this.caminhoArquivo = caminhoArquivo;
            this.momentoInicial = momentoInicial;

            IniciarSorteio();
        }

        void SalvarNumeroBingo(int sorteado)
        {
            File.AppendAllText(
                caminhoArquivo,
                $"\n{sorteado.ToString().PadLeft(2, '0')}"
            );
        }

        void IniciarSorteio()
        {
            DateTime momentoInicio = DateTime.Now;

            numeros = Enumerable.Range(1, 75).ToList();

            gerador = new Random();

            EmbaralharLista();

            indiceAtual = 0;

            lblSorteioUltimaLetra.Text = ultimaLetra;
            lblSorteioUltimoNumero.Text = ultimoSorteado.ToString();

            lblSorteioSorteadoLetra.Text = "B";
            lblSorteioNumeroSorteado.Text = "0";
        }

        void EmbaralharLista()
        {
            for (int i = numeros.Count - 1; i > 0; i--)
            {
                int j = gerador.Next(i + 1);
                int temp = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = temp;
            }
        }

        string VerificaLetra(int sorteado)
        {
            string letra = "";

            if (sorteado <= 15) letra = "B";
            else if (sorteado <= 30) letra = "I";
            else if (sorteado <= 45) letra = "N";
            else if (sorteado <= 60) letra = "G";
            else letra = "O";

            return letra;
        }

        void MarcarPlacar(int sorteado)
        {
            string letraAtual = VerificaLetra(sorteado);

            lblSorteioSorteadoLetra.Text = letraAtual;
            lblSorteioNumeroSorteado.Text = sorteado.ToString().PadLeft(2, '0');

            if (ultimoSorteado != 0)
            {
                lblSorteioUltimaLetra.Text = ultimaLetra;
                lblSorteioUltimoNumero.Text = ultimoSorteado.ToString().PadLeft(2, '0');
            }

            ultimaLetra = letraAtual;
            ultimoSorteado = sorteado;
        }

        void MarcarNumeroNoBingo(int sorteado)
        {
            List<Label> labels = this.Controls.OfType<Label>().ToList();

            foreach (Label label in labels) {
                if (label.Name == $"lbl{sorteado}") {
                    label.BackColor = Color.Green;
                    label.ForeColor = Color.White;
                }
            }
        }

        int SortearNumero()
        {
            // Se retornar -1, é porque não há mais números a serem sorteados. Portanto, o bingo terminou!
            if (indiceAtual >= numeros.Count) return -1;

            int sorteado = numeros[indiceAtual++];

            MarcarNumeroNoBingo(sorteado);
            MarcarPlacar(sorteado);

            try
            {
                SalvarNumeroBingo(sorteado);
            } catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao salvar o número do BINGO\nERRO: " + ex,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            numerosSorteados.Add(sorteado);
            return sorteado;
        }

        private void btnSorteioSortear_Click(object sender, EventArgs e)
        {
            if (SortearNumero() == -1)
            {
                MessageBox.Show("O bingo terminou!");
            }
        }

        void FinalizarBingo()
        {
            MessageBox.Show(
               "Obrigado por participar!",
               "Bingo Finalizado",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
            );

            this.Close();
        }

        private void btnSorteioBingo_Click(object sender, EventArgs e)
        {
            FormConferenciaBingo formConferenciaBingo = new FormConferenciaBingo(this.caminhoArquivo, this.momentoInicial, this.numerosSorteados);
            
            DialogResult bingo = formConferenciaBingo.ShowDialog();

            if (bingo == DialogResult.Retry)
            {
                MessageBox.Show(
                   "Atenção - Cartela Inválida",
                   "Você informou um número não sorteado! COMEU BRONHA!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                );
                return;
            }

            FinalizarBingo();
        }
    }
}

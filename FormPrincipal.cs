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
    public partial class FormPrincipal : Form
    {
        DateTime momentoInicial;

        public FormPrincipal()
        {
            InitializeComponent();

            AutoValidate = AutoValidate.Disable;
        }

        private void txtPrincipalPremio_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrincipalPremio.Text)) {
                e.Cancel = true;
                errorProviderPrincipal.
                    SetError(txtPrincipalPremio, "Preencha o prêmio do bingo!");
            } else {
                e.Cancel = false;
                errorProviderPrincipal.SetError(txtPrincipalPremio, "");
            }
        }

        string MontaNomeArquivo(DateTime tempo)
        {
            return $"{tempo.ToShortDateString().Replace("/", "-")}_{tempo.ToShortTimeString().Replace(":", "-")}.txt";
        }

        string CriarArquivoBingo(string premio)
        {
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            string caminho = Path.Combine(raiz, "bingos");

            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            momentoInicial = DateTime.Now;

            string caminhoArquivo = Path.Combine(caminho, MontaNomeArquivo(momentoInicial));

            File.WriteAllText(
                caminhoArquivo,
                $"BINGO - Prêmio: {premio}\nDATA INÍCIO: {momentoInicial}\n"
            );

            return caminhoArquivo;
        }

        private void btnPrincipalIniciar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                try
                {
                    string caminhoArquivo = CriarArquivoBingo(txtPrincipalPremio.Text);

                    FormSorteio formSorteio = new FormSorteio(caminhoArquivo, momentoInicial);
                    formSorteio.ShowDialog();
                } catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ocorreu um erro ao iniciar o BINGO\nERRO: "+ex,
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            } else {
                MessageBox.Show(
                    "Preencha corretamente o prêmio do bingo",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            } 
        }
    }
}

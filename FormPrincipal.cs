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
    public partial class FormPrincipal : Form
    {
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

        private void btnPrincipalIniciar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                FormSorteio formSorteio = new FormSorteio();
                formSorteio.ShowDialog();
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

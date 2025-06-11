namespace BingoApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPrincipalIniciar = new System.Windows.Forms.Button();
            this.txtPrincipalPremio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderPrincipal = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrincipalIniciar
            // 
            this.btnPrincipalIniciar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrincipalIniciar.Location = new System.Drawing.Point(84, 151);
            this.btnPrincipalIniciar.Name = "btnPrincipalIniciar";
            this.btnPrincipalIniciar.Size = new System.Drawing.Size(121, 33);
            this.btnPrincipalIniciar.TabIndex = 0;
            this.btnPrincipalIniciar.Text = "INICIAR BINGO";
            this.btnPrincipalIniciar.UseVisualStyleBackColor = true;
            this.btnPrincipalIniciar.Click += new System.EventHandler(this.btnPrincipalIniciar_Click);
            // 
            // txtPrincipalPremio
            // 
            this.txtPrincipalPremio.Location = new System.Drawing.Point(42, 109);
            this.txtPrincipalPremio.Name = "txtPrincipalPremio";
            this.txtPrincipalPremio.Size = new System.Drawing.Size(218, 20);
            this.txtPrincipalPremio.TabIndex = 1;
            this.txtPrincipalPremio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrincipalPremio_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o Prêmio do Bingo";
            // 
            // errorProviderPrincipal
            // 
            this.errorProviderPrincipal.ContainerControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(295, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrincipalPremio);
            this.Controls.Add(this.btnPrincipalIniciar);
            this.Name = "FormPrincipal";
            this.Text = "Bingo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrincipalIniciar;
        private System.Windows.Forms.TextBox txtPrincipalPremio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderPrincipal;
    }
}


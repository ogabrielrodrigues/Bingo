namespace BingoApp
{
    partial class FormHistorico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtHistoricoConteudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(12, 27);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(285, 238);
            this.lstHistorico.TabIndex = 0;
            this.lstHistorico.SelectedIndexChanged += new System.EventHandler(this.lstHistorico_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Histórico";
            // 
            // txtHistoricoConteudo
            // 
            this.txtHistoricoConteudo.Location = new System.Drawing.Point(322, 27);
            this.txtHistoricoConteudo.Multiline = true;
            this.txtHistoricoConteudo.Name = "txtHistoricoConteudo";
            this.txtHistoricoConteudo.ReadOnly = true;
            this.txtHistoricoConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistoricoConteudo.Size = new System.Drawing.Size(258, 238);
            this.txtHistoricoConteudo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalhes do Bingo";
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(592, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHistoricoConteudo);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lstHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHistorico";
            this.Text = "Histórico de Bingos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtHistoricoConteudo;
        private System.Windows.Forms.Label label1;
    }
}
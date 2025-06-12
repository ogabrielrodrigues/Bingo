namespace BingoApp
{
    partial class FormConferenciaBingo
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
            this.txtConferenciaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConferenciaNumerosCartela = new System.Windows.Forms.TextBox();
            this.btnConferenciaConferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConferenciaNome
            // 
            this.txtConferenciaNome.Location = new System.Drawing.Point(12, 29);
            this.txtConferenciaNome.Name = "txtConferenciaNome";
            this.txtConferenciaNome.Size = new System.Drawing.Size(319, 20);
            this.txtConferenciaNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Números da Cartela (Separar por espaço)";
            // 
            // txtConferenciaNumerosCartela
            // 
            this.txtConferenciaNumerosCartela.Location = new System.Drawing.Point(15, 103);
            this.txtConferenciaNumerosCartela.Name = "txtConferenciaNumerosCartela";
            this.txtConferenciaNumerosCartela.Size = new System.Drawing.Size(319, 20);
            this.txtConferenciaNumerosCartela.TabIndex = 2;
            // 
            // btnConferenciaConferir
            // 
            this.btnConferenciaConferir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConferenciaConferir.Location = new System.Drawing.Point(228, 129);
            this.btnConferenciaConferir.Name = "btnConferenciaConferir";
            this.btnConferenciaConferir.Size = new System.Drawing.Size(106, 34);
            this.btnConferenciaConferir.TabIndex = 4;
            this.btnConferenciaConferir.Text = "Conferir";
            this.btnConferenciaConferir.UseVisualStyleBackColor = true;
            this.btnConferenciaConferir.Click += new System.EventHandler(this.btnConferenciaConferir_Click);
            // 
            // FormConferenciaBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(345, 176);
            this.Controls.Add(this.btnConferenciaConferir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConferenciaNumerosCartela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConferenciaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormConferenciaBingo";
            this.Text = "Conferir BINGO!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConferenciaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConferenciaNumerosCartela;
        private System.Windows.Forms.Button btnConferenciaConferir;
    }
}
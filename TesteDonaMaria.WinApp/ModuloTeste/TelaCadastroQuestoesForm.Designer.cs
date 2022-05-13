namespace TesteDonaMaria.WinApp.ModuloTeste
{
    partial class TelaCadastroQuestoesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBimestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gabarito = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.RichTextBox();
            this.txtGabarito = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listQuestoes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bimestre:";
            // 
            // cmbBimestre
            // 
            this.cmbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBimestre.FormattingEnabled = true;
            this.cmbBimestre.Location = new System.Drawing.Point(74, 17);
            this.cmbBimestre.Name = "cmbBimestre";
            this.cmbBimestre.Size = new System.Drawing.Size(90, 23);
            this.cmbBimestre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pergunta:";
            // 
            // Gabarito
            // 
            this.Gabarito.AutoSize = true;
            this.Gabarito.Location = new System.Drawing.Point(13, 105);
            this.Gabarito.Name = "Gabarito";
            this.Gabarito.Size = new System.Drawing.Size(55, 15);
            this.Gabarito.TabIndex = 13;
            this.Gabarito.Text = "Gabarito:";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(74, 46);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(333, 53);
            this.txtPergunta.TabIndex = 14;
            this.txtPergunta.Text = "";
            // 
            // txtGabarito
            // 
            this.txtGabarito.Location = new System.Drawing.Point(73, 105);
            this.txtGabarito.Name = "txtGabarito";
            this.txtGabarito.Size = new System.Drawing.Size(333, 83);
            this.txtGabarito.TabIndex = 15;
            this.txtGabarito.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(335, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(256, 394);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(334, 194);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(72, 31);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // listQuestoes
            // 
            this.listQuestoes.FormattingEnabled = true;
            this.listQuestoes.ItemHeight = 15;
            this.listQuestoes.Location = new System.Drawing.Point(13, 249);
            this.listQuestoes.Name = "listQuestoes";
            this.listQuestoes.Size = new System.Drawing.Size(394, 139);
            this.listQuestoes.TabIndex = 19;
            this.listQuestoes.SelectedIndexChanged += new System.EventHandler(this.listQuestoes_SelectedIndexChanged);
            // 
            // TelaCadastroQuestoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 440);
            this.Controls.Add(this.listQuestoes);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtGabarito);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.Gabarito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBimestre);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroQuestoesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroQuestoesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBimestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Gabarito;
        private System.Windows.Forms.RichTextBox txtPergunta;
        private System.Windows.Forms.RichTextBox txtGabarito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listQuestoes;
    }
}
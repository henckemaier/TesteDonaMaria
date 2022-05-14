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
            this.label3 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirQuestao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bimestre:";
            // 
            // cmbBimestre
            // 
            this.cmbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBimestre.FormattingEnabled = true;
            this.cmbBimestre.Location = new System.Drawing.Point(380, 17);
            this.cmbBimestre.Name = "cmbBimestre";
            this.cmbBimestre.Size = new System.Drawing.Size(112, 23);
            this.cmbBimestre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pergunta:";
            // 
            // Gabarito
            // 
            this.Gabarito.AutoSize = true;
            this.Gabarito.Location = new System.Drawing.Point(13, 115);
            this.Gabarito.Name = "Gabarito";
            this.Gabarito.Size = new System.Drawing.Size(55, 15);
            this.Gabarito.TabIndex = 13;
            this.Gabarito.Text = "Gabarito:";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(73, 53);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(419, 53);
            this.txtPergunta.TabIndex = 14;
            this.txtPergunta.Text = "";
            // 
            // txtGabarito
            // 
            this.txtGabarito.Location = new System.Drawing.Point(73, 115);
            this.txtGabarito.Name = "txtGabarito";
            this.txtGabarito.Size = new System.Drawing.Size(419, 83);
            this.txtGabarito.TabIndex = 15;
            this.txtGabarito.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(420, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(342, 447);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(420, 204);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(72, 31);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // listQuestoes
            // 
            this.listQuestoes.BackColor = System.Drawing.SystemColors.Window;
            this.listQuestoes.FormattingEnabled = true;
            this.listQuestoes.ItemHeight = 15;
            this.listQuestoes.Location = new System.Drawing.Point(6, 22);
            this.listQuestoes.Name = "listQuestoes";
            this.listQuestoes.Size = new System.Drawing.Size(401, 139);
            this.listQuestoes.TabIndex = 19;
            this.listQuestoes.SelectedIndexChanged += new System.EventHandler(this.listQuestoes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Num/Letra:";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(73, 17);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(69, 23);
            this.txtLetra.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnExcluirQuestao);
            this.groupBox1.Controls.Add(this.listQuestoes);
            this.groupBox1.Location = new System.Drawing.Point(13, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 173);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Questões";
            // 
            // btnExcluirQuestao
            // 
            this.btnExcluirQuestao.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluirQuestao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirQuestao.Image = global::TesteDonaMaria.WinApp.Properties.Resources.outline_delete_black_24dp;
            this.btnExcluirQuestao.Location = new System.Drawing.Point(413, 59);
            this.btnExcluirQuestao.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluirQuestao.Name = "btnExcluirQuestao";
            this.btnExcluirQuestao.Size = new System.Drawing.Size(60, 57);
            this.btnExcluirQuestao.TabIndex = 20;
            this.btnExcluirQuestao.UseVisualStyleBackColor = false;
            this.btnExcluirQuestao.Click += new System.EventHandler(this.btnExcluirQuestao_Click);
            // 
            // TelaCadastroQuestoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtGabarito);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.Gabarito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBimestre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroQuestoesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Questões";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirQuestao;
    }
}
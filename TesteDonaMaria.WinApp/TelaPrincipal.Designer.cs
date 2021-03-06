namespace TesteDonaMaria.WinApp
{
    partial class TelaPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionarQuestao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDuplicar = new System.Windows.Forms.ToolStripButton();
            this.btnPdf = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.toolBox = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparator1,
            this.btnAdicionarQuestao,
            this.toolStripSeparator2,
            this.btnDuplicar,
            this.btnPdf,
            this.toolStripSeparator3,
            this.labelTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 49);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolbox";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::TesteDonaMaria.WinApp.Properties.Resources.outline_add_circle_outline_black_24dp;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(38, 46);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::TesteDonaMaria.WinApp.Properties.Resources.outline_mode_edit_black_24dp;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(38, 46);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::TesteDonaMaria.WinApp.Properties.Resources.outline_delete_black_24dp;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(38, 46);
            this.btnExcluir.Text = "toolStripButton1";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // btnAdicionarQuestao
            // 
            this.btnAdicionarQuestao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionarQuestao.Image = global::TesteDonaMaria.WinApp.Properties.Resources.outline_list_alt_black_24dp;
            this.btnAdicionarQuestao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionarQuestao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionarQuestao.Name = "btnAdicionarQuestao";
            this.btnAdicionarQuestao.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdicionarQuestao.Size = new System.Drawing.Size(38, 46);
            this.btnAdicionarQuestao.Text = "toolStripButton1";
            this.btnAdicionarQuestao.Click += new System.EventHandler(this.btnAdicionarQuestao_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuplicar.Image = global::TesteDonaMaria.WinApp.Properties.Resources.icons8_duplicata_32;
            this.btnDuplicar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuplicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Padding = new System.Windows.Forms.Padding(5);
            this.btnDuplicar.Size = new System.Drawing.Size(46, 46);
            this.btnDuplicar.Text = "toolStripButton2";
            this.btnDuplicar.Click += new System.EventHandler(this.btnDuplicar_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPdf.Image = global::TesteDonaMaria.WinApp.Properties.Resources.icons8_pdf_30;
            this.btnPdf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Padding = new System.Windows.Forms.Padding(5);
            this.btnPdf.Size = new System.Drawing.Size(44, 46);
            this.btnPdf.Text = "toolStripButton1";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(90, 46);
            this.labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(839, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(52, 17);
            this.labelRodape.Text = "[rodapé]";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelRegistros.Location = new System.Drawing.Point(0, 73);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(839, 402);
            this.panelRegistros.TabIndex = 3;
            this.panelRegistros.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegistros_Paint);
            // 
            // toolBox
            // 
            this.toolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.toolBox.Location = new System.Drawing.Point(0, 0);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(839, 24);
            this.toolBox.TabIndex = 4;
            this.toolBox.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testesMenuItem,
            this.materiaMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // testesMenuItem
            // 
            this.testesMenuItem.Name = "testesMenuItem";
            this.testesMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.testesMenuItem.Size = new System.Drawing.Size(138, 22);
            this.testesMenuItem.Text = "Testes";
            this.testesMenuItem.Click += new System.EventHandler(this.testesMenuItem_Click);
            // 
            // materiaMenuItem
            // 
            this.materiaMenuItem.Name = "materiaMenuItem";
            this.materiaMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.materiaMenuItem.Size = new System.Drawing.Size(138, 22);
            this.materiaMenuItem.Text = "Materias";
            this.materiaMenuItem.Click += new System.EventHandler(this.materiaMenuItem_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 497);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolBox);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Teste";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolBox.ResumeLayout(false);
            this.toolBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.MenuStrip toolBox;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdicionarQuestao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.ToolStripButton btnPdf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDuplicar;
    }
}
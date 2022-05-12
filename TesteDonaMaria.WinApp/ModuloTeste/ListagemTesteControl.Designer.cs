namespace TesteDonaMaria.WinApp.ModuloTeste
{
    partial class ListagemTesteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listTestes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listTestes
            // 
            this.listTestes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTestes.FormattingEnabled = true;
            this.listTestes.ItemHeight = 15;
            this.listTestes.Location = new System.Drawing.Point(0, 0);
            this.listTestes.Name = "listTestes";
            this.listTestes.Size = new System.Drawing.Size(429, 305);
            this.listTestes.TabIndex = 0;
            // 
            // ListagemTesteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listTestes);
            this.Name = "ListagemTesteControl";
            this.Size = new System.Drawing.Size(429, 305);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTestes;
    }
}

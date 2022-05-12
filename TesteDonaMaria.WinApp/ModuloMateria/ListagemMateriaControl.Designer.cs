namespace TesteDonaMaria.WinApp.ModuloMateria
{
    partial class ListagemMateriaControl
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
            this.listMaterias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listMaterias
            // 
            this.listMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMaterias.FormattingEnabled = true;
            this.listMaterias.ItemHeight = 15;
            this.listMaterias.Location = new System.Drawing.Point(0, 0);
            this.listMaterias.Name = "listMaterias";
            this.listMaterias.Size = new System.Drawing.Size(292, 252);
            this.listMaterias.TabIndex = 0;
            this.listMaterias.SelectedIndexChanged += new System.EventHandler(this.listMaterias_SelectedIndexChanged);
            // 
            // ListagemMateriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMaterias);
            this.Name = "ListagemMateriaControl";
            this.Size = new System.Drawing.Size(292, 252);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMaterias;
    }
}

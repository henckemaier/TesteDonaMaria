using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDonaMaria.Dominio.ModuloMateria;

namespace TesteDonaMaria.WinApp.ModuloMateria
{
    public partial class ListagemMateriaControl : UserControl
    {
        public ListagemMateriaControl()
        {
            InitializeComponent();
        }

        internal void AtualizarRegistros(List<Materia> materias)
        {
            listMaterias.Items.Clear();

            foreach (Materia materia in materias)
            {
                listMaterias.Items.Add(materia);
            }
        }

        private void listMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal Materia SelecionarMateria()
        {
            return (Materia)listMaterias.SelectedItem;
        }
    }
}

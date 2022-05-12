using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDonaMaria.Dominio.ModuloTeste;

namespace TesteDonaMaria.WinApp.ModuloTeste
{
    public partial class ListagemTesteControl : UserControl
    {
        public ListagemTesteControl()
        {
            InitializeComponent();
        }

        internal void AtualizarRegistros(List<Teste> testes)
        {
            listTestes.Items.Clear();

            foreach (Teste teste in testes)
            {
                listTestes.Items.Add(teste);
            }
        }

        internal Teste SelecionarTeste()
        {
            return (Teste)listTestes.SelectedItem;
        }
    }
}

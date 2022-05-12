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
using TesteDonaMaria.WinApp.Compartilhado;

namespace TesteDonaMaria.WinApp.ModuloTeste
{
    public partial class ListagemTesteControl : UserControl
    {
        public ListagemTesteControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Disciplina, Matéria, Série"},
                new DataGridViewTextBoxColumn { DataPropertyName = "NumQuestoes", HeaderText = "Nº de questões"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataCriacao", HeaderText = "Data"}
            };
            return colunas;
        }

        internal void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();

            foreach (Teste teste in testes)
            {
                grid.Rows.Add(teste.Numero, teste.Materia, teste.NumQuestoes, teste.DataCriacao);
            }
        }

        internal int ObtemNumeroTesteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }
    }
}

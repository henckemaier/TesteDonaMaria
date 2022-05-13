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
    public partial class TelaCadastroQuestoesForm : Form
    {
        private readonly Teste teste;
        public TelaCadastroQuestoesForm(Teste teste)
        {
            InitializeComponent();

            CarregarBimestre();

            this.teste = teste;

            foreach (TesteQuestoes item in teste.Questoes)
            {
                listQuestoes.Items.Add(item);
            }
        }

        private void CarregarBimestre()
        {
            var bimestre = Enum.GetValues(typeof(BimestreTesteEnum));

            foreach (var item in bimestre)
            {
                cmbBimestre.Items.Add(item);
            }

            cmbBimestre.SelectedItem = BimestreTesteEnum.Primeiro;
        }

        public List<TesteQuestoes> QuestoesAdicionadas
        {
            get
            {
                return listQuestoes.Items.Cast<TesteQuestoes>().ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> questoes = QuestoesAdicionadas.Select(x => x.Pergunta).ToList();

            if (questoes.Count == 0 || questoes.Contains(txtPergunta.Text) == false)
            {
                TesteQuestoes testeQuestoes = new TesteQuestoes();

                testeQuestoes.Bimestre = (BimestreTesteEnum)cmbBimestre.SelectedItem;

                testeQuestoes.Pergunta = txtPergunta.Text;

                testeQuestoes.Gabarito = txtGabarito.Text;

                listQuestoes.Items.Add(testeQuestoes);
            }
        }
    }
}

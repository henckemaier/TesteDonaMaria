using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDonaMaria.Dominio.ModuloMateria;
using TesteDonaMaria.Dominio.ModuloTeste;
using TesteDonaMaria.WinApp.Compartilhado;
using TesteDonaMaria.WinApp.ModuloMateria;

namespace TesteDonaMaria.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private readonly IRepositorioTeste repositorioTeste;
        private readonly IRepositorioMateria repositorioMateria;

        private ListagemTesteControl listagemTestes;

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioMateria repositorioMateria)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioMateria = repositorioMateria;
        }

        public override void Inserir()
        {

            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroTesteForm tela = new TelaCadastroTesteForm(materias);
            tela.Teste = new Teste();

            tela.GravarRegistro = repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }
        public override void Editar()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Edição de Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroTesteForm tela = new TelaCadastroTesteForm(materias);

            tela.Teste = testeSelecionado;

            tela.GravarRegistro = repositorioTeste.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }
        public override void Excluir()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Exclusão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o Teste?",
                "Exclusão de Teste", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTeste.Excluir(testeSelecionado);
                CarregarTestes();
            }
        }

        public override void AdicionarQuestao()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Adição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroQuestoesForm tela = new TelaCadastroQuestoesForm(testeSelecionado);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<TesteQuestoes> itens = tela.QuestoesAdicionadas;

                repositorioTeste.AdicionarQuestoes(testeSelecionado, itens);

                CarregarTestes();               
            }
        }

        public override void Duplicar()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Duplicação de Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroTesteForm tela = new TelaCadastroTesteForm(materias);

            tela.Teste = testeSelecionado.Clone(); //Clonar o objeto

            tela.GravarRegistro = repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxTeste();
        }

        public override UserControl ObtemListagem()
        {
            if (listagemTestes == null)
                listagemTestes = new ListagemTesteControl();

            CarregarTestes();

            return listagemTestes;
        }

        private Teste ObtemTesteSelecionado()
        {
            int numeroSelecionado = listagemTestes.ObtemNumeroTesteSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorNumero(numeroSelecionado);
            return testeSelecionado;
        }

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            listagemTestes.AtualizarRegistros(testes);
        }

    }
}

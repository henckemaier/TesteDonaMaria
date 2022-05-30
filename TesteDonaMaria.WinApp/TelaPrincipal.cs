using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteDonaMaria.Infra.Arquivos;
using TesteDonaMaria.Infra.Arquivos.ModuloMateria;
using TesteDonaMaria.Infra.Arquivos.ModuloTeste;
using TesteDonaMaria.Infra.BancoDados.ModuloMateria;
using TesteDonaMaria.Infra.BancoDados.ModuloTeste;
using TesteDonaMaria.WinApp.Compartilhado;
using TesteDonaMaria.WinApp.ModuloMateria;
using TesteDonaMaria.WinApp.ModuloTeste;

namespace TesteDonaMaria.WinApp
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;

        public TelaPrincipal(DataContext contextoDados)
        {
            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
        }

        public static TelaPrincipal Instancia
        {
            get;
            private set;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void InicializarControladores()
        {
            var repositorioMateria = new RepositorioMateriaEmBancoDados();
            var repositorioTeste = new RepositorioTesteEmBancoDados();


            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Testes", new ControladorTeste(repositorioTeste, repositorioMateria));
            controladores.Add("Materias", new ControladorMateria(repositorioMateria));
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnAdicionarQuestao_Click(object sender, EventArgs e)
        {
            controlador.AdicionarQuestao();
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            controlador.Duplicar();
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            controlador.GerarPdf();
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolStrip1.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            btnAdicionarQuestao.Enabled = configuracao.AdicionarItensHabilitado;
            btnDuplicar.Enabled = configuracao.DuplicarHabilitado;
            btnPdf.Enabled = configuracao.PdfHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            btnAdicionarQuestao.ToolTipText = configuracao.TooltipAdicionarItens;
            btnDuplicar.ToolTipText = configuracao.TooltipDuplicar;
            btnPdf.ToolTipText = configuracao.TooltipPdf;
        }

    }
}

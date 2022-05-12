
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDonaMaria.Dominio.ModuloMateria;
using TesteDonaMaria.WinApp.Compartilhado;

namespace TesteDonaMaria.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private readonly IRepositorioMateria repositorioMateria;
        private ListagemMateriaControl listagemMaterias;

        public ControladorMateria(IRepositorioMateria repositorio)
        {
            repositorioMateria = repositorio;
        }

        public override void Inserir()
        {
            TelaCadastroMateriaForm tela = new TelaCadastroMateriaForm();
            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }
        public override void Editar()
        {
            Materia materiaSelecionada = listagemMaterias.SelecionarMateria();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Matéria primeiro",
                "Edição de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroMateriaForm tela = new TelaCadastroMateriaForm();

            tela.Materia = materiaSelecionada;

            tela.GravarRegistro = repositorioMateria.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia materiaSelecionada = listagemMaterias.SelecionarMateria();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Matéria primeiro",
                "Exclusão de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Matéria?",
                "Exclusão de Matéria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Excluir(materiaSelecionada);
                CarregarMaterias();
            }
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            listagemMaterias.AtualizarRegistros(materias);
        }



        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMateria();
        }

        public override UserControl ObtemListagem()
        {
            if (listagemMaterias == null)
                listagemMaterias = new ListagemMateriaControl();

            CarregarMaterias();

            return listagemMaterias;
        }
    }
}

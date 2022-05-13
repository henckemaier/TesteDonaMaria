using System.Windows.Forms;

namespace TesteDonaMaria.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();

        public virtual void AdicionarQuestao() { }

        public virtual void AtualizarQuestao() { }

        public virtual void Filtrar() { }

        public virtual void Agrupar() { }

        public virtual void Duplicar() { }

        public virtual void GerarPdf() { }

        public abstract UserControl ObtemListagem();

        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();
    }
}

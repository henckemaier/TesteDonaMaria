using TesteDonaMaria.WinApp.Compartilhado;

namespace TesteDonaMaria.WinApp.ModuloMateria
{
    public class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Matérias";

        public override string TooltipInserir => "Inserir uma nova Matéria";

        public override string TooltipEditar => "Editar uma Matéria existente";

        public override string TooltipExcluir => "Excluir uma Matéria existente";
    }
}
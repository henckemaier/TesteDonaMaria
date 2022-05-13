using TesteDonaMaria.WinApp.Compartilhado;

namespace TesteDonaMaria.WinApp.ModuloTeste
{
    public class ConfiguracaoToolboxTeste : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Testes";

        public override string TooltipInserir => "Inserir um novo Teste";

        public override string TooltipEditar => "Editar um Teste existente";

        public override string TooltipExcluir => "Excluir um Teste existente";

        public override string TooltipAdicionarItens => "Adicionar uma Lista de Questões";

        public override string TooltipAtualizarItens => "Atualizar uma Lista de Questões";

        public override string TooltipDuplicar => "Duplicar um Teste";

        public override string TooltipPdf => "Gerar PDF de um Teste";

        public override bool AdicionarItensHabilitado => true;

        public override bool AtualizarItensHabilitado => true;

        public override bool DuplicarHabilitado => true;

        public override bool PdfHabilitado => true;
    }
}
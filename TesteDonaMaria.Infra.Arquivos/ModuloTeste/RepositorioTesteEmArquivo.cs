using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDonaMaria.Dominio.ModuloTeste;

namespace TesteDonaMaria.Infra.Arquivos.ModuloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioEmArquivoBase<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo(DataContext dataContext) : base(dataContext)
        {
        }

        public override List<Teste> ObterRegistros()
        {
            return dataContext.Testes;
        }

        public override AbstractValidator<Teste> ObterValidador()
        {
            return new ValidadorTeste();
        }
    }
}

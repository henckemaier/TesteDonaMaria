using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDonaMaria.Dominio.ModuloTeste
{
    public class ValidadorTesteQuestoes : AbstractValidator<TesteQuestoes>
    {
        public ValidadorTesteQuestoes()
        {
            RuleFor(x => x.Pergunta)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Gabarito)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Letra)
               .NotNull()
               .NotEmpty();
        } 
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDonaMaria.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Materia)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.NumQuestoes)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

        }
    }
}

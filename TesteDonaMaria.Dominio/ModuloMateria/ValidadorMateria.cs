using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDonaMaria.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.NomeMateria)
                .NotNull()
                .NotEmpty();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDonaMaria.Dominio.ModuloTeste
{
    public class TesteQuestoes
    {
        public BimestreTesteEnum Bimestre { get; set; }

        public string Pergunta {  get; set; }

        public string Gabarito { get; set; }

        public string Letra { get; set; }

        public override string ToString()
        {
            return $"{Letra}) Pergunta: {Pergunta} | Gabarito: {Gabarito} | Bimestre: {Bimestre}";
        }
    }
}

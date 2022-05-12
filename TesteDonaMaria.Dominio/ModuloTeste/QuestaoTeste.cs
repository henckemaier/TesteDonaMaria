using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDonaMaria.Dominio.ModuloTeste
{
    public class QuestaoTeste
    {
        public BimestreTesteEnum Bimestre { get; set; }
        public string Pergunta { get; set; }
        public string Gabarito { get; set; }
        public bool Concluido { get; set; }

        public void Concluir()
        {
            Concluido = true;
        }
    }

}

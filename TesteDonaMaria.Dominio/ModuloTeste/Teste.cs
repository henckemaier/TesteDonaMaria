using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDonaMaria.Dominio.Compartilhado;
using TesteDonaMaria.Dominio.ModuloMateria;

namespace TesteDonaMaria.Dominio.ModuloTeste
{
    [Serializable]
    public class Teste : EntidadeBase<Teste>
    {
        private List<TesteQuestoes> questoes = new List<TesteQuestoes>();

        public Teste()
        {
            DataCriacao = DateTime.Now;
        }
        public Teste(int n, int numQuestoes, Materia materia) : this()
        {
            Numero = n;
            NumQuestoes = numQuestoes;
            Materia = materia;
        }

        public void AdicionarQuestao(TesteQuestoes item)
        {
            if (Questoes.Exists(x => x.Equals(item)) == false)
                questoes.Add(item);
        }

        public DateTime DataCriacao { get; set; }
        public Materia Materia { get; set; }
        public int NumQuestoes { get; set; }

        public List<TesteQuestoes> Questoes { get { return questoes; } }


        public override string ToString() //string?
        {
            return $"ID: {Numero} | Matéria: {Materia} | Nº de questões: {NumQuestoes} | Data: {DataCriacao.ToShortDateString()}";
        }

        public override void Atualizar(Teste registro)
        {
            
        }

        public Teste Clone()
        {
            return MemberwiseClone() as Teste;  
        }
    }
}

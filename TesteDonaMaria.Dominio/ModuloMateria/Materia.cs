using System;
using TesteDonaMaria.Dominio.Compartilhado;

namespace TesteDonaMaria.Dominio.ModuloMateria
{
    [Serializable]
    public class Materia : EntidadeBase<Materia>
    {
        public Materia()
        {
        }

        public Materia(int n, string nomeMateria)
        {
            Numero = n;
            NomeMateria = nomeMateria;
        }

        public string NomeMateria { get; set; }
        public MateriaDisciplinaEnum Disciplina { get; set; }
        public SerieMateriaEnum Serie { get; set; }

        public override void Atualizar(Materia registro)
        {
            
        }
        public override string ToString()
        {
            return $"Nº: {Numero} - Disciplina: {Disciplina} - Materia: {NomeMateria} - Série: {Serie}";
        }
    }
}

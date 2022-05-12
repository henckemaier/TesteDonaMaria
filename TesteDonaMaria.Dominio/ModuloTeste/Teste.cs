﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDonaMaria.Dominio.Compartilhado;
using TesteDonaMaria.Dominio.ModuloMateria;

namespace TesteDonaMaria.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
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

        public DateTime DataCriacao { get; set; }
        public Materia Materia { get; set; }
        public int NumQuestoes { get; set; }


        public override string ToString() //string?
        {
            return $"ID: {Numero} | Matéria: {Materia} | Nº de questões: {NumQuestoes} | Data: {DataCriacao.ToShortDateString()}";
        }

        public override void Atualizar(Teste registro)
        {
            
        }
    }
}

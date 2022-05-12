using System;
using System.Collections.Generic;
using System.Linq;
using TesteDonaMaria.Dominio.ModuloMateria;
using TesteDonaMaria.Dominio.ModuloTeste;

namespace TesteDonaMaria.Infra.Arquivos
{
    [Serializable]
    public class DataContext //Container
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Materias = new List<Materia>();

            Testes = new List<Teste>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Materia> Materias { get; set; }
        public List<Teste> Testes { get; set; }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);

            if (ctx.Testes.Any())
                this.Testes.AddRange(ctx.Testes);
        }
    }
}

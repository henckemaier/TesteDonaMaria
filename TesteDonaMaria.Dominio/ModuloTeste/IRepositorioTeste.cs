using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDonaMaria.Dominio.Compartilhado;

namespace TesteDonaMaria.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorio<Teste>
    {
        void AdicionarQuestoes(Teste testeSelecionado, List<TesteQuestoes> itens);

        //void Duplicar(Teste testeSelecionado, List<Teste> itens);

    }
}

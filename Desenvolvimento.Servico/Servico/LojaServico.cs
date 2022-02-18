using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Data.Repositorio.Interface;
using Desenvolvimento.Entidade.Entidade;
using Desenvolvimento.Servico.Servico.Interface;

namespace Desenvolvimento.Servico.Servico
{
    public class LojaServico : ILojaServico
    {
        private readonly ILojaRepositorio IlojaRepositorio;

        public LojaServico(ILojaRepositorio _IlojaRepositorio)
        {
            this.IlojaRepositorio = _IlojaRepositorio;
        }

        public List<Loja> ListarProLoja(int IdLoja)
        {
            return IlojaRepositorio.ListarProLoja(IdLoja);
        }
    }
}

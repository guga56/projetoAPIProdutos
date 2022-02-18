using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Data.Contexto;
using Desenvolvimento.Data.Repositorio.Interface;
using Desenvolvimento.Entidade.Entidade;

namespace Desenvolvimento.Data.Repositorio
{
    public class LojaRepositorio : GenericRepositorio<Loja>, ILojaRepositorio
    {
        private readonly DesenvolverAPIContexto ctx;

        public IEnumerable<Loja> Buscar(object id)
        {
            throw new NotImplementedException();
        }

        public List<Loja> ListarProLoja(int IdLoja)
        {
            return ctx.Loja.Where(l => l.IdLoja == IdLoja).ToList();
        }
    }
}

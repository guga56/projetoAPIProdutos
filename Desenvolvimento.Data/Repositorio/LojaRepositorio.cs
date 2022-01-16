using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Data.Repositorio.Interface;
using Desenvolvimento.Entidade.Entidade;

namespace Desenvolvimento.Data.Repositorio
{
    public class LojaRepositorio : GenericRepositorio<Loja>, ILojaRepositorio
    {
        public IEnumerable<Loja> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}

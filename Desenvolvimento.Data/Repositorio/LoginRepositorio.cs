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
    public class LoginRepositorio : GenericRepositorio<Login>, ILoginRepositorio
    {
        private readonly DesenvolverAPIContexto ctx;

        public IEnumerable<Login> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}

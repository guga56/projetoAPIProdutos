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
    public class ClienteRepositorio : GenericRepositorio<Cliente>, IClienteRepositorio
    {
        private readonly DesenvolverAPIContexto ctx;

        public IEnumerable<Cliente> Buscar(object id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarPorCliente(int ICliente)
        {
           return ctx.Cliente.Where(a => a.IdCliente == ICliente).ToList();
        }
    }
}

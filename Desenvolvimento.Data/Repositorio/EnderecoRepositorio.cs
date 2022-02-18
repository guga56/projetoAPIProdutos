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
    public class EnderecoRepositorio : GenericRepositorio<Endereco>, IEnderecoRepoositorio
    {
        private readonly DesenvolverAPIContexto ctx;

        public IEnumerable<Endereco> Buscar(object id)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> ListarPorEndereco(int IdEndereco)
        {
            return ctx.Endereco.Where(e => e.IdEndereco == IdEndereco).ToList();
        }
    }
}

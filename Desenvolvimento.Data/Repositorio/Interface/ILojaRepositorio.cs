using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Entidade.Entidade;

namespace Desenvolvimento.Data.Repositorio.Interface
{
    public interface ILojaRepositorio : IGenericRepositorio<Loja>
    {
        List<Loja> ListarProLoja(int IdLoja);
    }
}

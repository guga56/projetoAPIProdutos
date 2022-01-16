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
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio iclienteRepositorio;

        public List<Cliente> ListarPorCliente(int IdCliente)
        {
            return iclienteRepositorio.ListarPorCliente(IdCliente);
        }
    }
}

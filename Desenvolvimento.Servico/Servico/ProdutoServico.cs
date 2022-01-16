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
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio IProdutoRepositorio;

        public List<Produto> ListarPorProduto(int IdProduto)
        {
            return IProdutoRepositorio.ListarPorProduto(IdProduto);
        }
    }
}

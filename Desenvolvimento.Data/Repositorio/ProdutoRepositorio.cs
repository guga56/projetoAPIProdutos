﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Data.Contexto;
using Desenvolvimento.Data.Repositorio.Interface;
using Desenvolvimento.Entidade.Entidade;

namespace Desenvolvimento.Data.Repositorio
{
    public class ProdutoRepositorio : GenericRepositorio<Produto>, IProdutoRepositorio
    {
        private readonly DesenvolverAPIContexto ctx;

        public IEnumerable<Produto> Buscar(object id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarPorProduto(int IdProduto)
        {
            throw new NotImplementedException();
        }
    }
}

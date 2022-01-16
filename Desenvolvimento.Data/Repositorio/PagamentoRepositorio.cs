﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Data.Repositorio.Interface;
using Desenvolvimento.Entidade.Entidade;

namespace Desenvolvimento.Data.Repositorio
{
    public class PagamentoRepositorio : GenericRepositorio<Pagamento>, IPagamentoRepositorio
    {
        public IEnumerable<Pagamento> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}

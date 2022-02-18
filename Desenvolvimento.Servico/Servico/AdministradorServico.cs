using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Data.Repositorio.Interface;
using Desenvolvimento.Servico.Servico.Interface;

namespace Desenvolvimento.Servico.Servico
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly IAdministradorRepositorio administradorRepositorio;

        public AdministradorServico(IAdministradorRepositorio _administradorRepositorio)
        {
            this.administradorRepositorio = _administradorRepositorio;
        }


    }
}

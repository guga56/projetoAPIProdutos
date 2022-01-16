using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desenvolvimento.Entidade.Entidade;

namespace Desenvolvimento.Data.Contexto
{
    public class DesenvolverAPIContexto : DbContext
    {
        public DesenvolverAPIContexto()
        {
        }

        public DesenvolverAPIContexto(DbContextOptions options)
           :base(options)
        {

        }

        public DbSet<Login> Login { get; set; }

        public DbSet<Administrador> Administrador { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Loja> Loja { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Pagamento> Pagamento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Desenvolvimento.Data.Repositorio.Interface
{
    public interface IGenericRepositorio<T> where T : class
    {
        void Adicionar(T entidade);

        List<T> ObterTodos();

        List<T> Obter(Expression<Func<T, bool>> predicate);

        T Buscar(params object[] Key);

        T Primeniro(Expression<Func<T, bool>> predicate);

        void Atualizar(T entidade);

        void Deletar(int i);

        void Commit();
    }
}

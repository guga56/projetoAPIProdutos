using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Desenvolvimento.Data.Repositorio.Interface;
using Desenvolvimento.Data.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Desenvolvimento.Data.Repositorio
{
    public class GenericRepositorio<T> : IGenericRepositorio<T>, IDisposable where T : class
    {
        private readonly DesenvolverAPIContexto _db;

        public GenericRepositorio()
        {
            _db = new DesenvolverAPIContexto();
        }

        public void Adicionar(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T entidade)
        {
            _db.Set<T>().Add(entidade);
            Commit();
        }

        public T Buscar(params object[] Key)
        {
            return _db.Set<T>().Find(Key);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Deletar(int i)
        {
            var obj = Buscar(i);
            _db.Set<T>().Remove(obj);
            Commit();
        }

        public void Dispose()
        {
            if(_db != null)
            {
                _db.Dispose();
            }
        }

        public List<T> Obter(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }

        public List<T> ObterTodos()
        {
            return _db.Set<T>().ToList();
        }

        public T Primeniro(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).FirstOrDefault();
        }
    }
}

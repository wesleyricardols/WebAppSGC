﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SGC.ApplicationCore.Interfaces.Repository;

namespace SGC.Infrastructure.Repository
{
    public class DapperRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public TEntity Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public interface IbaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Remover(TEntity entity);
    }
}

using Microsoft.EntityFrameworkCore.Storage;
using System;
using Tryitter.Domain.Interfaces.UoW;
using Tryitter.Infra.Context;

namespace Tryitter.Infra.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly TryitterContext _tryitterContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork(TryitterContext tryitterContext)
        {
            _tryitterContext = tryitterContext;
        }

        public int Commit()
        {
            return _tryitterContext.SaveChanges();
        }

        public void BeginTransaction()
        {
            _transaction = _tryitterContext.Database.BeginTransaction();
        }

        public void BeginCommit()
        {
            _transaction.Commit();
        }

        public void BeginRollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _tryitterContext.Dispose();

            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            GC.SuppressFinalize(this);
        }
    }
}

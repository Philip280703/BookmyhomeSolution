using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmyhome.Application.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using Bookmyhome.Persistence.ContextDB;

namespace Bookmyhome.Persistence.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly MyDBContext _db;
		private IDbContextTransaction? _transaction;

		public UnitOfWork(MyDBContext db)
		{
			_db = db;
		}

		void IUnitOfWork.BeginTransaction(System.Data.IsolationLevel isolationLevel)
		{
			if (_db.Database.CurrentTransaction != null) return;
			_transaction = _db.Database.BeginTransaction(isolationLevel);
		}
		void IUnitOfWork.Commit()
		{
			if (_transaction == null) throw new Exception("You must call 'BeginTransaction' before Commit is called");
			_transaction.Commit();
			_transaction.Dispose();
		}
		void IUnitOfWork.Rollback()
		{
			if (_transaction == null) throw new Exception("You must call 'BeginTransaction' before Rollback is called");
			_transaction.Rollback();
			_transaction.Dispose();
		}
	}
}

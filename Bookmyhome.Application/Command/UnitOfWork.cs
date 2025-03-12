using Bookmyhome.Application.Command.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data;

namespace Bookmyhome.Application.Command
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly DbContext _db;
		private IDbContextTransaction? _transaction;

		public UnitOfWork (DbContext db)
		{
			_db = db;
		}

		void IUnitOfWork.BeginTransaction(System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.Serializable)
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

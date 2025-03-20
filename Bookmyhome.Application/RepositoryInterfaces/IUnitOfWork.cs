using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.RepositoryInterfaces
{
	public interface IUnitOfWork
	{
		void Commit();
		void Rollback();
		void BeginTransaction(System.Data.IsolationLevel isolationLevel);
	}
}

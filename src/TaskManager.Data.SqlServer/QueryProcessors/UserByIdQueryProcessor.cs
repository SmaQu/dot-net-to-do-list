using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using TaskManager.Data.Entities;
using TaskManager.Data.QueryProcessors;

namespace TaskManager.Data.SqlServer.QueryProcessors
{
	public class UserByIdQueryProcessor : IUserByIdQueryProcessor
	{
		private readonly ISession _session;

		public UserByIdQueryProcessor(ISession session)
		{
			_session = session;
		}

		public User GetUserById(long userId)
		{
			var user = _session.Get<User>(userId);
			return user;
		}
	}
}

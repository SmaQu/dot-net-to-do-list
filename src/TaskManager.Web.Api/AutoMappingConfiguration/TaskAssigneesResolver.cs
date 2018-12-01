using AutoMapper;
using TaskManager.Common.TypeMapping;
using TaskManager.Data.Entities;
using User = TaskManager.Web.Api.Models.User;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Web.Common;

namespace TaskManager.Web.Api.AutoMappingConfiguration
{
	public class TaskAssigneesResolver : ValueResolver<Task, List<User>>
	{
		public IAutoMapper AutoMapper
		{
			get { return WebContainerManager.Get<IAutoMapper>(); }
		}

		protected override List<User> ResolveCore(Task source)
		{
			return source.Users.Select(x => AutoMapper.Map<User>(x)).ToList();
		}
	}
}
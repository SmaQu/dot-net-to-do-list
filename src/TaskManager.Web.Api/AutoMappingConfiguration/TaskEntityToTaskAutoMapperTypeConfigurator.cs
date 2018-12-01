using AutoMapper;
using TaskManager.Common.TypeMapping;
using TaskManager.Data.Entities;

namespace TaskManager.Web.Api.AutoMappingConfiguration
{
	public class TaskEntityToTaskAutoMapperTypeConfigurator: IAutoMapperTypeConfigurator
	{
		public void Configure()
		{
			Mapper.CreateMap<Task, Models.Task>()
				.ForMember(dest => dest.Links, opt => opt.Ignore())
				.ForMember(dest => dest.Assigness, opt => opt.ResolveUsing<TaskAssigneesResolver>());
		}
	}
}
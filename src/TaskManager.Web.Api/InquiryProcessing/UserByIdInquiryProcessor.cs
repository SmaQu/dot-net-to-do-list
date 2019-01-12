using TaskManager.Common.TypeMapping;
using TaskManager.Data.Exceptions;
using TaskManager.Data.QueryProcessors;
using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.InquiryProcessing
{
	public class UserByIdInquiryProcessor : IUserByIdInquiryProcessor
	{
		private readonly IAutoMapper _autoMapper;
		private readonly ITaskByIdQueryProcessor _queryProcessor;

		public User GetUserById(long userId)
		{
			throw new System.NotImplementedException();
		}
	}
}
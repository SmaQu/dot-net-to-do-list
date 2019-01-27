using TaskManager.Common.TypeMapping;
using TaskManager.Data.Exceptions;
using TaskManager.Data.QueryProcessors;
using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.InquiryProcessing
{
	public class UserByIdInquiryProcessor : IUserByIdInquiryProcessor
	{
		private readonly IAutoMapper _autoMapper;
		private readonly IUserByIdQueryProcessor _queryProcessor;

		public UserByIdInquiryProcessor(IUserByIdQueryProcessor queryProcessor, IAutoMapper autoMapper)
		{
			_queryProcessor = queryProcessor;
			_autoMapper = autoMapper;
		}

		public User GetUserById(long userId)
		{
			var userEntity = _queryProcessor.GetUserById(userId);

			if (userEntity == null)
			{
				throw new RootObjectNotFoundException("User not found");
			}

			var user = _autoMapper.Map<User>(userEntity);
			return user;
		}
	}
}
using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.InquiryProcessing
{
	interface IUserByIdInquiryProcessor
	{
		User GetUserById(long userId);
	}
}

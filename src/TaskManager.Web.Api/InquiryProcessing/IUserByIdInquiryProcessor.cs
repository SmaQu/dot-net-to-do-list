using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.InquiryProcessing
{
	public interface IUserByIdInquiryProcessor
	{
		User GetUserById(long userId);
	}
}

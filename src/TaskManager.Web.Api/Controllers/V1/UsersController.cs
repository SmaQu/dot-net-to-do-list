using System.Net.Http;
using System.Web.Http;
using TaskManager.Common;
using TaskManager.Web.Api.InquiryProcessing;
using TaskManager.Web.Api.Models;
using TaskManager.Web.Common.Routing;

namespace TaskManager.Web.Api.Controllers.V1
{
	[ApiVersion1RoutePrefix("user")]
	[Authorize(Roles = Constants.RoleNames.User)]
	public class UsersController : ApiController
	{
		private readonly IUserByIdInquiryProcessor _userByIdInquiryProcessor;

		public UsersController(IUserByIdInquiryProcessor userByIdInquiryProcessor)
		{
			_userByIdInquiryProcessor = userByIdInquiryProcessor;
		}

		[Route("{id:long}", Name = "GetUserRoute")]
		public User GetUserById(long id)
		{
			var user = _userByIdInquiryProcessor.GetUserById(id);
			return user;
		}
	}
}
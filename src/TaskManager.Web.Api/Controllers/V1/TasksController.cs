using System.Net.Http;
using System.Web.Http;
using TaskManager.Common;
using TaskManager.Web.Api.InquiryProcessing;
using TaskManager.Web.Api.Models;
using TaskManager.Web.Common.Routing;

namespace TaskManager.Web.Api.Controllers.V1
{
	[ApiVersion1RoutePrefix("tasks")]
	[Authorize(Roles = Constants.RoleNames.User)]
    public class TasksController : ApiController
    {
		private readonly ITaskByIdInquiryProcessor _taskByIdInquiryProcessor;

		public TasksController(ITaskByIdInquiryProcessor taskByIdInquiryProcessior)
		{
			_taskByIdInquiryProcessor = taskByIdInquiryProcessior;
		}
		
		[Route("{id:long}",Name = "GetTaskRoute")]
		public Task GetTaskById(long id)
		{
			var task = _taskByIdInquiryProcessor.GetTaskById(id);
			return task;
		}
    }
}
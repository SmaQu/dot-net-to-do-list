using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Web.Api.Models
{
	public class NewTask
	{
		public string Subject { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DueDate { get; set; }
		public List<User> Assigness { get; set; }
	}
}

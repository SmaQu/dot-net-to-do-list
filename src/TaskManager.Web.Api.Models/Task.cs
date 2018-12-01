using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Web.Api.Models
{
	public class Task : ILinkContaining
	{
		private List<Link> _links;
		private bool _shouldSerialieRoles;

		[Key]
		public long? TaskId { get; set; }

		[Editable(true)]
		public string Subject { get; set; }

		[Editable(true)]
		public DateTime StartDate { get; set; }

		[Editable(true)]
		public DateTime DueDate { get; set; }

		[Editable(false)]
		public DateTime CompletionDate { get; set; }

		[Editable(false)]
		public Status Status { get; set; }

		[Editable(true)]
		public DateTime CreatedDate { get; set; }

		[Editable(false)]
		public List<User> Assigness { get; set; }

		[Editable(false)]
		public List<Link> Links
		{
			get { return _links ?? (_links = new List<Link>()); }
			set { _links = value; }
		}

		public void AddLink(Link link)
		{
			Links.Add(link);
		}

		public void SetShouldSerializeRoles(bool shouldSerialized)
		{
			_shouldSerialieRoles = shouldSerialized;
		}

		public bool ShouldSerializeRoles()
		{
			return _shouldSerialieRoles;
		}
	}
}

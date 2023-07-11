using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Domain.DTOs
{
	public class UserProfileDto
	{
		public string? Email { get; set; }

		public string? PhoneNumber { get; set; }

		public string? Address { get; set; }

		public string? WebSite { get; set; }

		public string? SocialMedia { get; set; }

		public int UserId { get; set; }

	}
}

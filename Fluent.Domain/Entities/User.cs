using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Domain.Entities
{
	public class User
	{
        public int UserId { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string NationalCode { get; set; }

        public int PersonalCode { get; set; }

        public string Password { get; set; }

        public string FatherName { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }




	}
}

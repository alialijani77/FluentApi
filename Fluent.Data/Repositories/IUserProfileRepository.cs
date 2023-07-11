using Fluent.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Data.Repositories
{
	public interface IUserProfileRepository
	{
		public Task<bool> AddUserProfile(UserProfileDto userProfileDto);
	}
}

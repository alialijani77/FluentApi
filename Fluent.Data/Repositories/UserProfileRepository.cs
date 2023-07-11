using Fluent.Data.Context;
using Fluent.Domain.DTOs;
using Fluent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Data.Repositories
{
	public class UserProfileRepository : IUserProfileRepository
	{
		private readonly FluentApiContext _context;

        public UserProfileRepository(FluentApiContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUserProfile(UserProfileDto userProfileDto)
        {
            var userprofile = new UserProfile();
            userprofile.UserId = userProfileDto.UserId;
            userprofile.Address = userProfileDto.Address;
            userprofile.PhoneNumber = userProfileDto.PhoneNumber;
            userprofile.Email = userProfileDto.Email;
            userprofile.SocialMedia = userProfileDto.SocialMedia;
            userprofile.WebSite = userProfileDto.WebSite;
            await _context.UserProfiles.AddAsync(userprofile);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

using Fluent.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Data.FluentConfigs
{
	public class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
	{
		public void Configure(EntityTypeBuilder<UserProfile> builder)
		{
			builder.HasKey(u => u.UserProfileId);
			builder.Property(p => p.Email).HasMaxLength(100);
			builder.Property(p => p.PhoneNumber).HasMaxLength(100);
			builder.Property(p => p.Address).HasMaxLength(100);
			builder.Property(p => p.WebSite).HasMaxLength(100);
			builder.Property(p => p.SocialMedia).HasMaxLength(100);
			builder.HasIndex(u => u.Email).IsUnique();

		}
	}
}

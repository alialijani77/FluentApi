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
	public class UserConfig : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(u => u.UserId);
			builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50).HasColumnName("FirstName");
			builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
			builder.Property(u => u.NationalCode).IsRequired().HasMaxLength(10);
			builder.Property(u => u.PersonalCode).IsRequired();
			builder.Property(u => u.Password).IsRequired().HasMaxLength(250);
			builder.Property(u => u.FatherName).IsRequired().HasMaxLength(50);
			builder.HasMany(u => u.UserProfiles).WithOne(u => u.User).HasForeignKey(u => u.UserId);
			builder.HasData(new User()
			{ 
				UserId = 1,
				FirstName = "Ali",
				LastName = "Alijani",
				FatherName = "Mohammad",
				NationalCode = "0311111111",
				Password = "Password",
				PersonalCode = 80448
			}
			);
			builder.HasIndex(u => u.PersonalCode).IsUnique();
			//builder.Ignore(p => p.test);
		}
	}
}

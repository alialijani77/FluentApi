using Fluent.Data.FluentConfigs;
using Fluent.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Data.Context
{
	public class FluentApiContext : DbContext
	{
		public FluentApiContext(DbContextOptions<FluentApiContext> options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new UserConfig());
			modelBuilder.ApplyConfiguration(new UserProfileConfig());

		}
	}
}

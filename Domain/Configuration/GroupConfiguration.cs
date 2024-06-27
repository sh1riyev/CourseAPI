using System;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration
{
	public class GroupConfiguration : BaseConfiguration<Group>
	{
		public override void Configure(EntityTypeBuilder<Group> builder)
		{
			builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
			builder.Property(m => m.Capacity).HasMaxLength(15);
		}
	}
}


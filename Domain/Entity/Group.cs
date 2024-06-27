using System;
using Domain.Common;

namespace Domain.Entity
{
	public class Group: BaseEntity
	{
		public string Name { get; set; }
		public int Capacity { get; set; }
		public ICollection<GroupStudent> GroupStudents { get; set; }
	}
}


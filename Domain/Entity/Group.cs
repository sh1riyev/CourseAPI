using System;
using Domain.Common;

namespace Domain.Entity
{
	public class Group: BaseEntity
	{
		public string Name { get; set; }
		public int Capacity { get; set; }
		public ICollection<GroupStudent> GroupStudents { get; set; }
		public ICollection<GroupTeacher> GroupTeachers { get; set; }
        public int EducationId { get; set; }
		public Education Education { get; set; }
		public int RommId { get; set; }
		public Room Room { get; set; }
	}
}


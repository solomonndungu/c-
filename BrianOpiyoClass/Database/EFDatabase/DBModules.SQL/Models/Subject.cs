using System.ComponentModel.DataAnnotations;

namespace DBModules.SQL.Models
{
	public class Subject
	{
		[Key, MaxLength(50)]
		public Guid SubjectId { get; set; } = Guid.NewGuid();

		[MaxLength(100)]
		public string SubjectName { get; set; }

		public int SchoolId { get; set; }

		public int TeacherId { get; set; }

		public int StudentID { get; set; }
	}
}


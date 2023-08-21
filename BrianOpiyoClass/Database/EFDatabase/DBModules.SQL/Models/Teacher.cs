using System.ComponentModel.DataAnnotations;

namespace DBModules.SQL.Models
{
    public class Teacher
	{
		[Key]
		public Guid TeacherID { get; set; } = Guid.NewGuid();

		public string Title { get; set; }

		[MaxLength(100)]
		public string Name { get; set; }

		public string SubjectsTaught { get; set; }

		public int GradeLevel { get; set; }
	}
}


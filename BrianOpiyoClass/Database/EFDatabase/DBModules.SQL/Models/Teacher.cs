using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DBModules.SQL.Enums;

namespace DBModules.SQL.Models
{
    public class Teacher
	{
		[Key]
		public Guid TeacherId { get; set; } = Guid.NewGuid();

		public string Title { get; set; }

		[MaxLength(100)]
		public string Name { get; set; }

		public string SubjectsTaught { get; set; }

		public int GradeLevel { get; set; }

        [ForeignKey("SchoolId")]
        public Guid SchoolId { get; set; }

		public virtual School School { get; set; }

        public GradeLevel Level { get; set; }
    }
}


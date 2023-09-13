using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModules.SQL.Models
{
    public class Student
	{
        [Key]
		public Guid StudentID { get; set; } = Guid.NewGuid();

		[Required, MaxLength(100)]
		public string Name { get; set; }

		[Required]
		public DateTime Dob { get; set; }

		[MaxLength(50)]
		public string Address { get; set; }

		public int StreamID { get; set; }

        [ForeignKey("SchoolId")]
        public Guid SchoolId { get; set; }

		public virtual School School { get; set; }

        [ForeignKey("TeacherId")]
        public Guid teacherId { get; set; }

		public virtual Teacher Teacher { get; set; }



	}
}

/*
 * 1. Unit Test
 * a> DB Connection
 * b> Data upload to DB.
 * 
 * Test database:
 * sqlite
 * TDD - test driven development
 * singleton
 */
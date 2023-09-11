using System.ComponentModel.DataAnnotations;

namespace DBModules.SQL.Models
{
    public class Student
	{
        [Key]
		public Guid StudentID { get; set; } = Guid.NewGuid();

		[MaxLength(100)]
		public string Name { get; set; }

		public DateTime Dob { get; set; }

		[MaxLength(50)]
		public string Address { get; set; }

		public int StreamID { get; set; }

		public int SchoolId { get; set; }
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
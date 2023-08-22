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
	}
}

using System;
using System.ComponentModel.DataAnnotations;

namespace DBModules.SQL.Models
{
    public class School
	{
		[Key]
		public Guid SchoolId { get; set; } = Guid.NewGuid();

		[MaxLength(60), Required]
		public string Name { get; set; }

		public DateTime CreatedAt { get; internal set; } = DateTime.UtcNow;

		[MaxLength(40)]
		public string Address { get; set; }

		[Range(1, 12)]
		public int Grade { get; set; }

		[MaxLength(60), Required]
		public string address { get; set; }

		[MaxLength(60), Required]
		public string location { get; set; }
	}
}


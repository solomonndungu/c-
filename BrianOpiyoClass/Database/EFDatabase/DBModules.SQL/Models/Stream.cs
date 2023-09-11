using System;
using System.ComponentModel.DataAnnotations;

namespace DBModules.SQL.Models
{
	public class Stream
	{
		[Key]
		public Guid StreamID { get; set; } = Guid.NewGuid();

		[MaxLength(20)]
		public string StreamName { get; set; }

		public int SchoolId { get; set; }
	}
}


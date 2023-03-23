using System.ComponentModel.DataAnnotations;

namespace MyBlaze.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[StringLength(10)]
		public string Gender { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
	}
}

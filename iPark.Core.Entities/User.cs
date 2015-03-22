using System;

namespace iPark.Entities
{
	public class User
	{
		public User ()
		{
		}

		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public string Country { get; set; }
		public int Age { get; set; }
		public DateTime RegistrationDate { get; set; }
		public string fbId { get; set; }
		public string ggId { get; set; }
	}
}


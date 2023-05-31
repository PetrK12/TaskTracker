using System.ComponentModel.DataAnnotations;

namespace TaskService.API
{
	public class LoginUserDto
	{
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 2)]
        public string? Password { get; set; }
    }

	public class UserDto : LoginUserDto
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		[DataType(DataType.PhoneNumber)]
		public string? PhoneNumber { get; set; }
	}
	
}


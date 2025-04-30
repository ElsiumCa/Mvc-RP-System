using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record UserDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Lütfen isminizi giriniz.")]
        public String? UserName { get; init; } = string.Empty;

        public String? FirstName { get; set; } = string.Empty;
        public String? LastName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Lütfen geçerli bir E-posta girin.")]
        public String? Email { get; init; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        public String? PhoneNumber { get; init; } = string.Empty;
        public HashSet<String> Roles { get; set; } = new HashSet<string>();
    }
}
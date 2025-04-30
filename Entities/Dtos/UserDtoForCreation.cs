using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record UserDtoForCreation : UserDto
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre Gerekli")]

        public String? JoinDate { get; set; }
        public String? Password { get; init; } = string.Empty;

    }
}
namespace Entities.Dtos
{
    public record UserDtoForUpdate : UserDto
    {
        public string ID { get; set; } = string.Empty;

        public List<string>? AllRoles {get; set;}
    }
}
namespace Entities.Dtos
{
    public record UserDtoForList : UserDto
    {
        public string ID { get; set; } = string.Empty;

        public String? JoinDate { get; set; }
        public HashSet<String> Roles { get; set; } = new HashSet<string>();
    }
}
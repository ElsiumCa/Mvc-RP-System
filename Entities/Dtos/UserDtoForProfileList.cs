namespace Entities.Dtos
{
    public record UserDtoForProfileList : UserDto
    {
        public List<string>? SubRoles { get; set; }
        public string? Occupation { get; set; }
        public string? MainRole { get; set; } = "Citizen";
        public List<string>? CriminalRecords { get; set; }
        public int? PenaltyPoints { get; set; }
        public List<String>? Lands { get; set; }

    }
}
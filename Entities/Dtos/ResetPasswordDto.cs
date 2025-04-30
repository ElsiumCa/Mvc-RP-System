namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String UserName { get; init; }
        public String Password { get; init; }
        public String ConfirmPassword { get; init; }
    }
}
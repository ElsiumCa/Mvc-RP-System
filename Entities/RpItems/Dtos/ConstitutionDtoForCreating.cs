using System.ComponentModel.DataAnnotations;

namespace Entities.RpItems.Dtos
{
    public class ConstitutionDtoForCreating
    {
        [Required(ErrorMessage = "Anayasa Başlıksız Olamaz.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Anayasa içeriği boş olamaz.")]
        public string Content { get; set; } = string.Empty;

        public string CreatedByUserId { get; set; } = string.Empty;

        public DateTime EndsAt { get; set; } = DateTime.UtcNow.AddDays(2);
    }
}
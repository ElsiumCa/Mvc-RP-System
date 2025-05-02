using System.ComponentModel.DataAnnotations;

public class Constitution
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Anayasa Başlıksız Olamaz. ")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Anayasa içeriği boş olamaz.")]
    public string Content { get; set; } = string.Empty;

    public string CreatedByUserId { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime EndsAt { get; set; } = DateTime.UtcNow.AddDays(2);

    public int YesVotes { get; set; } = 0;
    public int NoVotes { get; set; } = 0;

    public bool IsVotingActive { get; set; } = true;

    public bool? IsPassed { get; set; } // null = oylama sürüyor, true/false = sonuçlanmış
}

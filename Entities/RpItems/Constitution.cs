using System.ComponentModel.DataAnnotations;

namespace Entities.RpItems
{


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

        // IsVotingActive: EndsAt geçmişse false olur
        public bool IsVotingActive => DateTime.UtcNow <= EndsAt;


        // IsPassed: IsVotingActive false olduğunda ve YesVotes > NoVotes olduğunda true döner,
        // aksi takdirde false döner.
        public bool? IsPassed
        {
            get
            {
                if (IsVotingActive)
                {
                    return null; // Oylama devam ediyorsa sonuç belirlenemez
                }

                return YesVotes > NoVotes; // Oylama bittiyse YesVotes > NoVotes ise true, aksi halde false
            }
        }
    }
}
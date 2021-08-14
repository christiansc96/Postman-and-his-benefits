using System.ComponentModel.DataAnnotations;

namespace Demo.Database.DbModels
{
    public class Speaker
    {
        [Key]
        public int SpeakerId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(100, ErrorMessage = "")]
        public string SpeakerName { get; set; }
    }
}
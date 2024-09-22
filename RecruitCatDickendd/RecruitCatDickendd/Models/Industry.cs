namespace RecruitCatDickendd.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Industry
    {
        public int IndustryId { get; set; }

        [DisplayName("Industry")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please ensure the Industry has been properly entered")]
        public string IndustryName { get; set; }
        [Required]

        public List<Candidate>? Candidates { get; set; }

        public List<Company>? Companies { get; set; }

    }
}

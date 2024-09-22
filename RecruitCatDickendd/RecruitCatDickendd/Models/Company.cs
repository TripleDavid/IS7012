namespace RecruitCatDickendd.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Company
    {
        public int CompanyId { get; set; }

        [DisplayName("Company Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please ensure the Company Name has been properly entered")]
        public string CompanyName { get; set; }
        [Required]

        public JobTitle JobTitle { get; set; }

        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }

        [DisplayName("Preferred Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DisplayName("City")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please ensure the City has been properly entered")]
        public string Location { get; set; }
        [Required]

        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }

        [DisplayName("Signing Bonus")]
        [Range(100, 10000000)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal? SigningBonus { get; set; }

    }
}

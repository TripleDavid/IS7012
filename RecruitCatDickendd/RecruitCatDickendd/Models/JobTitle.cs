using System.ComponentModel;

namespace RecruitCatDickendd.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class JobTitle
    {
        public int JobTitleId { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please ensure the Title has been properly entered")]
        public string Title { get; set; }
        [Required]

        [DisplayName("Highest Salary")]
        [Range(10000, 10000000)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal SalaryHigh { get; set; }

        [DisplayName("Lowest Salary")]
        [Range(10000, 10000000)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal SalaryLow { get; set; }

        public List<Candidate>? Candidates { get; set; }

        [DisplayName("Certificate Required?")]
        public bool CertificationNeeded { get; set; }

    }
}

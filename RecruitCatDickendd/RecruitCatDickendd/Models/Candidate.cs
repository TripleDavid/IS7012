namespace RecruitCatDickendd.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Candidate
    {
        public int CandidateId { get; set; }

        [DisplayName("First Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please ensure the First Name has been properly entered")]
        public string FirstName { get; set; }
        [Required]

        [DisplayName("Last Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please ensure the Last Name has been properly entered")]
        public string LastName { get; set; }
        [Required]

        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [DisplayName("Experience (Years)")]
        public int YearsExperience { get; set; }

        [DisplayName("Has a Degree?")]
        public bool HasDegree { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        [Range(10000, 10000000)]
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DisplayName("Desired Title")]
        public JobTitle? JobTitle { get; set; }

        [DisplayName("Desired Title")]
        public int? JobTitleId { get; set; }

        public Company? Company { get; set; }

        [DisplayName("Current Employer")]
        public int? CompanyId { get; set; }

        public Industry? Industry { get; set; }

        [DisplayName("Desired Industry")]
        public int? IndustryId { get; set; }

        [DisplayName("Currently Employed")]
        public bool IsEmployed { get; set; }

        [DisplayName("Willing to Relocate")]
        public bool WillRelocate { get; set; }

        [DisplayName("Start of Job Search")]
        [DataType(DataType.Date)]
        public DateTime JobSearchStartDate { get; set; }
        
        [DisplayName("Current Title")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please enter a valid title. If none, leave blank.")]
        public string CurrentTitle { get; set; }

    }
}

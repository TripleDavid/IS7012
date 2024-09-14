namespace RecruitCatDickendd.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string PositionName { get; set; }
        public decimal SalaryMinimum { get; set; }
        public decimal SalaryMaximum { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public List<Candidate>? Candidates { get; set; }
        public Industry? Industry { get; set; }
        public int? IndustryId { get; set; }
        public decimal? SigningBonus { get; set; }

    }
}

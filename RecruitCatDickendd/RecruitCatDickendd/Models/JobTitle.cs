namespace RecruitCatDickendd.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public decimal SalaryHigh { get; set; }
        public decimal SalaryLow { get; set; }
        public string Title { get; set; }
        public List<Candidate> Candidates { get; set; }
        public bool CertificationNeeded { get; set; }

    }
}

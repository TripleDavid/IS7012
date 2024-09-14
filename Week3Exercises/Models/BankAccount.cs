namespace Week3Exercises.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public bool IsActive { get; set; }
        public AccountHolder? AccountHolder { get; set; }
        public int? AccountHolderId { get; set; }

    }
}

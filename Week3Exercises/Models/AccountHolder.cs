namespace Week3Exercises.Models
{
    public class AccountHolder
    {
        public int AccountHolderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public List<BankAccount>? BankAccounts { get; set; }
    }
}

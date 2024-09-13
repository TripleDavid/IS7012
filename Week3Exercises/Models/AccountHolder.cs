namespace Week3Exercises.Models
{
    public class AccountHolder
    {
        public int AccountHolderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

    }
}

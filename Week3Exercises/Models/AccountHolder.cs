namespace Week3Exercises.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class AccountHolder
    {
        [DisplayName("ID")]
        public int AccountHolderId { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal Salary { get; set; }

        [DisplayName("Bank Accounts")]
        public List<BankAccount>? BankAccounts { get; set; }
    }
}

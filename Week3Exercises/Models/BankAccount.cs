namespace Week3Exercises.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class BankAccount
    {
        [DisplayName("Bank Account ID")]
        public int BankAccountId { get; set; }

        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [DisplayName("Current Balance")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal CurrentBalance { get; set; }

        [DisplayName("Account Name")]
        public string AccountName { get; set; }

        [DisplayName("Active?")]
        public bool IsActive { get; set; }

        [DisplayName("Account Holder")]
        public AccountHolder? AccountHolder { get; set; }

        [DisplayName("Account Holder")]
        public int? AccountHolderId { get; set; }

    }
}

namespace SHRIS.EF.Models
{
    class BankAccount : BaseModel
    {
        public Employee Employee { get; set; }

        public Bank Bank { get; set; }

        public string AccountHolder { get; set; }

        public string AccountIdentification { get; set; }

        public string AccountNumber { get; set; }

        public string Currency { get; set; }
    }
}

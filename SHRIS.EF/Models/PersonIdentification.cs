using System;

namespace SHRIS.EF.Models
{
    class PersonIdentification : BaseModel
    {
        public Employee Employee { get; set; }

        public PersonIdentificationType Type { get; set; }

        public string IdentificationNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsPrimary { get; set; }
    }
}

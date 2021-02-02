using System;

namespace SHRIS.EF.Models
{
    public class PersonalDetail
    {
        public Employee Employee { get; set; }

        public Country BirthCountry { get; set; }

        public string BirthCity { get; set; }

        public DateTime BirthDate { get; set; }

        public Location Address { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }
    }
}

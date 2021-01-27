using SHRIS.EF.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHRIS.EF.Models
{
    class Employee : BaseModel, ISoftDelete
    {
        public string EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName 
        { 
            get 
            { 
                return string.Concat(FirstName, " ", LastName); 
            }
        }

        public PersonalDetail PersonalDetail { get; set; }

        public BankAccount BankAccount { get; set; }

        public DateTime JoinDate { get; set; }

        public Department Department { get; set; }

        public Employee Manager { get; set; }

        public bool SoftDeleted { get; set; }

        public ICollection<EmploymentContract> EmploymentContracts { get; set; }

        public ICollection<PersonIdentification> PersonIdentifications { get; set; }
    }   
}

﻿using SHRIS.EF.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHRIS.EF.Models
{
    public class Employee : BaseModel
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

        [ForeignKey("ManagerId")]
        public Employee Manager { get; set; }

        public ICollection<EmploymentContract> EmploymentContracts { get; set; }

        public ICollection<PersonIdentification> PersonIdentifications { get; set; }
    }   
}

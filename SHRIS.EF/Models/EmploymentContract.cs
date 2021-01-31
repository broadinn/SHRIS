﻿using System;

namespace SHRIS.EF.Models
{
    class EmploymentContract : BaseModel
    {
        public Employee Employee { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }
    }
}

using SHRIS.EF.Models.Interface;
using System;

namespace SHRIS.EF.Models
{
    class EmploymentContract : BaseModel, ISoftDelete
    {
        public Employee Employee { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public bool SoftDeleted { get; set; }
    }
}

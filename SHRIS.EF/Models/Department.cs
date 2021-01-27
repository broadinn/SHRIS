using System.Collections.Generic;

namespace SHRIS.EF.Models
{
    class Department : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public Office Office { get; set; }

        public Employee Manager { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

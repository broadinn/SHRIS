using System.Collections.Generic;

namespace SHRIS.EF.Models
{
    public class Office : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Location Location { get; set; }

        /// <summary>
        /// Kantor cabang jika <strong>true</strong>
        /// </summary>
        public bool BranchOffice { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}

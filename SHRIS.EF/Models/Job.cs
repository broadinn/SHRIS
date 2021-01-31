using SHRIS.EF.Models.Interface;

namespace SHRIS.EF.Models
{
    class Job : BaseModel
    {
        public string Code { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }
    }
}

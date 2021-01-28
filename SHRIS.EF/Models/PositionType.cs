using SHRIS.EF.Models.Interface;

namespace SHRIS.EF.Models
{
    class PositionType : BaseModel, ISoftDelete
    {
        public string Code { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public bool SoftDeleted { get; set; }
    }
}

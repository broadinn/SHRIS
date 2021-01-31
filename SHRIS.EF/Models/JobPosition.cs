using SHRIS.EF.Models.Interface;

namespace SHRIS.EF.Models
{
    class JobPosition : BaseModel
    {
        public Job Job { get; set; }

        public PositionType PositionType { get; set; }

        public string Description { get; set; }
    }
}

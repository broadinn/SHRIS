using SHRIS.EF.Models.Interface;

namespace SHRIS.EF.Models
{
    class ShiftSchedule : BaseModel, ISoftDelete
    {
        public bool FullDayOperation { get; set; }

        public int ShiftDuration { get; set; }



        public bool SoftDeleted { get; set; }
    }
}

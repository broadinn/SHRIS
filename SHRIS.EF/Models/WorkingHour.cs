using SHRIS.EF.Models.Interface;

namespace SHRIS.EF.Models
{
    class WorkingHour : BaseModel
    {
        public bool FullDayOperation { get; set; }

        public int ShiftDuration { get; set; }
    }
}

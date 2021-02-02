namespace SHRIS.EF.Models
{
    public class WorkingHour : BaseModel
    {
        public bool FullDayOperation { get; set; }

        public int ShiftDuration { get; set; }
    }
}

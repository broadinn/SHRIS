using SHRIS.EF.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHRIS.EF.Models
{
    class ShiftSchedule : BaseModel, ISoftDelete
    {
        public bool FullDayOperation { get; set; }

        public int ShiftDuration { get; set; }



        public bool SoftDeleted { get; set; }
    }
}

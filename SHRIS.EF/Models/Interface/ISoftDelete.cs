using System;

namespace SHRIS.EF.Models.Interface
{
    interface ISoftDelete
    {
        string DeletedBy { get; set; }

        DateTime? DeletedAt { get; set; }

        bool SoftDeleted { get; set; }
    }
}

﻿using System.Collections.Generic;

namespace SHRIS.EF.Models
{
    class Currency : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}

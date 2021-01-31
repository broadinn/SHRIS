using SHRIS.EF.Models.Interface;

namespace SHRIS.EF.Models
{
    class Country : BaseModel
    {
        public string ISOCode { get; set; }

        public string Name { get; set; }

        public string Nationality { get; set; }
        
        public Currency Currency { get; set; }
    }
}

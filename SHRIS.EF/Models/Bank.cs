namespace SHRIS.EF.Models
{
    public class Bank : BaseModel
    {
        public string Code { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public Country Country { get; set; }
    }
}

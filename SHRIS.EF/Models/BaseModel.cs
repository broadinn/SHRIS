using SHRIS.EF.Models.Interface;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHRIS.EF.Models
{
    public class BaseModel : ISoftDelete
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool SoftDeleted { get; set; } = false;
    }
}

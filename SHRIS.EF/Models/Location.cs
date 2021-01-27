using System.ComponentModel.DataAnnotations.Schema;

namespace SHRIS.EF.Models
{
    class Location : BaseModel
    {
        public Country Country { get; set; }
        
        public string City { get; set; }

        /// <summary>
        /// Kelurahan
        /// </summary>
        public string District { get; set; }
        
        /// <summary>
        /// Kecamatan
        /// </summary>
        public string SubDistrict { get; set; }
        
        public string Address { get; set; }
        
        public string AddressNumber { get; set; }

        /// <summary>
        /// Kode pos
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// <em>opsional</em> Garis lintang
        /// </summary>
        [Column(TypeName = "decimal(10,6)")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// <em>opsional</em> Garis bujur
        /// </summary>
        [Column(TypeName = "decimal(10,6)")]
        public decimal? Longitude { get; set; }


    }
}

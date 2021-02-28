using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VenderConvention.Models
{
    public class Tag:BaseEntity
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string NameTag { get; set; }
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
       
        public vendor Vendor { get; set; }

    }
}

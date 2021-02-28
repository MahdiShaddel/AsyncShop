using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VenderConvention.DTOs
{
    public class ListDTO
    {
        public int Id { get; set; }
       
        [Required]
        [StringLength(128)]
        public string VendorName { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<string> NameTag { get; set; }
        public DateTime? Modifiedate { get; set; }
        public DateTime Createdate { get; set; }

    }
}

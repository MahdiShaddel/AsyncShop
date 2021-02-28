using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VenderConvention.Models
{
    public class vendor:BaseEntity
    {
        public vendor()
        {
           Tag = new HashSet<Tag>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string VendorName { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Tag> Tag { get; set; }
       

        
    }
}

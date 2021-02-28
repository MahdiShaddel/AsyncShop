using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VenderConvention.DTOs
{
    public class UpdatePatchDTO
    {
        [Required]
        [StringLength(128)]
        public string VendorName { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<TagUpdateDTO> Tags { get; set; }
    }
}

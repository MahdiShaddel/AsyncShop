using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.Models;

namespace VenderConvention.DTOs
{
    public class InsertVendorDTO
    {
        public string VenderName { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<TagDTO> Tags { get; set; }
    }
}

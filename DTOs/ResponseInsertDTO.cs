using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.DTOs;

namespace VenderFluentApi.DTOs
{
    public class ResponseInsertDTO
    {
        public int Id { get; set; }
        public string VenderName { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<string> NameTag { get; set; }
    }
}

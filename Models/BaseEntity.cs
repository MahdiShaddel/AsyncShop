using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderConvention.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Createdate = DateTime.Now;
            Modifiedate = Createdate;
        }
        public DateTime Createdate { get; set; }
        public bool Isdeleted { get; set; }
        public int UserId { get; set; }
        public DateTime? Modifiedate { get; set; }
    }
}

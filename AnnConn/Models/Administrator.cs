using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class Administrator
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
    }
}

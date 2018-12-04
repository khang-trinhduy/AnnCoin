using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class CustomerModal
    {
        public Administrator administrator { get; set; }
        public Collaborators coll { get; set; }
        public List<Customers> customers { get; set; }
    }
}

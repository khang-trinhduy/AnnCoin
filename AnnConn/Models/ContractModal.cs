using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class ContractModal
    {
        public Collaborators coll { get; set; }
        public Customers customer { get; set; }
        public Contracts contract { get; set; }
    }
}

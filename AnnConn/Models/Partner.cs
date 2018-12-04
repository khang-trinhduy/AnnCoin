using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class Partner
    {
        public Administrator ad { get; set; }
        public List<Collaborators> collaborators { get; set; }
    }
}

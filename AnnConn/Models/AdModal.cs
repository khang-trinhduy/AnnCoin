using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class AdModal
    {
        public Administrator administrator { get; set; }
        public List<Contracts> contracts { get; set; }
    }
}

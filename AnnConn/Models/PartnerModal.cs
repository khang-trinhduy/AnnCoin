using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class PartnerModal
    {
        public List<SelectListItem> sales { get; set; }
        public List<SelectListItem> appoinments { get; set; }
        public Collaborators collaborators { get; set; }
        public Customers customer { get; set; }
    }
}

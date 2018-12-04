using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class Collaborators
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public string password { get; set; }
        //public string MyProperty { get; set; }
        public string office { get; set; }
        public DateTime joinDate { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string cmnd { get; set; }
        public string place { get; set; }
        public DateTime day { get; set; }
        public string office_name { get; set; }
        public string field { get; set; }
        public string position { get; set; }
        public string house { get; set; }
        public string nation { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string town { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public ICollection<Contracts> contracts { get; set; }
        public ICollection<Customers> customers { get; set; }
        public string policy { get; set; }
    }
}

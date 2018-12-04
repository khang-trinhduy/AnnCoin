using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class Customers
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Họ & tên*", Prompt = "Nguyễn Văn Minh")]
        public string name { get; set; }
        [Required]
        [Display(Name = "SĐT*")]
        public string phone { get; set; }
       //[Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        public string note { get; set; }
        public string condition { get; set; }
        public int cNumber { get; set; }
        public int pNumber { get; set; }
        public string ch { get; set; }
        public double price { get; set; }
        public string policy { get; set; }
        public double charges { get; set; }
        public double totals { get; set; }
        public DateTime pDate { get; set; }
        public string q4a { get; set; }
        public bool q5a { get; set; }
        public bool q5b { get; set; }
        public bool q5c { get; set; }
        public bool q5d { get; set; }
        public bool q6a { get; set; }
        public bool q6b { get; set; }
        public bool q6c { get; set; }
        public bool q7a { get; set; }
        public bool q7b { get; set; }
        public bool q7c { get; set; }
        public bool q7d { get; set; }
        public bool q7e { get; set; }
        public bool q7f { get; set; }
        public bool q7g { get; set; }
        public bool q7h { get; set; }
        public bool q7i { get; set; }
        public bool q7j { get; set; }
        public bool q7k { get; set; }
        public bool q7l { get; set; }
        public bool q7m { get; set; }
        //public bool q7j { get; set; }
        public string supporter { get; set; }
        public int CollaboratorsID { get; set; }
        public string provider { get; set; }
        public bool signed { get; set; }

    }
}

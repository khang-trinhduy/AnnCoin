﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnConn.Models
{
    public class Sale
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Tên nhân sự")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Số điện thoại")]
        public string phone { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string pass { get; set; }
        [Display(Name = "Lịch sử gặp khách hàng")]
        public ICollection<Appoinment> meetings { get; set; }
        [Display(Name = "Thông tin sale")]
        public string info { get; set; }
        [Display(Name = "Tên hiển thị")]
        public string display { get; set; }
        public string type { get; set; }
    }
}

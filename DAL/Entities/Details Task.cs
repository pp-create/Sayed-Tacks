using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities 
{
    public class Details_Task
    {
        [Key]
        public int ID { get; set; } 
     
        public string? Day { get; set; }    
        public string? Addries { get; set; } 
        public string? Reasons { get; set; } 
        public int? data { get; set; }    
        public string? month { get; set; }    
        public int? year { get; set; }
    }
}

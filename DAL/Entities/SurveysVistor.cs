using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SurveysVistor
    {
        [Key]
        public int ID { get; set; }  
        public int Details_TaskID { get; set; }

        public  string  NameService  { get; set; }
        public string Think { get; set; }
    }
}

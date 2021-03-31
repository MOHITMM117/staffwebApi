using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffWebApi.Models
{
    public class StaffName
    {[Key]
        public int id { get; set; }
        public string name { get; set; }
        public string department {get;set;}

    }
}

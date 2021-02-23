using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        public String Name { get; set; }
    }
}

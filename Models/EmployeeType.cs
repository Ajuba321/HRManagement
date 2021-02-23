using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class EmployeeType
    {
        [Key]
        public int TypeId { get; set; }
        public string Type { get; set; }
    }
}

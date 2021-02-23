using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Designation
    {

        [Key]
        public int DesgId { get; set; }

        public string Name { get; set; }
    }
}

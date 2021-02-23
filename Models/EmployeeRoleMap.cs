using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class EmployeeRoleMap
    {
        [Key]
        public int MapId { get; set; }
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("EmployeeId")]
        [NotMapped]
        public Employee Employee { get; set; }
        [ForeignKey("RoleId")]
        [NotMapped]
        public Roles Roles { get; set; }
    }
}

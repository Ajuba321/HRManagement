using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    [Table("EmployeeMaster")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [Column("FirstName", TypeName = "ntext")]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [Column("LastName", TypeName = "ntext")]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [Column("Email", TypeName = "ntext")]
        [MaxLength(20)]
        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
        public string EmployeeType { get; set; }        
        public string RoleId { get; set; }
        [ForeignKey("Id")]
        public Roles Roles { get; set; }
        public int DesgId { get; set; }
        public int TypeId { get; set; }
        public int DepId { get; set; }
        [NotMapped]
        [ForeignKey("DepId")]
        public Department Department { get; set; }
        [NotMapped]
        [ForeignKey("DesgId")]
        public Designation Designation { get; set; }
        [NotMapped]
        [ForeignKey("TypeId")]
        public bool EmployeeStatus { get; set; } 
        
    }
}

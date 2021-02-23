using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class PersonalDetails
    {
        [Key]
        public int PersonalId { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        [Column("PresentAddress", TypeName = "ntext")]
        [MaxLength(20)]
        public string PresentAddress { get; set; }
        [Required]
        [Column("PermanentAddress", TypeName = "ntext")]
        [MaxLength(20)]
        public string PermanentAddress { get; set; }
        public string Mobile { get; set; }
        public DateTime? DOB { get; set; }
        public int GenderId { get; set; }
        [NotMapped]
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
        [ForeignKey("EmployeeId")]
        [NotMapped]
        public Employee Employee { get; set; }
    }
}

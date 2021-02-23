using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class DocumentsUpload
    {
        public int DocumentId { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public FormFile File { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}

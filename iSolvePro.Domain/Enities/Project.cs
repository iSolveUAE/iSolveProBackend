using iSolvePro.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolvePro.Domain.Enities
{
    public class Project:Setupbase
    {
        [Column(TypeName = "nvarchar(500)")]
        public string ProjectName { get; set; }=string.Empty;
        [Column(TypeName = "nvarchar(500)")]
        public string ProjectType { get; set; }= string.Empty;
        [Column(TypeName = "nvarchar(500)")]
        public string Location { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(500)")]
        public string WebSite { get; set; } = string.Empty;

        public int SubCompID { get; set; }
        [ForeignKey("SubCompID")]
        public SubCompany SubCompany { get; set; }
    }
}

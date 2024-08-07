using iSolvePro.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolvePro.Domain.Enities
{
    public class SubCompany:Setupbase
    {
        public int ParentCompID { get; set; }
        [ForeignKey("ParentCompID")]
        public ParentCompany ParentCompany { get; set; }
        [Column(TypeName = ("varchar(200)"))]
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = ("tinyint"))]
        public byte Employees { get; set; }

        [Column(TypeName = ("varchar(100)"))]
        public string Country { get; set; } = string.Empty;
        [Column(TypeName = ("varchar(100)"))]
        public string City { get; set; } = string.Empty;
        [Column(TypeName = ("varchar(100)"))]
        public string Website { get; set; } = string.Empty;
    }
}

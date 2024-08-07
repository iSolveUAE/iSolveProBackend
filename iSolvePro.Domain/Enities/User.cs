using iSolvePro.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolvePro.Domain.Enities
{
    public class User:Setupbase
    {
        [Column (TypeName ="varchar(100")]
        public string FirstName { get; set; }=string.Empty;
        [Column(TypeName = "varchar(100")]
        public string LastName { get; set; } = string.Empty;
        [Column(TypeName = "varchar(500")]
        public string Password { get; set; } = string.Empty;
        [Column(TypeName = "bit")]
        public string Status { get; set; } = string.Empty;
        [Column(TypeName = "varchar(50)")]
        public string PlayerID { get; set; } = string.Empty;
        [Column(TypeName = "tinyint")]
       
        public byte RoleID { get; set; }
        [ForeignKey("RoleID")]
        public Role Role { get; set; }

        
        public int SubCompID { get; set; }
        [ForeignKey("SubCompID")]
        public SubCompany SubCompany { get; set; }
    }
}

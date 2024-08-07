using iSolvePro.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolvePro.Domain.Enities
{
    public class Team:Setupbase
    {
        [Column (TypeName ="varchar(150)")]
        public string TeamName { get; set; }=string.Empty;

       
        public int SubCompID { get; set; }
        [ForeignKey("SubCompID")]
        public SubCompany SubCompany { get; set; }

    }
}

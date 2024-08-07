using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolvePro.Domain.Enities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }=string.Empty;
        public DateTime CreatedDate { get { return DateTime.Now; } }
        public DateTime ModifiedDate { get { return DateTime.Now; } }


    }

}

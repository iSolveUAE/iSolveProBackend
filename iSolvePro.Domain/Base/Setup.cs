using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolvePro.Domain.Base
{
    public class Setup
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreatedDate { get{ return DateTime.Now; } }
        public DateTime ModifiedDate { get { return DateTime.Now; } }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCPrj.Models
{
    public class Softlock
    {
       
        public int EmployeeID { get; set; }
        public Emp Employee { get; set; }
        public string Manager { get; set; }
        public DateTime Reqdate { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
        [Key]
        public int LockID { get; set; }
        public string RequestMessage { get; set; }
        public string WFMRemark { get; set; }
        public string ManagerStatus { get; set; }
        public string MGRStatusComments { get; set; }
        public DateTime MGRLastUpdate { get; set; }
    }
}

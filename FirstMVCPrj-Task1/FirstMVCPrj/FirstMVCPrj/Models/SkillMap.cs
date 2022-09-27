using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCPrj.Models
{
    public class SkillMap
    {   
        public int EmployeeID { get; set; }
        public int SkillID { get; set; }
        public Emp employee { get; set; }
        public Skills skills { get; set; }
    }
}

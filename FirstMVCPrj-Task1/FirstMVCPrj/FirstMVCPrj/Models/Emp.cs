﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCPrj.Models
{
    public class Emp
    {
        [Key]
        public int employeeID { get; set; }
        public ICollection<Softlock> softlocks { get; set; }
        public ICollection<SkillMap> skillMaps { get; set; }
        public string EmpName { get; set; }
        public string Status { get; set; }
        public string Manager { get; set; }
        public string WFMmanager { get; set; }
        public string Email { get; set; }
        public string Lockstatus { get; set; }
        public decimal Experience { get; set; }
        public int ProfileID { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCPrj.Models
{
    public class Skills
    {
        [Key]
        public int SkillID { get; set; }
        public string Name { get; set; }
       public ICollection<SkillMap> skillMaps { get; set; }
    }
}

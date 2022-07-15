using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework {
    internal class teacher {
        [Key]
        public int teach_id { get; set;}
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string subj { get; set; }
    }
}

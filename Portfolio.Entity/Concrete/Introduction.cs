using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Entity.Concrete
{
    public class Introduction
    {
        [Key]
        public int IntroductionID { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Entity.Concrete
{
    public class Portfolyo
    {
        [Key]
        public int PortfolioID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
    }
}

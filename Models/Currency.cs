using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double Rate { get; set; }
        public int IterationId { get; set; }
    }
}

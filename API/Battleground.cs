using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class Battleground
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int ControllingFaction { get; set; }
        public int Status { get; set; }
        public long Next { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    class Realm
    {
        public enum Type
        {
            PVE,
            PVP,
            RPPVP,
            RPPVE
        }

        public enum PopulationLevel
        {
            Low,
            Normal,
            High
        }

        public Type RealmType { get; set; }
        public bool Queue { get; set; }
        public List<Battleground> Battlegrounds = new List<Battleground>();
        public int Status { get; set; }
        public PopulationLevel Population { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
